using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Unity.VectorGraphics;

#nullable enable

namespace Weather
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] Text _locationText = null!;
        [SerializeField] Text[] _dateTexts = null!;
        [SerializeField] SpriteRenderer[] _spriteRenderers = null!;
        [SerializeField] Text _bodyText = null!;
        [SerializeField] Text _copyrightText = null!;
        [SerializeField] Dropdown _ddArea = null!;
        [SerializeField] Dropdown _ddCity = null!;

        City? _selectCity = null;

        void Start()
        {
            _ddArea.ClearOptions();
            foreach (var prefecture in LocationDatabase.prefectures)
            {
                _ddArea.options.Add(new(prefecture.name));
            }

            _ddArea.onValueChanged.AddListener(_ =>
            {
                _ddCity.ClearOptions();
                var cities = LocationDatabase.prefectures[_ddArea.value].cities;
                foreach (var city in cities)
                {
                    _ddCity.options.Add(new(city.name));
                }

                _ddCity.value = -1;
                _ddCity.value = 0;
                _ddCity.RefreshShownValue();
            });

            _ddCity.onValueChanged.AddListener(_ =>
            {
                _selectCity = LocationDatabase.prefectures[_ddArea.value].cities[_ddCity.value];
                Debug.Log($"{_selectCity.name} , {_selectCity.id}");
            });

            _ddArea.value = -1;
            _ddArea.value = 0;
            _ddArea.RefreshShownValue();
        }

        IEnumerator Refresh(ResponseData responseData)
        {
            if (!responseData.isSuccess)
            {
                _locationText.text = "error";
                _bodyText.text = responseData.error;
                Debug.LogError(responseData.error);
                yield break;
            }

            var data = responseData.data!;
            var location = data.Location;
            _locationText.text = $"{location.Area} - {location.Prefecture} - {location.District} - {location.City}";

            var index = 0;
            foreach (var forecast in data.Forecasts)
            {
                _dateTexts[index++].text = $"{forecast.DateLabel}\n{forecast.Date}";
            }

            index = 0;
            foreach (var forecast in data.Forecasts)
            {
                using var request = UnityWebRequest.Get(forecast.Image.Url);
                yield return request.SendWebRequest();

                var renderer = _spriteRenderers[index++];
                if (request.result != UnityWebRequest.Result.Success)
                {
                    if (renderer.sprite != null)
                    {
                        Destroy(renderer.sprite);
                        renderer.sprite = null;
                    }
                    continue;
                }

                using (var reader = new StringReader(request.downloadHandler.text))
                {
                    var sceneInfo = SVGParser.ImportSVG(reader);
                    var geometry = VectorUtils.TessellateScene(sceneInfo.Scene, new VectorUtils.TessellationOptions
                    {
                        StepDistance = 100.0f,
                        MaxCordDeviation = 0.5f,
                        MaxTanAngleDeviation = 0.1f,
                        SamplingStepSize = 0.01f
                    });

                    if (renderer.sprite != null)
                    {
                        Destroy(renderer.sprite);
                        renderer.sprite = null;
                    }

                    renderer.sprite = VectorUtils.BuildSprite(geometry, 1.0f, VectorUtils.Alignment.Center, Vector2.zero, 128, true);
                }
            }

            _bodyText.text = data.Description.BodyText;
            _copyrightText.text = data.Copyright.Title;
        }

        public void OnClickSend()
        {
            if (_selectCity != null)
            {
                StartCoroutine(WeatherApi.Send(new RequestData(_selectCity.id), (response) =>
                {
                    StartCoroutine(Refresh(response));
                }));
            }
        }
    }
}
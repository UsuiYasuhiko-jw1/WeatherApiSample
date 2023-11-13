using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

#nullable enable

namespace Weather
{
    public class RequestData
    {
        public readonly int cityId;

        public RequestData(int cityId)
        {
            this.cityId = cityId;
        }
    }

    public class ResponseData
    {
        public bool isSuccess => !(!string.IsNullOrEmpty(error) || data == null);
        public readonly string error;
        public readonly WeatherData? data;

        public ResponseData(string error, WeatherData? data)
        {
            this.error = error;
            this.data = data;
        }
    }

    public static class WeatherApi
    {
        static float _lastRequestTime;

        public static IEnumerator Send(RequestData requestData, Action<ResponseData>? callback)
        {
            if (Time.realtimeSinceStartup < _lastRequestTime)
            {
                callback?.Invoke(new ResponseData("Waiting for interval", null));
                yield break;
            }

            var uri = $"https://weather.tsukumijima.net/api/forecast/city/{requestData.cityId}";
            var request = UnityWebRequest.Get(uri);

            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                callback?.Invoke(new ResponseData(request.error, null));
                yield break;
            }

            try
            {
                var data = JsonUtility.FromJson<WeatherData>(request.downloadHandler.text);
                callback?.Invoke(new ResponseData(request.error, data));
            }
            catch (Exception ex)
            {
                callback?.Invoke(new ResponseData(ex.ToString(), null));
            }

            _lastRequestTime = Time.realtimeSinceStartup + 0.5f;
        }
    }
}
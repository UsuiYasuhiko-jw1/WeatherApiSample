using System;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace Weather
{
    [Serializable]
    public class WeatherData
    {
        [SerializeField] string publicTime = string.Empty;
        [SerializeField] string publicTimeFormatted = string.Empty;
        [SerializeField] string publishingOffice = string.Empty;
        [SerializeField] string title = string.Empty;
        [SerializeField] string link = string.Empty;
        [SerializeField] Description description = new Description();
        [SerializeField] Forecast[] forecasts = Array.Empty<Forecast>();
        [SerializeField] Location location = new Location();
        [SerializeField] Copyright copyright = new Copyright();

        public string PublicTime => publicTime;
        public string PublicTimeFormatted => publicTimeFormatted;
        public string PublishingOffice => publishingOffice;
        public string Title => title;
        public string Link => link;
        public Description Description => description;
        public IReadOnlyCollection<Forecast> Forecasts => forecasts;
        public Location Location => location;
        public Copyright Copyright => copyright;
    }

    [Serializable]
    public class Description
    {
        [SerializeField] string publicTime = string.Empty;
        [SerializeField] string publicTimeFormatted = string.Empty;
        [SerializeField] string headlineText = string.Empty;
        [SerializeField] string bodyText = string.Empty;
        [SerializeField] string text = string.Empty;

        public string PublicTime => publicTime;
        public string PublicTimeFormatted => publicTimeFormatted;
        public string HeadlineText => headlineText;
        public string BodyText => bodyText;
        public string Text => text;
    }

    [Serializable]
    public class Forecast
    {
        [SerializeField] string date = string.Empty;
        [SerializeField] string dateLabel = string.Empty;
        [SerializeField] string telop = string.Empty;
        [SerializeField] Detail detail = new Detail();
        [SerializeField] Temperature temperature = new Temperature();
        [SerializeField] ChanceOfRain chanceOfRain = new ChanceOfRain();
        [SerializeField] Image image = new Image();

        public string Date => date;
        public string DateLabel => dateLabel;
        public string Telop => telop;
        public Detail Detail => detail;
        public Temperature Temperature => temperature;
        public ChanceOfRain ChanceOfRain => chanceOfRain;
        public Image Image => image;
    }

    [Serializable]
    public class Temperature
    {
        [SerializeField] TemperatureData min = new TemperatureData();
        [SerializeField] TemperatureData max = new TemperatureData();

        public TemperatureData Min => min;
        public TemperatureData Max => max;
    }

    [Serializable]
    public class ChanceOfRain
    {
        [SerializeField] string T00_06 = string.Empty;
        [SerializeField] string T06_12 = string.Empty;
        [SerializeField] string T12_18 = string.Empty;
        [SerializeField] string T18_24 = string.Empty;

        public string T00To06 => T00_06;
        public string T06To12 => T06_12;
        public string T12To18 => T12_18;
        public string T18To24 => T18_24;
    }

    [Serializable]
    public class TemperatureData
    {
        [SerializeField] string celsius = string.Empty;
        [SerializeField] string fahrenheit = string.Empty;

        public string Celsius => celsius;
        public string Fahrenheit => fahrenheit;
    }

    [Serializable]
    public class Detail
    {
        [SerializeField] string weather = string.Empty;
        [SerializeField] string wind = string.Empty;
        [SerializeField] string wave = string.Empty;

        public string Weather => weather;
        public string Wind => wind;
        public string Wave => wave;
    }

    [Serializable]
    public class Location
    {
        [SerializeField] string area = string.Empty;
        [SerializeField] string prefecture = string.Empty;
        [SerializeField] string district = string.Empty;
        [SerializeField] string city = string.Empty;

        public string Area => area;
        public string Prefecture => prefecture;
        public string District => district;
        public string City => city;
    }

    [Serializable]
    public class Copyright
    {
        [SerializeField] string title = string.Empty;
        [SerializeField] string link = string.Empty;
        [SerializeField] Image image = new Image();
        [SerializeField] Provider[] provider = Array.Empty<Provider>();

        public string Title => title;
        public string Link => link;
        public Image Image => image;
        public IReadOnlyCollection<Provider> Provider => provider;
    }

    [Serializable]
    public class Image
    {
        [SerializeField] string title = string.Empty;
        [SerializeField] string link = string.Empty;
        [SerializeField] string url = string.Empty;
        [SerializeField] int width;
        [SerializeField] int height;

        public string Title => title;
        public string Link => link;
        public string Url => url;
        public int Width => width;
        public int Height => height;
    }

    [Serializable]
    public class Provider
    {
        [SerializeField] string link = string.Empty;
        [SerializeField] string name = string.Empty;
        [SerializeField] string note = string.Empty;

        public string Link => link;
        public string Name => name;
        public string Note => note;
    }
}

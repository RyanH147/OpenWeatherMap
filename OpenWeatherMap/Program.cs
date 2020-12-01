using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace OpenWeatherMap
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("apiKey.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.Write("Please enter your Zip Code: ");
            string zipCode = Console.ReadLine();
            Console.Write("Please enter your Country Code: ");
            string countryCode = Console.ReadLine().ToLower();

            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={APIkey}";

            Console.WriteLine(WeatherAPI.GetTemp(apiCall));
        }
    }
}

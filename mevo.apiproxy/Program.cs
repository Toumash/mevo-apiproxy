using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mevo.apiproxy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = CreateDriver())
            {
                driver.Navigate().GoToUrl("https://rowermevo.pl/mapa-stacji/?city=Gda%C5%84sk&place=#city-switcher");
                var bike_data = (string)driver.ExecuteScript("return NEXTBIKE_PLACES_DB;");

                // following line removes [ and ] on the both ends of the variable in javascript.
                // Without the string cut the string is not a valid json object
                bike_data = bike_data.Substring(1, bike_data.Length - 2);
                var data = JsonConvert.DeserializeObject<MevoApiRootDto>(bike_data);

                var gdansk = data.places.Where(p => p.city == "Gdańsk").ToList();
                var notEmptyPlaces = gdansk.Where(p => p.bike_numbers.Any()).ToList();
                var places = notEmptyPlaces.Select(p => new { p.bike_numbers, p.bike, p.lat, p.lng });
                Console.WriteLine(JsonConvert.SerializeObject(places));
            }
        }

        private static ChromeDriver CreateDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions
            {
                LeaveBrowserRunning = false,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore
            };
            chromeOptions.AddArgument("headless");
            return new ChromeDriver(".", chromeOptions);
        }
    }
}

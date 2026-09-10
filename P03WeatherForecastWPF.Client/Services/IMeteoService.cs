using P03WeatherForecastWPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03WeatherForecastWPF.Client.Services
{
    internal interface IMeteoService
    {
        Task<City[]> GetLocationsAsync(string locationName);

        Task<Weather> GetCurrentConditionsAsync(double latitude, double longitude);
    }
}

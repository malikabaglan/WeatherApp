using System;
using System.Threading.Tasks;

namespace WeatherApp.Services.Settings
{
    public interface ISettingsService
    {


        bool GetValueOrDefault(string key, bool defaultValue);
        string GetValueOrDefault(string key, string defaultValue);
        Task AddOrUpdateValue(string key, bool value);
        Task AddOrUpdateValue(string key, string value);
    }
}

//
//  ApplicationSettings.cs
//
//  Code Construct System 2021-2024
//
using System.Globalization;
using Microsoft.Extensions.Configuration;

[assembly: CLSCompliant(true)]
namespace Configurations
{
    public class ApplicationSettings : IApplicationSettings
    {
        private readonly string settingsSectionName;
        private readonly string settingsFileName;

        public ApplicationSettings()
        {
            settingsSectionName = "appSettings";
            settingsFileName = "appsettings.json";
        }

        public ApplicationSettings(string sectionName)
        {
            settingsSectionName = sectionName;
            settingsFileName = "appsettings.json";
        }

        public ApplicationSettings(string sectionName, string fileName)
        {
            settingsSectionName = sectionName;
            settingsFileName = fileName;
        }

        public long GetIntegerValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0;
            }
            return long.TryParse(configurationValue, out var number) ? number : 0;
        }

        public double GetDoubleValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0;
            }
            return double.TryParse(configurationValue, out var number) ? number : 0;
        }

        public decimal GetDecimalValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0;
            }
            return decimal.TryParse(configurationValue, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var number) ? number : 0;
        }

        public string GetStringValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            return string.IsNullOrEmpty(configurationValue) ? string.Empty : configurationValue;
        }

        public bool GetBooleanValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return false;
            }
            return configurationValue.Equals("TRUE", StringComparison.OrdinalIgnoreCase);
        }

        public DateTime? GetDateTimeValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return DateTime.TryParse(configurationValue, out var dateTime) ? dateTime : null;
        }

        private IConfigurationSection GetConfiguration()
        {
            var configurationRoot = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFileName)
                .Build();

            return configurationRoot.GetSection(settingsSectionName);
        }
    }
}
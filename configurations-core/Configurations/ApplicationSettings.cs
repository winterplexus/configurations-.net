//
//  ApplicationSettings.cs
//
//  Code Construct System 2021-2025
//
using Microsoft.Extensions.Configuration;
using System.Globalization;

[assembly: CLSCompliant(true)]
namespace Configurations
{
    public class ApplicationSettings : IApplicationSettings
    {
        private readonly string settingsSectionName;
        private readonly string settingsFileName;

        public ApplicationSettings()
        {
            settingsFileName = "appsettings.json";
            settingsSectionName = "appSettings";
        }

        public ApplicationSettings(string sectionName)
        {
            settingsFileName = "appsettings.json";
            settingsSectionName = sectionName;
        }

        public ApplicationSettings(string sectionName, string fileName)
        {
            settingsFileName = fileName;
            settingsSectionName = sectionName;
        }

        public char GetCharValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return ' ';
            }
            return configurationValue[0];
        }

        public int GetIntValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0;
            }
            return int.TryParse(configurationValue, out var number) ? number : 0;
        }

        public long GetLongValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0L;
            }
            return long.TryParse(configurationValue, out var number) ? number : 0L;
        }

        public float GetFloatValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return 0;
            }
            return float.TryParse(configurationValue, out var number) ? number : 0;
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

        public bool GetBoolValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return false;
            }
            return configurationValue.Equals("TRUE", StringComparison.OrdinalIgnoreCase);
        }

        public DateTime GetDateTimeValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return DateTime.MinValue;
            }
            return DateTime.TryParse(configurationValue, out var dt) ? dt : DateTime.MinValue;
        }

        public DateOnly GetDateOnlyValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return DateOnly.FromDateTime(DateTime.MinValue);
            }
            var dateTime = DateTime.TryParse(configurationValue, out var dt) ? dt : DateTime.MinValue;
            return DateOnly.FromDateTime(dateTime);
        }

        public TimeOnly GetTimeOnlyValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return TimeOnly.FromDateTime(DateTime.MinValue);
            }
            var dateTime = DateTime.TryParse(configurationValue, out var dt) ? dt : DateTime.MinValue;
            return TimeOnly.FromDateTime(dateTime);
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
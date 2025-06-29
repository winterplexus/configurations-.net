﻿//
//  ApplicationSettings.cs
//
//  Code Construct System 2021-2025
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

        public char? GetCharValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return configurationValue[0];
        }

        public int? GetIntValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return int.TryParse(configurationValue, out var number) ? number : 0;
        }

        public long? GetLongValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return long.TryParse(configurationValue, out var number) ? number : 0;
        }

        public float? GetFloatValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return float.TryParse(configurationValue, out var number) ? number : 0;
        }

        public double? GetDoubleValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return double.TryParse(configurationValue, out var number) ? number : 0;
        }

        public decimal? GetDecimalValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
            }
            return decimal.TryParse(configurationValue, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var number) ? number : 0;
        }

        public string? GetStringValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            return string.IsNullOrEmpty(configurationValue) ? null : configurationValue;
        }

        public bool? GetBoolValue(string name)
        {
            var configurationValue = GetConfiguration()[name];
            if (string.IsNullOrEmpty(configurationValue))
            {
                return null;
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
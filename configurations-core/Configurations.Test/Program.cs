//
//  Program.cs
//
//  Wiregrass Code Technology 2021-2022
//
using System;

[assembly: CLSCompliant(true)]
namespace Configurations.Test
{
    public static class Program
    {
        public static void Main()
        {
            TestApplicationSettings();
            TestApplicationSettings("elementAppSettings");
            TestApplicationSettings("elementAppSettings", "appsettings.dat");
        }

        private static void TestApplicationSettings()
        {
            Console.WriteLine($"{Environment.NewLine}test: application settings using default constructor values");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings();

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        private static void TestApplicationSettings(string sectionName)
        {
            Console.WriteLine($"{Environment.NewLine}test: application settings using section name {sectionName}");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName);

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        private static void TestApplicationSettings(string sectionName, string fileName)
        {
            Console.WriteLine($"{Environment.NewLine}test: application settings using section name {sectionName} and path name {fileName}");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName, fileName);

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        private static void DisplayApplicationSettings(IApplicationSettings applicationSettings)
        {
            Console.WriteLine($"element name         : {applicationSettings.GetStringValue("ElementName")}");
            Console.WriteLine($"element is a gas?    : {applicationSettings.GetBooleanValue("ElementIsGas")}");
            Console.WriteLine($"atomic number        : {applicationSettings.GetIntegerValue("AtomicNumber")}");
            Console.WriteLine($"atomic weight        : {applicationSettings.GetDoubleValue("AtomicWeight")}");
            Console.WriteLine($"thermal conductivity : {applicationSettings.GetDecimalValue("ThermalConductivity")}");
            Console.WriteLine($"source               : {applicationSettings.GetStringValue("Source")}");
            Console.WriteLine($"source publish date  : {applicationSettings.GetDateTimeValue("SourcePublishDate")}");
        }
    }
}
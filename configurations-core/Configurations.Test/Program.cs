//
//  Program.cs
//
//  Wiregrass Code Technology 2021
//
using System;

namespace Configurations.Test
{
    public class Program
    {
        public static void Main()
        {
            TestApplicationSettings();
            TestApplicationSettings("elementAppSettings");
            TestApplicationSettings("elementAppSettings", "appsettings.dat");
        }

        private static void TestApplicationSettings()
        {
            Console.WriteLine("{0}test: application settings using default constructor values", Environment.NewLine);

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings();

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("exception-> argument exception: {0}", ae.Message);
            }
        }

        private static void TestApplicationSettings(string sectionName)
        {
            Console.WriteLine("{0}test: application settings using section name {1}", Environment.NewLine, sectionName);

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName);

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("exception-> argument exception: {0}", ae.Message);
            }
        }

        private static void TestApplicationSettings(string sectionName, string fileName)
        {
            Console.WriteLine("{0}test: application settings using section name {1} and path name {2}", Environment.NewLine, sectionName, fileName);

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName, fileName);

                DisplayApplicationSettings(applicationSettings);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("exception-> argument exception: {0}", ae.Message);
            }
        }

        private static void DisplayApplicationSettings(IApplicationSettings applicationSettings)
        {
            Console.WriteLine("element name         : {0}", applicationSettings.GetStringValue("ElementName"));
            Console.WriteLine("element is a gas?    : {0}", applicationSettings.GetBooleanValue("ElementIsGas"));
            Console.WriteLine("atomic number        : {0}", applicationSettings.GetIntegerValue("AtomicNumber"));
            Console.WriteLine("atomic weight        : {0}", applicationSettings.GetDoubleValue("AtomicWeight"));
            Console.WriteLine("thermal conductivity : {0}", applicationSettings.GetDecimalValue("ThermalConductivity"));
            Console.WriteLine("source               : {0}", applicationSettings.GetStringValue("Source"));
            Console.WriteLine("source publish date  : {0}", applicationSettings.GetDateTimeValue("SourcePublishDate"));
        }
    }
}
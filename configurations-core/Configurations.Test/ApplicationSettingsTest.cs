//
//  ApplicationSettingsTest.cs
//
//  Code Construct System 2021-2024
//
namespace Configurations.Test
{
    [TestClass]
    public class ApplicationSettingsTest
    {
        [TestMethod]
        public void GetDefaultConstructorIntegerValueTest()
        {
            Console.WriteLine("");
            Console.WriteLine("class ApplicationSettings() test: default constructor");
            Console.WriteLine("-----------------------------------------------------");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings();

                Console.WriteLine($"atomic number             : {applicationSettings.GetIntegerValue("AtomicNumber")}");
                Console.WriteLine($"atomic weight             : {applicationSettings.GetDoubleValue("AtomicWeight")}");
                Console.WriteLine($"thermal conductivity      : {applicationSettings.GetDecimalValue("ThermalConductivity")}");
                Console.WriteLine($"element name              : {applicationSettings.GetStringValue("ElementName")}");
                Console.WriteLine($"element is a gas?         : {applicationSettings.GetBooleanValue("ElementIsGas")}");
                Console.WriteLine($"source publish date       : {applicationSettings.GetDateTimeValue("SourcePublishDate")}");

                Assert.AreEqual("10",                           applicationSettings.GetIntegerValue("AtomicNumber").ToString());
                Assert.AreEqual("20.179",                       applicationSettings.GetDoubleValue("AtomicWeight").ToString());
                Assert.AreEqual("81435716392427590.1995589401", applicationSettings.GetDecimalValue("ThermalConductivity").ToString());
                Assert.AreEqual("neon",                         applicationSettings.GetStringValue("ElementName"));
                Assert.AreEqual("True",                         applicationSettings.GetBooleanValue("ElementIsGas").ToString());
                Assert.AreEqual("7/15/2023 12:00:00 AM",        applicationSettings.GetDateTimeValue("SourcePublishDate").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        [TestMethod]
        public void GetSectionNameConstructorIntegerValueTest()
        {
            var sectionName = "elementAppSettings";

            Console.WriteLine("");
            Console.WriteLine($"class ApplicationSettings(\"{sectionName}\") test");
            Console.WriteLine("----------------------------------------------------");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName);

                Console.WriteLine($"atomic number             : {applicationSettings.GetIntegerValue("AtomicNumber")}");
                Console.WriteLine($"atomic weight             : {applicationSettings.GetDoubleValue("AtomicWeight")}");
                Console.WriteLine($"thermal conductivity      : {applicationSettings.GetDecimalValue("ThermalConductivity")}");
                Console.WriteLine($"element name              : {applicationSettings.GetStringValue("ElementName")}");
                Console.WriteLine($"element is a gas?         : {applicationSettings.GetBooleanValue("ElementIsGas")}");
                Console.WriteLine($"source publish date       : {applicationSettings.GetDateTimeValue("SourcePublishDate")}");

                Assert.AreEqual("10",                           applicationSettings.GetIntegerValue("AtomicNumber").ToString());
                Assert.AreEqual("20.179",                       applicationSettings.GetDoubleValue("AtomicWeight").ToString());
                Assert.AreEqual("81435716392427590.1995589401", applicationSettings.GetDecimalValue("ThermalConductivity").ToString());
                Assert.AreEqual("neon",                         applicationSettings.GetStringValue("ElementName"));
                Assert.AreEqual("True",                         applicationSettings.GetBooleanValue("ElementIsGas").ToString());
                Assert.AreEqual("7/15/2023 12:00:00 AM",        applicationSettings.GetDateTimeValue("SourcePublishDate").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        [TestMethod]
        public void GetSectionNameFileNameConstructorIntegerValueTest()
        {
            var sectionName = "elementAppSettings";
            var applicationSettingsFileName = "appsettings.dat";

            Console.WriteLine("");
            Console.WriteLine($"class method ApplicationSettings(\"{sectionName}\", \"{applicationSettingsFileName }\") test");
            Console.WriteLine("------------------------------------------------------------------------------");

            try
            {
                IApplicationSettings applicationSettings = new ApplicationSettings(sectionName, applicationSettingsFileName);

                Console.WriteLine($"atomic number             : {applicationSettings.GetIntegerValue("AtomicNumber")}");
                Console.WriteLine($"atomic weight             : {applicationSettings.GetDoubleValue("AtomicWeight")}");
                Console.WriteLine($"thermal conductivity      : {applicationSettings.GetDecimalValue("ThermalConductivity")}");
                Console.WriteLine($"element name              : {applicationSettings.GetStringValue("ElementName")}");
                Console.WriteLine($"element is a gas?         : {applicationSettings.GetBooleanValue("ElementIsGas")}");
                Console.WriteLine($"source publish date       : {applicationSettings.GetDateTimeValue("SourcePublishDate")}");

                Assert.AreEqual("10",                           applicationSettings.GetIntegerValue("AtomicNumber").ToString());
                Assert.AreEqual("20.179",                       applicationSettings.GetDoubleValue("AtomicWeight").ToString());
                Assert.AreEqual("81435716392427590.1995589401", applicationSettings.GetDecimalValue("ThermalConductivity").ToString());
                Assert.AreEqual("neon",                         applicationSettings.GetStringValue("ElementName"));
                Assert.AreEqual("True",                         applicationSettings.GetBooleanValue("ElementIsGas").ToString());
                Assert.AreEqual("7/15/2023 12:00:00 AM",        applicationSettings.GetDateTimeValue("SourcePublishDate").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }
    }
}
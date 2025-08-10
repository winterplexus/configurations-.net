//
//  ApplicationSettingsTest.cs
//
//  Code Construct System 2021-2025
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
                ApplicationSettings applicationSettings = new ApplicationSettings();

                Console.WriteLine($"char-value         : {applicationSettings.GetCharValue("char-value")}");                                     
                Console.WriteLine($"int-value          : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long-vaue          : {applicationSettings.GetLongValue("long-value")}");                                     
                Console.WriteLine($"float-value        : {applicationSettings.GetFloatValue("float-value")}");                                    
                Console.WriteLine($"double-value       : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal-value      : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string-value       : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool-value         : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime-value     : {applicationSettings.GetDateTimeValue("datetime-value")}");

                Assert.AreEqual("A",                     applicationSettings.GetCharValue("char-value").ToString());                             
                Assert.AreEqual("1",                     applicationSettings.GetIntValue("int-value").ToString());               
                Assert.AreEqual("2",                     applicationSettings.GetLongValue("long-value").ToString());                             
                Assert.AreEqual("1.1",                   applicationSettings.GetFloatValue("float-value").ToString());                            
                Assert.AreEqual("2.12",                  applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123",                 applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc",               applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True",                  applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:00:00 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());
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
                ApplicationSettings applicationSettings = new ApplicationSettings(sectionName);

                Console.WriteLine($"char-value         : {applicationSettings.GetCharValue("char-value")}");                                     
                Console.WriteLine($"int-value          : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long-vaue          : {applicationSettings.GetLongValue("long-value")}");                                     
                Console.WriteLine($"float-value        : {applicationSettings.GetFloatValue("float-value")}");                                    
                Console.WriteLine($"double-value       : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal-value      : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string-value       : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool-value         : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime-value     : {applicationSettings.GetDateTimeValue("datetime-value")}");

                Assert.AreEqual("A",                     applicationSettings.GetCharValue("char-value").ToString());                             
                Assert.AreEqual("1",                     applicationSettings.GetIntValue("int-value").ToString());               
                Assert.AreEqual("2",                     applicationSettings.GetLongValue("long-value").ToString());                             
                Assert.AreEqual("1.1",                   applicationSettings.GetFloatValue("float-value").ToString());                            
                Assert.AreEqual("2.12",                  applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123",                 applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc",               applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True",                  applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:00:00 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());                  
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
                ApplicationSettings applicationSettings = new ApplicationSettings(sectionName, applicationSettingsFileName);

                Console.WriteLine($"char-value         : {applicationSettings.GetCharValue("char-value")}");
                Console.WriteLine($"int-value          : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long-vaue          : {applicationSettings.GetLongValue("long-value")}");
                Console.WriteLine($"float-value        : {applicationSettings.GetFloatValue("float-value")}");
                Console.WriteLine($"double-value       : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal-value      : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string-value       : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool-value         : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime-value     : {applicationSettings.GetDateTimeValue("datetime-value")}");

                Assert.AreEqual("A",                     applicationSettings.GetCharValue("char-value").ToString());
                Assert.AreEqual("1",                     applicationSettings.GetIntValue("int-value").ToString());
                Assert.AreEqual("2",                     applicationSettings.GetLongValue("long-value").ToString());
                Assert.AreEqual("1.1",                   applicationSettings.GetFloatValue("float-value").ToString());
                Assert.AreEqual("2.12",                  applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123",                 applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc",               applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True",                  applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:00:00 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }
    }
}
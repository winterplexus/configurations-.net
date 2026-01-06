//
//  ApplicationSettingsTest.cs
//
//  Code Construct System 2021-2025
//
[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
namespace Configurations.Test
{
    [TestClass]
    public class ApplicationSettingsTest
    {
        [TestMethod]
        public void DefaultConstructorGetValuesTest()
        {
            Console.WriteLine("");
            Console.WriteLine("ApplicationSettings class methods tests: default constructor");
            Console.WriteLine("------------------------------------------------------------");

            try
            {
                ApplicationSettings applicationSettings = new ApplicationSettings();

                Console.WriteLine($"char              : {applicationSettings.GetCharValue("char-value")}");
                Console.WriteLine($"int               : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long              : {applicationSettings.GetLongValue("long-value")}");
                Console.WriteLine($"float             : {applicationSettings.GetFloatValue("float-value")}");
                Console.WriteLine($"double            : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal           : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string            : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool              : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime          : {applicationSettings.GetDateTimeValue("datetime-value")}");
                Console.WriteLine($"date-only         : {applicationSettings.GetDateOnlyValue("datetime-value")}");
                Console.WriteLine($"time-only         : {applicationSettings.GetTimeOnlyValue("datetime-value")}");

                Assert.AreEqual("A",                     applicationSettings.GetCharValue("char-value").ToString());
                Assert.AreEqual("1",                     applicationSettings.GetIntValue("int-value").ToString());
                Assert.AreEqual("2",                     applicationSettings.GetLongValue("long-value").ToString());
                Assert.AreEqual("1.1",                   applicationSettings.GetFloatValue("float-value").ToString());
                Assert.AreEqual("2.12",                  applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123",                 applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc",               applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True",                  applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:10:55 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());
                Assert.AreEqual("6/15/2025",             applicationSettings.GetDateOnlyValue("datetime-value").ToString());
                Assert.AreEqual("12:10 AM",              applicationSettings.GetTimeOnlyValue("datetime-value").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        [TestMethod]
        public void SectionNameGetValuesTest()
        {
            var sectionName = "sectionName";

            Console.WriteLine("");
            Console.WriteLine($"ApplicationSettings class methods tests: contructor (\"{sectionName}\")");
            Console.WriteLine("-------------------------------------------------------------------");

            try
            {
                ApplicationSettings applicationSettings = new ApplicationSettings(sectionName);

                Console.WriteLine($"char              : {applicationSettings.GetCharValue("char-value")}");
                Console.WriteLine($"int               : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long              : {applicationSettings.GetLongValue("long-value")}");
                Console.WriteLine($"float             : {applicationSettings.GetFloatValue("float-value")}");
                Console.WriteLine($"double            : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal           : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string            : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool              : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime          : {applicationSettings.GetDateTimeValue("datetime-value")}");
                Console.WriteLine($"date-only         : {applicationSettings.GetDateOnlyValue("datetime-value")}");
                Console.WriteLine($"time-only         : {applicationSettings.GetTimeOnlyValue("datetime-value")}");

                Assert.AreEqual("A",                     applicationSettings.GetCharValue("char-value").ToString());
                Assert.AreEqual("1",                     applicationSettings.GetIntValue("int-value").ToString());
                Assert.AreEqual("2",                     applicationSettings.GetLongValue("long-value").ToString());
                Assert.AreEqual("1.1",                   applicationSettings.GetFloatValue("float-value").ToString());
                Assert.AreEqual("2.12",                  applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123",                 applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc",               applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True",                  applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:10:55 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());
                Assert.AreEqual("6/15/2025",             applicationSettings.GetDateOnlyValue("datetime-value").ToString());
                Assert.AreEqual("12:10 AM",              applicationSettings.GetTimeOnlyValue("datetime-value").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }

        [TestMethod]
        public void SectionNameFileNameGetValuesTest()
        {
            var sectionName = "sectionName";
            var applicationSettingsFileName = "appsettings.dat";

            Console.WriteLine("");
            Console.WriteLine($"ApplicationSettings class methods tests: contructor(\"{sectionName}\", \"{applicationSettingsFileName}\")");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            try
            {
                ApplicationSettings applicationSettings = new ApplicationSettings(sectionName, applicationSettingsFileName);

                Console.WriteLine($"char              : {applicationSettings.GetCharValue("char-value")}");
                Console.WriteLine($"int               : {applicationSettings.GetIntValue("int-value")}");
                Console.WriteLine($"long              : {applicationSettings.GetLongValue("long-value")}");
                Console.WriteLine($"float             : {applicationSettings.GetFloatValue("float-value")}");
                Console.WriteLine($"double            : {applicationSettings.GetDoubleValue("double-value")}");
                Console.WriteLine($"decimal           : {applicationSettings.GetDecimalValue("decimal-value")}");
                Console.WriteLine($"string            : {applicationSettings.GetStringValue("string-value")}");
                Console.WriteLine($"bool              : {applicationSettings.GetBoolValue("bool-value")}");
                Console.WriteLine($"datetime          : {applicationSettings.GetDateTimeValue("datetime-value")}");
                Console.WriteLine($"date-only         : {applicationSettings.GetDateOnlyValue("datetime-value")}");
                Console.WriteLine($"time-only         : {applicationSettings.GetTimeOnlyValue("datetime-value")}");

                Assert.AreEqual("A", applicationSettings.GetCharValue("char-value").ToString());
                Assert.AreEqual("1", applicationSettings.GetIntValue("int-value").ToString());
                Assert.AreEqual("2", applicationSettings.GetLongValue("long-value").ToString());
                Assert.AreEqual("1.1", applicationSettings.GetFloatValue("float-value").ToString());
                Assert.AreEqual("2.12", applicationSettings.GetDoubleValue("double-value").ToString());
                Assert.AreEqual("3.123", applicationSettings.GetDecimalValue("decimal-value").ToString());
                Assert.AreEqual("ABC abc", applicationSettings.GetStringValue("string-value"));
                Assert.AreEqual("True", applicationSettings.GetBoolValue("bool-value").ToString());
                Assert.AreEqual("6/15/2025 12:10:55 AM", applicationSettings.GetDateTimeValue("datetime-value").ToString());
                Assert.AreEqual("6/15/2025", applicationSettings.GetDateOnlyValue("datetime-value").ToString());
                Assert.AreEqual("12:10 AM", applicationSettings.GetTimeOnlyValue("datetime-value").ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"exception-> argument exception: {ae.Message}");
            }
        }
    }
}
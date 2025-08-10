//
//  IApplicationSettings.cs
//
//  Code Construct System 2021-2025
//
namespace Configurations
{
    public interface IApplicationSettings
    {
        public char GetCharValue(string name);
        public int GetIntValue(string name);
        public long GetLongValue(string name);
        public float GetFloatValue(string name);
        public double GetDoubleValue(string name);
        public decimal GetDecimalValue(string name);
        public string GetStringValue(string name);
        public bool GetBoolValue(string name);
        public DateTime GetDateTimeValue(string name);
    }
}
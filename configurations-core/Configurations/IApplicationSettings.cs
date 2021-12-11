//
//  IApplicationSettings.cs
//
//  Wiregrass Code Technology 2021-2022
//
using System;

namespace Configurations
{
    public interface IApplicationSettings
    {
        public long GetIntegerValue(string name);
        public double GetDoubleValue(string name);
        public decimal GetDecimalValue(string name);
        public string GetStringValue(string name);
        public bool GetBooleanValue(string name);
        public DateTime? GetDateTimeValue(string name);
    }
}
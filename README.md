Configurations Library for .NET Core
====================================

Configurations library based on .NET Core platform and contains interface and class for application settings configurations.

* IApplicationSettings interface:

```
    public interface IApplicationSettings
    {
        public long GetIntegerValue(string name);

        public double GetDoubleValue(string name);

        public decimal GetDecimalValue(string name);

        public string GetStringValue(string name);

        public bool GetBooleanValue(string name);

        public DateTime? GetDateTimeValue(string name);
    }
```
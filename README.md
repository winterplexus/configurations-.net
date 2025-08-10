Configurations Library for .NET
=================================
Configurations library based on .NET 8 LTS platform and contains interfaces and classes for application settings configurations.

Library includes the following components:

* IApplicationSettings interface

## IApplicationSettings Interface

```
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
```
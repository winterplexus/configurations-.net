Configurations Library for .NET
===============================
Configurations library based on .NET 9 platform and contains interfaces and classes for application settings configurations.

Library includes the following components:

* IApplicationSettings interface
* ApplicationSettings class

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
    public DateOnly GetDateOnlyValue(string name);
    public TimeOnly GetTimeOnlyValue(string name);
```

## ApplicationSettings Class Instantiation

```
public ApplicationSettings()
public ApplicationSettings(string sectionName)
public ApplicationSettings(string sectionName, string fileName)
```
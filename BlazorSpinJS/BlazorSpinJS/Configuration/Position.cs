using CustomEnum;

namespace BlazorSpinJS.Configuration;

public class Position : Enumeration<string>
{
    public static Position Absolute = new Position("absolute", "Absolute");
    public static Position Fixed = new Position("fixed", "Fixed");

    public Position(string value, string displayName) : base(value, displayName) { }
}
using System.Text.Json;

namespace BlazorSpinJS.Components;
public class Spinner
{
    /// <summary>
    ///  The number of lines to draw
    /// </summary>
    public int Lines { get; set; } = 13;

    /// <summary>
    ///  The length of each line
    /// </summary>
    public int Length { get; set; } = 20;

    /// <summary>
    ///  The line thickness
    /// </summary>
    public int Width { get; set; } = 10;

    /// <summary>
    ///  The radius of the inner circle
    /// </summary>
    public int Radius { get; set; } = 45;

    /// <summary>
    ///  Scales overall size of the spinner
    /// </summary>
    public int Scale { get; set; } = 1;

    /// <summary>
    ///  Corner roundness (0.1)
    /// </summary>
    public int Corners { get; set; } = 1;

    /// <summary>
    ///  Rounds per second
    /// </summary>
    public int Speed { get; set; } = 1;

    /// <summary>
    ///  The rotation offset
    /// </summary>
    public int Rotate { get; set; } = 0;

    /// <summary>
    ///  The CSS animation name for the lines
    /// </summary>
    public string Animation { get; set; } = "spinner-line-fade-quick";

    /// <summary>
    ///  1 : clockwise, -1: counter clockwise
    /// </summary>
    public int Direction { get; set; } = 1;

    /// <summary>
    ///  CSS color or array of colors
    /// </summary>
    public string Color { get; set; } = "#000000";

    /// <summary>
    ///  CSS color or array of colors
    /// </summary>
    public string FadeColor { get; set; } = "#e3e3e3";

    /// <summary>
    ///  Top position relative to parent
    /// </summary>
    public string Top { get; set; } = "50%";

    /// <summary>
    ///  Left position relative to parent
    /// </summary>
    public string Left { get; set; } = "50%";

    /// <summary>
    ///  Box-shadow for the lines
    /// </summary>
    public string Shadow { get; set; } = "0 0 1px transparent";

    /// <summary>
    ///  the z-index (defaults to 2e9)
    /// </summary>
    public long ZIndex { get; set; } = 2000000000;

    /// <summary>
    ///  The CSS class to assign to the spinner
    /// </summary>
    public string ClassName { get; set; } = "spinner";

    /// <summary>
    ///  Element positioning
    /// </summary>
    public string Position { get; set; } = "absolute";


    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}

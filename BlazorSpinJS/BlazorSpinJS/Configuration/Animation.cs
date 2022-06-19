using CustomEnum;

namespace BlazorSpinJS.Configuration;

public class Animation : Enumeration<string>
{
    public static Animation FadeDefault = new Animation("spinner-line-fade-default", "Fade Default");
    public static Animation FadeQuick = new Animation("spinner-line-fade-quick", "Fade Quick");
    public static Animation FadeMore = new Animation("spinner-line-fade-more", "Fade More");
    public static Animation Shrink = new Animation("spinner-line-shrink", "Shrink");
    public Animation(string value, string displayName) : base(value, displayName) { }
}

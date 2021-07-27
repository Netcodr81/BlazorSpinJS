using CustomEnum;

namespace BlazorSpinJS.Configuration
{
    public class Animation : Enumeration<string>
    {
        public static Animation FadeDefault = new Animation("Fade Default", "spinner-line-fade-default");
        public static Animation FadeQuick = new Animation("Fade Quick", "spinner-line-fade-quick");
        public static Animation FadeMore = new Animation("Fade More", "spinner-line-fade-more");
        public static Animation Shrink = new Animation("Shrink", "spinner-line-shrink");
        public Animation(string value, string displayName) : base(value, displayName) { }
    }
}

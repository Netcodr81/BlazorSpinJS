using System.Text.Json;

namespace BlazorSpinJS.Configuration
{
    public class SpinnerOptions
    {
        public SpinnerOptions()
        {

        }

        public SpinnerOptions(int? lines, int? length, int? width, int? radius, int? scale, 
                              int? corners, int? speed, int? rotate, Animation animation, 
                              SpinDirection direction, string color, string fadeColor, string top,
                              string left, string shadow, long? zIndex, string className, string position)
        {
            Lines = lines != null ? lines.Value : Lines;
            Length = length != null ? length.Value : Length;
            Width = width != null ? width.Value : Width;
            Radius = radius != null ? radius.Value : Radius;
            Scale = scale != null ? scale.Value : Scale;
            Corners = corners != null ? corners.Value : Corners;
            Speed = speed != null ? speed.Value : Speed;
            Rotate = rotate != null ? rotate.Value : Rotate;
            Animation = animation != null ? animation.Value : Animation;
            Direction = direction != null ? direction.Value : Direction;
            Color = !string.IsNullOrEmpty(color) ? color : Color;
            FadeColor = !string.IsNullOrEmpty(fadeColor) ? fadeColor : FadeColor;
            Top = !string.IsNullOrEmpty(top) ? top : Top;
            Left = !string.IsNullOrEmpty(left) ? left : Left;
            Shadow = !string.IsNullOrEmpty(shadow) ? shadow : Shadow;
            ZIndex = zIndex != null ? zIndex.Value : ZIndex;
            ClassName = !string.IsNullOrEmpty(className) ? className : ClassName;
            Position = !string.IsNullOrEmpty(position) ? position : Position;

        }
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

   
}

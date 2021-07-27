using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorSpinner.Configuration;

namespace BlazorSpinner.Utils
{
    internal static class Mapper
    {
        public static SpinnerOptions MapOptions(SpinnerOptions options, bool isFixed)
        {
            var spinnerOptions = new SpinnerOptions()
            {
                Lines = options.Lines,
                Length = options.Length,
                Width = options.Width,
                Radius = options.Radius,
                Scale = options.Scale,
                Corners = options.Corners,
                Speed = options.Speed,
                Rotate = options.Rotate,
                Animation = options.Animation,
                Direction = options.Direction,
                Color = options.Color,
                FadeColor = options.FadeColor,
                Top = options.Top,
                Left = options.Left,
                Shadow = options.Shadow,
                ZIndex = options.ZIndex,
                ClassName = options.ClassName,
                Position = isFixed ? "fixed" : "absolute"
            };

            return spinnerOptions;
        }

        public static void UpdateOptions(SpinnerOptions orginalValues, SpinnerOptions updatedValues)
        {
            orginalValues.Lines = updatedValues.Lines;
            orginalValues.Length = updatedValues.Length;
            orginalValues.Width = updatedValues.Width;
            orginalValues.Radius = updatedValues.Radius;
            orginalValues.Scale = updatedValues.Scale;
            orginalValues.Corners = updatedValues.Corners;
            orginalValues.Speed = updatedValues.Speed;
            orginalValues.Rotate = updatedValues.Rotate;
            orginalValues.Animation = updatedValues.Animation;
            orginalValues.Direction = updatedValues.Direction;
            orginalValues.Color = updatedValues.Color;
            orginalValues.FadeColor = updatedValues.FadeColor;
            orginalValues.Top = updatedValues.Top;
            orginalValues.Left = updatedValues.Left;
            orginalValues.Shadow = updatedValues.Shadow;
            orginalValues.ZIndex = updatedValues.ZIndex;
            orginalValues.ClassName = updatedValues.ClassName;
            orginalValues.Position = updatedValues.Position;
        }
    }
}

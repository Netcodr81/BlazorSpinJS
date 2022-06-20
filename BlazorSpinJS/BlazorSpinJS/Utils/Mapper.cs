using BlazorSpinJS.Components;
using BlazorSpinJS.Configuration;

namespace BlazorSpinJS.Utils;

internal static class Mapper
{
    public static Spinner MapOptions(SpinnerOptions options)
    {
        var spinner = new Spinner()
        {
            Lines = options.Lines,
            Length = options.Length,
            Width = options.Width,
            Radius = options.Radius,
            Scale = options.Scale,
            Corners = options.Corners,
            Speed = options.Speed,
            Rotate = options.Rotate,
            Animation = options.Animation.Value,
            Direction = options.Direction.Value,
            Color = options.Color,
            FadeColor = options.FadeColor,
            Top = options.Top,
            Left = options.Left,
            Shadow = options.Shadow,
            ZIndex = options.ZIndex,
            ClassName = options.ClassName,
            Position = options.Position.Value
        };

        return spinner;
    }

    public static void UpdateSpinner(Spinner spinnerToReset, Spinner spinnerFromService)
    {
        spinnerToReset.Lines = spinnerFromService.Lines;
        spinnerToReset.Length = spinnerFromService.Length;
        spinnerToReset.Width = spinnerFromService.Width;
        spinnerToReset.Radius = spinnerFromService.Radius;
        spinnerToReset.Scale = spinnerFromService.Scale;
        spinnerToReset.Corners = spinnerFromService.Corners;
        spinnerToReset.Speed = spinnerFromService.Speed;
        spinnerToReset.Rotate = spinnerFromService.Rotate;
        spinnerToReset.Animation = spinnerFromService.Animation;
        spinnerToReset.Direction = spinnerFromService.Direction;
        spinnerToReset.Color = spinnerFromService.Color;
        spinnerToReset.FadeColor = spinnerFromService.FadeColor;
        spinnerToReset.Top = spinnerFromService.Top;
        spinnerToReset.Left = spinnerFromService.Left;
        spinnerToReset.Shadow = spinnerFromService.Shadow;
        spinnerToReset.ZIndex = spinnerFromService.ZIndex;
        spinnerToReset.ClassName = spinnerFromService.ClassName;
        spinnerToReset.Position = spinnerFromService.Position;
    }
}

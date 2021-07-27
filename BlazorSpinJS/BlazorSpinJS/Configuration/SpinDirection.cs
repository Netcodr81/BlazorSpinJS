using CustomEnum;

namespace BlazorSpinJS.Configuration
{
    public class SpinDirection : Enumeration<int>
    {

        public static SpinDirection Clockwise = new SpinDirection(1, "Clockwise");
        public static SpinDirection CounterClockwise = new SpinDirection(-1, "Clockwise");
        public SpinDirection(int value, string displayName) : base(value, displayName) { }
    }
   
}

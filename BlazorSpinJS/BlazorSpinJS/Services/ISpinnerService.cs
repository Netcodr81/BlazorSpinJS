using System;

namespace BlazorSpinJS.Services
{
    public interface ISpinnerService
    {  

        event Action Spin;
        event Action NoSpin;
        event Action SetSpinner;

        void StartSpinner();
        void StopSpinner();

        void ResetSpinner();
    }
}

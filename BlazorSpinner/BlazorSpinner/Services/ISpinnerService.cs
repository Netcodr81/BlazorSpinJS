using System;

namespace BlazorSpinner.Services
{
    public interface ISpinnerService
    {  

        event Action Spin;
        event Action NoSpin;

        void StartSpinner();
        void StopSpinner();
    }
}

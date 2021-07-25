using BlazorSpinner.Configuration;
using System;

namespace BlazorSpinner.Services
{
    public interface ISpinnerService
    {
        SpinnerOptions SpinnerOptions { get; set; }

        event Action Spin;
        event Action NoSpin;

        void StartSpinner();
        void StopSpinner();
    }
}

using BlazorSpinJS.Components;
using System;

namespace BlazorSpinJS.Services;

public class SpinnerService : ISpinnerService
{


    public event Action Spin;

    public event Action<Spinner> DynamicConfigSpin;

    public event Action NoSpin;

    public event Action<Spinner> SetSpinner;

    public void StartSpinner()
    {
        Spin?.Invoke();
    }

    public void StartSpinner(Spinner options)
    {
        DynamicConfigSpin?.Invoke(options);
    }

    public void StopSpinner()
    {
        NoSpin?.Invoke();
    }

    public void ResetSpinner(Spinner spinnerToReset)
    {
        SetSpinner?.Invoke(spinnerToReset);
    }
}

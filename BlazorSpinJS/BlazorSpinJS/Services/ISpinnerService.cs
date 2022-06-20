using BlazorSpinJS.Components;
using System;

namespace BlazorSpinJS.Services;

public interface ISpinnerService
{

    event Action Spin;
    event Action<Spinner> DynamicConfigSpin;
    event Action NoSpin;
    event Action<Spinner> SetSpinner;

    void StartSpinner();

    void StartSpinner(Spinner options);

    void StopSpinner();

    void ResetSpinner(Spinner spinnerToReset);
}

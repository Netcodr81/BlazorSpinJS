using BlazorSpinJS.Components;
using BlazorSpinJS.Configuration;
using BlazorSpinJS.Utils;

namespace BlazorSpinJS.Services;

public class SpinnerOptionsService : ISpinnerOptionsService
{

    public SpinnerOptionsService(SpinnerOptions options)
    {

        _spinnerOptions = options;

    }

    private SpinnerOptions _spinnerOptions;

    public Spinner GetSpinner()
    {
        return Mapper.MapOptions(_spinnerOptions);
    }
}

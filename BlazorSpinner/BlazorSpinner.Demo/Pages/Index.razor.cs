using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorSpinner.Demo.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public ISpinnerService SpinnerService { get; set; }

        private void StartSpinner()
        {
            SpinnerService.StartSpinner();
        }

        private void StopSpinner()
        {
            SpinnerService.StopSpinner();
        }
    }

}


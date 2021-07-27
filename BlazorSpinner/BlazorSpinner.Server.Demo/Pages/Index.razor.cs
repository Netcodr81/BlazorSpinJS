using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorSpinner.Server.Demo.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public ISpinnerService SpinnerService { get; set; }
        private bool IsSpinning = false;

        private void StartSpinner()
        {
            if (!IsSpinning)
            {
                SpinnerService.StartSpinner();
                IsSpinning = !IsSpinning;
            }
           
        }

        private void StopSpinner()
        {
            if (IsSpinning)
            {
                SpinnerService.StopSpinner();
                IsSpinning = !IsSpinning;
            }
           
        }
    }

}


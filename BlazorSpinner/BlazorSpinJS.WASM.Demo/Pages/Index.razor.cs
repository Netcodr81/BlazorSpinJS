using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorSpinJS.Services;

namespace BlazorSpinJS.WASM.Demo.Pages
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

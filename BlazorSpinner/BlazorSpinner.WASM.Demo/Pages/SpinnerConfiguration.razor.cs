using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSpinner.Configuration;
using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorSpinner.WASM.Demo.Pages
{
    public partial class SpinnerConfiguration : ComponentBase
    {
        [Inject]
        public ISpinnerService SpinnerService { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [CascadingParameter]
        public SpinnerOptions SpinnerOptions { get; set; }

        [CascadingParameter]
        public EventCallback<SpinnerOptions> OnSpinnerOptionsChanged { get; set; }

        private List<SelectListItem> Animations { get; set; } = new List<SelectListItem>();

        private List<SelectListItem> SpinDirection { get; set; } = new List<SelectListItem>();

        private bool IsSpinning = false;

        private bool StartDisabled { get; set; } = false;
        public bool StopDisabled { get; set; } = false;

        public bool ResetDisabled { get; set; } = false;

        public bool DownloadDisabled { get; set; } = false;

        public bool FormDisabled { get; set; } = false;


        protected override void OnInitialized()
        {
            Animations.Add(new SelectListItem() { Text = "Fade Default", Value = "spinner-line-fade-default", Selected = true });
            Animations.Add(new SelectListItem() { Text = "Fade Quick", Value = "spinner-line-fade-quick" });
            Animations.Add(new SelectListItem() { Text = "Fade More", Value = "spinner-line-fade-more" });
            Animations.Add(new SelectListItem() { Text = "Shrink", Value = "spinner-line-shrink" });

            SpinDirection.Add(new SelectListItem() { Text = "Clockwise", Value = "1" });
            SpinDirection.Add(new SelectListItem() { Text = "Counter Clockwise", Value = "-1" });


        }


        private void StartSpinner()
        {
            if (!IsSpinning)
            {
                SpinnerService.StartSpinner();
                IsSpinning = !IsSpinning;
                StopDisabled = false;
                ResetDisabled = true;
                StartDisabled = true;
                DownloadDisabled = true;
                FormDisabled = true;
            }

        }

        private void StopSpinner()
        {
            if (IsSpinning)
            {
                SpinnerService.StopSpinner();
                IsSpinning = !IsSpinning;
                StopDisabled = false;
                ResetDisabled = false;
                StartDisabled = false;
                DownloadDisabled = false;
                FormDisabled = false;
            }

        }

        private void ResetValues()
        {
            StopSpinner();
            SpinnerService.ResetSpinner();
            StateHasChanged();
            Alert("Spinner reset");

        }

        private void Alert(string message)
        {
            JSRuntime.InvokeVoidAsync("window.alert", message);
        }

        //https://wellsb.com/csharp/aspnet/blazor-jsinterop-save-file/
        private void DownloadValues()
        {
            var fileContent = JsonConvert.SerializeObject(SpinnerOptions);

            JSRuntime.InvokeAsync<object>("FileSaveAsJson", "SpinnerSettings.json", fileContent);
        }
    }
}

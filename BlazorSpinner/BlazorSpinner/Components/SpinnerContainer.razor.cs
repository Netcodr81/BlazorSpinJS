using BlazorSpinner.Configuration;
using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSpinner.Components
{
    public partial class SpinnerContainer : ComponentBase
    {
        private string SpinnerId { get; set; }

        private IJSObjectReference _jsModule;

        protected override async Task OnInitializedAsync()
        {
            SpinnerId = "spinner" + Guid.NewGuid();
            SpinnerService.Spin += Spin;
            SpinnerService.NoSpin += Stop;

          

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorSpinner/blazor-spin.js");
                await _jsModule.InvokeVoidAsync("Initialize", SpinnerService.SpinnerOptions);
            }           
        }

        [Inject]
        public ISpinnerService SpinnerService { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; } 

       
        public void Stop()
        {
            _jsModule.InvokeVoidAsync("DefaultSpinner.Stop");
        }

        public void Spin()
        {
            _jsModule.InvokeVoidAsync("DefaultSpinner.Spin", SpinnerId);
        }

    }
}

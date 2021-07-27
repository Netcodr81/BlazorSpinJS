using BlazorSpinner.Configuration;
using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using BlazorSpinner.Utils;

namespace BlazorSpinner.Components
{

    public partial class SpinnerContainer : ComponentBase, IDisposable

    {
        private string SpinnerId { get; set; }

        private IJSObjectReference _jsModule;

        protected override void OnInitialized()
        {
            SpinnerId = "spinner" + Guid.NewGuid();
            SpinnerService.Spin += Spin;
            SpinnerService.NoSpin += Stop;
            SpinnerService.SetSpinner += ResetSpinner;
            NavigationManager.LocationChanged += LocationChanged;

            if (SpinnerOptions == null)
            {
                SpinnerOptions = new SpinnerOptions();
            }
            else
            {
                OriginalSpinnerOptions = Mapper.MapOptions(SpinnerOptions, IsFixed);

            }


        }

        protected override void OnParametersSet()
        {
            if (IsFixed)
            {
                SpinnerOptions.Position = "fixed";
            }

            
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorSpinner/blazor-spin.js");
                await _jsModule.InvokeVoidAsync("Initialize");
            }
        }

        #region DI
        [Inject]
        public ISpinnerService SpinnerService { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        #endregion

        #region Properties
        private bool SpinnerSpinning = false;

        public SpinnerOptions OriginalSpinnerOptions { get; set; } = new SpinnerOptions();

        #endregion


        #region Parameters
        [Parameter]
        public SpinnerOptions SpinnerOptions { get; set; } 


        [Parameter] 
        public RenderFragment ChildContent { get; set; }

        [Parameter] 
        public bool IsFixed { get; set; }

        #endregion

        #region Methods
        public void Stop()
        {
            if (SpinnerSpinning)
            {
                _jsModule.InvokeVoidAsync("DefaultSpinner.Stop");
                SpinnerSpinning = !SpinnerSpinning;
            }           
        }

        public void Spin()
        {
            if (!SpinnerSpinning)
            {
                _jsModule.InvokeVoidAsync("DefaultSpinner.Spin", SpinnerId, SpinnerOptions);
                SpinnerSpinning = !SpinnerSpinning;
            }

        }

        public void ResetSpinner()
        {
            Mapper.UpdateOptions(SpinnerOptions, OriginalSpinnerOptions);
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SpinnerService.Spin -= Spin;
            SpinnerService.NoSpin -= Stop;
            SpinnerService.SetSpinner -= ResetSpinner;
            NavigationManager.LocationChanged -= LocationChanged;
        }

        void LocationChanged(object sender, LocationChangedEventArgs e)
        {
            Stop();
        }

        #endregion


    }
}

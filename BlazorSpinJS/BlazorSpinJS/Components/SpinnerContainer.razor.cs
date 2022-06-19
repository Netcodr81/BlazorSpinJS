using BlazorSpinJS.Services;
using BlazorSpinJS.Utils;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorSpinJS.Components;

public partial class SpinnerContainer : ComponentBase, IDisposable

{
    private string SpinnerId { get; set; }

    private IJSObjectReference _jsModule;

    protected override void OnInitialized()
    {
        SpinnerId = "spinner" + Guid.NewGuid();
        SpinnerService.Spin += Spin;
        SpinnerService.DynamicConfigSpin += Spin;
        SpinnerService.NoSpin += Stop;
        SpinnerService.SetSpinner += ResetSpinner;
        NavigationManager.LocationChanged += LocationChanged;

        var spinner = SpinnerOptionsService.GetSpinner();



        OriginalSpinner = spinner;

    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorSpinJS/blazor-spin.js");
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

    [Inject]
    public ISpinnerOptionsService SpinnerOptionsService { get; set; }
    #endregion

    #region Properties

    private bool SpinnerSpinning = false;

    public Spinner OriginalSpinner { get; set; } = new Spinner();

    #endregion


    #region Parameters


    [Parameter]
    public RenderFragment ChildContent { get; set; }


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
            _jsModule.InvokeVoidAsync("DefaultSpinner.Spin", SpinnerId, OriginalSpinner);
            SpinnerSpinning = !SpinnerSpinning;
        }

    }

    public void Spin(Spinner updatedOptions)
    {
        if (!SpinnerSpinning)
        {
            _jsModule.InvokeVoidAsync("DefaultSpinner.Spin", SpinnerId, updatedOptions);
            SpinnerSpinning = !SpinnerSpinning;
        }

    }

    public void ResetSpinner(Spinner spinnerToReset)
    {
        Mapper.UpdateSpinner(spinnerToReset, OriginalSpinner);
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        SpinnerService.Spin -= Spin;
        SpinnerService.DynamicConfigSpin -= Spin;
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

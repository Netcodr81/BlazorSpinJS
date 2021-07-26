using BlazorSpinner.Configuration;
using BlazorSpinner.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSpinner.Demo.Pages
{
    public partial class SpinnerConfiguration : ComponentBase
    {
        [Inject]
        public ISpinnerService SpinnerService { get; set; }

        [CascadingParameter]
        public SpinnerOptions SpinnerOptions { get; set; }      
       
       

        private List<SelectListItem> Animations { get; set; } = new List<SelectListItem>();

        private List<SelectListItem> SpinDirection { get; set; } = new List<SelectListItem>();

        private bool IsSpinning = false;


        protected override void OnInitialized()
        {
            Animations.Add(new SelectListItem() { Text = "Fade Default", Value = "spinner-line-fade-default", Selected = true });
            Animations.Add(new SelectListItem() { Text = "Fade Quick", Value = "spinner-line-fade-quick" });
            Animations.Add(new SelectListItem() { Text = "Fade More", Value = "spinner-line-fade-more" });
            Animations.Add(new SelectListItem() { Text = "Shrink", Value = "spinner-line-shrink" });

            SpinDirection.Add(new SelectListItem() { Text = "Clockwise", Value = "1"});
            SpinDirection.Add(new SelectListItem() { Text = "Counter Clockwise", Value = "-1" });
        }
             
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
        
        private async Task ResetValues()
        {
            StopSpinner();
            SpinnerOptions = new SpinnerOptions();         

           
        }
    }
}

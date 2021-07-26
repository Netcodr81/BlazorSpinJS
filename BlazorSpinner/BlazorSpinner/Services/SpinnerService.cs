using BlazorSpinner.Configuration;
using Microsoft.JSInterop;
using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSpinner.Services
{
    public class SpinnerService : ISpinnerService
    {           
        //public SpinnerOptions SpinnerOptions { get; set; }

        public event Action Spin;

        public event Action NoSpin;

        public event Action SetSpinner;

        public void StartSpinner()
        {
            Spin?.Invoke();
        }

        public void StopSpinner()
        {
            NoSpin?.Invoke();
        }

        public void ResetSpinner()
        {
            SetSpinner?.Invoke();
        }
    }
}

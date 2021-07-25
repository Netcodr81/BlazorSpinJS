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
        /// <summary>
        ///  User can pass any options during the registration of the SpinnerService in Startup
        /// </summary>
        /// <param name="options"></param>
        public SpinnerService(SpinnerOptions options)
        {
            SpinnerOptions = options;          
        }

        /// <summary>
        ///  Used to set the default options
        /// </summary>
        public SpinnerService(){
          
            SpinnerOptions = new SpinnerOptions(); 
        }  
    
        public SpinnerOptions SpinnerOptions { get; set; }

        public event Action Spin;

        public event Action NoSpin;

        public void StartSpinner()
        {
            Spin?.Invoke();
        }

        public void StopSpinner()
        {
            NoSpin?.Invoke();
        }
    }
}

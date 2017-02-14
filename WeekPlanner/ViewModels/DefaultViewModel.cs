using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace WeekPlanner.ViewModels
{
    public class DefaultViewModel : DotvvmViewModelBase
    {
        public string something { get; set; }

        public DefaultViewModel()
        {
            
        }

        public void ButtonPress()
        {
            something = "Test";
        }
    }
}

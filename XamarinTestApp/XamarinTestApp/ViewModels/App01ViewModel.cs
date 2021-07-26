using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinTestApp.ViewModels
{
    public class App01ViewModel : BaseViewModel
    {
        public App01ViewModel()
        {
            Title = "App01";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.bbc.co.uk"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
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
            //Convert = new Command(async () => await Browser.OpenAsync("https://www.bbc.co.uk"));
            /*
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
            */
        }

        //public Command Convert { get; }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Browser.OpenAsync("https://www.bbc.co.uk");
        }
    }
}
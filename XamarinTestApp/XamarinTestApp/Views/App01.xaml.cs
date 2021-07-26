using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App01 : ContentPage
    {
        public App01()
        {
            InitializeComponent();
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.bbc.co.uk");
        }
    }
}
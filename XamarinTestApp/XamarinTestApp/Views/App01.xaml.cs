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

        /* this method was added by the 'Clicked' property in the XAML Button attribute */
        private void Convert(object sender, EventArgs e)
        {
            (sender as Button).Text = "You pressed this!";
        }
    }
}
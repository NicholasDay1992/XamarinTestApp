using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
/* Include */
using XamarinTestApp.ViewModels;

namespace XamarinTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App01 : ContentPage
    {
        public App01()
        {
            InitializeComponent();
            /* ADD */
            BindingContext = new App01ViewModel();
        }
    }
}
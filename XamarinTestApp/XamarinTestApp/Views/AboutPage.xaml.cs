using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            
        }
        /* this method was added by the 'Clicked' property in the XAML Button attribute */
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "You pressed me!";
        }
    }
}
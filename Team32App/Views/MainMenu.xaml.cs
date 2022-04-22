using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Team32App.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        async void Phrases(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Phrases());
        }

        async void Contacts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Contacts());
        }

        async void Locations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Locations());
        }

        async void Communication(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Communication());
        }

        async void LanguageSelector(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.LanguageSelector());
        }


    }
}
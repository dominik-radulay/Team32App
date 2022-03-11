using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Phrases(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Phrases());
        }

        async void Contacs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Contacts());
        }

        async void Locations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Locations());
        }

        async void MainMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MainMenu());
        }

        async void Communication(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Communication());
        }
    }
}
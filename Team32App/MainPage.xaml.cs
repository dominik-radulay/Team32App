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
namespace Team32App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            picker.SelectedIndex = 0;
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

        async void MainMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MainMenu());
        }

        async void Communication(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Communication());
        }



        // Languages

        void OnUpdateLangugeClicked(object sender, System.EventArgs e)
        {
            if (picker.SelectedItem != null)
            {
                var language = CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString())); ;
                Thread.CurrentThread.CurrentUICulture = language;
                AppResources.Culture = language;
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private async void HelplineNavigate(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ContactLevels.Helpline()) ; 

        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }
        private async void EmailNavigate(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ContactLevels.Emailer());

        }

        private async void EmergencyNavigate(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ContactLevels.Emergency());

        }

    }

}
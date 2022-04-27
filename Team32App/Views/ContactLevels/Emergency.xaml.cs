using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views.ContactLevels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Emergency : ContentPage
    {
        public Emergency()
        {
            InitializeComponent();
        }

        private void EmergencyCall(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("112");
            }
            catch (FeatureNotSupportedException ex)
            {
                DisplayAlert("Dialing Error", "Phone Dialer is not supported on this device.", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Phone number cannot be dialed", "Please try dialing again", "OK");
            }
        }

        private void AmbulanceCall(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("166");
            }
            catch (FeatureNotSupportedException ex)
            {
                DisplayAlert("Dialing Error", "Phone Dialer is not supported on this device.", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Phone number cannot be dialed", "Please try dialing again", "OK");
            }
        }

        private void PoliceCall(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("100");
            }
            catch (FeatureNotSupportedException ex)
            {
                DisplayAlert("Dialing Error", "Phone Dialer is not supported on this device.", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Phone number cannot be dialed", "Please try dialing again", "OK");
            }
        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }
    }

}
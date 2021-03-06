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
    public partial class Helpline : ContentPage
    {
        public Helpline()
        {
            InitializeComponent();
        }

        private void Helpline_Call(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(DialNumber.Text);
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
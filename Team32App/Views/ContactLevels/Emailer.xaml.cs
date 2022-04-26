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
    public partial class Emailer : ContentPage
    {
        public Emailer()
        {
            InitializeComponent();
        }

       

        private void Send_Email(object sender, EventArgs e)
        {
            try
            {
                var message = new EmailMessage(EmailName.Text, "" ,EmailAddress.Text);
                message.BodyFormat = EmailBodyFormat.PlainText;
                Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException ex)
            {
               DisplayAlert("Place holder error", "Place holder error message", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Place holder for email not sent", "Please try emailing again", "OK");
            }
        } 

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }
    }
}
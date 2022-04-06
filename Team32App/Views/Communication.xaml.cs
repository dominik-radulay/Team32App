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
    public partial class Communication : ContentPage
    {
        public Communication()
        {
            InitializeComponent();
        }
        private void LevelNavigate(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;

            switch (Convert.ToInt32(data))
            {
                case 1:
                    Navigation.PushAsync(new CommunicationLevels.Grammar());
                    break;
                case 2:
                    Navigation.PushAsync(new CommunicationLevels.Suffix());
                    break;
                case 3:
                    Navigation.PushAsync(new CommunicationLevels.FormalW());
                    break;

                default:
                    // code block
                    break;
            }
        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }

    }
}
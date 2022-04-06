using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team32App.Resources;
using System.Globalization;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Phrases : ContentPage
    {
        // comment
        public Phrases()
        {
       

            InitializeComponent();
        }

        private void LevelNavigate(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;

            Navigation.PushAsync(new PhrasesLevels.Level1(Convert.ToInt32(data)), true);

            /*switch (Convert.ToInt32(data))
            {
                case 1:
                    Navigation.PushAsync(new PhrasesLevels.Level1(1), true);
                    break;
                case 2:
                    Navigation.PushAsync(new PhrasesLevels.Level1(2), true);
                    break;
                case 3:
                    Navigation.PushAsync(new PhrasesLevels.Level1(3), true);
                    break;
               // case 4:
                //    Navigation.PushAsync(new PhrasesLevels.Level4());
                  //  break;
                //case 5:
                  //  Navigation.PushAsync(new PhrasesLevels.Level5());
                    //break;

                default:
                    // code block
                    break;
            }*/
        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
             Navigation.PushAsync(new MainMenu());

        }



    }
}
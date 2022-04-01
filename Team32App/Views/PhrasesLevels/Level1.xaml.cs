using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views.PhrasesLevels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Level1 : ContentPage
    {
        public Level1()
        {
            InitializeComponent();
            var grid = new Grid();
            var row = new RowDefinition() { Height = new GridLength(2, GridUnitType.Star) };
        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }


        private void WordNavigate(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;

            switch (Convert.ToInt32(data))
            {
                case 1:
                    Navigation.PushAsync(new PhrasesLevels.LearnWord());
                    //PhrasesLevels.LearnWord.headerofword.Text = "bla bla";
                    break;
                case 2:
                    Navigation.PushAsync(new PhrasesLevels.Level2());
                    break;
                case 3:
                    Navigation.PushAsync(new PhrasesLevels.Level3());
                    break;
                case 4:
                    Navigation.PushAsync(new PhrasesLevels.Level4());
                    break;
                case 5:
                    Navigation.PushAsync(new PhrasesLevels.Level5());
                    break;

                default:
                    // code block
                    break;
            }
        }

    }
}
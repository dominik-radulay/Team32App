using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Team32App.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views.PhrasesLevels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Level1 : ContentPage
    {
        public Level1(int level)
        {
            InitializeComponent();
            var grid = new Grid();
            var row = new RowDefinition() { Height = new GridLength(2, GridUnitType.Star) };
            Generatepage(level);
        }

        void Generatepage(int level )
        {
            switch (level)
            {
                case 1:

                    MainHeader.Text = AppResources.Phrases_Welcome1;

                    Image_1x1.Glyph = "\uE925";
                    Text_1x1.Text =  AppResources.Phrases_Greetings;
                    Button_1x1.BindingContext = "Greetings";

                    Image_1x2.Glyph = "\uE88b";
                    Text_1x2.Text = AppResources.Phrases_Time;
                    Button_1x2.BindingContext = "Time";

                    Image_1x3.Glyph = "\uE2e6";
                    Text_1x3.Text = AppResources.Phrases_Agreeing;
                    Button_1x3.BindingContext = "Agreeing";












                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    // code block
                    break;
            }

        }


        void LearnWord(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;
            Navigation.PushAsync(new PhrasesLevels.LearnWord(data), true);

        }






        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }


    }
}
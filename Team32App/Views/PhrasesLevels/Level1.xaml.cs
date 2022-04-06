using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

                    // Page Header
                    MainHeader.Text = AppResources.Phrases_Welcome1;

                    // First Line
                    Image_1x1.Glyph = "\uE925";
                    Text_1x1.Text =  AppResources.Phrases_Greetings;
                    Button_1x1.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Greetings,
                        greek = GreekPhrases.Phrases_Greetings,
                    };

                    Image_1x2.Glyph = "\uE88b";
                    Text_1x2.Text = AppResources.Phrases_Time;
                    Button_1x2.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Time,
                        greek = GreekPhrases.Phrases_Time,
                    };

                    Image_1x3.Glyph = "\uE2e6";
                    Text_1x3.Text = AppResources.Phrases_Agreeing;
                    Button_1x3.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Agreeing,
                        greek = GreekPhrases.Phrases_Agreeing,
                    };

                    // Second Line
                    Image_2x1.Glyph = "\ue99a";
                    Text_2x1.Text = AppResources.Phrases_Denying;
                    Button_2x1.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Denying,
                        greek = GreekPhrases.Phrases_Denying,
                    };

                    Image_2x2.Glyph = "\ue939";
                    Text_2x2.Text = AppResources.Phrases_YourName;
                    Button_2x2.BindingContext = new
                    {
                        phrase = AppResources.Phrases_YourName,
                        greek = GreekPhrases.Phrases_YourName,
                    };

                    Image_2x3.Glyph = "\ue94c";
                    Text_2x3.Text = AppResources.Phrases_HowAreYou;
                    Button_2x3.BindingContext = new
                    {
                        phrase = AppResources.Phrases_HowAreYou,
                        greek = GreekPhrases.Phrases_HowAreYou,
                    };

                    // Third Line
                    Image_3x1.Glyph = "\ue87c";
                    Text_3x1.Text = AppResources.Phrases_MyNameIs;
                    Button_3x1.BindingContext = new
                    {
                        phrase = AppResources.Phrases_MyNameIs,
                        greek = GreekPhrases.Phrases_MyNameIs,
                    };

                    Image_3x2.Glyph = "\ue8b4";
                    Text_3x2.Text = AppResources.Phrases_ImFrom;
                    Button_3x2.BindingContext = new
                    {
                        phrase = AppResources.Phrases_ImFrom,
                        greek = GreekPhrases.Phrases_ImFrom,
                    };

                    Image_3x3.Glyph = "\ue56c";
                    Text_3x3.Text = AppResources.Phrases_Hungry;
                    Button_3x3.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Hungry,
                        greek = GreekPhrases.Phrases_Hungry,
                    };

                    // Fourth Line
                    Image_4x1.Glyph = "\uea70";
                    Text_4x1.Text = AppResources.Phrases_ThankYou;
                    Button_4x1.BindingContext = new
                    {
                        phrase = AppResources.Phrases_ThankYou,
                        greek = GreekPhrases.Phrases_ThankYou,
                    };

                    Image_4x2.Glyph = "\ue549";
                    Text_4x2.Text = AppResources.Phrases_Accomodation;
                    Button_4x2.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Accomodation,
                        greek = GreekPhrases.Phrases_Accomodation,
                    };

                    Image_4x3.Glyph = "\ue90e";
                    Text_4x3.Text = AppResources.Phrases_Legal;
                    Button_4x3.BindingContext = new
                    {
                        phrase = AppResources.Phrases_Legal,
                        greek = GreekPhrases.Phrases_Legal,
                    };









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
            var Phrase = new Label();
            Phrase.SetBinding(Label.TextProperty, "phrase");
            Phrase.BindingContext = ((Button)sender).BindingContext;
            //Debug.WriteLine(Phrase.Text);

            var Greek = new Label();
            Greek.SetBinding(Label.TextProperty, "greek");
            Greek.BindingContext = ((Button)sender).BindingContext;
            //Debug.WriteLine(Greek.Text);

            Navigation.PushAsync(new PhrasesLevels.LearnWord(Phrase.Text, Greek.Text), true);

        }






        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }


    }
}
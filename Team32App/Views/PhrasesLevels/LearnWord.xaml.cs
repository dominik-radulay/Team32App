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
    public partial class LearnWord : ContentPage
    {
        public LearnWord(string phrase, string greek)
        {

            InitializeComponent();
            InGreek.Text = greek;
            Header.Text = phrase;
        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu());

        }
    }
}
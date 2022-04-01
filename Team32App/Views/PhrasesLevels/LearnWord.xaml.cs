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
        public LearnWord()
        {
            InitializeComponent();
        }


        static String[] Level1 = {"Greetings","Time","Agreeing","Denying","What is your name?", "How are you?", "My name is...", "Im from...", "Im hungry", "Thank you", "I need an accomodation", "I need Legal help", "I have a pet", "I need to charge my phone", "Where is the restrom?" };
        

        private void Settext (object sender, EventArgs e)
        {
            headerofword.Text = "Test";

        }



    }
}
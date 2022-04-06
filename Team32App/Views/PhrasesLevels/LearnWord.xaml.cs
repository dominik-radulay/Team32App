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
            Settext("1");
        }
        

        private void Settext (string Information)
        {
            headerofword.Text = "Test from C";

        }



    }
}
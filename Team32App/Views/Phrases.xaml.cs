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
    public partial class Phrases : ContentPage
    {
        // comment
        public Phrases()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Back_to_Menu(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//MainMenu");

        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Team32App.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageSelector : ContentPage
    {
        public LanguageSelector()
        {
            InitializeComponent();
            picker.SelectedIndex = 0;
        }

        void OnUpdateLangugeClicked(object sender, System.EventArgs e)
        {
            if (picker.SelectedItem != null)
            {
                var language = CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString())); ;
                Thread.CurrentThread.CurrentUICulture = language;
                AppResources.Culture = language;
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
    }
}
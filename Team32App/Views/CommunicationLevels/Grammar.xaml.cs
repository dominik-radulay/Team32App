using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views.CommunicationLevels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grammar : ContentPage
    {
        public Grammar()
        {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Grammar));
        }
    }
}
using System.ComponentModel;
using Team32App.ViewModels;
using Xamarin.Forms;

namespace Team32App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
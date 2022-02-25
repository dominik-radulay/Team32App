using System;
using System.Collections.Generic;
using System.ComponentModel;
using Team32App.Models;
using Team32App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
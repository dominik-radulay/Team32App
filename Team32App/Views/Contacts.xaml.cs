﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();

            languagePicker.Items.Add("English");
            languagePicker.Items.Add("Greek");
            languagePicker.Items.Add("XXX");

        }
        

    }

}
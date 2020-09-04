using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TinderApp.Models;
using TinderApp.ViewModels;

namespace TinderApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Contact Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
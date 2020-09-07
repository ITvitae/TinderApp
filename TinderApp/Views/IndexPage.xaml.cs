using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TinderApp.Models;
using TinderApp.Views;
using TinderApp.ViewModels;

namespace TinderApp.Views
{
    public partial class IndexPage : ContentPage
    {
        IndexViewModel _viewModel;

        public IndexPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new IndexViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
using System.ComponentModel;
using Xamarin.Forms;
using TinderApp.ViewModels;

namespace TinderApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel  _viewModel;

        public ItemDetailPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemDetailViewModel();
        }
    }
}
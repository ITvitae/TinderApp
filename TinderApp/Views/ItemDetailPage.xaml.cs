using System.ComponentModel;
using Xamarin.Forms;
using TinderApp.ViewModels;

namespace TinderApp.Views
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
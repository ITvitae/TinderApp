using System;
using System.Collections.Generic;
using System.Windows.Input;
using TinderApp.ViewModels;
using TinderApp.Views;
using Xamarin.Forms;

namespace TinderApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        //Currently user 101 is our fake user profile.
        private readonly int UserID = 101;


        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(IndexPage), typeof(IndexPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(EditProfilePage), typeof(EditProfilePage));
        }

        #region Methods
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
            //await Shell.Current.GoToAsync($"//LoginPage?ContactId={UserID}");
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//ProfilePage?ContactId={UserID}");
            Shell.Current.FlyoutIsPresented = false;
        }
        #endregion
    }
}

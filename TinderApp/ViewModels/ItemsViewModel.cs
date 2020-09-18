using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using TinderApp.Models;
using TinderApp.Views;

namespace TinderApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private Contact _selectedItem;

        public ObservableCollection<Contact> Contacts { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Contact> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = "Mathches";
            Contacts = new ObservableCollection<Contact>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Contact>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Contacts.Clear();
                var contacts = await DataStore.GetLikedItemsAsync(true);
                //var contacts = await DataStore.GetItemsAsync(true);
                foreach (var contact in contacts)
                {
                    Contacts.Add(contact);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Contact SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(Contact contact)
        {
            if (contact == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"//{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ContactId)}={contact.Id}");
        }
    }
}
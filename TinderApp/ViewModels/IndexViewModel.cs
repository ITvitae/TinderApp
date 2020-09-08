using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using TinderApp.Models;
using TinderApp.Views;
using System.Linq;
using System.Collections.Generic;

namespace TinderApp.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private int CurrentNumber;
        private Item _selectedItem;
        public Item Item { get; set; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        private string fullName;
        private string gender;
        private string age;
        private string city;
        private string country;
        private string description;

        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }

        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }
        public string Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }
        public string Country
        {
            get => country;
            set => SetProperty(ref country, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public IndexViewModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Item>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                var Items = await DataStore.GetItemsAsync(true);
                Item = Items.FirstOrDefault(i => i.Id == CurrentNumber.ToString());
                CurrentNumber++;

                FullName = Item.FullName;
                Gender = Item.Gender.ToString();
                Age = Item.Age;
                City = Item.City;
                Age = Item.Age;
                Country = Item.Country;
                Description = Item.Description;
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

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(Item item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
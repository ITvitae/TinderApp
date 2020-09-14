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
        private Random rnd = new Random();

        private int CurrentNumber;
        private string SwipeDirection;
        private List<Contact> AcceptedList = new List<Contact>();
        public Contact Item { get; set; }
        public List<Contact> Items;
        public Command LoadItemsCommand { get; }

        private string fullName;
        private int age;
        private string city;
        private string image;

        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }

        public int Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        public IndexViewModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (Items == null)
            {
                Items = await DataStore.GetUnseenItemsAsync();
            }


            IsBusy = true;

            try
            {
                var Item = Items.FirstOrDefault(i => i.Id == CurrentNumber.ToString());
                if (Item != null)
                {
                    switch (SwipeDirection)
                    {
                        case "Left":
                            Item.SwipeState = SwipeStates.Accepted;
                            CurrentNumber++;
                            SwipeDirection = "None";
                            AcceptedList.Add(Item);
                            Items.Remove(Item);
                            break;
                        case "Right":
                            Item.SwipeState = SwipeStates.Denied;
                            CurrentNumber++;
                            SwipeDirection = "None";
                            Items.Remove(Item);
                            break;
                        default:
                            break;
                    }
                }


                int newNumber = rnd.Next(Items.Count()-1);
                var newItem = Items.FirstOrDefault(c =>    c.SwipeState == SwipeStates.Unseen && c.Id == newNumber.ToString());
                if (newItem != null)
                {
                    CurrentNumber = newNumber;

                    FullName = newItem.FullName;
                    Age = newItem.Age;
                    City = newItem.City;
                    Image = newItem.Image;
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
        }

        public async void OnSwipedLeft(object Sender, EventArgs e)
        {
            SwipeDirection = "Left";
            await ExecuteLoadItemsCommand();
        }
        public async void OnSwipedRight(object Sender, EventArgs e)
        {
            SwipeDirection = "Right";
            await ExecuteLoadItemsCommand();
        }
    }
}
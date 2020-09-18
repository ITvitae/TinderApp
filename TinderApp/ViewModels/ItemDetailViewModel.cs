using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TinderApp.Models;
using Xamarin.Forms;

namespace TinderApp.ViewModels
{
    [QueryProperty(nameof(ContactId), nameof(ContactId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public string Id { get; set; }
        public string contactId { get; set; }
        private string fullName;
        private int age;
        private string city;
        private string image;
        private string gender;

        public string ContactId
        {
            get
            {
                return contactId;
            }
            set
            {
                contactId = value;
                LoadContactId(value);
            }
        }
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
        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }

        //public ItemDetailViewModel()
        //{
        //    LoadContactId(ContactId);
        //}


        public async void LoadContactId(string ContactId)
        {
            try
            {
                var contact = await DataStore.GetItemAsync(contactId);
                Id = contact.Id;
                FullName = contact.FullName;
                Age = contact.Age;
                City = contact.City;
                Gender = contact.Gender.ToString();
                Image = contact.Image;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}

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
        #region private properties
        private string _ContactId;
        private string _FullName;
        private int _Age;
        private string _Description;
        private string _Image;
        private string _City;
        private GenderEnum _Gender;
        #endregion
        public string Id { get; set; }

        #region INotification Properties
        public string FullName
        {
            get => _FullName;
            set => SetProperty(ref _FullName, value);
        }
        public int Age
        {
            get => _Age;
            set => SetProperty(ref _Age, value);
        }
        public GenderEnum Gender
        {
            get => _Gender;
            set => SetProperty(ref _Gender, value);
        }
        public string City
        {
            get => _City;
            set => SetProperty(ref _City, value);
        }
        public string Image
        {
            get => _Image;
            set => SetProperty(ref _Image, value);
        }
        public string Description
        {
            get => _Description;
            set => SetProperty(ref _Description, value);
        }

        public string ContactId
        {
            get
            {
                return _ContactId;
            }
            set
            {
                _ContactId = value;
                LoadItemId(value);
            }
        }
        #endregion

        public async void LoadItemId(string contactId)
        {
            try
            {
                var contact = await DataStore.GetItemAsync(contactId);
                Id = contact.Id;
                FullName = contact.FullName;
                Age = contact.Age;
                Gender = contact.Gender;
                City = contact.City;
                Description = contact.Description;
                Image = contact.Image;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Diagnostics;
using TinderApp.Models;
using TinderApp.Views;
using System.Linq;
using TinderApp.Helpers;

namespace TinderApp.ViewModels
{
    [QueryProperty(nameof(ContactId), nameof(ContactId))]
    public class EditProfileViewModel :BaseViewModel
    {
        #region private properties
        private string _contactId;
        private string _FullName;
        private int _Age;
        private string _Description;
        private string _Image;
        private string _City;
        private GenderEnum _Gender;
        #endregion

        #region public properties
        public string Id { get; set; }

        public List<string> GenderList
        {
            get
            {
                return Enum.GetNames(typeof(GenderEnum)).Select(b => b).ToList();
            }
        }

        public List<string> SwipeStatesList
        {
            get
            {
                return Enum.GetNames(typeof(SwipeStates)).Select(b => b).ToList();
            }
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        #endregion

        public EditProfileViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
        }

        #region Bindable INotify Properties
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
                return _contactId;
            }
            set
            {
                _contactId = value;
                LoadContactId(value);
            }
        }
        #endregion

        #region Methods
        public async void LoadContactId(string contactId)
        {
            try
            {
                var contact = await DataStore.GetItemAsync(contactId);
                Id = contact.Id;
                FullName = contact.FullName;
                Age = contact.Age;
                Description = contact.Description;
                Image = contact.Image;
                City = contact.City;
                Gender = contact.Gender;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Contact");
            }
        }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Contact newContact = new Contact()
            {
                Id = Id,
                FullName = FullName,
                Age = Age,
                Gender = Gender,
                City = City,
                Image = Image,
                Description = Description
            };

            await DataStore.UpdateItemAsync(newContact);
            MessagingCenter.Send(this, ConstantNames.MsgProfileChanged, Id);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        #endregion
    }
}

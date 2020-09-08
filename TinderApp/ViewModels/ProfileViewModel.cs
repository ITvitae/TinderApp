using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Diagnostics;
using TinderApp.Models;
using TinderApp.Views;
using System.Linq;
using System.Windows.Input;
using TinderApp.Helpers;

namespace TinderApp.ViewModels
{
    [QueryProperty(nameof(ContactId), nameof(ContactId))]
    public class ProfileViewModel : BaseViewModel
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

        public List<string> ImageNamesList
        {
            get
            {
                return ContactHelper.ImageNameConstants.ToList();
            }
        }
        #endregion

        #region Commands
        public Command EditCommand { get; }
        #endregion

        public ProfileViewModel()
        {
            EditCommand = new Command(OnEdit);
            MessagingCenter.Subscribe<EditProfileViewModel, string>
                (this, ConstantNames.MsgProfileChanged, LoadContactId);

            LoadContactId("101");
        }

        #region Bindable INotify Properties
        public string FullName
        {
            get => _FullName;
            set => SetProperty(ref _FullName, value);
        }
        public string Image
        {
            get => _Image;
            set => SetProperty(ref _Image, value);
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
        public async void LoadContactId(EditProfileViewModel viewModel,string contactId)
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

        public async void OnEdit()
        {
            if (Id == null)
                return;

            // This will push the EditProfilePage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(EditProfilePage)}?{nameof(EditProfileViewModel.ContactId)}={Id}");
            //$"//ProfilePage?ContactId={UserID}"
        }
        #endregion
    }
}

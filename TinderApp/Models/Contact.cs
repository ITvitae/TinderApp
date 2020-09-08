using System;

namespace TinderApp.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public GenderEnum Gender { get; set; }
        public SwipeStates SwipeState { get; set; }
        public string Description { get; set; }
    }
}
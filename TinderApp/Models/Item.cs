using System;

namespace TinderApp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public GenderEnum Gender { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
    }
}
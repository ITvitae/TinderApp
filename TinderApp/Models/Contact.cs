using System;

namespace TinderApp.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public GenderEnum Gender { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
    }

    public enum GenderEnum
    {
        Male,
        Female,
        Other
    }

    public class DescriptionClass
    {
        public const string
            Line0 = "Line 0",
            Line1 = "Line 1",
            Line2 = "Line 2",
            Line3 = "Line 3",
            Line4 = "Line 4",
            Line5 = "Line 5",
            Line6 = "Line 6",
            Line7 = "Line 7",
            Line8 = "Line 8",
            Line9 = "Line 9",
            Line10 = "Line 10";
    }
}
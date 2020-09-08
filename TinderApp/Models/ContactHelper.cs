using System;
using System.Collections.Generic;
using System.Text;

namespace TinderApp.Models
{
    public class ContactHelper
    {
        public static readonly string[] DescriptionConstants = {
            "I like long walks on the beach.",
            "Lazy couch potato, Netflix all day every day.",
            "I love staying up late at night stargazing.",
            "Seeking a player 2.",
            "Party all night! Staying up till the sun rises every weekend.",
            "Shy and Timid. Looking for someone calm.",
            "I love trying out new things, travelling to new places.",
            "If you don't want me at my worst you don't deserve me at my best.",
            "Come at me with your best pickup lines.",
            "If you can't love my pets that's a dealbreaker.",
             "Music is my life. Seeking someone that enjoys music as much as I do."
        };

        public static readonly string[] ImageNameConstants = {
            "bird0.jpg",
            "cat0.jpg",
            "cat1.jpg",
            "cat2.jpg",
            "cat3.jpg",
            "cat4.jpg",
            "cat5.jpg",
            "dog0.jpg",
            "dog1.jpg",
            "dog2.jpg",
            "dog3.png",
            "dog4.png",
            "dog5.png",
            "rabbit0.jpg"};

    }

    public enum SwipeStates
    {
        Unseen,
        Denied,
        Accepted,
        SuperLike
    }
    public enum GenderEnum
    {
        Male,
        Female,
        Other
    }
}

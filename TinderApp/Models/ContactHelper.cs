using System;
using System.Collections.Generic;
using System.Text;

namespace TinderApp.Models
{
    class ContactHelper
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

        //Old Description Constant Strings. Kept accesible in case array does not function as intended.
       /* public const string
          Desc0 = "I like long walks on the beach.",
          Desc1 = "Lazy couch potato, Netflix all day every day.",
          Desc2 = "I love staying up late at night stargazing.",
          Desc3 = "Seeking a player 2.",
          Desc4 = "Party all night! Staying up till the sun rises every weekend.",
          Desc5 = "Shy and Timid. Looking for someone calm.",
          Desc6 = "I love trying out new things, travelling to new places.",
          Desc7 = "If you don't want me at my worst you don't deserve me at my best.",
          Desc8 = "Come at me with your best pickup lines.",
          Desc9 = "If you can't love my pets that's a dealbreaker.",
          Desc10 = "Music is my life. Seeking someone that enjoys music as much as I do.";*/

        //Old Image Constant Strings. Keptaccesible in case array does not function correctly.
          /*public const string
            Img0 = "bird0.jpg",
            Img1 = "cat0.jpg",
            Img2 = "cat1.jpg",
            Img3 = "cat2.jpg",
            Img4 = "cat3.jpg",
            Img5 = "cat4.jpg",
            Img6 = "cat5.jpg",
            Img7 = "dog0.jpg",
            Img8 = "dog1.jpg",
            Img9 = "dog2.jpg",
            Img10 = "dog3.png",
            Img11 = "dog4.png",
            Img12 = "dog5.png",
            Img13 = "rabbit0.jpg";*/

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

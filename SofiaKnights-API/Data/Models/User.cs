using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SofiaKnights_API.Data.Models
{
    public class User : IdentityUser
    {

        public string FullName { get; set; }

        public string NickName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Nationality { get; set; }

        public string SelfDiscription { get; set; }

        public int PlayerInfoId { get; set; }

        public PlayerInfo PlayerInfo { get; set; }

        public string ProfilePictureUrl { get; set; }

    }
}

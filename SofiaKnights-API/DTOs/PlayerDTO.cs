using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class PlayerDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string NickName { get; set; }

        public string BirthDay { get; set; }

        public string Nationality { get; set; }

        public string SelfDiscription { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Positions { get; set; }

        public int Number { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}

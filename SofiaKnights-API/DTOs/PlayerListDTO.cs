using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class PlayerListDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Nationality { get; set; }

        public string ProfilePictureUrl { get; set; }
    }
}

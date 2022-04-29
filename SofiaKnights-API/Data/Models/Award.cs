using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Models
{
    public class Award
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Year { get; set; }

        public string PersonName { get; set; }
    }
}

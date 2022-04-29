using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class TacticDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Formation { get; set; }
        public string Concept { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
    }
}

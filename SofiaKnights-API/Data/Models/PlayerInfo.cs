using System.ComponentModel.DataAnnotations;

namespace SofiaKnights_API.Data.Models
{
    public class PlayerInfo
    {
        public int Id { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Positions { get; set; }

        public int Number { get; set; }

    }
}

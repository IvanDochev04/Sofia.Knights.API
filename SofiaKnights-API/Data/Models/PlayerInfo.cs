using System.ComponentModel.DataAnnotations;

namespace SofiaKnights_API.Data.Models
{
    public class PlayerInfo
    {
        public int Id { get; set; }

        [Range(140, 230)]
        public int Height { get; set; }

        [Range(40, 250)]
        public int Weight { get; set; }

        [Required]
        public string Positions { get; set; }

        [Required]
        [Range(0, 100)]
        public int Number { get; set; }
    }
}

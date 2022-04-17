using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class CreateFixtureDTO
    {
        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public string Location { get; set; }

        public int HomePoints { get; set; }

        public int AwayPoints { get; set; }

        public DateTime Date { get; set; }
    }
}

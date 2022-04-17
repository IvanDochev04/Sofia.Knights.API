using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.DTOs
{
    public class FixtureDTO
    {
        public int Id { get; set; }

        public TeamDTO HomeTeam { get; set; }

        public TeamDTO AwayTeam { get; set; }

        public string Location { get; set; }

        public int HomePoints { get; set; }

        public int AwayPoints { get; set; }

        public string Date { get; set; }
    }
}

using System;

namespace SofiaKnights_API.Data.Models
{
    public class Fixture
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public string Location { get; set; }

        public int HomePoints { get; set; }

        public int AwayPoints { get; set; }

        public DateTime Date { get; set; }
    }
}

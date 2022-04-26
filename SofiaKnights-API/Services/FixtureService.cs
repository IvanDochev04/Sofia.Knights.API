using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using SofiaKnights_API.DTOs;
using SofiaKnights_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services
{
    public class FixtureService : IFixtureService
    {
        private readonly IRepository<Fixture> fixtureRepository;
        private readonly ITeamService teamService;

        public FixtureService(IRepository<Fixture> fixtureRepository, ITeamService teamService)
        {
            this.fixtureRepository = fixtureRepository;
            this.teamService = teamService;
        }
        public List<FixtureDTO> GetFixtureList()
        {
            var fixtureList = new List<FixtureDTO>();
            var fixtures = this.fixtureRepository.GetAll();
            var teams = this.teamService.GetTeamsList();
            foreach (var fixture in fixtures)
            {
                var fixtureDTO = new FixtureDTO()
                {
                    Id = fixture.Id,
                    Location = fixture.Location,
                    Date = fixture.Date.ToString("f"),
                    HomeTeam = teams.Where(t => t.Id == fixture.HomeTeamId).FirstOrDefault(),
                    AwayTeam = teams.Where(t => t.Id == fixture.AwayTeamId).FirstOrDefault(),
                    HomePoints = fixture.HomePoints,
                    AwayPoints = fixture.AwayPoints,
                };

                fixtureList.Add(fixtureDTO);
            }
            return fixtureList;
        }
        public FixtureDTO GetFixtureById(int id)
        {
            var fixture = this.fixtureRepository.GetById(id);
            var teams = this.teamService.GetTeamsList();
            var fixtureDTO = new FixtureDTO()
            {
                Id = fixture.Id,
                Location = fixture.Location,
                Date = fixture.Date.ToString("f"),
                HomeTeam = teams.Where(t => t.Id == fixture.HomeTeamId).FirstOrDefault(),
                AwayTeam = teams.Where(t => t.Id == fixture.AwayTeamId).FirstOrDefault(),
                HomePoints = fixture.HomePoints,
                AwayPoints = fixture.AwayPoints,
            };
            return fixtureDTO;
        }
        public int CreateFixture(CreateFixtureDTO fixtureDTO)
        {
            var fixture = new Fixture()
            {
                Location = fixtureDTO.Location,
                Date = fixtureDTO.Date,
                HomeTeamId = fixtureDTO.HomeTeamId,
                AwayTeamId = fixtureDTO.AwayTeamId,
                HomePoints = fixtureDTO.HomePoints,
                AwayPoints = fixtureDTO.AwayPoints,
            };
            var createdFixture = this.fixtureRepository.Create(fixture);
            return createdFixture.Id;
        }
        public int UpdateFixture(FixtureDTO fixtureDTO)
        {
            var fixture = this.fixtureRepository.GetById(fixtureDTO.Id);

            fixture.Location = fixtureDTO.Location;
            fixture.Date = DateTime.Parse(fixtureDTO.Date);
            fixture.HomeTeamId = fixtureDTO.HomeTeam.Id;
            fixture.AwayTeamId = fixtureDTO.AwayTeam.Id;
            fixture.HomePoints = fixtureDTO.HomePoints;
            fixture.AwayPoints = fixtureDTO.AwayPoints;

            var updatedFixture = this.fixtureRepository.Update(fixture);
            return updatedFixture.Id;
        }

        public void DeleteFixture(int id)
        {
            this.fixtureRepository.Delete(id);
        }


    }
}

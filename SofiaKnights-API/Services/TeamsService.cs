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
    public class TeamsService : ITeamsService
    {
        private readonly IRepository<Team> repository;

        public TeamsService(IRepository<Team> repository)
        {
            this.repository = repository;
        }

        public List<TeamDTO> GetTeamsList()
        {
            var teams = this.repository.GetAll();
            var teamsToReturn = new List<TeamDTO>();
            foreach (var team in teams)
            {
                var teamDTO = new TeamDTO()
                {
                    Id = team.Id,
                    Name = team.Name,
                    LogoUrl = team.LogoUrl
                };
                teamsToReturn.Add(teamDTO);
            }
            return teamsToReturn;
        }
        public TeamDTO GetTeamById(int id)
        {
            var team = this.repository.GetById(id);
            var teamDTO = new TeamDTO()
            {
                Id = team.Id,
                Name = team.Name,
                LogoUrl = team.LogoUrl
            };
            return teamDTO;
        }

        public int CreateTeam(TeamDTO teamDTO)
        {
            var team = new Team()
            {
                Name = teamDTO.Name,
                LogoUrl = teamDTO.LogoUrl
            };
           var createdTeam = this.repository.Create(team);
            return createdTeam.Id;
        }

        public int UpdateTeam(TeamDTO teamDTO)
        {
            var team = this.repository.GetById(teamDTO.Id);
         
                team.Name = teamDTO.Name;
                team.LogoUrl = teamDTO.LogoUrl;

            var updatedTeam = repository.Update(team);
            return updatedTeam.Id;
        }

        public void DeleteTeam(int id)
        {
            this.repository.Delete(id);
        }
    }
}

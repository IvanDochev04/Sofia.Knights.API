using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public interface ITeamsService
    {
        public List<TeamDTO> GetTeamsList();

        public TeamDTO GetTeamById(int id);

        public int CreateTeam(TeamDTO teamDTO);

        public int UpdateTeam(TeamDTO teamDTO);

        public void DeleteTeam(int id);
    }
}

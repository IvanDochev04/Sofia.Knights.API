using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public interface IPlayerService
    {
        public List<PlayerListDTO> GetPlayersList();

        public PlayerDTO GetPlayerById(int id);

        public int CreatePlayer(PlayerDTO playerDTO);

        public int UpdatePlayer(PlayerDTO playerDTO);

        public void DeletePlayer(int id);
    }
}

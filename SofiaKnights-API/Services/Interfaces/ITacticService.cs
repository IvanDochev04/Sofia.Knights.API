using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public interface ITacticService
    {
        public List<TacticListDTO> GetTacticList();

        public TacticDTO GetTacticById(int id);

        public int CreateTactic(TacticDTO tacticDTO);

        public int UpdateTactic(TacticDTO tacticDTO);

        public void DeleteTactic(int id);

    }
}

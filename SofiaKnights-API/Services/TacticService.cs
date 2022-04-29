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
    public class TacticService : ITacticService
    {
        private readonly IRepository<Tactic> repository;

        public TacticService(IRepository<Tactic> repository)
        {
            this.repository = repository;
        }
        public List<TacticListDTO> GetTacticList()
        {
            var tactics = this.repository.GetAll();
            var tacticsToReturn = new List<TacticListDTO>();
            foreach (var tactic in tactics)
            {
                var tacticDTO = new TacticListDTO()
                {
                    Id = tactic.Id,
                    Type = tactic.Type,
                    Name = tactic.Name,
                    PictureUrl = tactic.PictureUrl
                };
                tacticsToReturn.Add(tacticDTO);
            }
            return tacticsToReturn;
        }
        public TacticDTO GetTacticById(int id)
        {
            var tactic = this.repository.GetById(id);
            var tacticDTO = new TacticDTO()
            {
                Id = tactic.Id,
                Type = tactic.Type,
                Formation = tactic.Formation,
                Concept = tactic.Concept,
                Description = tactic.Description,
                Name = tactic.Name,
                PictureUrl = tactic.PictureUrl
            };
            return tacticDTO;
        }

        public int CreateTactic(TacticDTO tacticDTO)
        {
            var tactic = new Tactic()
            {
                Type = tacticDTO.Type,
                Formation = tacticDTO.Formation,
                Concept = tacticDTO.Concept,
                Description = tacticDTO.Description,
                Name = tacticDTO.Name,
                PictureUrl = tacticDTO.PictureUrl
            };
            var createdTactic = this.repository.Create(tactic);
            return createdTactic.Id;
        }

        public int UpdateTactic(TacticDTO tacticDTO)
        {
            var tactic = this.repository.GetById(tacticDTO.Id);
            tactic.Id = tacticDTO.Id;
            tactic.Type = tacticDTO.Type;
            tactic.Formation = tacticDTO.Formation;
            tactic.Concept = tacticDTO.Concept;
            tactic.Description = tacticDTO.Description;
            tactic.Name = tacticDTO.Name;
            tactic.PictureUrl = tacticDTO.PictureUrl;

            var updatedTactic = this.repository.Update(tactic);
            return updatedTactic.Id;
        }

        public void DeleteTactic(int id)
        {
            this.repository.Delete(id);
        }
    }
}

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
    public class AwardService : IAwardService
    {
        private readonly IRepository<Award> repository;

        public AwardService(IRepository<Award> repository)
        {
            this.repository = repository;
        }

        public List<AwardDTO> GetAwardList()
        {
            var awards = this.repository.GetAll();
            var awardsToReturn = new List<AwardDTO>();
            foreach (var award in awards)
            {
                var awardDTO = new AwardDTO()
                {
                    Id = award.Id,
                    Name = award.Name,
                    Description = award.Description,
                    PersonName = award.PersonName,
                    Year = award.Year,
                    PictureUrl = award.PictureUrl
                };
                awardsToReturn.Add(awardDTO);
            }
            return awardsToReturn;
        }
        public AwardDTO GetAwardById(int id)
        {
            var award = this.repository.GetById(id);
            var awardDTO = new AwardDTO()
            {
                Id = award.Id,
                Name = award.Name,
                Description = award.Description,
                PersonName = award.PersonName,
                Year = award.Year,
                PictureUrl = award.PictureUrl

            };
            return awardDTO;
        }

        public int CreateAward(AwardDTO awardDTO)
        {
            var award = new Award()
            {
                Name = awardDTO.Name,
                Description = awardDTO.Description,
                PersonName = awardDTO.PersonName,
                Year = awardDTO.Year,
                PictureUrl = awardDTO.PictureUrl
            };
            var createdAward = this.repository.Create(award);
            return createdAward.Id;
        }

        public int UpdateAward(AwardDTO awardDTO)
        {
            var award = this.repository.GetById(awardDTO.Id);

            award.Name = awardDTO.Name;
            award.Description = awardDTO.Description;
            award.PersonName = awardDTO.PersonName;
            award.Year = awardDTO.Year;
            award.PictureUrl = awardDTO.PictureUrl;


            var updatedAward = this.repository.Update(award);
            return updatedAward.Id;
        }

        public void DeleteAward(int id)
        {
            this.repository.Delete(id);
        }
    }
}

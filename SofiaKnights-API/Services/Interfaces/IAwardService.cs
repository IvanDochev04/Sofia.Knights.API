using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
        public interface IAwardService
    {
            public List<AwardDTO> GetAwardList();

            public AwardDTO GetAwardById(int id);

            public int CreateAward(AwardDTO awardDTO);

            public int UpdateAward(AwardDTO awardDTO);

            public void DeleteAward(int id);
        }
   
}

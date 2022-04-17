using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public interface IFixtureService
    {
        public List<FixtureDTO> GetFixtureList();

        public FixtureDTO GetFixtureById(int id);

        public int CreateFixture(CreateFixtureDTO fixtureDTO);

        public int UpdateFixture(FixtureDTO fixtureDTO);

        public void DeleteFixture(int id);
    }
}

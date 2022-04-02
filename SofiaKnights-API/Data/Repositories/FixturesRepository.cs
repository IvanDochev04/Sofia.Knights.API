using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class FixturesRepository : IRepository<Fixture>
    {
        private readonly ApplicationDbContext context;

        public FixturesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<Fixture> GetAll()
        {
            return this.context.Fixtures.ToList();
        }

        public Fixture GetById(int id)
        {
            return this.context.Fixtures.Where(n => n.Id == id).FirstOrDefault();
        }

        public Fixture Create(Fixture model)
        {
            var fixture = this.context.Fixtures.Add(model);
            this.context.SaveChanges();

            return this.GetById(fixture.Entity.Id);
        }

        public Fixture Update(Fixture model)
        {
            var fixture = this.context.Fixtures.Update(model);
            this.context.SaveChanges();

            return this.GetById(fixture.Entity.Id);
        }
        public void Delete(int id)
        {
            var fixture = this.GetById(id);
            this.context.Fixtures.Remove(fixture);

            this.context.SaveChanges();
        }
    }
}

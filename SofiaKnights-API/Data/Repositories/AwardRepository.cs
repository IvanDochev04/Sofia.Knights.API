using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class AwardRepository : IRepository<Award>
    {
        private readonly ApplicationDbContext context;

        public AwardRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Award> GetAll()
        {
            return this.context.Awards.ToList();
        }

        public Award GetById(int id)
        {
            return this.context.Awards.Where(t => t.Id == id).FirstOrDefault();
        }
        public Award Create(Award model)
        {
            var award = this.context.Awards.Add(model);
            this.context.SaveChanges();

            return this.GetById(award.Entity.Id);
        }
        public Award Update(Award model)
        {
            var award = this.context.Awards.Update(model);
            this.context.SaveChanges();

            return this.GetById(award.Entity.Id);
        }

        public void Delete(int id)
        {
            var award = this.GetById(id);
            this.context.Awards.Remove(award);

            this.context.SaveChanges();
        }
    }
}

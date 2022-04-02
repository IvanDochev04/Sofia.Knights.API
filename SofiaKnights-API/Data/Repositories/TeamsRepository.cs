using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class TeamsRepository : IRepository<Team>
    {
        private readonly ApplicationDbContext context;

        public TeamsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Team> GetAll()
        {
            return this.context.Teams.ToList();
        }

        public Team GetById(int id)
        {
            return this.context.Teams.Where(t => t.Id == id).FirstOrDefault();
        }
        public Team Create(Team model)
        {
            var team = this.context.Teams.Add(model);
            this.context.SaveChanges();

            return this.GetById(team.Entity.Id);
        }
        public Team Update(Team model)
        {
            var team = this.context.Teams.Update(model);
            this.context.SaveChanges();

            return this.GetById(team.Entity.Id);
        }

        public void Delete(int id)
        {
            var team = this.GetById(id);
            this.context.Teams.Remove(team);

            this.context.SaveChanges();
        }

    }
}

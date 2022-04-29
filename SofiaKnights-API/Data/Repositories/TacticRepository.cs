using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class TacticRepository: IRepository<Tactic>
    {
        private readonly ApplicationDbContext context;

        public TacticRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Tactic> GetAll()
        {
            return this.context.Tactics.ToList();
        }

        public Tactic GetById(int id)
        {
            return this.context.Tactics.Where(t => t.Id == id).FirstOrDefault();
        }
        public Tactic Create(Tactic model)
        {
            var tactic = this.context.Tactics.Add(model);
            this.context.SaveChanges();

            return this.GetById(tactic.Entity.Id);
        }
        public Tactic Update(Tactic model)
        {
            var tactic = this.context.Tactics.Update(model);
            this.context.SaveChanges();

            return this.GetById(tactic.Entity.Id);
        }

        public void Delete(int id)
        {
            var tactic = this.GetById(id);
            this.context.Tactics.Remove(tactic);

            this.context.SaveChanges();
        }
    }
}

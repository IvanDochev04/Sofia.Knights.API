using Microsoft.EntityFrameworkCore;
using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class PlayerRepository : IRepository<Player>
    {
        private readonly ApplicationDbContext context;

        public PlayerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Player> GetAll()
        {
            return this.context.Players.Include("PlayerInfo").ToList();
        }

        public Player GetById(int id)
        {

            return this.context.Players.Where(p => p.Id == id).Include("PlayerInfo").FirstOrDefault();
        }

        public Player Create(Player model)
        {
            var player = this.context.Players.Add(model);
            this.context.SaveChanges();

            return this.GetById(player.Entity.Id);
        }

        public Player Update(Player model)
        {
            var player = this.context.Players.Update(model);
            this.context.SaveChanges();

            return this.GetById(player.Entity.Id);
        }

        public void Delete(int id)
        {
            var player = this.GetById(id);
            this.context.Players.Remove(player);
            
            this.context.SaveChanges();
        }
    }
}

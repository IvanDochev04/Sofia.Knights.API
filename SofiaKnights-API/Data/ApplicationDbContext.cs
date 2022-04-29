using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SofiaKnights_API.Accounts.Entities.Configuration;
using SofiaKnights_API.Accounts.Entities.Models;
using SofiaKnights_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofiaKnights_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; } 

        public DbSet<Team> Teams { get; set; }

        public DbSet<Fixture> Fixtures { get; set; }

        public DbSet<PlayerInfo> PlayerInfos { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Award> Awards { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }

}

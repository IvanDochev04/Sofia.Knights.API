using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Data.Repositories
{
    public class NewsRepository : IRepository<News>
    {
        private readonly ApplicationDbContext context;

        public NewsRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<News> GetAll()
        {
            return this.context.News.ToList();
        }

        public News GetById(int id)
        {
            return this.context.News.Where(n => n.Id == id).FirstOrDefault();
        }

        public News Create(News model)
        {
            var news = this.context.News.Add(model);
            this.context.SaveChanges();

            return this.GetById(news.Entity.Id);
        }

        public News Update(News model)
        {
            var news = this.context.News.Update(model);
            this.context.SaveChanges();

            return this.GetById(news.Entity.Id);
        }

        public void Delete(int id)
        {
            var news = this.GetById(id);
            this.context.News.Remove(news);

            this.context.SaveChanges();
        }
    }
}

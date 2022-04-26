using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Data.Repositories.Interfaces;
using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News> repository;

        public NewsService(IRepository<News> repository)
        {
            this.repository = repository;
        }
        public List<NewsListDTO> GetNewsList()
        {
            var news = this.repository.GetAll();
            var newsToReturn = new List<NewsListDTO>();
            foreach (var newsInfo in news)
            {
                var newsDTO = new NewsListDTO()
                {
                    Id = newsInfo.Id,
                    Title = newsInfo.Title,
                    Date = newsInfo.Date.ToString("d"),
                    ShortDescription = newsInfo.ShortDescription,
                    PictureUrl = newsInfo.PictureUrl
                };
                newsToReturn.Add(newsDTO);
            }
            return newsToReturn;
        }
        public NewsDTO GetNewsById(int id)
        {
            var news = this.repository.GetById(id);
            var newsDTO = new NewsDTO()
            {
                Id = news.Id,
                Title = news.Title,
                Date = news.Date.ToString("d"),
                ShortDescription = news.ShortDescription,
                Content = news.Content,
                PictureUrl = news.PictureUrl
            };
            return newsDTO;
        }

        public int CreateNews(NewsDTO newsDTO)
        {
            var news = new News()
            {
                Title = newsDTO.Title,
                Date = DateTime.Parse(newsDTO.Date),
                ShortDescription = newsDTO.ShortDescription,
                Content = newsDTO.Content,
                PictureUrl = newsDTO.PictureUrl
            };
            var createdNews = this.repository.Create(news);
            return createdNews.Id;
        }

        public int UpdateNews(NewsDTO newsDTO)
        {
            var news = this.repository.GetById(newsDTO.Id);

            news.Id = newsDTO.Id;
            news.Title = newsDTO.Title;
            news.Date = DateTime.Parse(newsDTO.Date);
            news.ShortDescription = newsDTO.ShortDescription;
            news.Content = newsDTO.Content;
            news.PictureUrl = newsDTO.PictureUrl;

            var updatedNews = this.repository.Update(news);
            return updatedNews.Id;
        }

        public void DeleteNews(int id)
        {
            this.repository.Delete(id);
        }
    }
}

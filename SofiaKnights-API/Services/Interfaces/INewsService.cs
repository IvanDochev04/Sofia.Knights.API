using SofiaKnights_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Services.Interfaces
{
    public interface INewsService
    {
        public List<NewsListDTO> GetNewsList();

        public NewsDTO GetNewsById(int id);

        public int CreateNews(NewsDTO newsDTO);

        public int UpdateNews(NewsDTO newsDTO);

        public void DeleteNews(int id);
    }
}

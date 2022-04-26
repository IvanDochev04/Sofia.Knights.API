using Microsoft.AspNetCore.Mvc;
using SofiaKnights_API.DTOs;
using SofiaKnights_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;  
        }
        [Route("all")]
        [HttpGet]
        public IActionResult GetAllNews()
        {
            try
            {
                var news = this.newsService.GetNewsList();

                return Ok(news);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{newsId}")]
        [HttpGet]
        public IActionResult GetnNewsById(int newsId)
        {
            try
            {
                var news = this.newsService.GetNewsById(newsId);

                return Ok(news);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreateNews(NewsDTO model)
        {
            try
            {
                var newsId = this.newsService.CreateNews(model);
                var news = this.newsService.GetNewsById(newsId);
                return Ok(news);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateNews(NewsDTO model)
        {
            try
            {
                var newsId = this.newsService.UpdateNews(model);
                var news = this.newsService.GetNewsById(newsId);
                return Ok(news);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{newsId}")]
        [HttpDelete]
        public IActionResult DeleteTeam(int newsId)
        {
            try
            {
                this.newsService.DeleteNews(newsId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SofiaKnights_API.DTOs;
using SofiaKnights_API.Services;
using SofiaKnights_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly INewsService newsService;
        private readonly ValidationService validationService;

        public NewsController(INewsService newsService, ValidationService validationService)
        {
            this.newsService = newsService;
            this.validationService = validationService;
        }
        [Route("all")]
        [HttpGet]
        [AllowAnonymous]
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
        [AllowAnonymous]
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
                if (validationService.IsAnyNullOrEmpty(model))
                {
                    throw new ArgumentException("One of the properties was null or empty!");
                }
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
                if (validationService.IsAnyNullOrEmpty(model))
                {
                    throw new ArgumentException("One of the properties was null or empty!");
                }
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
        public IActionResult DeleteNews(int newsId)
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


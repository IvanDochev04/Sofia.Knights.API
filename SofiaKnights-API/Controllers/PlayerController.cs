using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SofiaKnights_API.Data.Models;
using SofiaKnights_API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SofiaKnights_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        [Route("all")]
        [HttpGet]
        public IActionResult GetAllPlayers() 
        {
            return Ok();
        }

        [Route("{playerId}")]
        [HttpGet]
        public IActionResult GetPlayerById(int playerId)
        {
            return Ok();
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreatePlayer(Player model)
        {
            return Ok();
        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdatePlayer(Player model)
        {
            return Ok();
        }

        [Route("{playerId}")]
        [HttpDelete]
        public IActionResult DeletePlayer(int playerId)
        {
            return Ok();
        }
    }
}

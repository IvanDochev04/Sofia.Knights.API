using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SofiaKnights_API.DTOs;
using SofiaKnights_API.Services.Interfaces;
using System;

namespace SofiaKnights_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }
        [Route("all")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllPlayers()
        {
            try
            {
                var players = this.playerService.GetPlayersList();

                return Ok(players);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{playerId}")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetPlayerById(int playerId)
        {
            try
            {
                var player = this.playerService.GetPlayerById(playerId);
                return Ok(player);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreatePlayer(PlayerDTO model)
        {
            try
            {
                var playerId = this.playerService.CreatePlayer(model);
                var player = this.playerService.GetPlayerById(playerId);
                return Ok(player);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdatePlayer(PlayerDTO model)
        {
            try
            {
                var playerId = this.playerService.UpdatePlayer(model);
                var player = this.playerService.GetPlayerById(playerId);
                return Ok(player);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{playerId}")]
        [HttpDelete]
        public IActionResult DeletePlayer(int playerId)
        {
            try
            {
                this.playerService.DeletePlayer(playerId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

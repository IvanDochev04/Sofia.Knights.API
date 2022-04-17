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
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamsService)
        {
            this.teamService = teamsService;
        }

        [Route("all")]
        [HttpGet]
        public IActionResult GetAllTeams()
        {
            try
            {
                var teams = this.teamService.GetTeamsList();

                return Ok(teams);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{teamId}")]
        [HttpGet]
        public IActionResult GetTeamById(int teamId)
        {
            try
            {
                var team = this.teamService.GetTeamById(teamId);
                return Ok(team);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreateTeam(TeamDTO model)
        {
            try
            {
                var team = this.teamService.CreateTeam(model);
                return Ok(model);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateTeam(TeamDTO model)
        {
            try
            {
                var team = this.teamService.UpdateTeam(model);
                return Ok(model);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{teamId}")]
        [HttpDelete]
        public IActionResult DeleteTeam(int teamId)
        {
            try
            {
                this.teamService.DeleteTeam(teamId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

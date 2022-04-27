using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class FixtureController : ControllerBase
    {
        private readonly IFixtureService fixtureService;

        public FixtureController(IFixtureService fixtureService)
        {
            this.fixtureService = fixtureService;
        }
        [Route("all")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllFixtures()
        {
            try
            {
                var fixtures = this.fixtureService.GetFixtureList();

                return Ok(fixtures);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{fixtureId}")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetTeamById(int fixtureId)
        {
            try
            {
                var fixture = this.fixtureService.GetFixtureById(fixtureId);

                return Ok(fixture);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreateFixture(CreateFixtureDTO model)
        {
            try
            {
                var fixtureId = this.fixtureService.CreateFixture(model);
                var fixture = this.fixtureService.GetFixtureById(fixtureId);
                return Ok(fixture);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateFixture(FixtureDTO model)
        {
            try
            {
                var fixtureId = this.fixtureService.UpdateFixture(model);
                var fixture = this.fixtureService.GetFixtureById(fixtureId);
                return Ok(fixture);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{fixtureId}")]
        [HttpDelete]
        public IActionResult DeleteTeam(int fixtureId)
        {
            try
            {
                this.fixtureService.DeleteFixture(fixtureId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

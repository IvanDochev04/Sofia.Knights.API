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
    public class TacticController : ControllerBase
    {
        private readonly ITacticService tacticService;

        public TacticController(ITacticService newsService)
        {
            this.tacticService = tacticService;
        }
        [Route("all")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllTactics()
        {
            try
            {
                var tactics = this.tacticService.GetTacticList();

                return Ok(tactics);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{tacticId}")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetnTacticById(int tacticId)
        {
            try
            {
                var tactic = this.tacticService.GetTacticById(tacticId);

                return Ok(tactic);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreateTactic(TacticDTO model)
        {
            try
            {
                var tacticId = this.tacticService.CreateTactic(model);
                var tactic = this.tacticService.GetTacticById(tacticId);
                return Ok(tactic);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateTactic(TacticDTO model)
        {
            try
            {
                var tacticId = this.tacticService.UpdateTactic(model);
                var tactic = this.tacticService.GetTacticById(tacticId);
                return Ok(tactic);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{tacticId}")]
        [HttpDelete]
        public IActionResult DeleteTactic(int tacticId)
        {
            try
            {
                this.tacticService.DeleteTactic(tacticId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

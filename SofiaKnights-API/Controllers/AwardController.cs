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
    public class AwardController : ControllerBase
    {
        private readonly IAwardService awardService;

        public AwardController(IAwardService awardService)
        {
            this.awardService = awardService;
        }

        [Route("all")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllAwards()
        {
            try
            {
                var awards = this.awardService.GetAwardList();

                return Ok(awards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("{awardId}")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAwardById(int awardId)
        {
            try
            {
                var award = this.awardService.GetAwardById(awardId);
                return Ok(award);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [Route("create")]
        [HttpPost]
        public IActionResult CreateAward(AwardDTO model)
        {
            try
            {
                var awardId = this.awardService.CreateAward(model);
                var award = this.awardService.GetAwardById(awardId);
                return Ok(award);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("update")]
        [HttpPut]
        public IActionResult UpdateAward(AwardDTO model)
        {
            try
            {
                var awardId = this.awardService.UpdateAward(model);
                var award = this.awardService.GetAwardById(awardId);
                return Ok(award);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [Route("{awardId}")]
        [HttpDelete]
        public IActionResult DeleteAward(int awardId)
        {
            try
            {
                this.awardService.DeleteAward(awardId);
                return Ok("Successful delete.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

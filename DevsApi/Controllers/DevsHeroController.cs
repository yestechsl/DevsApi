using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevsApi.Controllers;
using DevsApi.Data;
using DevsApi.Models;
using DevsApi.Models.DataObject;

using Microsoft.EntityFrameworkCore;
using DevsApi.Models.DataObject;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace DevsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevsHeroController : ControllerBase
    {
        private readonly DataContext _context;
       

        public DevsHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DevsTemDataObeject>>> GetDevs()
        {
            IEnumerable<DevsHero> DevList;

           DevList = await _context.DevsHeroes.ToListAsync();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(DevList);
        }

        

        [HttpGet("{id:int}", Name = "GetDev")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DevsTemDataObeject>> GetDev(int id)
        {
          if(id == 0)
         {
        _context.StatusCode = HttpStatusCode.BadRequest;
        return BadRequest(_context);

        }
            var Devs = await _context.DevsHeroes.FindAsync(id);
            if (Devs == null)
         {
        _context.StatusCode = HttpStatusCode.NotFound;
        return NotFound(_context);
        }
           
            _context.StatusCode = HttpStatusCode.OK;
            return Ok(_context);

}


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<DevsTemDataObeject>>> CreateDevs([FromBody]DevsHero Dev)
        {
            _context.DevsHeroes.Add(Dev);
            await _context.SaveChangesAsync();

            return Ok(await _context.DevsHeroes.ToListAsync());
        }

        [HttpPut("{id:int}", Name = "UpdateDevs")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<DevsTemDataObeject>>> UpdateDevs(DevsHero DevTeam)
        {
            var Dev = await _context.DevsHeroes.FindAsync(DevTeam.Id);
            if (Dev == null)
                return BadRequest("Hero not found.");

            Dev.Name = DevTeam.Name;
            Dev.ProgrammingLanguage = DevTeam.ProgrammingLanguage;
            Dev.Project = DevTeam.Project;
            Dev.location = DevTeam.location;
            Dev.CreatedDate = DevTeam.CreatedDate;
            Dev.CreatedBy = DevTeam.CreatedBy;


            await _context.SaveChangesAsync();

            return Ok(await _context.DevsHeroes.ToListAsync());
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteDevs")]
        public async Task<ActionResult<List<DevsHero>>> DeleteDevs(int id)
        {
            var dbHero = await _context.DevsHeroes.FindAsync(id);
            if (dbHero == null)
                return BadRequest("Hero not found.");

            _context.DevsHeroes.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}

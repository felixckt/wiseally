using NetCoreAPI.Services;
using NetCoreAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using NetCoreAPI.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace NetCoreAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController: ControllerBase
    {
        
        //private readonly IRepository repoistory;
        private readonly ApplicationDbContext context;
        public GenresController( IRepository repository, ILogger<GenresController> logger, ApplicationDbContext context)
        
        {
         //   this.repoistory = repository;
            this.context = context;
        }

        [HttpGet("list")] 
        [HttpGet("/allgenres")]
        [ResponseCache(Duration = 60)]
        [ServiceFilter(typeof(MyActionFilter))]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            //await Task.Delay(3000);
            //  return await repoistory.GetAllGenres();
            return await context.Genres.AsNoTracking().ToListAsync();

        }

        [HttpGet("{Id:int}",Name = "getGenre")] 
        public async Task<ActionResult<Genre>> Get(int Id)
        {
            //var genre = repoistory.GetGenreById(Id);
            var genre = await context.Genres.FirstOrDefaultAsync(x => x.Id == Id);

            if (genre == null)
            {
                return NotFound();
            }
            return genre;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Genre genre)
        {
            context.Add(genre);
            //return NoContent();
            await context.SaveChangesAsync();

             return new CreatedAtRouteResult("getGenre", new { ID = genre.Id }, genre);
            //return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }

    }
}

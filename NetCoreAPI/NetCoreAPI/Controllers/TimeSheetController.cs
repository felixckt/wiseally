using System;
using NetCoreAPI.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using NetCoreAPI.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ModelClass.Model;

namespace NetCoreAPI.Controllers
{
  
        [Route("api/timesheet")]
        [ApiController]
        public class TimeSheetController : ControllerBase
        {

            //private readonly IRepository repoistory;
            private readonly ApplicationDbContext context;
        
        public TimeSheetController(IRepository repository, ApplicationDbContext context)

        {
                //   this.repoistory = repository;
                this.context = context;
            }

            [HttpGet("list")]
            [HttpGet("/alltimesheet")]
            public async Task<ActionResult<List<TimeSheet>>> Get()
            {
                //await Task.Delay(3000);
                //  return await repoistory.GetAllGenres();
                return await context.TimeSheets.AsNoTracking().ToListAsync();

            }

            [HttpPost]
            public async Task<ActionResult> Post([FromBody] TimeSheet timesheet)
            {
                timesheet.Id = 0;
                context.Add(timesheet);
                await context.SaveChangesAsync();
                return NoContent();
            }

            [HttpDelete("{Id:int}")]
        //public async Task<ActionResult> Delete(int id, [FromBody] TimeSheet timesheet)
        public async Task<ActionResult> Delete(int Id)
        {
                var timesheet = await context.TimeSheets.FirstOrDefaultAsync(x => x.Id == Id);
                context.Remove(timesheet);

                await context.SaveChangesAsync();

                return NoContent();

            }



            [HttpGet("{Id:int}", Name = "getTimeSheet")]
            public async Task<ActionResult<TimeSheet>> Get(int Id)
            {
                //var genre = repoistory.GetGenreById(Id);
                 var timesheet = await context.TimeSheets.FirstOrDefaultAsync(x => x.Id == Id);

                if (timesheet == null)
                 {
                     return NotFound();
                 }
                return timesheet;
            }

            [HttpGet("email/{emailaddr}")]
            
            public async Task<ActionResult<List<TimeSheet>>> Get(string emailaddr)
            {

            return await context.TimeSheets.AsNoTracking().Where(x => x.StaffName == emailaddr).ToListAsync();
            }

            [HttpPut("{id}")]
            public async Task<ActionResult> Put(int id, [FromBody] TimeSheet timeSheet)
            {
                //var timesheet = await context.TimeSheets.FirstOrDefaultAsync(x => x.Id == id);
                context.Entry(timeSheet).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return NoContent();
                
            }





        }

}

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
using NetCoreAPI.Entities;

namespace NetCoreAPI.Controllers
{
  
        [Route("api/NPIMasterList")]
        [ApiController]
        public class NPIMasterListController : ControllerBase
        {

            //private readonly IRepository repoistory;
            private readonly WaDbContext context;
        
        public NPIMasterListController(IRepository repository, WaDbContext context)

        {
                //   this.repoistory = repository;
                this.context = context;
            }

            [HttpGet("list")]
            
            public async Task<ActionResult<List<NPIMasterList>>> Get()
            {
                //await Task.Delay(3000);
                //  return await repoistory.GetAllGenres();
                return await context.NPIMasterLists.AsNoTracking().ToListAsync();

            }





        }

}

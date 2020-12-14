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
  
        [Route("api/QuoteNumber")]
        [ApiController]
        public class QuoteNumberController : ControllerBase
        {

            //private readonly IRepository repoistory;
            private readonly WaDbContext context;
        
        public QuoteNumberController(IRepository repository, WaDbContext context)

        {
                //   this.repoistory = repository;
                this.context = context;
            }

            [HttpGet("list")]
            
            public async Task<ActionResult<List<QuoteNumber>>> Get()
            {
                //await Task.Delay(3000);
                //  return await repoistory.GetAllGenres();
                return await context.QuoteNumber.AsNoTracking().ToListAsync();

            }





        }

}

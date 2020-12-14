using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPI.Controllers
{

    [Route("util")]
    [ApiController]
    public class UtilController : ControllerBase
    {

       
        [HttpGet("GetWOD")]
        public string GetWeekOfDate()
        {

            return "This is week of date";

        }


        [HttpGet("Index")]
        public ActionResult<String> Index()
        {

            return "This is default of date";

        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Truepill.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeAPIController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Call /api/patient url";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Versioning.Controllers
{
    // Conventions specified in Startup
    // via HTTP header
    // e.g. /writers, add api-version header

    [Route("writers")]
    public class WritersControllerV1 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 1");
    }
    
    [Route("writers")]
    public class WritersControllerV2 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 2");
    }
}

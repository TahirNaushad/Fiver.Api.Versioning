using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Versioning.Controllers
{
    // Deprecated
    // via HTTP header
    // e.g. /genres, add api-version header

    [ApiVersion("1.0", Deprecated = true)]
    [Route("genres")]
    public class GenresControllerV1 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 1");
    }

    [ApiVersion("2.0")]
    [Route("genres")]
    public class GenresControllerV2 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 2");
    }
}

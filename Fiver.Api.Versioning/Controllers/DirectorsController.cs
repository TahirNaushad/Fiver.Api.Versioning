using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Versioning.Controllers
{
    // via HTTP header with only method mapped to different version
    // e.g. /directors, add api-version header

    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("directors")]
    public class DirectorsController : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 1");

        [HttpGet, MapToApiVersion("2.0")]
        public IActionResult GetV2() => Content("Version 2");
    }
}

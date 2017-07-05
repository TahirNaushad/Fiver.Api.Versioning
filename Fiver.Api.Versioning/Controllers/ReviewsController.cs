using Microsoft.AspNetCore.Mvc;

namespace Fiver.Api.Versioning.Controllers
{
    // via HTTP header
    // e.g. /reviews, add api-version header

    [ApiVersion("1.0")]
    [Route("reviews")]
    public class ReviewsControllerV1 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 1");
    }

    [ApiVersion("2.0")]
    [Route("reviews")]
    public class ReviewsControllerV2 : Controller
    {
        [HttpGet]
        public IActionResult Get() => Content("Version 2");
    }
}

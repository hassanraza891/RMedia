using Microsoft.AspNetCore.Mvc;

namespace RMediaApi.Controllers
{
    [Route("api/enrollment")]
    public class EnrollmentController : Controller
    {
        public IActionResult Post()
        {
            return View();
        }
    }
}

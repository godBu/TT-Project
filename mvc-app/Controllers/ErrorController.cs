using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

//For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_app.Controllers
{
    [ApiController]
    public class SharedController : Controller
    {
        [Route("/error")]
        public IActionResult Error()
        {
            var Exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var statusCode = Exception.Error.GetType().Name switch
            {
                "ArgumentException" => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.ServiceUnavailable
            };

            return Problem(detail: Exception.Error.Message, statusCode: (int)statusCode);
        }
        public IActionResult Http404()
        {
            return View();
        }
        public IActionResult Http500()
        {
            return View();
        }
    }
}

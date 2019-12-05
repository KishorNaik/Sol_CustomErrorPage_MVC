using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Custom_Error_Page.Controllers
{
    public class StatusCodeController : Controller
    {
        [HttpGet("/StatusCode/{statusCode}")]
        public IActionResult Index(int statusCode)
        {

            //HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            return View(statusCode);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Custom_Error_Page.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet("Error/{statusCode}")]
        public IActionResult StatusCodeHandler(int statusCode)
        {
            return View("Index", statusCode);
        }

        [HttpGet("Error")]
        [AllowAnonymous]
        public IActionResult ErrorHandler()
        {
            var exceptionDetailsObj = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.ExceptionPath = exceptionDetailsObj.Path;
            ViewBag.ExceptionMessage = exceptionDetailsObj.Error.Message;
            ViewBag.ExceptionStackTrace = exceptionDetailsObj.Error.StackTrace;

            return View("Error");
        }
    }
}
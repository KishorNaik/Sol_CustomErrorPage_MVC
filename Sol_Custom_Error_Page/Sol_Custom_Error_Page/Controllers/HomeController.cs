using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Custom_Error_Page.Filters;
using Sol_Custom_Error_Page.Models;

namespace Sol_Custom_Error_Page.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult OnErrorTest()
        {
            return base.BadRequest();
        }

        [HttpGet]
        public IActionResult OnExceptionHandlingGet()
        {
            throw new Exception("Exception in View Details");
            //return base.BadRequest();
        }

        [HttpPost]
        //[HandleException]
        public IActionResult OnExceptionHandlingPost()
        {
            //throw new Exception("Exception in View Details");

            return base.Unauthorized();
        }
    }
}
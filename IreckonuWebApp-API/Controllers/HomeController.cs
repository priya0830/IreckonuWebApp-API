using IreckonuWebApp_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static IreckonuWebApp_API.Classes.Helper;

namespace IreckonuWebApp_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
       
        public IActionResult GetData()
        {
            // import the file
            var fileData = ImportFileFromDesktop("wwwroot//Files//iru-assignment-2018.csv");
            if (fileData == null)
            {
                // handle null file data
            }
            else
            {
                ViewData["Message"] = "File successfully imported";
            }


            // transform file into logical model


            // store data into database


            return View("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CyberBrainzMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberBrainzMedia.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Graphic_Design()
        {
            return View();
        }
        public IActionResult Digital_and_Large_Format_Printing()
        {
            return View();
        }
        public IActionResult Film_Video_Production_and_Directing()
        {
            return View();
        }

        public IActionResult TwoD_ThreeD_Animations()
        {
            return View();
        }

        public IActionResult Studio_Outdoor_Photography()
        {
            return View();
        }

        public IActionResult Motion_Graphics_and_Visual_Effects()
        {
            return View();
        }

        public IActionResult Content_Development_and_Copy_Writing()
        {
            return View();
        }

        public IActionResult Business_Name_Registration()
        {
            return View();
        }

        public IActionResult Brand_Identity_Development()
        {
            return View();
        }

        public IActionResult Website_Development_and_Management()
        {
            return View();
        }

        public IActionResult Software_Development()
        {
            return View();
        }

        public IActionResult Training_and_Consultancy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
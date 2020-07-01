using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CyberBrainzMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberBrainzMedia.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult School_Management_System()
        {
            return View();
        }
        public IActionResult Blog_News()
        {
            return View();
        }

        public IActionResult Church_Management_System()
        {
            return View();
        }

        public IActionResult Business_Branding_Solution()
        {
            return View();
        }
        public IActionResult Event_Management_Solution()
        {
            return View();
        }
        public IActionResult Personal_Branding_Solution()
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
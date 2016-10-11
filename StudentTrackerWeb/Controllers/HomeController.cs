using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentTracker.Models;

namespace StudentTrackerWeb.Controllers
{
    public class HomeController : Controller
    {

        private StudentContext _context;

        public HomeController(StudentContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Students.ToList();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

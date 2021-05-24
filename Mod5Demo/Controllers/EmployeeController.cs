using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod5Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.EmployeeNames = new string[] { "Michael", "Sarah", "Becky", "Logan"};
            return View();
        }

        public IActionResult Details (string employeeName)
        {
            ViewBag.SelectedEmployee = employeeName;
            return View();
        }

        public IActionResult GetImage(string employeeName)
        {
            return File($@"\pics\{employeeName.ToLower()}.jpg", "image/jpeg");
        }
    }
}

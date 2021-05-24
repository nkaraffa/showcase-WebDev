using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mod4Demo.Models;      //use model classes

namespace Mod4Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // to pass data action methods dynamically to the views
            ViewData["header"] = "This is index page heading";
            ViewData["productname"] = "grocery";

            ViewBag.Servertime = DateTime.Now.ToString();
            ViewBag.data = 45;
            Person p = new Person();
            p.Id = 34;
            p.Name = "deepali";
            return View(p);  //action name
        }
        //public IActionResult Demo()
        //{

        //}
    }
}

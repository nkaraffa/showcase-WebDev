using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod4Demo.Controllers
{
    public class SomeController : Controller
    {
        //attribute routing
        [Route("/PrintYourName/{id}/{title}")]
        public IActionResult Print(string id, string title)
        {
            return Content("id:" + id + " & title; " + title);
        }

        [HttpGet("/Mysimplefunction/{i:int}/{j:int}")]
        public IActionResult Add(int i, int j)
        {
            int res = i + j;
            return Content(res.ToString());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

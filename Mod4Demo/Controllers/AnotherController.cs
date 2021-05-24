using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod4Demo.Controllers
{
    public class AnotherController : Controller
    {
        public ContentResult Method1(string id)
        {
            return Content("Querystring data:" + id);
        }
        public ContentResult Method2()
        {
            string id = (string) RouteData.Values["id"];
            return Content("This is route data value: " + id);
        }
    }
}

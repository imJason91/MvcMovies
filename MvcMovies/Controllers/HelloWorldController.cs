using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {// 
     // GET: /MvcMovies/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /MvcMovies/Welcome/ 

        public ActionResult Welcome(string name, int numtimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weather.Controllers
{
    public class AnaController : Controller
    {
        // GET: Ana
        public ActionResult WeatherJS()
        {
            return View();
        }
    }
}
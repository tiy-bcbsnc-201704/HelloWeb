using HelloWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWeb.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SayHello(SayHelloModel model)
        {
            return View(model);
        }
    }
}
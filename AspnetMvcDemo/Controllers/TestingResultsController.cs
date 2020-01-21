using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class TestingResultsController : Controller
    {
        // GET: TestingResults
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConcreteTestingResult()
        {
            return View();
        }

        public ActionResult BlockTestingResult()
        {
            return View();
        }
    }
}
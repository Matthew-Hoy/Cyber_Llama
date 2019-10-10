using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
            dynamic test = sc.getAllRAM();
            return View();
        }
    }
}
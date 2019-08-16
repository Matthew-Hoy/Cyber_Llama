using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaAdminSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["UserSession"] == null)
            {
                return View("Error");
            }
            else
            {
                return View();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaAdminSite.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string strEmail, string strPassword)
        {
            if (strEmail == "a@a" && strPassword == "12345")
            {
                int x = 1;
                this.Session["Xsession"] = x;
                return this.Redirect(Url.Action("Index","Home"));
            }
            else{
                int y = 2;
                this.Session["Xsession"] = y;
                return this.Redirect(Url.Action("Index", "Home"));
            }
            
        }
    }
}
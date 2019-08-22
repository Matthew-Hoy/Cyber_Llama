using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            this.Session["UserID"] = null;
            this.Session["UserName"] = null;
            this.Session["UserType"] = null;
            return this.Redirect(Url.Action("Index", "Home"));
        }
    }
}
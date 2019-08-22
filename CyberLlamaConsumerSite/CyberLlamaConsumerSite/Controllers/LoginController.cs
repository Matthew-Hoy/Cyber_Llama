using CyberLlamaConsumerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index(int? status)
        {
            if (status == 1)
            {
                ViewBag.status = "ERROR";
            }
            else if (status == 2)
            {
                ViewBag.status = "Incorrect";
            }
            else
            {
                ViewBag.status = "";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string strEmail, string strPassword)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            var User = sc.Login(strEmail, strPassword);
            if (User == "EX")
            {

                this.Session["UserID"] = null;
                return this.Redirect(Url.Action("Index", "Login", new { status = 1 }));
            }
            else if (User == null)
            {

                this.Session["UserID"] = null;
                return this.Redirect(Url.Action("Index", "Login", new { status = 2 }));
            }
            else
            {
                string[] splitUser = User.Split(',');
                this.Session["UserID"] = splitUser[0];
                this.Session["UserName"] = splitUser[1];
                this.Session["UserType"] = splitUser[2];
                return this.Redirect(Url.Action("Index", "Home"));
            }
        }
    }
}

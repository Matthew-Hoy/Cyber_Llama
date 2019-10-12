using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyberLlamaAdminSite.Models;

namespace CyberLlamaAdminSite.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index(int? status)
        {
            if(status== 1)
            {
                ViewBag.status = "ERROR";
            }
            else if(status == 2)
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
            AdminServiceReference.ServiceClient sc = new AdminServiceReference.ServiceClient();
            var User = sc.Login(strEmail, strPassword);
            if (User == "EX")
            {
               
                this.Session["UserSession"] = null;
                return this.Redirect(Url.Action("Index", "Login", new { status = 1}));
            }
            else if (User == null)
            {
                
                this.Session["UserSession"] = null;
                return this.Redirect(Url.Action("Index", "Login", new { status = 2 }));
            }
            else
            {
                string[] splitUser = User.Split(',');
                UserLogin objVerifiedUser = new UserLogin()
                {
                    UserID = splitUser[0],
                    UserName = splitUser[1],
                    UserType = Convert.ToInt32(splitUser[2])
                };
                this.Session["UserSession"] = objVerifiedUser;
                return this.Redirect(Url.Action("Index", "Home"));
            }     
        }
    }
}
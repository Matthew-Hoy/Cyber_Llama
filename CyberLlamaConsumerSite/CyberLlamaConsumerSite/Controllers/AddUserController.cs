using CyberLlamaConsumerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class AddUserController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
        public ActionResult Index(string fName, string sName, string eMail, string phone, string type, string UserName, string password, string confirm, string status)
        {
            if (status == Convert.ToString(-1))
            {
                ViewBag.status = "username already exists";
            }
            else if (status == Convert.ToString(-2))
            {
                ViewBag.status = "Passwords do not match";
            }
            else
            {
                ViewBag.status = "";
            }

            if (Session["UserType"] == null)
            {
               return View();
            }
            else if(Convert.ToInt32(Session["UserType"]) <= 2)
            {
                var positions = sr.getUserPositions();

                UserPositionView view = new UserPositionView
                {
                    userPosition = positions.ToList()
                };
                return View(view);
            }
            return View();
        }

        [HttpPost]
        public ActionResult SubmitClient(string fName, string sName, string eMail, string address, string city, string province, string zipCode, string UserName, string password, string confirm)
        {
            var x = sr.addClient(fName, sName, eMail, address, city, province, zipCode, UserName, password, confirm);
            if(x == -1)
            {
                return this.Redirect(Url.Action("Index", "AddUser", new { status = Convert.ToString(-1) }));
            }   else if(x == -2)
            {
                return this.Redirect(Url.Action("Index", "AddUser", new { status = Convert.ToString(-2) }));
            }
            return this.Redirect(@Url.Action("Index", "Home"));
        }

        [HttpPost]
        public ActionResult SubmitEmployee(string fName, string sName, string eMail, string phone, string type, string UserName, string password, string confirm)
        {
            var x = sr.addEmployee(fName, sName, eMail, phone, Convert.ToInt32(type), UserName, password, confirm);
            if (x == -1)
            {
                return this.Redirect(Url.Action("Index", "AddUser", new { status = -1 }));
            }
            else if (x == -2)
            {
                return this.Redirect(Url.Action("Index", "AddUser", new { status = -2 }));
            }
            return this.Redirect(@Url.Action("Index", "Home"));
        }
    }
}


using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class EditUserController : Controller
    {
        // GET: EditUser
        public ActionResult Index()
        {
            if(Session["UserID"] == null)
            {
               return this.Redirect(Url.Action("Index", "Home"));
            }
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cClient client = sr.getClient(Convert.ToInt32(Session["UserID"]));
            return View(client);

        }

        public ActionResult ChangeUser(cClient client)
        {
            if (Session["UserID"] == null)
            {
               return this.Redirect(Url.Action("Index", "Home"));
            }

            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool isEditied = sr.editClient(client);
            if (isEditied)
            {
                return View();
            }
            else
            {
                return this.Redirect(Url.Action("Index", "EditUser"));
            }

        }

    }
}
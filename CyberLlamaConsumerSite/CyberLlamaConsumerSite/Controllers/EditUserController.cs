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
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cClient client = sr.getClient(Convert.ToInt32(Session["UserID"]));
            return View(client);

        }

        public ActionResult ChangeUser(cClient client)
        {
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
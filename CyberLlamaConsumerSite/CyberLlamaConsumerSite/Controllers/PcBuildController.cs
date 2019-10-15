using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class PcBuildController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();

        // GET: PcBuild
        public ActionResult Index()
        {
            return View();
        }

        public void SelectCase(int ID)
        {
            Session["Case"] = ID;
            Url.Action("Index", "PcBuild");
        }
    }
}
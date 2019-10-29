using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class PartinfoController : Controller
    {
        // GET: Partinfo
        public ActionResult Index()
        {
            return View();
        }

        public void AddToCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if (Session["UserID"] != null)
            {
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), ID, 1, 100);

            }
            else if (Session["Cart"] != null)
            {
                List<int> cartIds = (List<int>)Session["Cart"];
                if (cartIds.Where(x => x.Equals(ID)).Select(y => y).FirstOrDefault() == 0)
                {
                    cartIds.Add(ID);
                }
            }
            else if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<int> { ID };
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

        }
    }
}
using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ProductPageController : Controller
    {
        // GET: ProductPage
        public ActionResult Index(string id, string filter)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            var prods = sc.getAllParts(id).ToList();

            if (filter != null)
            {

                if (filter.Equals("price"))
                {
                    return View(prods.OrderBy(x => x.price).Select(x => x).ToList());
                }
                else if (filter.Equals("name"))
                {
                    return View(prods.OrderBy(x => x.model.Trim()).Select(x => x).ToList());
                }
                else
                {
                    return View(prods.OrderByDescending(x => x.discount).Select(x => x).ToList());
                }
            }
            else
            {
                return View(prods.OrderByDescending(x => x.discount).Select(x => x).ToList());
            }
        }

        public void AddToCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if(Session["UserID"] != null)
            {
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), ID, 1, 100);

            }
            else if(Session["Cart"] != null)
            {
                List<int> cartIds = (List<int>)Session["Cart"];
                if (cartIds.Where(x => x.Equals(ID)).Select(y => y).FirstOrDefault() == 0)
                {
                    cartIds.Add(ID);
                }
            }
            else if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<int> {ID};
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            
        }
    }
    
}
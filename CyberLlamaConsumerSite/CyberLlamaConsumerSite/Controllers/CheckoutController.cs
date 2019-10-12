using CyberLlamaConsumerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{

    public class CheckoutController : Controller
    {
        // GET: Chechout
        public ActionResult Index()
        {
            if(Session["UserID"] != null)
            {
               return this.Redirect(Url.Action("Cart", "Checkout", new { ID = Convert.ToInt32(Session["UserID"]) }));
            }
            else
            {
                return View();
            }
        }

        public ActionResult Cart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            List<Cart> cart = sc.getCartItems(ID).GroupBy(y => new {y.imagelink, y.part_id, y.price, y.qua, y.description}).Select(x => new Cart
            {
                Name = x.Key.description,
                ImageLink = x.Key.imagelink,
                Price = x.Key.price,
                ProductID = x.Key.part_id,
                Quantity = x.Key.qua
            }).ToList();


            return View(cart);
        }
        [HttpPost]
        public void RemoveFromCart(List<int> cart)
        {
           // List<int> remove = cart.Where(x => x.Keep).Select(y => y.ProductID).ToList();

            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            foreach(var item in cart)
            {
                bool isRemoved = sc.removeFromPartCart(Convert.ToInt32(Session["UserID"]), item);
                if(isRemoved == false)
                {
                    isRemoved = sc.removeFromPcCart(Convert.ToInt32(Session["UserID"]), item);
                }
            }

            this.Redirect(Url.Action("Cart", "Checkout", new { ID = Convert.ToInt32(Session["UserID"]) }));
                
        }

        public ActionResult Checkout()
        {
            return View();
        }
    }
}
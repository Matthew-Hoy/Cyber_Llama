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
                return this.Redirect(Url.Action("Index", "Login"));
            }
        }

        public List<Cart> getCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            List<Cart> cart = sc.getCartItems(ID).GroupBy(y => new { y.imagelink, y.part_id, y.price, y.qua, y.description, y.Max_qua, y.cart, y.discount}).Select(x => new Cart
            {
                cart=x.Key.cart,
                Name = x.Key.description,
                ImageLink = x.Key.imagelink,
                Price = x.Key.price,
                Discount = x.Key.discount,
                ProductID = x.Key.part_id,
                Quantity = x.Key.qua,
                MaxQuantity = x.Key.Max_qua
            }).ToList();
            return cart;
        }

        public ActionResult Cart()
        {
            if (Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Login"));
            }
            List<Cart> cart = getCart(Convert.ToInt32(Session["UserID"]));
            return View(cart);
        }

        public ActionResult RemoveFromCart(int item, string cart)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if (Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Login"));
            }
            if(cart == "part")
            {
                bool isRemoved = sc.removeFromPartCart(Convert.ToInt32(Session["UserID"]), item);
            }
            if(cart == "pc")
            {
                bool isRemoved = sc.removeFromPcCart(Convert.ToInt32(Session["UserID"]), item);
            }

            return View("cart" , getCart(Convert.ToInt32(Session["UserID"])));
                
        }
        [HttpPost]
        public ActionResult Checkout(List<Cart> cart)
        {
            if(Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Login"));
            }
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            foreach (Cart item in cart)
            {
                bool updated = sc.updatePartCart(Convert.ToInt32(Session["UserID"]), item.ProductID, item.Quantity);
                if (!updated)
                {
                    updated = sc.updatePcCart(Convert.ToInt32(Session["UserID"]), item.ProductID, item.Quantity);
                }
            }
            return View();
        }
    }
}
using CyberLlamaConsumerSite.CRUDService;
using CyberLlamaConsumerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            else if (Session["Cart"] != null)
            {
                return this.Redirect(Url.Action("Cart", "Checkout", new { ID = 0 }));
            }
            else if (Session["Cart"] == null)
            {
                return this.Redirect(Url.Action("Cart", "Checkout", new { ID = 0 }));
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
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            List<Cart> cart = new List<Cart>();
            if (Session["UserID"] != null)
            {
                cart = getCart(Convert.ToInt32(Session["UserID"]));
            }
            if (Session["Cart"] != null)
            {
                c_ProductPageInfo part;
                cart = new List<Cart>();
                List<int> ids = (List<int>)Session["Cart"];
                foreach(int id in ids)
                {
                    part = sc.getPart(id);
                    cart.Add(new Cart
                    {
                        Discount = part.discount,
                        ImageLink = part.image,
                        MaxQuantity = part.Quantity,
                        Quantity = 1,
                        Name = part.model,
                        Price = part.price,
                       ProductID = part.ID,
                       cart = "part"
                    });
                   
                }
            }
            if (Session["PartCart"] != null)
            {
                c_PcPageInfo part;
                if(cart == null)
                {
                    cart = new List<Cart>();
                }
                List<int> ids = (List<int>)Session["PartCart"];
                foreach (int id in ids)
                {
                    part = sc.getPcInfo(id);
                    cart.Add(new Cart
                    {
                        Discount = part.discount,
                        ImageLink = part.image,
                        MaxQuantity = part.Quantity,
                        Quantity = 1,
                        Name = part.type,
                        Price = part.price,
                        ProductID = part.ID,
                        cart = "pc"
                    });
                }
            }
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
            var client = sc.getClient(Convert.ToInt32(Session["UserID"]));
            Delivery view = new Delivery
            {
                Address = client.Address,
                City = client.city,
                Method = "Collect",
                Province = client.province,
                ZipCode = client.ZipCode,
                Products = getCart(client.ID),
                Email = client.email,
                FirstName = client.firstName,
                Surname = client.Surname,
            };
            return View(view);
        }
        
        public ActionResult Invoice(Delivery delivery)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            var client = sc.getClient(Convert.ToInt32(Session["UserID"]));
            if (delivery != null)
            {
                delivery.Method = "Deliver";
            }
            else
            {
                delivery = new Delivery();
                delivery.Method = "Collect";
            }

            delivery.Products = getCart(Convert.ToInt32(Session["UserID"]));
            foreach(Cart product in delivery.Products)
            {
                delivery.SubTotal +=Math.Round(product.Price*product.Quantity, 2);
                delivery.Discount += Math.Round(product.Discount * product.Price*product.Quantity/100, 2);
            }
            delivery.Tax = Math.Round(delivery.SubTotal * 15 / 100, 2);
            delivery.Total = Math.Round(delivery.SubTotal + delivery.Tax - delivery.Discount, 2);
            delivery.Email = client.email;
            delivery.Surname = client.Surname;
            delivery.FirstName = client.firstName;
            return View(delivery);
        }

        public void BuyProduct(Delivery invoice)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if (Session["UserID"] != null)
            {
                //add to sold
                bool sold = sc.addToPartSold(Convert.ToInt32(Session["UserID"]));
                sold = sc.addToPcSold(Convert.ToInt32(Session["UserID"]));
                //add to deliveries

                //add to invoices
                bool added = sc.addToPartInvoice(Convert.ToInt32(Session["UserID"]));
                added = sc.addToPcInvoice(Convert.ToInt32(Session["UserID"]));
                //REMOVE FROM stock
                bool removed = sc.decreasePartStock(Convert.ToInt32(Session["UserID"]));
                removed = sc.decreasePcStock(Convert.ToInt32(Session["UserID"]));
                //clear cart
                bool cleared = sc.clearPartCart(Convert.ToInt32(Session["UserID"]));
                cleared = sc.clearPcCart(Convert.ToInt32(Session["UserID"]));  
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}
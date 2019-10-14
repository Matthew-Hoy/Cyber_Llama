using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyberLlamaConsumerSite.CRUDService;
using CyberLlamaConsumerSite.Models;

namespace CyberLlamaConsumerSite.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            List<Invoice> invoices = sc.getAllInvoices(Convert.ToInt32(Session["UserID"])).GroupBy(x => new { x.date,x.InvoiceId,x.numItems,x.pc_ID,x.type,x.user_ID })
                .Select(y => new Invoice
                {
                    date = y.Key.date,
                    InvoiceId = y.Key.InvoiceId,
                    numItems = y.Key.numItems,
                    pc_ID = y.Key.pc_ID,
                    type = y.Key.type,
                    user_ID = y.Key.user_ID
                }).OrderBy(z=>z.InvoiceId).ToList();
            if(invoices== null)
            {
                return this.Redirect(Url.Action("Empty", "Invoice"));
            }
            return View(invoices);
        }

        public ActionResult Empty()
        {
            return View();
        }

        public List<Cart> getCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            List<Cart> cart = sc.getPartInvoice(ID).Select(x => new Cart
            {
                Discount = x.discount,
                ImageLink = x.imagelink,
                Name = x.description,
                Price = x.price,
                ProductID =  x.part_id,
                Quantity = x.qua
            }).ToList();

            List<Cart> cartpc = sc.getpcinvoice(ID).Select(x => new Cart
            {
                Discount = x.discount,
                ImageLink = x.imagelink,
                Name = x.description,
                Price = x.price,
                ProductID = x.part_id,
                Quantity = x.qua
            }).ToList();

            return cart.Concat(cartpc).ToList();
        }

        public ActionResult Invoice(int id)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            Delivery delivery = new Delivery();
            delivery.Products = getCart(Convert.ToInt32(Session["UserID"]));
            foreach (Cart product in delivery.Products)
            {
                delivery.SubTotal += Math.Round(product.Price * product.Quantity, 2);
                delivery.Discount += Math.Round(product.Discount * product.Price * product.Quantity / 100, 2);
            }
            delivery.Tax = Math.Round(delivery.SubTotal * 15 / 100, 2);
            delivery.Total = Math.Round(delivery.SubTotal + delivery.Tax - delivery.Discount, 2);
            return View(delivery);
        }
    }
}
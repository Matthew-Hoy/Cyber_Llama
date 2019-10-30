using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class AdminInvoiceController : Controller
    {
        // GET: AdminInvoice
        public ActionResult Index(string search)
        {

            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();

            if (Session["UserType"] == null)
            {
                return this.Redirect(Url.Action("Index", "Home"));
            }
            else if (Convert.ToInt32(Session["UserType"]) == 1 || Convert.ToInt32(Session["UserType"]) == 5)
            {

                var invoices = sr.getEntireInvoice();
                if(search == null)
                {
                    return View(invoices.ToList());
                }   else if(search == "iID")
                {
                    return View(invoices.OrderBy(x => x.InvoiceId).Select(y => y).ToList());
                }
                else if (search == "uID")
                {
                    return View(invoices.OrderBy(x => x.user_ID).Select(y => y).ToList());
                }
                else if (search == "date")
                {
                    return View(invoices.OrderBy(x => x.date).Select(y => y).ToList());
                }
                else if (search == "PcInvoice")
                {
                    return View(invoices.Where(x => x.type.Equals("PcInvoice")).Select(y => y).ToList());
                }
                else if (search == "PartInvoice")
                {
                    return View(invoices.Where(x => x.type.Equals("PartInvoice")).Select(y => y).ToList());
                }
                else
                {
                    return View(invoices.ToList());
                }

            }
            return this.Redirect(Url.Action("Index", "Home"));
        }
    }
}
using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ProductPageController : Controller
    {
        private IService service;

        public ProductPageController()
        {
            service = new ServiceClient();
        }
        // GET: Product
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Motherboard()
        {
            return View();
        }
    }
}
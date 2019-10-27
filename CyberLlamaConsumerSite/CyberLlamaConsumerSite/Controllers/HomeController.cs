using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string filter)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            dynamic gpu = sc.getAllParts("GPU");
            dynamic Motherboard = sc.getAllParts("Motherboard");
            dynamic RAM = sc.getAllParts("RAM");
            dynamic CPU = sc.getAllParts("CPU");
            dynamic AirCooler = sc.getAllParts("AirCooler");
            dynamic LiquidCooler = sc.getAllParts("LiquidCooler");
            dynamic SSD = sc.getAllParts("SSD");
            dynamic HDD = sc.getAllParts("HDD");
            dynamic Monitor = sc.getAllParts("Monitor");
            dynamic Mouse = sc.getAllParts("Mouse");
            dynamic Mousepad = sc.getAllParts("Mousepad");
            dynamic Keyboard = sc.getAllParts("Keyboard");
            dynamic Headset = sc.getAllParts("Headset");
            dynamic Case = sc.getAllParts("Case");
            dynamic PSU = sc.getAllParts("PSU");
            dynamic Speaker = sc.getAllParts("Speaker");
            dynamic Fan = sc.getAllParts("Fan");
            dynamic Microphone = sc.getAllParts("Microphone");
            //dynamic Case = sc.getAllParts("Case");
            ;
            List<c_ProductPageInfo> prods = new List<c_ProductPageInfo>();
            foreach (c_ProductPageInfo p in gpu)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Motherboard)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in RAM)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in CPU)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in AirCooler)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in LiquidCooler)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in SSD)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in HDD)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Case)
            {
                prods.Add(p);
            }



            foreach (c_ProductPageInfo p in Case)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Monitor)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Mouse)
            {
                prods.Add(p);

            }
            foreach (c_ProductPageInfo p in Mousepad)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Speaker)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Headset)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Fan)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in PSU)
            {
                prods.Add(p);
            }
            foreach (c_ProductPageInfo p in Keyboard)
            {
                prods.Add(p);
            }


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
            if (Session["UserID"] != null)
            {
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), ID, 1, 100);

            }
            else if (Session["Cart"] != null)
            {
                List<int> cartIds = (List<int>)Session["Cart"];
                if(cartIds.Where(x => x.Equals(ID)).Select(y => y) == null)
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
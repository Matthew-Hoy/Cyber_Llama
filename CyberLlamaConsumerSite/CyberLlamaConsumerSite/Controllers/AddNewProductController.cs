using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class AddNewProductController : Controller
    {
        // GET: AddNewProduct
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addProduct(string product)
        {
            switch (product) {
                case "Graphics processing Unit":
                    return this.Redirect(@Url.Action("GPU", "AddNewProduct"));
                case "Motherboard":
                    return this.Redirect(@Url.Action("Mobo", "AddNewProduct"));
                case "Random Access Memory":
                    return this.Redirect(@Url.Action("RAM", "AddNewProduct"));
                case "Computer Processing Unit":
                    return this.Redirect(@Url.Action("CPU", "AddNewProduct"));
                case "Air Cooler":
                    return this.Redirect(@Url.Action("AirCooler", "AddNewProduct"));
                case "Liquid Cooler":
                    return this.Redirect(@Url.Action("LiquidCoooler", "AddNewProduct"));
                case "Solid State Drive":
                    return this.Redirect(@Url.Action("SSD", "AddNewProduct"));
                case "Hard Drive":
                    return this.Redirect(@Url.Action("HHD", "AddNewProduct"));
                case "PC Chassis":
                    return this.Redirect(@Url.Action("Case", "AddNewProduct"));
                case "Power Supply":
                    return this.Redirect(@Url.Action("PSU", "AddNewProduct"));
                case "Case Fan":
                    return this.Redirect(@Url.Action("Fan", "AddNewProduct"));
                default:
                    break;
            }
            return View();
        }

        public ActionResult addPeripheral(string product)
        {
            return View();
        }

        public ActionResult GPU()
        {

            cGPU gpu = new cGPU
            {
                active = 0
            };

            return View(gpu);
        }
        public ActionResult addGPU(cGPU gpu, decimal price)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addGPU(gpu,1, price);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("GPU", "AddNewProduct"));
            }    
        }

        public ActionResult Complete()
        {
            return View();
        }
    }
}
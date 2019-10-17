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
                    return this.Redirect(@Url.Action("LiquidCooler", "AddNewProduct"));
                case "Solid State Drive":
                    return this.Redirect(@Url.Action("SSD", "AddNewProduct"));
                case "Hard Drive":
                    return this.Redirect(@Url.Action("HDD", "AddNewProduct"));
                case "PC Chassis":
                    return this.Redirect(@Url.Action("Case", "AddNewProduct"));
                case "Power Supply":
                    return this.Redirect(@Url.Action("PSU", "AddNewProduct"));
                case "Case Fan":
                    return this.Redirect(@Url.Action("Fan", "AddNewProduct"));
                case "PC":
                    return this.Redirect(@Url.Action("PC", "AddNewProduct"));
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
        public ActionResult addGPU(cGPU gpu, decimal price, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addGPU(gpu, 1, price, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("GPU", "AddNewProduct"));
            }
        }

        public ActionResult AirCooler()
        {

            cAirCooler airCooler = new cAirCooler
            {
                active = 0
            };

            return View(airCooler);
        }
        public ActionResult addAirCooler(cAirCooler airCooler, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addAirCooler(airCooler, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("AirCooler", "AddNewProduct"));
            }
        }

        public ActionResult Case()
        {

            cCase Case = new cCase
            {
                active = 0
            };

            return View(Case);
        }
        public ActionResult addCase(cCase Case, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addCase(Case, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Case", "AddNewProduct"));
            }
        }

        public ActionResult CPU()
        {

            cCPU part = new cCPU
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addCPU(cCPU part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addCPU(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult Fan()
        {

            cFan part = new cFan
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addFan(cFan part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addFan(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult HDD()
        {

            cHDD part = new cHDD
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addHDD(cHDD part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addHDD(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult LiquidCooler()
        {

            cLiquidCooler part = new cLiquidCooler
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addLiquidCooler(cLiquidCooler part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addLiquidCooler(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult Mobo()
        {

            cMobo part = new cMobo
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMobo(cMobo part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addMobo(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult PSU()
        {

            cPSU part = new cPSU
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addPSU(cPSU part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addPSU(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult RAM()
        {

            cRAM part = new cRAM
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addRAM(cRAM part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addRAM(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult SSD()
        {

            cSSD part = new cSSD
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addSSD(cSSD part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addSSD(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "AddNewProduct"));
            }
        }

        public ActionResult Complete()
        {
            return View();
        }
    }
}
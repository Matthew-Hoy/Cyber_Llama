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
                case "Keyboard":
                    return this.Redirect(@Url.Action("Keyboard", "AddNewProduct"));
                case "Mouse":
                    return this.Redirect(@Url.Action("Mouse", "AddNewProduct"));
                case "Mousepad":
                    return this.Redirect(@Url.Action("Mousepad", "AddNewProduct"));
                case "Headset":
                    return this.Redirect(@Url.Action("Headset", "AddNewProduct"));
                case "Speaker":
                    return this.Redirect(@Url.Action("Speaker", "AddNewProduct"));
                case "Microphone":
                    return this.Redirect(@Url.Action("Microphone", "AddNewProduct"));
                case "Monitor":
                    return this.Redirect(@Url.Action("Monitor", "AddNewProduct"));
                default:
                    break;
            }
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
                return this.Redirect(Url.Action("HDD", "AddNewProduct"));
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
                return this.Redirect(Url.Action("LiquidCooler", "AddNewProduct"));
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
                return this.Redirect(Url.Action("Mobo", "AddNewProduct"));
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
                return this.Redirect(Url.Action("PSU", "AddNewProduct"));
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
                return this.Redirect(Url.Action("RAM", "AddNewProduct"));
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
                return this.Redirect(Url.Action("SSD", "AddNewProduct"));
            }
        }

        public ActionResult Keyboard()
        {

            cKeyboard part = new cKeyboard
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addKeyboard(cKeyboard part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addKeyboard(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Keyboard", "AddNewProduct"));
            }
        }

        public ActionResult Mouse()
        {

            cMouse part = new cMouse
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMouse(cMouse part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addMouse(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Mouse", "AddNewProduct"));
            }
        }

        public ActionResult Mousepad()
        {

            cMousePad part = new cMousePad
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMousepad(cMousePad part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addMousepad(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Mousepad", "AddNewProduct"));
            }
        }

        public ActionResult Headset()
        {

            cHeadset part = new cHeadset
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addHeadset(cHeadset part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addHeadset(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Headset", "AddNewProduct"));
            }
        }

        public ActionResult Speaker()
        {

            cSpeaker part = new cSpeaker
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addSpeaker(cSpeaker part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addSpeaker(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Speaker", "AddNewProduct"));
            }
        }

        public ActionResult Microphone()
        {

            cMicrophone part = new cMicrophone
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMicrophone(cMicrophone part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addMicrophone(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Microphone", "AddNewProduct"));
            }
        }

        public ActionResult Monitor()
        {

            cMonitor part = new cMonitor
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMonitor(cMonitor part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addMonitor(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Monitor", "AddNewProduct"));
            }
        }

        public ActionResult PC()
        {

            cPC part = new cPC
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addPC(cPC part, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool added = sr.addPC(part, 1, image);
            if (added)
            {
                return this.Redirect(Url.Action("Complete", "AddNewProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("PC", "AddNewProduct"));
            }
        }

        public ActionResult Complete()
        {
            return View();
        }
    }
}
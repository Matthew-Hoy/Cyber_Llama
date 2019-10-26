using CyberLlamaConsumerSite.CRUDService;
using CyberLlamaConsumerSite.Models;
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
            if(Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            return View();
        }

        public ActionResult addProduct(string product)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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

        public ActionResult PC()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PCModel pcmodel = new PCModel
            {
              parts =  sr.getAllPCparts()
            };
            return View(pcmodel);
        }

        public ActionResult addPC(int? caseID, int? moboID, int? CPUID, int? RAMID, int? GPUID, int? coolerID, int? SSDID, int? FanID, int? HDDID, int? PSUID, int? OSID, int? MonitorID, int? HeadsetID, int? KeyboardID, int? MouseID, int? SpeakerID, string Warranty, int? numFans, int? numSSDs, int? numHDDs, string pcType, int? Quantity, double? Price, string Image, bool? Active, int? Discount)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cPC newPC = new cPC
            {
                active = Active != null ? 1 : 0,
                case_id = Convert.ToString(caseID),
                cooler_id = Convert.ToString(coolerID),
                cpu_id = Convert.ToString(CPUID),
                fan_id = Convert.ToString(FanID),
                gpu_id = Convert.ToString(GPUID),
                headset_id = Convert.ToString(HeadsetID),
                hdd_id = Convert.ToString(HDDID),
                keyboard_id = Convert.ToString(KeyboardID),
                mobo_id = Convert.ToString(moboID),
                monitor_id = Convert.ToString(MonitorID),
                mouse_id = Convert.ToString(MouseID),
                os_id = Convert.ToString(OSID),
                psu_id = Convert.ToString(PSUID),
                ram_id = Convert.ToString(RAMID),
                ssd_id = Convert.ToString(SSDID),
                speaker_id = Convert.ToString(SpeakerID),
                discount = Discount != null ? (int)Discount : 0,
                num_fans= numFans != null ? (int)numFans : 0,
                num_hdd= numHDDs != null ? (int)numHDDs : 0,
                num_ssd = numSSDs != null ? (int)numSSDs : 0,
                price  = Price != null ? (double)Price : 0,
                type = pcType,
                warranty  = Warranty,
            };
            bool added = sr.addPC(newPC, Quantity == null ? 0:(int) Quantity, Image);
            if (added)
            {
                return this.RedirectToAction("Index", "AddnewProduct");
            }
            else
            {
                return this.RedirectToAction("PC", "AddnewProduct");
            }

        }

        public ActionResult GPU()
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cGPU gpu = new cGPU
            {
                active = 0
            };

            return View(gpu);
        }
        public ActionResult addGPU(cGPU gpu, decimal price, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cAirCooler airCooler = new cAirCooler
            {
                active = 0
            };

            return View(airCooler);
        }
        public ActionResult addAirCooler(cAirCooler airCooler, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cCase Case = new cCase
            {
                active = 0
            };

            return View(Case);
        }
        public ActionResult addCase(cCase Case, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cCPU part = new cCPU
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addCPU(cCPU part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cFan part = new cFan
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addFan(cFan part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cHDD part = new cHDD
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addHDD(cHDD part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cLiquidCooler part = new cLiquidCooler
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addLiquidCooler(cLiquidCooler part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cMobo part = new cMobo
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMobo(cMobo part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cPSU part = new cPSU
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addPSU(cPSU part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cRAM part = new cRAM
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addRAM(cRAM part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cSSD part = new cSSD
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addSSD(cSSD part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cKeyboard part = new cKeyboard
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addKeyboard(cKeyboard part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cMouse part = new cMouse
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMouse(cMouse part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cMousePad part = new cMousePad
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMousepad(cMousePad part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cHeadset part = new cHeadset
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addHeadset(cHeadset part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cSpeaker part = new cSpeaker
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addSpeaker(cSpeaker part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cMicrophone part = new cMicrophone
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMicrophone(cMicrophone part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            cMonitor part = new cMonitor
            {
                active = 0
            };

            return View(part);
        }
        public ActionResult addMonitor(cMonitor part, string image)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
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

        public ActionResult Complete()
        {
            return View();
        }
    }
}
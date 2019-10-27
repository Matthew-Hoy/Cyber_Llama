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
    public class EditProductController : Controller
    {
        // GET: EditProduct
        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            return View();
        }

        public ActionResult EditProduct(string product)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                return this.Redirect(@Url.Action("Index", "Home"));
            }
            switch (product)
            {
                case "Graphics processing Unit":
                    return this.Redirect(@Url.Action("EditGPU", "EditProduct"));
                case "Motherboard":
                    return this.Redirect(@Url.Action("EditMobo", "EditProduct"));
                case "Random Access Memory":
                    return this.Redirect(@Url.Action("EditRAM", "EditProduct"));
                case "Computer Processing Unit":
                    return this.Redirect(@Url.Action("EditCPU", "EditProduct"));
                case "Air Cooler":
                    return this.Redirect(@Url.Action("EditAirCooler", "EditProduct"));
                case "Liquid Cooler":
                    return this.Redirect(@Url.Action("EditLiquidCooler", "EditProduct"));
                case "Solid State Drive":
                    return this.Redirect(@Url.Action("EditSSD", "EditProduct"));
                case "Hard Drive":
                    return this.Redirect(@Url.Action("EditHDD", "EditProduct"));
                case "PC Chassis":
                    return this.Redirect(@Url.Action("EditCase", "EditProduct"));
                case "Power Supply":
                    return this.Redirect(@Url.Action("EditPSU", "EditProduct"));
                case "Case Fan":
                    return this.Redirect(@Url.Action("EditFan", "EditProduct"));
                case "PC":
                    return this.Redirect(@Url.Action("EditPC", "EditProduct"));
                case "Microphone":
                    return this.Redirect(@Url.Action("EditMicrophone", "EditProduct"));
                case "Keyboard":
                    return this.Redirect(@Url.Action("EditKeyboard", "EditProduct"));
                case "Mouse":
                    return this.Redirect(@Url.Action("EditMouse", "EditProduct"));
                case "Mousepad":
                    return this.Redirect(@Url.Action("EditMousepad", "EditProduct"));
                case "Headset":
                    return this.Redirect(@Url.Action("EditHeadset", "EditProduct"));
                case "Speaker":
                    return this.Redirect(@Url.Action("EditSpeaker", "EditProduct"));
                case "Monitor":
                    return this.Redirect(@Url.Action("EditMonitor", "EditProduct"));
                default:
                    break;
            }
            return View();
        }

        public ActionResult EditGPU()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cGPU> gpu = sr.getAllGPU().ToList();
            
            return View(gpu);
        }
        public ActionResult GPU(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cGPU gpu = sr.getGPU(id);
            return View(gpu);
        }
        public ActionResult ChangeGPU(cGPU gpu, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(gpu.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(gpu.id).image;
            }
            bool done = sr.EditGPU(gpu,part,gpu.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("GPU", "EditProduct"));
            }
        }

        public ActionResult EditAirCooler()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cAirCooler> part = sr.getAllAirCooler().ToList();

            return View(part);
        }
        public ActionResult AirCooler(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cAirCooler part = sr.getAirCooler(id);
            return View(part);
        }
        public ActionResult ChangeAirCooler(cAirCooler airCooler, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(airCooler.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(airCooler.id).image;
            }
            bool done = sr.EditAirCooler(airCooler, part, airCooler.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("AirCooler", "EditProduct"));
            }
        }

        public ActionResult EditCase()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cCase> part = sr.getAllCase().ToList();

            return View(part);
        }
        public ActionResult Case(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cCase part = sr.getCase(id);
            return View(part);
        }
        public ActionResult ChangeCase(cCase Case, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(Case.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(Case.id).image;
            }
            bool done = sr.EditCase(Case, part, Case.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Case", "EditProduct"));
            }
        }

        public ActionResult EditCPU()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cCPU> part = sr.getAllCPU().ToList();

            return View(part);
        }
        public ActionResult CPU(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cCPU part = sr.getCPU(id);
            return View(part);
        }
        public ActionResult ChangeCPU(cCPU cpu, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(cpu.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(cpu.id).image;
            }
            bool done = sr.EditCPU(cpu, part, cpu.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("CPU", "EditProduct"));
            }
        }

        public ActionResult EditFan()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cFan> part = sr.getAllFan().ToList();

            return View(part);
        }
        public ActionResult Fan(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cFan part = sr.getFan(id);
            return View(part);
        }
        public ActionResult ChangeFan(cFan fan, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(fan.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(fan.id).image;
            }
            bool done = sr.EditFan(fan, part, fan.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Fan", "EditProduct"));
            }
        }

        public ActionResult EditHDD()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cHDD> part = sr.getAllHDD().ToList();

            return View(part);
        }
        public ActionResult HDD(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cHDD part = sr.getHDD(id);
            return View(part);
        }
        public ActionResult ChangeHDD(cHDD hdd, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(hdd.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(hdd.id).image;
            }
            bool done = sr.EditHDD(hdd, part, hdd.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("HDD", "EditProduct"));
            }
        }

        public ActionResult EditLiquidCooler()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cLiquidCooler> part = sr.getAllLiquidCooler().ToList();

            return View(part);
        }
        public ActionResult LiquidCooler(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cLiquidCooler part = sr.getLiquidCooler(id);
            return View(part);
        }
        public ActionResult ChangeLiquidCooler(cLiquidCooler liquidCooler, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(liquidCooler.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(liquidCooler.id).image;
            }
            bool done = sr.EditLiquidCooler(liquidCooler, part, liquidCooler.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("LiquidCooler", "EditProduct"));
            }
        }

        public ActionResult EditMobo()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cMobo> part = sr.getAllMobo().ToList();

            return View(part);
        }
        public ActionResult Mobo(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cMobo part = sr.getMobo(id);
            return View(part);
        }
        public ActionResult ChangeMobo(cMobo mobo, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(mobo.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(mobo.id).image;
            }
            bool done = sr.EditMobo(mobo, part, mobo.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Mobo", "EditProduct"));
            }
        }

        public ActionResult EditPSU()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cPSU> part = sr.getAllPSU().ToList();

            return View(part);
        }
        public ActionResult PSU(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cPSU part = sr.getPSU(id);
            return View(part);
        }
        public ActionResult ChangePSU(cPSU psu, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(psu.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(psu.id).image;
            }
            bool done = sr.EditPSU(psu, part, psu.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("PSU", "EditProduct"));
            }
        }

        public ActionResult EditRAM()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cRAM> part = sr.getAllRAM().ToList();

            return View(part);
        }
        public ActionResult RAM(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cRAM part = sr.getRAM(id);
            return View(part);
        }
        public ActionResult ChangeRAM(cRAM ram, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(ram.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(ram.id).image;
            }
            bool done = sr.EditRAM(ram, part, ram.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("RAM", "EditProduct"));
            }
        }

        public ActionResult EditSSD()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cSSD> part = sr.getAllSSD().ToList();

            return View(part);
        }
        public ActionResult SSD(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cSSD part = sr.getSSD(id);
            return View(part);
        }
        public ActionResult ChangeSSD(cSSD ssd, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(ssd.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(ssd.id).image;
            }
            bool done = sr.EditSSD(ssd, part, ssd.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("SSD", "EditProduct"));
            }
        }

        public ActionResult EditKeyboard()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cKeyboard> part = sr.getAllKeyboard().ToList();

            return View(part);
        }
        public ActionResult Keyboard(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cKeyboard part = sr.getKeyboard(id);
            return View(part);
        }
        public ActionResult ChangeKeyboard(cKeyboard keyboard, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(keyboard.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(keyboard.id).image;
            }
            bool done = sr.EditKeyboard(keyboard, part, keyboard.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Keyboard", "EditProduct"));
            }
        }

        public ActionResult EditMouse()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cMouse> part = sr.getAllMouse().ToList();

            return View(part);
        }
        public ActionResult Mouse(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cMouse part = sr.getMouse(id);
            return View(part);
        }
        public ActionResult ChangeMouse(cMouse mouse, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(mouse.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(mouse.id).image;
            }
            bool done = sr.EditMouse(mouse, part, mouse.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Mouse", "EditProduct"));
            }
        }

        public ActionResult EditMousepad()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cMousePad> part = sr.getAllMousepad().ToList();

            return View(part);
        }
        public ActionResult Mousepad(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cMousePad part = sr.getMousepad(id);
            return View(part);
        }
        public ActionResult ChangeMousepad(cMousePad mousepad, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(mousepad.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(mousepad.id).image;
            }
            bool done = sr.EditMousepad(mousepad, part, mousepad.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Mousepad", "EditProduct"));
            }
        }

        public ActionResult EditHeadset()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cHeadset> part = sr.getAllHeadset().ToList();

            return View(part);
        }
        public ActionResult Headset(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cHeadset part = sr.getHeadset(id);
            return View(part);
        }
        public ActionResult ChangeHeadset(cHeadset headset, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(headset.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(headset.id).image;
            }
            bool done = sr.EditHeadset(headset, part, headset.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Headset", "EditProduct"));
            }
        }

        public ActionResult EditSpeaker()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cSpeaker> part = sr.getAllSpeaker().ToList();

            return View(part);
        }
        public ActionResult Speaker(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cSpeaker part = sr.getSpeaker(id);
            return View(part);
        }
        public ActionResult ChangeSpeaker(cSpeaker speaker, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(speaker.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(speaker.id).image;
            }
            bool done = sr.EditSpeaker(speaker, part, speaker.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Speaker", "EditProduct"));
            }
        }

        public ActionResult EditMicrophone()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cMicrophone> part = sr.getAllMicrophone().ToList();

            return View(part);
        }
        public ActionResult Microphone(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cMicrophone part = sr.getMicrophone(id);
            return View(part);
        }
        public ActionResult ChangeMicrophone(cMicrophone mic, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(mic.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(mic.id).image;
            }
            bool done = sr.EditMicrophone(mic, part, mic.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Microphone", "EditProduct"));
            }
        }

        public ActionResult EditMonitor()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cMonitor> part = sr.getAllMonitor().ToList();

            return View(part);
        }
        public ActionResult Monitor(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cMonitor part = sr.getMonitor(id);
            return View(part);
        }
        public ActionResult ChangeMonitor(cMonitor monitor, int? quantity, string image)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PartsStock part = new PartsStock();
            if (quantity != null)
            {
                part.Quantity = (int)quantity;
            }
            else
            {
                part.Quantity = sr.getPart(monitor.id).Quantity;
            }
            if (image != null && image != "")
            {
                part.Image = image;
            }
            else
            {
                part.Image = sr.getPart(monitor.id).image;
            }
            bool done = sr.EditMonitor(monitor, part, monitor.id);
            if (done)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("Monitor", "EditProduct"));
            }
        }

        public ActionResult EditPC()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cPC> part = sr.getAllPC().ToList();

            return View(part);
        }

        public ActionResult PC(int id)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            PCModel pcmodel = new PCModel
            {
                parts = sr.getAllPCparts(),
                PC = sr.getPCbyID(id)
            };
            return View(pcmodel);
        }

        public ActionResult changePC(int? id, int? caseID, int? moboID, int? CPUID, int? RAMID, int? GPUID, int? coolerID, int? SSDID, int? FanID, int? HDDID, int? PSUID, int? OSID, int? MonitorID, int? HeadsetID, int? KeyboardID, int? MouseID, int? SpeakerID, string Warranty, int? numFans, int? numSSDs, int? numHDDs, string pcType, int? Quantity, double? Price, string Image, int? Active, int? Discount)
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cPC newPC = new cPC
            {
                active = (int)Active,
                case_id = Convert.ToString(caseID),
                cooler_id = Convert.ToString(coolerID),
                cpu_id = Convert.ToString(CPUID),
                fan_id = Convert.ToString(FanID),
                gpu_id = Convert.ToString(GPUID),
                headset_id = Convert.ToString(HeadsetID) == "" ? null : Convert.ToString(HeadsetID),
                hdd_id = Convert.ToString(HDDID) == "" ? null:  Convert.ToString(HDDID),
                keyboard_id = Convert.ToString(KeyboardID) == "" ? null : Convert.ToString(KeyboardID),
                mobo_id = Convert.ToString(moboID),
                monitor_id = Convert.ToString(MonitorID) == "" ? null : Convert.ToString(MonitorID),
                mouse_id = Convert.ToString(MouseID) == "" ? null : Convert.ToString(MouseID),
                os_id = Convert.ToString(OSID) == "" ? null : Convert.ToString(OSID),
                psu_id = Convert.ToString(PSUID),
                ram_id = Convert.ToString(RAMID),
                ssd_id = Convert.ToString(SSDID) == "" ? null : Convert.ToString(SSDID),
                speaker_id = Convert.ToString(SpeakerID) == "" ? null : Convert.ToString(SpeakerID),
                discount = Discount != null ? (int)Discount : 0,
                num_fans = numFans != null ? (int)numFans : 0,
                num_hdd = numHDDs != null ? (int)numHDDs : 0,
                num_ssd = numSSDs != null ? (int)numSSDs : 0,
                price = Price != null ? (double)Price : 0,
                type = pcType,
                warranty = Warranty,
            };

            PcStock stock = new PcStock
            {
               PC_Type =  pcType,
               Active = (int)Active,
               Discount = (int)Discount  ,
               ID = (int)id,
               Image = Image,
               Price = (decimal)Price,
               Quantity = (int)Quantity 
            };

            bool edited = sr.EditPC(newPC, stock, (int)id);
            if (edited)
            {
                return this.Redirect(Url.Action("Complete", "EditProduct"));
            }
            else
            {
                return this.Redirect(Url.Action("PC", "EditProduct"));
            }
    }


        public void Delete(string type, int id)
        {
            if (Convert.ToInt32(Session["UserType"]) != 1 && Convert.ToInt32(Session["UserType"]) != 3)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            switch (type)
            {
                case "Graphics processing Unit":
                    sr.deleteGPU(id);
                        break;
                case "Motherboard":
                    sr.deleteMobo(id);
                    break;
                case "Random Access Memory":
                    sr.deleteRAM(id);
                    break;
                case "Computer Processing Unit":
                    sr.deleteCPU(id);
                    break;
                case "Air Cooler":
                    sr.DeleteAirCooler(id);
                    break;
                case "Liquid Cooler":
                    sr.deleteLiquidCooler(id);
                    break;
                case "Solid State Drive":
                    sr.deleteSSD(id);
                    break;
                case "Hard Drive":
                    sr.deleteHDD(id);
                    break;
                case "PC Chassis":
                    sr.deleteCase(id);
                    break;
                case "Power Supply":
                    sr.deletePSU(id);
                    break;
                case "Case Fan":
                    sr.deleteFan(id);
                    break;
                case "PC":
                    sr.deletePC(id);
                    break;
                case "Microphone":
                    sr.deleteMicrophone(id);
                    break;
                case "Keyboard":
                    sr.deleteKeyboard(id);
                    break;
                case "Mouse":
                    sr.deleteMouse(id);
                    break;
                case "Mousepad":
                    sr.deleteMousepad(id);
                    break;
                case "Headset":
                    sr.deleteHeadset(id);
                    break;
                case "Speaker":
                    sr.deleteSpeaker(id);
                    break;
                case "Monitor":
                    sr.deleteMonitor(id);
                    break;
                default:
                    Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
            }
        }

        public ActionResult Complete()
        {
            return View();
        }
    }
}
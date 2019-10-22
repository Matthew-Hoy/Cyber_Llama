using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class EditProductController : Controller
    {
        // GET: EditProduct
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditProduct(string product)
        {
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
                case "Case Microphone":
                    return this.Redirect(@Url.Action("EditMicrophone", "EditProduct"));
                case "Case keyboard":
                    return this.Redirect(@Url.Action("EditKeyboard", "EditProduct"));
                case "Case Mouse":
                    return this.Redirect(@Url.Action("EditMouse", "EditProduct"));
                case "Case Mousepad":
                    return this.Redirect(@Url.Action("EditMousepad", "EditProduct"));
                case "Case Headset":
                    return this.Redirect(@Url.Action("EditHeadset", "EditProduct"));
                case "Case Speaker":
                    return this.Redirect(@Url.Action("EditSpeaker", "EditProduct"));
                case "Case Monitor":
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

        public ActionResult Complete()
        {
            return View();
        }
    }
}
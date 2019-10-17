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

        public ActionResult addProduct(string product)
        {
            switch (product)
            {
                case "Graphics processing Unit":
                    return this.Redirect(@Url.Action("AddGPU", "AddNewProduct"));
                case "Motherboard":
                    return this.Redirect(@Url.Action("AddMobo", "AddNewProduct"));
                case "Random Access Memory":
                    return this.Redirect(@Url.Action("AddRAM", "AddNewProduct"));
                case "Computer Processing Unit":
                    return this.Redirect(@Url.Action("AddCPU", "AddNewProduct"));
                case "Air Cooler":
                    return this.Redirect(@Url.Action("AddAirCooler", "AddNewProduct"));
                case "Liquid Cooler":
                    return this.Redirect(@Url.Action("AddLiquidCooler", "AddNewProduct"));
                case "Solid State Drive":
                    return this.Redirect(@Url.Action("AddSSD", "AddNewProduct"));
                case "Hard Drive":
                    return this.Redirect(@Url.Action("AddHDD", "AddNewProduct"));
                case "PC Chassis":
                    return this.Redirect(@Url.Action("AddCase", "AddNewProduct"));
                case "Power Supply":
                    return this.Redirect(@Url.Action("AddPSU", "AddNewProduct"));
                case "Case Fan":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "PC":
                    return this.Redirect(@Url.Action("AddPC", "AddNewProduct"));
                case "Case Microphone":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case keyboard":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case Mouse":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case Mousepad":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case Headset":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case Speaker":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                case "Case Monitor":
                    return this.Redirect(@Url.Action("AddFan", "AddNewProduct"));
                default:
                    break;
            }
            return View();
        }
    }
}
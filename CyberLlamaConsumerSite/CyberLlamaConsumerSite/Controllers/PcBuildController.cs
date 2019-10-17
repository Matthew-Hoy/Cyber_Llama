using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class PcBuildController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();

        // GET: PcBuild
        public ActionResult Index()
        {
            return View();
        }

        public void SelectCase(int ID)
        {
            Session["Case"] = ID;
            AddToCart(ID);
        }

        public void SelectMobo(int ID)
        {
            Session["Mobo"] = ID;
            AddToCart(ID);
        }

        public void SelectCPU(int ID)
        {
            Session["CPU"] = ID;
            AddToCart(ID);
        }

        public void SelectRAM(int ID)
        {
            Session["RAM"] = ID;
            AddToCart(ID);
        }

        public void SelectCooler(int ID)
        {
            Session["Cooler"] = ID;
            AddToCart(ID);
        }

        public void SelectSSD(int ID)
        {
            Session["SSD"] = ID;
            AddToCart(ID);
        }

        public void SelectHDD(int ID)
        {
            Session["HDD"] = ID;
            AddToCart(ID);
        }

        public void SelectPSU(int ID)
        {
            Session["PSU"] = ID;
            AddToCart(ID);
        }

        public void SelectGPU(int ID)
        {
            Session["GPU"] = ID;
            AddToCart(ID);
        }

        public void SelectFan(int ID)
        {
            Session["Fan"] = ID;
            AddToCart(ID);
        }

        public void ClearAll()
        {
            Session["Case"] = null;
            Session["Mobo"] = null;
            Session["CPU"] = null;
            Session["RAM"] = null;
            Session["Cooler"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearCase()
        {
            Session["Case"] = null;
            Session["Mobo"] = null;
            Session["CPU"] = null;
            Session["RAM"] = null;
            Session["Cooler"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearMobo()
        {
            Session["Mobo"] = null;
            Session["CPU"] = null;
            Session["RAM"] = null;
            Session["Cooler"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearCPU()
        {
            Session["CPU"] = null;
            Session["RAM"] = null;
            Session["Cooler"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearRAM()
        {
            Session["RAM"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearCooler()
        {
            Session["Cooler"] = null;
            Session["RAM"] = null;
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearGPU()
        {
            Session["GPU"] = null;
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearPSU()
        {
            Session["PSU"] = null;
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearFan()
        {
            Session["Fan"] = null;
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearHDD()
        {
            Session["HDD"] = null;
            Session["SSD"] = null;
        }

        public void ClearSSD()
        {
            Session["SSD"] = null;
        }

        public void CheackoutParts()
        {
            AddToCart(Convert.ToInt32(Session["Case"]));
            AddToCart(Convert.ToInt32(Session["Mobo"]));
            AddToCart(Convert.ToInt32(Session["CPU"]));
            AddToCart(Convert.ToInt32(Session["Cooler"]));
            AddToCart(Convert.ToInt32(Session["RAM"]));
            AddToCart(Convert.ToInt32(Session["GPU"]));
            AddToCart(Convert.ToInt32(Session["PSU"]));
            AddToCart(Convert.ToInt32(Session["Fan"]));
            AddToCart(Convert.ToInt32(Session["HDD"]));
            AddToCart(Convert.ToInt32(Session["SSD"]));

        } 

        public void AddToCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if (Session["UserID"] != null)
            {
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), ID, 1, 100);

            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

        }
    }
}
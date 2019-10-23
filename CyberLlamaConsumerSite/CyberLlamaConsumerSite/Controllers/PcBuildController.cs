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
        }

        public void SelectMobo(int ID)
        {
            Session["Mobo"] = ID;
        }

        public void SelectCPU(int ID)
        {
            Session["CPU"] = ID;
        }

        public void SelectRAM(int ID)
        {
            Session["RAM"] = ID;
        }

        public void SelectCooler(int ID)
        {
            Session["Cooler"] = ID;
        }

        public void SelectSSD(int ID)
        {
            Session["SSD"] = ID;
        }

        public void SelectHDD(int ID)
        {
            Session["HDD"] = ID;
        }

        public void SelectPSU(int ID)
        {
            Session["PSU"] = ID;
        }

        public void SelectGPU(int ID)
        {
            Session["GPU"] = ID;
        }

        public void SelectFan(int ID)
        {
            Session["Fan"] = ID;
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
            RemoveFromCart(Convert.ToInt32(Session["Case"]));
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

        public void AddAllToCart()
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if (Session["UserID"] != null)
            {
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["Case"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["Mobo"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["CPU"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["Cooler"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["RAM"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["GPU"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["PSU"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["Fan"]), 1, 100);
                sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["HDD"]), 1, 100);

                if (Session["SSD"] != null)
                {
                    sc.addToPartCart(Convert.ToInt32(Session["UserID"]), Convert.ToInt32(Session["SSD"]), 1, 100);
                }
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        public void RemoveFromCart(int item)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            bool isRemoved = sc.removeFromPartCart(Convert.ToInt32(Session["UserID"]), item);
            

        }
        
    }
}
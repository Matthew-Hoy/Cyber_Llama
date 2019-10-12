using CyberLlamaConsumerSite.CRUDService;
using System;
using System.Collections.Generic;
using System.Linq;
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
            /*
             * Sequence of Choosing parts:
             * 1. Case
             * 2. Motherboard
             * 3. CPU
             * 4. Cooler Air/Liquid
             * 5. RAM
             * 6. GPU
             * 7. PSU
             * 8. HDD
             * 9. SSD
             * 10. Fans
             * 11. Peripherals
             * 
             * 
             * Reload the page when a part is chosen and create session variables of the ID's of the chosen parts
             */

            //Load any Session variables
            //Session["Case"] = sr.getPcCase(Request.QueryString["Case_ID"]);
            //Session["Mobo"] = sr.getMobo(Request.QueryString["Mobo_ID"]);
            //Session["CPU"] = sr.getMobo(Request.QueryString["CPU_ID"]);
            //Session["AC"] = sr.getMobo(Request.QueryString["AC_ID"]);
            //Session["LC"] = sr.getMobo(Request.QueryString["LC_ID"]);
            //Session["RAM"] = sr.getMobo(Request.QueryString["RAM_ID"]);
            //Session["GPU"] = sr.getMobo(Request.QueryString["GPU_ID"]);
            //Session["PSU"] = sr.getMobo(Request.QueryString["PSU_ID"]);
            //Session["HDD"] = sr.getMobo(Request.QueryString["HDD_ID"]);
            //Session["SSD"] = sr.getMobo(Request.QueryString["SSD_ID"]);
            //Session["Fan"] = sr.getMobo(Request.QueryString["Fan_ID"]);

            if (Session["Case"] == null)
            {
                //Show all Cases
                dynamic list = sr.getAllCase();
                String info = ""; 
                foreach(cCase c in list)
                {
                    info += "<p>ID: "+c.id+"</p>";
                    info += "<p>Series: " + c.series + "</p>";
                    info += "<p>Brand: " + c.brand + "</p>";
                    info += "<p>Model: " + c.model + "</p>";
                    info += "<p>Dimensions: " + c.dimensions + "</p>";
                    info += "<p>Form Factor: " + c.mobo_form_factor + "</p>";
                    //info += "<p>Price: " + Math.Round((c.price - (c.price*c.discount/100),2)+"</p>";
                    info += "<a href='PcBuild.aspx?ID=" + c.id + "'> </a>";
                }

                //Create session variable when a case is selected
                
            }
            else if (Session["Case"] != null)
            {
                //Show Case Chosen

                if (Session["CPU"] != null)
                {
                    if (Session["Cooler"] != null)
                    {
                        if (Session["Fans"] != null)
                        {
                            if (Session["RAM"] != null)
                            {
                                if (Session["GPU"] != null)
                                {
                                    if (Session["PSU"] != null)
                                    {
                                        if (Session["HDD"] != null && !Session["HDD"].Equals("None"))
                                        {
                                            if (Session["SSD"] != null || Session["HDD"].Equals("None"))
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            // 1. Case
                //Show all cases
                //Remove all cases when one is chosen
            // 2. Motherboard
                //Show all Motherboards that fit in the Case
                //Remove all cases when one is chosen
            // 3. CPU
                //Show all CPU's of the correct Socket
                //Remove all cases when one is chosen
            // 4. Cooler Air/Liquid
                //Show all Coolers of the correct Socket and Height/Length
                //Remove all Coolers when one is chosen
            // 5. RAM
                //Show all RAM of the correct Capacity
                //Remove all RAM when Max Capacity or Number of Mobo is reached
            // 6. GPU
                //Show all GPU
                //Remove all GPU's when one is chosen
            // 7. PSU
                //Show all PSU's with the corrcct Power --> GPU Power
                //Remove all PSU's when one is chosen
            // 8. HDD
                //Show all HDD's if the case can support them
                //Remove all HDD when the limit is reached
            // 9. SSD
                //Show all SSD's if the Mobo supports them (Size, Type)
                //Remove all SSD's when one is chosen
            // 10. Fans
                //Show all Fans
                //Remove all Fans when the max amount are chosen (Dependant on Liquid Cooler radiator length)

            // 11. Peripherals - Optional

            //List<cPart> PartList = new List<cPart>();
            //List<cPartCart> partCart = new List<cPartCart>();

            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class PcPageController : Controller
    {
        // GET: PcPage
        public ActionResult Index()
        {
            return View();
        }

        public void AddToCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if(Session["UserID"] != null)
            {
                sc.addToPcCart(Convert.ToInt32(Session["UserID"]), ID, 1, 100);

            }
            else if (Session["PartCart"] != null)
            {
                List<int> cartIds = (List<int>)Session["PartCart"];
                if (cartIds.Where(x => x.Equals(ID)).Select(y => y) == null)
                {
                    cartIds.Add(ID);
                }

            }
            else if (Session["PartCart"] == null)
            {
                Session["PartCart"] = new List<int> { ID };
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

        }
    }
}
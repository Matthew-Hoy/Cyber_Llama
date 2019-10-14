﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ProductPageController : Controller
    {
        // GET: ProductPage
        public ActionResult Index()
        {
            return View();
        }


        public void AddToCart(int ID)
        {
            CRUDService.ServiceClient sc = new CRUDService.ServiceClient();
            if(Session["UserID"] != null)
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
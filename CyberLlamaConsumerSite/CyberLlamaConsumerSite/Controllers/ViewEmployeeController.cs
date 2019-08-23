using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyberLlamaConsumerSite.Models;
using CyberLlamaConsumerSite.Models.ViewModels;
using Newtonsoft.Json;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ViewEmployeeController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["UserType"]) <= 2)
            {
                List <Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(sr.getAllEmployees());
                Employees employeeView = new Employees
                {
                    listEmployees = employees
                };
                return View(employeeView);
            }
            else
            {
                return View("AccessDenied");
            }
            
        }
    }
}
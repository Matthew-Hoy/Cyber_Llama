using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyberLlamaConsumerSite.Models;
using CyberLlamaConsumerSite.Models.ViewModels;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ViewEmployeeController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
        public ActionResult Index()
        {
            if (Convert.ToInt32(Session["UserType"]) <= 2)
            {
                var dbEmployees = sr.getAllEmployees().ToList();
                List<Employee> employees = dbEmployees.GroupBy(x => new { x.Admin_ID, x.First_Name, x.Surname, x.Email, x.Contact_Number, x.Position })
                    .Select(y => new Employee
                    {
                        Admin_ID = y.Key.Admin_ID,
                        Conrtact_Number = y.Key.Contact_Number,
                        Email = y.Key.Email,
                        First_Name = y.Key.First_Name,
                        Position = y.Key.Position,
                        Surname = y.Key.Surname
                    }).ToList();

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
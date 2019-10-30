using CyberLlamaConsumerSite.CRUDService;
using CyberLlamaConsumerSite.Models;
using CyberLlamaConsumerSite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Index()
        {
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            
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

                List<Statistics> partsold = sr.getpartSoldStats().Select(x => new Statistics
                {
                    Name = x.Name,
                    ProductID = x.ProductID,
                    Quantity = x.Quantity,
                    Date = x.date
                }).ToList();

                List<Statistics> partstock = sr.getpartStockStats().Select(x => new Statistics
                {
                    Name = x.Name,
                    ProductID = x.ProductID,
                    Quantity = x.Quantity
                }).ToList();

                List<Statistics> pcsold = sr.getpcSoldStats().Select(x => new Statistics
                {
                    Name = x.Name,
                    ProductID = x.ProductID,
                    Quantity = x.Quantity,
                   Date = x.date
                }).ToList();

                List<Statistics> pcStock = sr.getpcStockStats().Select(x => new Statistics
                {
                    Name = x.Name,
                    ProductID = x.ProductID,
                    Quantity = x.Quantity
                }).ToList();

                List<UserStat> reg = sr.getLoginStats().Select(x => new UserStat
                {
                    Date = x.Date,
                    User_ID = x.User_ID
                }).ToList();

                List<UserStat> Usernew = sr.getRegisterStats().Select(x => new UserStat
                {
                    Date = x.Date,
                    User_ID = x.User_ID
                }).ToList();


                Management view = new Management(){
                    Employees = employees,
                    partSold = partsold,
                    partStock = partstock,
                    pcSold = pcsold,
                    pcStock = pcStock,
                    newUser = Usernew,
                    userReg = reg

                };
               


                return View(view);
            }
            else
            {
                return View("AccessDenied");
            }

        
        }

        public ActionResult AdminIndex(string search)
        {
            if (Convert.ToInt32(Session["UserType"]) > 2 || Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Home"));
            }
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            List<cEmployee> employees = sr.getAllEmployees().ToList();
            if (search == null)
            {
                return View(employees);
            }
            else if(search == "name")
            {
                return View(employees.OrderBy(x => x.First_Name.Trim()).Select(y => y).ToList());
            }
            else if (search == "email")
            {
                return View(employees.OrderBy(x => x.Email.Trim()).Select(y => y).ToList());
            }
            else if (search == "surname")
            {
                return View(employees.OrderBy(x => x.Surname.Trim()).Select(y => y).ToList());
            }
            else if (search == "id")
            {
                return View(employees.OrderBy(x => x.Admin_ID).Select(y => y).ToList());
            }
            else
            {
                return View(employees.Where(x => x.First_Name.Equals(search) || x.Email.Equals(search) || x.Surname.Equals(search)).Select(y => y).ToList());
            }
        }

        public ActionResult EditEmployee(int id)
        {
            if (Convert.ToInt32(Session["UserType"]) > 2 || Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Home"));
            }
            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            cEmployee client = sr.getEmployee(id);
            return View(client);

        }

        public ActionResult ChangeEmployee(cEmployee client)
        {
            if (Session["UserID"] == null)
            {
                return this.Redirect(Url.Action("Index", "Home"));
            }

            CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
            bool isEditied = sr.editEmployee(client);
             if (isEditied)
             {
                 return View();
             }
             else
             {
                 return this.Redirect(Url.Action("EditEmployee", "Management"));
             }
            

        }
    }
}
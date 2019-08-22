using CyberLlamaConsumerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberLlamaConsumerSite.Controllers
{
    public class AddUserController : Controller
    {
        CRUDService.ServiceClient sr = new CRUDService.ServiceClient();
        public ActionResult Index()

        {
            var positions = sr.getUserPositions();
            IEnumerable<UserPositions> positionView = positions.GroupBy(n => new {n.PositionID, n.Position }).Select(y => new UserPositions
            {
                UserID = y.Key.PositionID,
                Position = y.Key.Position
            });

            UserPositionView view = new UserPositionView
            {
                userPosition = positionView
            };
            return View(view);
        }

        public ActionResult Submit(string fName, string sName, string eMail, string phone, string type, string UserName, string password, string confirm)

        {
            var x = sr.addEmployee(fName,  sName,  eMail,  phone,  Convert.ToInt32(type),  UserName,  password,  confirm);
            return this.Redirect(@Url.Action("Index", "Home"));
        }
    }
}


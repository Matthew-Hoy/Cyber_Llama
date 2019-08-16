using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    CyberLlamaDatabaseDataContext db = new CyberLlamaDatabaseDataContext();
    public string Login(string strUserName, string strPassword)
    {
        try
        {
            var hash = HashUserInfo.hash(strPassword, strUserName);
            var User = db.LoginTables.Where(x => x.User_Name.Equals(strUserName) && x.Password.Equals(hash))
                    .Select(y => y).FirstOrDefault();
            if (User != null)
            {
                return User.User_ID + "," + User.User_Name + "," + User.User_Type;
            }
            else
            {
                return null;
            }
        }
        catch(Exception ex){
            return "EX";
        }
    }
}

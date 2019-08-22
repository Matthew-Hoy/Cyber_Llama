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

    public int addEmployee(string fName, string sName, string eMail, string phone, int type, string UserName, string password, string confirm)
    {

        if (password.Equals(confirm))
        {
            if(db.LoginTables.Where(x => x.User_Name.Equals(UserName)).Select(y => y.User_Name).FirstOrDefault() == null)
            {
                var newLogin = new LoginTable
                {
                    User_Name = UserName,
                    Password = HashUserInfo.hash(password, UserName),
                    User_Type = type,
                    Admin = new Admin
                    {
                        First_Name = fName,
                        Surname = sName,
                        Email = eMail,
                        Conrtact_Number = phone,
                        Position = type,
                    }  
                };
                db.LoginTables.InsertOnSubmit(newLogin);
                try
                {
                    db.SubmitChanges();
                }
                //catch exceptions
                catch (Exception ex)
                {
                    //error adding into database
                    ex.GetBaseException();
                    return -3;
                }
                //Successfully added into database
                return 1;
            }
            else
            {
                //the userName already exists
                return -1;
            }
        }
        else
        {
            //the passwords do not match
            return -2;
        }
    }
    public int addClient(string fName, string sName, string eMail, string address, string City, string Province, int ZipCode)
    {
        return 1;
    }

    public List<string> getUserPositions()
    {
        return db.UserPositions.Select(x => x.Position).ToList();
    }
}

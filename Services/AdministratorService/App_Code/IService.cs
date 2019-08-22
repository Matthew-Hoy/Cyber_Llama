﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string Login(string strUserName, string strPassword);
    [OperationContract]
    int addEmployee(string fName, string sName, string eMail, string phone, int type, string UserName, string password, string confirm);
    [OperationContract]
    int addClient(string fName, string sName, string eMail, string address, string City, string Province, int ZipCode);
    [OperationContract]
    List<string> getUserPositions();
}

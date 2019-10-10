using System;
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
    int addClient(string fName, string sName, string eMail, string address, string city, string province, string zipCode, string UserName, string password, string confirm);

    [OperationContract]
    List<string> getUserPositions();

    //Adding new Products to the DB
    [OperationContract]
    bool addAirCooler(cAirCooler newAC, int qua);

    [OperationContract]
    bool addCase(cCase newCase, int qua);

    [OperationContract]
    bool addCPU(cCPU newCPU, int qua);

    [OperationContract]
    bool addFan(cFan newFan, int qua);

    [OperationContract]
    bool addGPU(cGPU newGPU, int qua);

    [OperationContract]
    bool addHDD(cHDD newHDD, int qua);

    [OperationContract]
    bool addLiquidCooler(cLiquidCooler newLC, int qua);

    [OperationContract]
    bool addMobo(cMobo newMobo, int qua);

    [OperationContract]
    bool addPSU(cPSU newPSU, int qua);

    [OperationContract]
    bool addRAM(cRAM newRAM, int qua);

    [OperationContract]
    bool addSSD(cSSD newSSD, int qua);

    [OperationContract]
    bool addPC(cPC newPC, int qua);


    //Retrieving Products from the DB
    //One at a time
    [OperationContract]
    dynamic getPart(int ID);

    [OperationContract]
    cPC getPC(int ID);


    //Select types
    [OperationContract]
    List<cPC> getPC(String Type);

    [OperationContract]
    List<cPC> getPCbyPrice(Double minPrice, Double maxPrice);

    //Entire Table
    [OperationContract]
    List<cAirCooler> getAllAirCooler();

    [OperationContract]
    List<cCase> getAllCase();

    [OperationContract]
    List<cCPU> getAllCPU();

    [OperationContract]
    List<cFan> getAllFan();

    [OperationContract]
    List<cGPU> getAllGPU();

    [OperationContract]
    List<cHDD> getAllHDD();

    [OperationContract]
    List<cLiquidCooler> getAllLiquidCooler();

    [OperationContract]
    List<cMobo> getAllMobo();

    [OperationContract]
    List<cPSU> getAllPSU();

    [OperationContract]
    List<cRAM> getAllRAM();

    [OperationContract]
    List<cSSD> getAllSSD();

    [OperationContract]
    List<cPC> getAllPC();

    //Add to bridging table

    //Reduce Product Quantity

    //Add Amount Sold

    //Shopping Cart Operations
    [OperationContract]
    Boolean addToPartCart(int user_ID, int part_ID, int qua);

    [OperationContract]
    Boolean removeFromPartCart(int user_ID, int part_ID);

    [OperationContract]
    Boolean clearPartCart(int user_ID);

    [OperationContract]
    Boolean addToPcCart(int user_ID, int pc_ID, int qua);

    [OperationContract]
    Boolean removeFromPcCart(int user_ID, int pc_ID);

    [OperationContract]
    Boolean clearPcCart(int user_ID);

    [OperationContract]
    Boolean checkOut(int user_ID);



}

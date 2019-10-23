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
    [OperationContract]
    List<cEmployee> getAllEmployees();

    //Adding new Products to the DB
    [OperationContract]
    bool addAirCooler(cAirCooler newAC, int qua, string image);
    [OperationContract]
    bool EditAirCooler(cAirCooler newAC, PartsStock newPart, int id);
    [OperationContract]
    bool DeleteAirCooler(int id);

    [OperationContract]
    bool addCase(cCase newCase, int qua, string image);
    [OperationContract]
    bool EditCase(cCase newCase, PartsStock newPart, int id);
    [OperationContract]
    bool deleteCase(int id);


    [OperationContract]
    bool addCPU(cCPU newCPU, int qua, string image);
    [OperationContract]
    bool EditCPU(cCPU newCPU, PartsStock newPart, int id);
    [OperationContract]
    bool deleteCPU(int id);

    [OperationContract]
    bool addFan(cFan newFan, int qua, string image);
    [OperationContract]
    bool EditFan(cFan newFan, PartsStock newPart, int id);
    [OperationContract]
    bool deleteFan(int id);

    [OperationContract]
    bool addGPU(cGPU newGPU, int qua, decimal price, string image);
    [OperationContract]
    bool EditGPU(cGPU newGPU, PartsStock newPart, int id);
    [OperationContract]
    bool deleteGPU(int id);

    [OperationContract]
    bool addHDD(cHDD newHDD, int qua, string image);
    [OperationContract]
    bool EditHDD(cHDD newHDD, PartsStock newPart, int id);
    [OperationContract]
    bool deleteHDD(int id);

    [OperationContract]
    bool addHeadset(cHeadset newHeadset, int qua, string image);
    [OperationContract]
    bool EditHeadset(cHeadset newHeadset, PartsStock newPart, int id);
    [OperationContract]
    bool deleteHeadset(int id);

    [OperationContract]
    bool addKeyboard(cKeyboard newKeyboard, int qua, string image);
    [OperationContract]
    bool EditKeyboard(cKeyboard newKeyboard, PartsStock newPart, int id);
    [OperationContract]
    bool deleteKeyboard(int id);

    [OperationContract]
    bool addLiquidCooler(cLiquidCooler newLC, int qua, string image);
    [OperationContract]
    bool EditLiquidCooler(cLiquidCooler newLC, PartsStock newPart, int id);
    [OperationContract]
    bool deleteLiquidCooler(int id);

    [OperationContract]
    bool addMicrophone(cMicrophone newMicrophone, int qua, string image);
    [OperationContract]
    bool EditMicrophone(cMicrophone newMicrophone, PartsStock newPart, int id);
    [OperationContract]
    bool deleteMicrophone(int id);

    [OperationContract]
    bool addMobo(cMobo newMobo, int qua, string image);
    [OperationContract]
    bool EditMobo(cMobo newMobo, PartsStock newPart, int id);
    [OperationContract]
    bool deleteMobo(int id);

    [OperationContract]
    bool addMonitor(cMonitor newMonitor, int qua, string image);
    [OperationContract]
    bool EditMonitor(cMonitor newMonitor, PartsStock newPart, int id);
    [OperationContract]
    bool deleteMonitor(int id);

    [OperationContract]
    bool addMouse(cMouse newMouse, int qua, string image);
    [OperationContract]
    bool EditMouse(cMouse newMouse, PartsStock newPart, int id);
    [OperationContract]
    bool deleteMouse(int id);

    [OperationContract]
    bool addMousepad(cMousePad newMousepad, int qua, string image);
    [OperationContract]
    bool EditMousepad(cMousePad newMousepad, PartsStock newPart, int id);
    [OperationContract]
    bool deleteMousepad(int id);

    [OperationContract]
    bool addOS(cOS newOS, int qua, string image);
    [OperationContract]
    bool EditOS(cOS newOS, PartsStock newPart, int id);
    [OperationContract]
    bool deleteOS(int id);

    [OperationContract]
    bool addPSU(cPSU newPSU, int qua, string image);
    [OperationContract]
    bool EditPSU(cPSU newPSU, PartsStock newPart, int id);
    [OperationContract]
    bool deletePSU(int id);

    [OperationContract]
    bool addRAM(cRAM newRAM, int qua, string image);
    [OperationContract]
    bool EditRAM(cRAM newRAM, PartsStock newPart, int id);
    [OperationContract]
    bool deleteRAM(int id);

    [OperationContract]
    bool addSSD(cSSD newSSD, int qua, string image);
    [OperationContract]
    bool EditSSD(cSSD newSSD, PartsStock newPart, int id);
    [OperationContract]
    bool deleteSSD(int id);

    [OperationContract]
    bool addSpeaker(cSpeaker newSpeaker, int qua, string image);
    [OperationContract]
    bool EditSpeaker(cSpeaker newSpeaker, PartsStock newPart, int id);
    [OperationContract]
    bool deleteSpeaker(int id);

    [OperationContract]
    bool addPC(cPC newPC, int qua, string image);
    [OperationContract]
    bool EditPC(cPC newPC, PartsStock newPart, int id);
    [OperationContract]
    bool deletePC(int id);


    //Retrieving Products from the DB
    //One at a time
    [OperationContract]
    c_ProductPageInfo getPart(int ID);

    [OperationContract]
    cPC intgetPC(int ID);

    [OperationContract]
    c_PcPageInfo getPcInfo(int ID);

    [OperationContract]
    cAirCooler getAirCooler(int ID);

    [OperationContract]
    cCase getCase(int ID);

    [OperationContract]
    cCPU getCPU(int ID);

    [OperationContract]
    cFan getFan(int ID);

    [OperationContract]
    cGPU getGPU(int ID);

    [OperationContract]
    cHDD getHDD(int ID);

    [OperationContract]
    cHeadset getHeadset(int ID);

    [OperationContract]
    cLiquidCooler getLiquidCooler(int ID);

    [OperationContract]
    cMobo getMobo(int ID);

    [OperationContract]
    cPSU getPSU(int ID);

    [OperationContract]
    cRAM getRAM(int ID);

    [OperationContract]
    cSSD getSSD(int ID);

    [OperationContract]
    cKeyboard getKeyboard(int ID);

    [OperationContract]
    cMicrophone getMicrophone(int ID);

    [OperationContract]
    cSpeaker getSpeaker(int ID);

    [OperationContract]
    cMonitor getMonitor(int ID);

    [OperationContract]
    cMouse getMouse(int ID);

    [OperationContract]
    cMousePad getMousepad(int ID);

    //Select PC by Type or Price
    [OperationContract]
    List<cPC> getPCbyType(String Type);

    [OperationContract]
    List<c_PcPageInfo> getAllPCInfo(String Type);

    [OperationContract]
    List<cPC> getPCbyPrice(Double minPrice, Double maxPrice);

    //Get compatible parts
    [OperationContract]
    List<c_ProductPageInfo> getAirCoolersForCPU(int cpu_ID);

    [OperationContract]
    List<c_ProductPageInfo> getLiquidCoolersForCPU(int cpu_ID);

    [OperationContract]
    List<c_ProductPageInfo> getCPUForAirCooler(int ac_ID);

    [OperationContract]
    List<c_ProductPageInfo> getCPUForLiquidCooler(int lc_ID);

    [OperationContract]
    List<c_ProductPageInfo> getCPUForMotherboard(int mobo_ID);

    [OperationContract]
    List<c_ProductPageInfo> getCaseForMotherboard(int mobo_ID);

    [OperationContract]
    List<c_ProductPageInfo> getRAMForMotherboard(int mobo_ID);

    [OperationContract]
    List<c_ProductPageInfo> getMotherboardForCPU(int cpu_ID);

    [OperationContract]
    List<c_ProductPageInfo> getMotherboardForRAM(int ram_ID);

    [OperationContract]
    List<c_ProductPageInfo> getMotherboardForCase(int case_ID);

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
    List<cHeadset> getAllHeadset();
    [OperationContract]
    List<cMouse> getAllMouse();
    [OperationContract]
    List<cMousePad> getAllMousepad();
    [OperationContract]
    List<cKeyboard> getAllKeyboard();
    [OperationContract]
    List<cSpeaker> getAllSpeaker();
    [OperationContract]
    List<cMicrophone> getAllMicrophone();
    [OperationContract]
    List<cMonitor> getAllMonitor();


    [OperationContract]
    List<cLiquidCooler> getAllLiquidCooler();

    [OperationContract]
    List<cMobo> getAllMobo();

    [OperationContract]
    List<cPSU> getAllPSU();

    [OperationContract]
    List<cRAM> getAllRAM();

    [OperationContract]
    List<c_ProductPageInfo> getAllParts(string type);

    [OperationContract]
    List<cSSD> getAllSSD();

    [OperationContract]
    List<cPC> getAllPC();

    //Add 

    //Shopping Cart Operations
    [OperationContract]
    Boolean addToPartCart(int user_ID, int part_ID, int qua, Double total_price);

    [OperationContract]
    Boolean updatePartCart(int user_ID, int pc_ID, int qua);

    [OperationContract]
    Boolean removeFromPartCart(int user_ID, int part_ID);

    [OperationContract]
    Boolean clearPartCart(int user_ID);

    [OperationContract]
    Boolean addToPcCart(int user_ID, int pc_ID, int qua, Double total_price);

    [OperationContract]
    Boolean updatePcCart(int user_ID, int pc_ID, int qua);

    [OperationContract]
    Boolean removeFromPcCart(int user_ID, int pc_ID);

    [OperationContract]
    Boolean clearPcCart(int user_ID);

    [OperationContract]
    Boolean checkOut(int user_ID);

    [OperationContract]
    List<cAllCart> getCartItems(int user_ID);

    //user oprations
    [OperationContract]
    cClient getClient(int id);

    [OperationContract]
    List<cInvoice> getAllInvoices(int UserID);

    [OperationContract]
    bool addToPartInvoice(int UserID);
    [OperationContract]
    bool addToPcInvoice(int UserID);
    [OperationContract]
    List<cAllCart> getpcinvoice(int InvoiceID);
    [OperationContract]
    List<cAllCart> getPartInvoice(int InvoiceID);
    [OperationContract]
    bool addToPartSold(int UserID);
    [OperationContract]
    bool addToPcSold(int UserID);
    [OperationContract]
    bool decreasePartStock(int userID);
    [OperationContract]
    bool decreasePcStock(int userID);
    [OperationContract]
    List<cStock> getpcStockStats();
    [OperationContract]
    List<cSold> getpcSoldStats();
    [OperationContract]
    List<cStock> getpartStockStats();
    [OperationContract]
    List<cSold> getpartSoldStats();
    [OperationContract]
    List<cLoginStat> getLoginStats();
    [OperationContract]
    List<cRegisterStat> getRegisterStats();



}

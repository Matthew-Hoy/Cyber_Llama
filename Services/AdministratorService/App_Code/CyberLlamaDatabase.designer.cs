
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class CyberLlamaDatabaseDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertAdmin(Admin instance);
  partial void UpdateAdmin(Admin instance);
  partial void DeleteAdmin(Admin instance);
  partial void InsertUserPosition(UserPosition instance);
  partial void UpdateUserPosition(UserPosition instance);
  partial void DeleteUserPosition(UserPosition instance);
  partial void InsertAirCooler(AirCooler instance);
  partial void UpdateAirCooler(AirCooler instance);
  partial void DeleteAirCooler(AirCooler instance);
  partial void InsertClient(Client instance);
  partial void UpdateClient(Client instance);
  partial void DeleteClient(Client instance);
  partial void InsertCPU(CPU instance);
  partial void UpdateCPU(CPU instance);
  partial void DeleteCPU(CPU instance);
  partial void InsertCpuToAirCooler(CpuToAirCooler instance);
  partial void UpdateCpuToAirCooler(CpuToAirCooler instance);
  partial void DeleteCpuToAirCooler(CpuToAirCooler instance);
  partial void InsertCpuToLiquidCooler(CpuToLiquidCooler instance);
  partial void UpdateCpuToLiquidCooler(CpuToLiquidCooler instance);
  partial void DeleteCpuToLiquidCooler(CpuToLiquidCooler instance);
  partial void InsertFan(Fan instance);
  partial void UpdateFan(Fan instance);
  partial void DeleteFan(Fan instance);
  partial void InsertGPU(GPU instance);
  partial void UpdateGPU(GPU instance);
  partial void DeleteGPU(GPU instance);
  partial void InsertHDD(HDD instance);
  partial void UpdateHDD(HDD instance);
  partial void DeleteHDD(HDD instance);
  partial void InsertHeadset(Headset instance);
  partial void UpdateHeadset(Headset instance);
  partial void DeleteHeadset(Headset instance);
  partial void InsertKeyboard(Keyboard instance);
  partial void UpdateKeyboard(Keyboard instance);
  partial void DeleteKeyboard(Keyboard instance);
  partial void InsertLiquidCooler(LiquidCooler instance);
  partial void UpdateLiquidCooler(LiquidCooler instance);
  partial void DeleteLiquidCooler(LiquidCooler instance);
  partial void InsertLoginTable(LoginTable instance);
  partial void UpdateLoginTable(LoginTable instance);
  partial void DeleteLoginTable(LoginTable instance);
  partial void InsertMicrophone(Microphone instance);
  partial void UpdateMicrophone(Microphone instance);
  partial void DeleteMicrophone(Microphone instance);
  partial void InsertMoboToCase(MoboToCase instance);
  partial void UpdateMoboToCase(MoboToCase instance);
  partial void DeleteMoboToCase(MoboToCase instance);
  partial void InsertMoboToCpu(MoboToCpu instance);
  partial void UpdateMoboToCpu(MoboToCpu instance);
  partial void DeleteMoboToCpu(MoboToCpu instance);
  partial void InsertMoboToRam(MoboToRam instance);
  partial void UpdateMoboToRam(MoboToRam instance);
  partial void DeleteMoboToRam(MoboToRam instance);
  partial void InsertMonitor(Monitor instance);
  partial void UpdateMonitor(Monitor instance);
  partial void DeleteMonitor(Monitor instance);
  partial void InsertMotherboard(Motherboard instance);
  partial void UpdateMotherboard(Motherboard instance);
  partial void DeleteMotherboard(Motherboard instance);
  partial void InsertMouse(Mouse instance);
  partial void UpdateMouse(Mouse instance);
  partial void DeleteMouse(Mouse instance);
  partial void InsertMousePad(MousePad instance);
  partial void UpdateMousePad(MousePad instance);
  partial void DeleteMousePad(MousePad instance);
  partial void InsertOperatingSystem(OperatingSystem instance);
  partial void UpdateOperatingSystem(OperatingSystem instance);
  partial void DeleteOperatingSystem(OperatingSystem instance);
  partial void InsertPartsSold(PartsSold instance);
  partial void UpdatePartsSold(PartsSold instance);
  partial void DeletePartsSold(PartsSold instance);
  partial void InsertPartsStock(PartsStock instance);
  partial void UpdatePartsStock(PartsStock instance);
  partial void DeletePartsStock(PartsStock instance);
  partial void InsertPc(Pc instance);
  partial void UpdatePc(Pc instance);
  partial void DeletePc(Pc instance);
  partial void InsertPCCase(PCCase instance);
  partial void UpdatePCCase(PCCase instance);
  partial void DeletePCCase(PCCase instance);
  partial void InsertPcSold(PcSold instance);
  partial void UpdatePcSold(PcSold instance);
  partial void DeletePcSold(PcSold instance);
  partial void InsertPcStock(PcStock instance);
  partial void UpdatePcStock(PcStock instance);
  partial void DeletePcStock(PcStock instance);
  partial void InsertPSU(PSU instance);
  partial void UpdatePSU(PSU instance);
  partial void DeletePSU(PSU instance);
  partial void InsertRAM(RAM instance);
  partial void UpdateRAM(RAM instance);
  partial void DeleteRAM(RAM instance);
  partial void InsertSpeaker(Speaker instance);
  partial void UpdateSpeaker(Speaker instance);
  partial void DeleteSpeaker(Speaker instance);
  partial void InsertSSD(SSD instance);
  partial void UpdateSSD(SSD instance);
  partial void DeleteSSD(SSD instance);
  partial void InsertPartInvoice(PartInvoice instance);
  partial void UpdatePartInvoice(PartInvoice instance);
  partial void DeletePartInvoice(PartInvoice instance);
  partial void InsertPcInvoice(PcInvoice instance);
  partial void UpdatePcInvoice(PcInvoice instance);
  partial void DeletePcInvoice(PcInvoice instance);
  partial void InsertPartCart(PartCart instance);
  partial void UpdatePartCart(PartCart instance);
  partial void DeletePartCart(PartCart instance);
  partial void InsertPcCart(PcCart instance);
  partial void UpdatePcCart(PcCart instance);
  partial void DeletePcCart(PcCart instance);
  partial void InsertUserPosition1(UserPosition1 instance);
  partial void UpdateUserPosition1(UserPosition1 instance);
  partial void DeleteUserPosition1(UserPosition1 instance);
  partial void InsertAdmin1(Admin1 instance);
  partial void UpdateAdmin1(Admin1 instance);
  partial void DeleteAdmin1(Admin1 instance);
  partial void InsertAirCooler1(AirCooler1 instance);
  partial void UpdateAirCooler1(AirCooler1 instance);
  partial void DeleteAirCooler1(AirCooler1 instance);
  partial void InsertClient1(Client1 instance);
  partial void UpdateClient1(Client1 instance);
  partial void DeleteClient1(Client1 instance);
  partial void InsertCPU1(CPU1 instance);
  partial void UpdateCPU1(CPU1 instance);
  partial void DeleteCPU1(CPU1 instance);
  partial void InsertCpuToAirCooler1(CpuToAirCooler1 instance);
  partial void UpdateCpuToAirCooler1(CpuToAirCooler1 instance);
  partial void DeleteCpuToAirCooler1(CpuToAirCooler1 instance);
  partial void InsertCpuToLiquidCooler1(CpuToLiquidCooler1 instance);
  partial void UpdateCpuToLiquidCooler1(CpuToLiquidCooler1 instance);
  partial void DeleteCpuToLiquidCooler1(CpuToLiquidCooler1 instance);
  partial void InsertFan1(Fan1 instance);
  partial void UpdateFan1(Fan1 instance);
  partial void DeleteFan1(Fan1 instance);
  partial void InsertGPU1(GPU1 instance);
  partial void UpdateGPU1(GPU1 instance);
  partial void DeleteGPU1(GPU1 instance);
  partial void InsertHDD1(HDD1 instance);
  partial void UpdateHDD1(HDD1 instance);
  partial void DeleteHDD1(HDD1 instance);
  partial void InsertHeadset1(Headset1 instance);
  partial void UpdateHeadset1(Headset1 instance);
  partial void DeleteHeadset1(Headset1 instance);
  partial void InsertKeyboard1(Keyboard1 instance);
  partial void UpdateKeyboard1(Keyboard1 instance);
  partial void DeleteKeyboard1(Keyboard1 instance);
  partial void InsertLiquidCooler1(LiquidCooler1 instance);
  partial void UpdateLiquidCooler1(LiquidCooler1 instance);
  partial void DeleteLiquidCooler1(LiquidCooler1 instance);
  partial void InsertLoginTable1(LoginTable1 instance);
  partial void UpdateLoginTable1(LoginTable1 instance);
  partial void DeleteLoginTable1(LoginTable1 instance);
  partial void InsertMicrophone1(Microphone1 instance);
  partial void UpdateMicrophone1(Microphone1 instance);
  partial void DeleteMicrophone1(Microphone1 instance);
  partial void InsertMoboToCase1(MoboToCase1 instance);
  partial void UpdateMoboToCase1(MoboToCase1 instance);
  partial void DeleteMoboToCase1(MoboToCase1 instance);
  partial void InsertMoboToCpu1(MoboToCpu1 instance);
  partial void UpdateMoboToCpu1(MoboToCpu1 instance);
  partial void DeleteMoboToCpu1(MoboToCpu1 instance);
  partial void InsertMoboToRam1(MoboToRam1 instance);
  partial void UpdateMoboToRam1(MoboToRam1 instance);
  partial void DeleteMoboToRam1(MoboToRam1 instance);
  partial void InsertMonitor1(Monitor1 instance);
  partial void UpdateMonitor1(Monitor1 instance);
  partial void DeleteMonitor1(Monitor1 instance);
  partial void InsertMotherboard1(Motherboard1 instance);
  partial void UpdateMotherboard1(Motherboard1 instance);
  partial void DeleteMotherboard1(Motherboard1 instance);
  partial void InsertMouse1(Mouse1 instance);
  partial void UpdateMouse1(Mouse1 instance);
  partial void DeleteMouse1(Mouse1 instance);
  partial void InsertMousePad1(MousePad1 instance);
  partial void UpdateMousePad1(MousePad1 instance);
  partial void DeleteMousePad1(MousePad1 instance);
  partial void InsertOperatingSystem1(OperatingSystem1 instance);
  partial void UpdateOperatingSystem1(OperatingSystem1 instance);
  partial void DeleteOperatingSystem1(OperatingSystem1 instance);
  partial void InsertPartCart1(PartCart1 instance);
  partial void UpdatePartCart1(PartCart1 instance);
  partial void DeletePartCart1(PartCart1 instance);
  partial void InsertPartInvoice1(PartInvoice1 instance);
  partial void UpdatePartInvoice1(PartInvoice1 instance);
  partial void DeletePartInvoice1(PartInvoice1 instance);
  partial void InsertPartsSold1(PartsSold1 instance);
  partial void UpdatePartsSold1(PartsSold1 instance);
  partial void DeletePartsSold1(PartsSold1 instance);
  partial void InsertPartsStock1(PartsStock1 instance);
  partial void UpdatePartsStock1(PartsStock1 instance);
  partial void DeletePartsStock1(PartsStock1 instance);
  partial void InsertPc1(Pc1 instance);
  partial void UpdatePc1(Pc1 instance);
  partial void DeletePc1(Pc1 instance);
  partial void InsertPcCart1(PcCart1 instance);
  partial void UpdatePcCart1(PcCart1 instance);
  partial void DeletePcCart1(PcCart1 instance);
  partial void InsertPCCase1(PCCase1 instance);
  partial void UpdatePCCase1(PCCase1 instance);
  partial void DeletePCCase1(PCCase1 instance);
  partial void InsertPcInvoice1(PcInvoice1 instance);
  partial void UpdatePcInvoice1(PcInvoice1 instance);
  partial void DeletePcInvoice1(PcInvoice1 instance);
  partial void InsertPcSold1(PcSold1 instance);
  partial void UpdatePcSold1(PcSold1 instance);
  partial void DeletePcSold1(PcSold1 instance);
  partial void InsertPcStock1(PcStock1 instance);
  partial void UpdatePcStock1(PcStock1 instance);
  partial void DeletePcStock1(PcStock1 instance);
  partial void InsertPSU1(PSU1 instance);
  partial void UpdatePSU1(PSU1 instance);
  partial void DeletePSU1(PSU1 instance);
  partial void InsertRAM1(RAM1 instance);
  partial void UpdateRAM1(RAM1 instance);
  partial void DeleteRAM1(RAM1 instance);
  partial void InsertSpeaker1(Speaker1 instance);
  partial void UpdateSpeaker1(Speaker1 instance);
  partial void DeleteSpeaker1(Speaker1 instance);
  partial void InsertSSD1(SSD1 instance);
  partial void UpdateSSD1(SSD1 instance);
  partial void DeleteSSD1(SSD1 instance);
  #endregion
	
	public CyberLlamaDatabaseDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CyberLlamaDatabaseDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CyberLlamaDatabaseDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CyberLlamaDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CyberLlamaDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Admin> Admins
	{
		get
		{
			return this.GetTable<Admin>();
		}
	}
	
	public System.Data.Linq.Table<UserPosition> UserPositions
	{
		get
		{
			return this.GetTable<UserPosition>();
		}
	}
	
	public System.Data.Linq.Table<AirCooler> AirCoolers
	{
		get
		{
			return this.GetTable<AirCooler>();
		}
	}
	
	public System.Data.Linq.Table<Client> Clients
	{
		get
		{
			return this.GetTable<Client>();
		}
	}
	
	public System.Data.Linq.Table<CPU> CPUs
	{
		get
		{
			return this.GetTable<CPU>();
		}
	}
	
	public System.Data.Linq.Table<CpuToAirCooler> CpuToAirCoolers
	{
		get
		{
			return this.GetTable<CpuToAirCooler>();
		}
	}
	
	public System.Data.Linq.Table<CpuToLiquidCooler> CpuToLiquidCoolers
	{
		get
		{
			return this.GetTable<CpuToLiquidCooler>();
		}
	}
	
	public System.Data.Linq.Table<Fan> Fans
	{
		get
		{
			return this.GetTable<Fan>();
		}
	}
	
	public System.Data.Linq.Table<GPU> GPUs
	{
		get
		{
			return this.GetTable<GPU>();
		}
	}
	
	public System.Data.Linq.Table<HDD> HDDs
	{
		get
		{
			return this.GetTable<HDD>();
		}
	}
	
	public System.Data.Linq.Table<Headset> Headsets
	{
		get
		{
			return this.GetTable<Headset>();
		}
	}
	
	public System.Data.Linq.Table<Keyboard> Keyboards
	{
		get
		{
			return this.GetTable<Keyboard>();
		}
	}
	
	public System.Data.Linq.Table<LiquidCooler> LiquidCoolers
	{
		get
		{
			return this.GetTable<LiquidCooler>();
		}
	}
	
	public System.Data.Linq.Table<LoginTable> LoginTables
	{
		get
		{
			return this.GetTable<LoginTable>();
		}
	}
	
	public System.Data.Linq.Table<Microphone> Microphones
	{
		get
		{
			return this.GetTable<Microphone>();
		}
	}
	
	public System.Data.Linq.Table<MoboToCase> MoboToCases
	{
		get
		{
			return this.GetTable<MoboToCase>();
		}
	}
	
	public System.Data.Linq.Table<MoboToCpu> MoboToCpus
	{
		get
		{
			return this.GetTable<MoboToCpu>();
		}
	}
	
	public System.Data.Linq.Table<MoboToRam> MoboToRams
	{
		get
		{
			return this.GetTable<MoboToRam>();
		}
	}
	
	public System.Data.Linq.Table<Monitor> Monitors
	{
		get
		{
			return this.GetTable<Monitor>();
		}
	}
	
	public System.Data.Linq.Table<Motherboard> Motherboards
	{
		get
		{
			return this.GetTable<Motherboard>();
		}
	}
	
	public System.Data.Linq.Table<Mouse> Mouses
	{
		get
		{
			return this.GetTable<Mouse>();
		}
	}
	
	public System.Data.Linq.Table<MousePad> MousePads
	{
		get
		{
			return this.GetTable<MousePad>();
		}
	}
	
	public System.Data.Linq.Table<OperatingSystem> OperatingSystems
	{
		get
		{
			return this.GetTable<OperatingSystem>();
		}
	}
	
	public System.Data.Linq.Table<PartsSold> PartsSolds
	{
		get
		{
			return this.GetTable<PartsSold>();
		}
	}
	
	public System.Data.Linq.Table<PartsStock> PartsStocks
	{
		get
		{
			return this.GetTable<PartsStock>();
		}
	}
	
	public System.Data.Linq.Table<Pc> Pcs
	{
		get
		{
			return this.GetTable<Pc>();
		}
	}
	
	public System.Data.Linq.Table<PCCase> PCCases
	{
		get
		{
			return this.GetTable<PCCase>();
		}
	}
	
	public System.Data.Linq.Table<PcSold> PcSolds
	{
		get
		{
			return this.GetTable<PcSold>();
		}
	}
	
	public System.Data.Linq.Table<PcStock> PcStocks
	{
		get
		{
			return this.GetTable<PcStock>();
		}
	}
	
	public System.Data.Linq.Table<PSU> PSUs
	{
		get
		{
			return this.GetTable<PSU>();
		}
	}
	
	public System.Data.Linq.Table<RAM> RAMs
	{
		get
		{
			return this.GetTable<RAM>();
		}
	}
	
	public System.Data.Linq.Table<Speaker> Speakers
	{
		get
		{
			return this.GetTable<Speaker>();
		}
	}
	
	public System.Data.Linq.Table<SSD> SSDs
	{
		get
		{
			return this.GetTable<SSD>();
		}
	}
	
	public System.Data.Linq.Table<PartInvoice> PartInvoices
	{
		get
		{
			return this.GetTable<PartInvoice>();
		}
	}
	
	public System.Data.Linq.Table<PcInvoice> PcInvoices
	{
		get
		{
			return this.GetTable<PcInvoice>();
		}
	}
	
	public System.Data.Linq.Table<PartCart> PartCarts
	{
		get
		{
			return this.GetTable<PartCart>();
		}
	}
	
	public System.Data.Linq.Table<PcCart> PcCarts
	{
		get
		{
			return this.GetTable<PcCart>();
		}
	}
	
	public System.Data.Linq.Table<UserPosition1> UserPosition1s
	{
		get
		{
			return this.GetTable<UserPosition1>();
		}
	}
	
	public System.Data.Linq.Table<Admin1> Admin1s
	{
		get
		{
			return this.GetTable<Admin1>();
		}
	}
	
	public System.Data.Linq.Table<AirCooler1> AirCooler1s
	{
		get
		{
			return this.GetTable<AirCooler1>();
		}
	}
	
	public System.Data.Linq.Table<Client1> Client1s
	{
		get
		{
			return this.GetTable<Client1>();
		}
	}
	
	public System.Data.Linq.Table<CPU1> CPU1s
	{
		get
		{
			return this.GetTable<CPU1>();
		}
	}
	
	public System.Data.Linq.Table<CpuToAirCooler1> CpuToAirCooler1s
	{
		get
		{
			return this.GetTable<CpuToAirCooler1>();
		}
	}
	
	public System.Data.Linq.Table<CpuToLiquidCooler1> CpuToLiquidCooler1s
	{
		get
		{
			return this.GetTable<CpuToLiquidCooler1>();
		}
	}
	
	public System.Data.Linq.Table<Fan1> Fan1s
	{
		get
		{
			return this.GetTable<Fan1>();
		}
	}
	
	public System.Data.Linq.Table<GPU1> GPU1s
	{
		get
		{
			return this.GetTable<GPU1>();
		}
	}
	
	public System.Data.Linq.Table<HDD1> HDD1s
	{
		get
		{
			return this.GetTable<HDD1>();
		}
	}
	
	public System.Data.Linq.Table<Headset1> Headset1s
	{
		get
		{
			return this.GetTable<Headset1>();
		}
	}
	
	public System.Data.Linq.Table<Keyboard1> Keyboard1s
	{
		get
		{
			return this.GetTable<Keyboard1>();
		}
	}
	
	public System.Data.Linq.Table<LiquidCooler1> LiquidCooler1s
	{
		get
		{
			return this.GetTable<LiquidCooler1>();
		}
	}
	
	public System.Data.Linq.Table<LoginTable1> LoginTable1s
	{
		get
		{
			return this.GetTable<LoginTable1>();
		}
	}
	
	public System.Data.Linq.Table<Microphone1> Microphone1s
	{
		get
		{
			return this.GetTable<Microphone1>();
		}
	}
	
	public System.Data.Linq.Table<MoboToCase1> MoboToCase1s
	{
		get
		{
			return this.GetTable<MoboToCase1>();
		}
	}
	
	public System.Data.Linq.Table<MoboToCpu1> MoboToCpu1s
	{
		get
		{
			return this.GetTable<MoboToCpu1>();
		}
	}
	
	public System.Data.Linq.Table<MoboToRam1> MoboToRam1s
	{
		get
		{
			return this.GetTable<MoboToRam1>();
		}
	}
	
	public System.Data.Linq.Table<Monitor1> Monitor1s
	{
		get
		{
			return this.GetTable<Monitor1>();
		}
	}
	
	public System.Data.Linq.Table<Motherboard1> Motherboard1s
	{
		get
		{
			return this.GetTable<Motherboard1>();
		}
	}
	
	public System.Data.Linq.Table<Mouse1> Mouse1s
	{
		get
		{
			return this.GetTable<Mouse1>();
		}
	}
	
	public System.Data.Linq.Table<MousePad1> MousePad1s
	{
		get
		{
			return this.GetTable<MousePad1>();
		}
	}
	
	public System.Data.Linq.Table<OperatingSystem1> OperatingSystem1s
	{
		get
		{
			return this.GetTable<OperatingSystem1>();
		}
	}
	
	public System.Data.Linq.Table<PartCart1> PartCart1s
	{
		get
		{
			return this.GetTable<PartCart1>();
		}
	}
	
	public System.Data.Linq.Table<PartInvoice1> PartInvoice1s
	{
		get
		{
			return this.GetTable<PartInvoice1>();
		}
	}
	
	public System.Data.Linq.Table<PartsSold1> PartsSold1s
	{
		get
		{
			return this.GetTable<PartsSold1>();
		}
	}
	
	public System.Data.Linq.Table<PartsStock1> PartsStock1s
	{
		get
		{
			return this.GetTable<PartsStock1>();
		}
	}
	
	public System.Data.Linq.Table<Pc1> Pc1s
	{
		get
		{
			return this.GetTable<Pc1>();
		}
	}
	
	public System.Data.Linq.Table<PcCart1> PcCart1s
	{
		get
		{
			return this.GetTable<PcCart1>();
		}
	}
	
	public System.Data.Linq.Table<PCCase1> PCCase1s
	{
		get
		{
			return this.GetTable<PCCase1>();
		}
	}
	
	public System.Data.Linq.Table<PcInvoice1> PcInvoice1s
	{
		get
		{
			return this.GetTable<PcInvoice1>();
		}
	}
	
	public System.Data.Linq.Table<PcSold1> PcSold1s
	{
		get
		{
			return this.GetTable<PcSold1>();
		}
	}
	
	public System.Data.Linq.Table<PcStock1> PcStock1s
	{
		get
		{
			return this.GetTable<PcStock1>();
		}
	}
	
	public System.Data.Linq.Table<PSU1> PSU1s
	{
		get
		{
			return this.GetTable<PSU1>();
		}
	}
	
	public System.Data.Linq.Table<RAM1> RAM1s
	{
		get
		{
			return this.GetTable<RAM1>();
		}
	}
	
	public System.Data.Linq.Table<Speaker1> Speaker1s
	{
		get
		{
			return this.GetTable<Speaker1>();
		}
	}
	
	public System.Data.Linq.Table<SSD1> SSD1s
	{
		get
		{
			return this.GetTable<SSD1>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Admin_ID;
	
	private string _First_Name;
	
	private string _Surname;
	
	private string _Email;
	
	private string _Conrtact_Number;
	
	private int _Position;
	
	private EntityRef<UserPosition> _UserPosition;
	
	private EntityRef<LoginTable> _LoginTable;
	
	private EntityRef<UserPosition1> _UserPosition1;
	
	private EntityRef<LoginTable1> _LoginTable1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdmin_IDChanging(int value);
    partial void OnAdmin_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnConrtact_NumberChanging(string value);
    partial void OnConrtact_NumberChanged();
    partial void OnPositionChanging(int value);
    partial void OnPositionChanged();
    #endregion
	
	public Admin()
	{
		this._UserPosition = default(EntityRef<UserPosition>);
		this._LoginTable = default(EntityRef<LoginTable>);
		this._UserPosition1 = default(EntityRef<UserPosition1>);
		this._LoginTable1 = default(EntityRef<LoginTable1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Admin_ID
	{
		get
		{
			return this._Admin_ID;
		}
		set
		{
			if ((this._Admin_ID != value))
			{
				if ((this._LoginTable.HasLoadedOrAssignedValue || this._LoginTable1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAdmin_IDChanging(value);
				this.SendPropertyChanging();
				this._Admin_ID = value;
				this.SendPropertyChanged("Admin_ID");
				this.OnAdmin_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string First_Name
	{
		get
		{
			return this._First_Name;
		}
		set
		{
			if ((this._First_Name != value))
			{
				this.OnFirst_NameChanging(value);
				this.SendPropertyChanging();
				this._First_Name = value;
				this.SendPropertyChanged("First_Name");
				this.OnFirst_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._Surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Conrtact_Number", DbType="VarChar(13) NOT NULL", CanBeNull=false)]
	public string Conrtact_Number
	{
		get
		{
			return this._Conrtact_Number;
		}
		set
		{
			if ((this._Conrtact_Number != value))
			{
				this.OnConrtact_NumberChanging(value);
				this.SendPropertyChanging();
				this._Conrtact_Number = value;
				this.SendPropertyChanged("Conrtact_Number");
				this.OnConrtact_NumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="Int NOT NULL")]
	public int Position
	{
		get
		{
			return this._Position;
		}
		set
		{
			if ((this._Position != value))
			{
				if ((this._UserPosition.HasLoadedOrAssignedValue || this._UserPosition1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPositionChanging(value);
				this.SendPropertyChanging();
				this._Position = value;
				this.SendPropertyChanged("Position");
				this.OnPositionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition_Admin", Storage="_UserPosition", ThisKey="Position", OtherKey="PositionID", IsForeignKey=true)]
	public UserPosition UserPosition
	{
		get
		{
			return this._UserPosition.Entity;
		}
		set
		{
			UserPosition previousValue = this._UserPosition.Entity;
			if (((previousValue != value) 
						|| (this._UserPosition.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._UserPosition.Entity = null;
					previousValue.Admins.Remove(this);
				}
				this._UserPosition.Entity = value;
				if ((value != null))
				{
					value.Admins.Add(this);
					this._Position = value.PositionID;
				}
				else
				{
					this._Position = default(int);
				}
				this.SendPropertyChanged("UserPosition");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Admin", Storage="_LoginTable", ThisKey="Admin_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable LoginTable
	{
		get
		{
			return this._LoginTable.Entity;
		}
		set
		{
			LoginTable previousValue = this._LoginTable.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable.Entity = null;
					previousValue.Admin = null;
				}
				this._LoginTable.Entity = value;
				if ((value != null))
				{
					value.Admin = this;
					this._Admin_ID = value.User_ID;
				}
				else
				{
					this._Admin_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition1_Admin", Storage="_UserPosition1", ThisKey="Position", OtherKey="PositionID", IsForeignKey=true)]
	public UserPosition1 UserPosition1
	{
		get
		{
			return this._UserPosition1.Entity;
		}
		set
		{
			UserPosition1 previousValue = this._UserPosition1.Entity;
			if (((previousValue != value) 
						|| (this._UserPosition1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._UserPosition1.Entity = null;
					previousValue.Admins.Remove(this);
				}
				this._UserPosition1.Entity = value;
				if ((value != null))
				{
					value.Admins.Add(this);
					this._Position = value.PositionID;
				}
				else
				{
					this._Position = default(int);
				}
				this.SendPropertyChanged("UserPosition1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Admin", Storage="_LoginTable1", ThisKey="Admin_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable1 LoginTable1
	{
		get
		{
			return this._LoginTable1.Entity;
		}
		set
		{
			LoginTable1 previousValue = this._LoginTable1.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable1.Entity = null;
					previousValue.Admin = null;
				}
				this._LoginTable1.Entity = value;
				if ((value != null))
				{
					value.Admin = this;
					this._Admin_ID = value.User_ID;
				}
				else
				{
					this._Admin_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPosition")]
public partial class UserPosition : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PositionID;
	
	private string _Position;
	
	private EntitySet<Admin> _Admins;
	
	private EntitySet<Admin1> _Admin1s;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPositionIDChanging(int value);
    partial void OnPositionIDChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    #endregion
	
	public UserPosition()
	{
		this._Admins = new EntitySet<Admin>(new Action<Admin>(this.attach_Admins), new Action<Admin>(this.detach_Admins));
		this._Admin1s = new EntitySet<Admin1>(new Action<Admin1>(this.attach_Admin1s), new Action<Admin1>(this.detach_Admin1s));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PositionID
	{
		get
		{
			return this._PositionID;
		}
		set
		{
			if ((this._PositionID != value))
			{
				this.OnPositionIDChanging(value);
				this.SendPropertyChanging();
				this._PositionID = value;
				this.SendPropertyChanged("PositionID");
				this.OnPositionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Position
	{
		get
		{
			return this._Position;
		}
		set
		{
			if ((this._Position != value))
			{
				this.OnPositionChanging(value);
				this.SendPropertyChanging();
				this._Position = value;
				this.SendPropertyChanged("Position");
				this.OnPositionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition_Admin", Storage="_Admins", ThisKey="PositionID", OtherKey="Position")]
	public EntitySet<Admin> Admins
	{
		get
		{
			return this._Admins;
		}
		set
		{
			this._Admins.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition_Admin1", Storage="_Admin1s", ThisKey="PositionID", OtherKey="Position")]
	public EntitySet<Admin1> Admin1s
	{
		get
		{
			return this._Admin1s;
		}
		set
		{
			this._Admin1s.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Admins(Admin entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition = this;
	}
	
	private void detach_Admins(Admin entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition = null;
	}
	
	private void attach_Admin1s(Admin1 entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition = this;
	}
	
	private void detach_Admin1s(Admin1 entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AirCooler")]
public partial class AirCooler : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Fan_Size;
	
	private string _Compatibility;
	
	private string _Fan_RPM;
	
	private string _Air_Flow;
	
	private string _Noise_Level;
	
	private string _Power_Connector;
	
	private string _Colour;
	
	private string _Materials;
	
	private string _Length;
	
	private string _Height;
	
	private string _Width;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<CpuToAirCooler> _CpuToAirCoolers;
	
	private EntitySet<CpuToAirCooler1> _CpuToAirCooler1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnCompatibilityChanging(string value);
    partial void OnCompatibilityChanged();
    partial void OnFan_RPMChanging(string value);
    partial void OnFan_RPMChanged();
    partial void OnAir_FlowChanging(string value);
    partial void OnAir_FlowChanged();
    partial void OnNoise_LevelChanging(string value);
    partial void OnNoise_LevelChanged();
    partial void OnPower_ConnectorChanging(string value);
    partial void OnPower_ConnectorChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWidthChanging(string value);
    partial void OnWidthChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public AirCooler()
	{
		this._CpuToAirCoolers = new EntitySet<CpuToAirCooler>(new Action<CpuToAirCooler>(this.attach_CpuToAirCoolers), new Action<CpuToAirCooler>(this.detach_CpuToAirCoolers));
		this._CpuToAirCooler1s = new EntitySet<CpuToAirCooler1>(new Action<CpuToAirCooler1>(this.attach_CpuToAirCooler1s), new Action<CpuToAirCooler1>(this.detach_CpuToAirCooler1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Compatibility", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Compatibility
	{
		get
		{
			return this._Compatibility;
		}
		set
		{
			if ((this._Compatibility != value))
			{
				this.OnCompatibilityChanging(value);
				this.SendPropertyChanging();
				this._Compatibility = value;
				this.SendPropertyChanged("Compatibility");
				this.OnCompatibilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_RPM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_RPM
	{
		get
		{
			return this._Fan_RPM;
		}
		set
		{
			if ((this._Fan_RPM != value))
			{
				this.OnFan_RPMChanging(value);
				this.SendPropertyChanging();
				this._Fan_RPM = value;
				this.SendPropertyChanged("Fan_RPM");
				this.OnFan_RPMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Air_Flow", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Air_Flow
	{
		get
		{
			return this._Air_Flow;
		}
		set
		{
			if ((this._Air_Flow != value))
			{
				this.OnAir_FlowChanging(value);
				this.SendPropertyChanging();
				this._Air_Flow = value;
				this.SendPropertyChanged("Air_Flow");
				this.OnAir_FlowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noise_Level", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Noise_Level
	{
		get
		{
			return this._Noise_Level;
		}
		set
		{
			if ((this._Noise_Level != value))
			{
				this.OnNoise_LevelChanging(value);
				this.SendPropertyChanging();
				this._Noise_Level = value;
				this.SendPropertyChanged("Noise_Level");
				this.OnNoise_LevelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power_Connector", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power_Connector
	{
		get
		{
			return this._Power_Connector;
		}
		set
		{
			if ((this._Power_Connector != value))
			{
				this.OnPower_ConnectorChanging(value);
				this.SendPropertyChanging();
				this._Power_Connector = value;
				this.SendPropertyChanged("Power_Connector");
				this.OnPower_ConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Materials
	{
		get
		{
			return this._Materials;
		}
		set
		{
			if ((this._Materials != value))
			{
				this.OnMaterialsChanging(value);
				this.SendPropertyChanging();
				this._Materials = value;
				this.SendPropertyChanged("Materials");
				this.OnMaterialsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Width
	{
		get
		{
			return this._Width;
		}
		set
		{
			if ((this._Width != value))
			{
				this.OnWidthChanging(value);
				this.SendPropertyChanging();
				this._Width = value;
				this.SendPropertyChanged("Width");
				this.OnWidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler_CpuToAirCooler", Storage="_CpuToAirCoolers", ThisKey="ID", OtherKey="AC_ID")]
	public EntitySet<CpuToAirCooler> CpuToAirCoolers
	{
		get
		{
			return this._CpuToAirCoolers;
		}
		set
		{
			this._CpuToAirCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler_CpuToAirCooler1", Storage="_CpuToAirCooler1s", ThisKey="ID", OtherKey="AC_ID")]
	public EntitySet<CpuToAirCooler1> CpuToAirCooler1s
	{
		get
		{
			return this._CpuToAirCooler1s;
		}
		set
		{
			this._CpuToAirCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_AirCooler", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.AirCooler = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.AirCooler = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_AirCooler", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.AirCooler = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.AirCooler = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler = this;
	}
	
	private void detach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler = null;
	}
	
	private void attach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler = this;
	}
	
	private void detach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private string _First_Name;
	
	private string _Surname;
	
	private string _Email;
	
	private string _Address;
	
	private string _City;
	
	private string _Province;
	
	private string _ZIP_Code;
	
	private EntitySet<PartInvoice> _PartInvoices;
	
	private EntitySet<PcInvoice> _PcInvoices;
	
	private EntitySet<PartCart> _PartCarts;
	
	private EntitySet<PcCart> _PcCarts;
	
	private EntitySet<PartCart1> _PartCart1s;
	
	private EntitySet<PartInvoice1> _PartInvoice1s;
	
	private EntitySet<PcCart1> _PcCart1s;
	
	private EntitySet<PcInvoice1> _PcInvoice1s;
	
	private EntityRef<LoginTable> _LoginTable;
	
	private EntityRef<LoginTable1> _LoginTable1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnProvinceChanging(string value);
    partial void OnProvinceChanged();
    partial void OnZIP_CodeChanging(string value);
    partial void OnZIP_CodeChanged();
    #endregion
	
	public Client()
	{
		this._PartInvoices = new EntitySet<PartInvoice>(new Action<PartInvoice>(this.attach_PartInvoices), new Action<PartInvoice>(this.detach_PartInvoices));
		this._PcInvoices = new EntitySet<PcInvoice>(new Action<PcInvoice>(this.attach_PcInvoices), new Action<PcInvoice>(this.detach_PcInvoices));
		this._PartCarts = new EntitySet<PartCart>(new Action<PartCart>(this.attach_PartCarts), new Action<PartCart>(this.detach_PartCarts));
		this._PcCarts = new EntitySet<PcCart>(new Action<PcCart>(this.attach_PcCarts), new Action<PcCart>(this.detach_PcCarts));
		this._PartCart1s = new EntitySet<PartCart1>(new Action<PartCart1>(this.attach_PartCart1s), new Action<PartCart1>(this.detach_PartCart1s));
		this._PartInvoice1s = new EntitySet<PartInvoice1>(new Action<PartInvoice1>(this.attach_PartInvoice1s), new Action<PartInvoice1>(this.detach_PartInvoice1s));
		this._PcCart1s = new EntitySet<PcCart1>(new Action<PcCart1>(this.attach_PcCart1s), new Action<PcCart1>(this.detach_PcCart1s));
		this._PcInvoice1s = new EntitySet<PcInvoice1>(new Action<PcInvoice1>(this.attach_PcInvoice1s), new Action<PcInvoice1>(this.detach_PcInvoice1s));
		this._LoginTable = default(EntityRef<LoginTable>);
		this._LoginTable1 = default(EntityRef<LoginTable1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._LoginTable.HasLoadedOrAssignedValue || this._LoginTable1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string First_Name
	{
		get
		{
			return this._First_Name;
		}
		set
		{
			if ((this._First_Name != value))
			{
				this.OnFirst_NameChanging(value);
				this.SendPropertyChanging();
				this._First_Name = value;
				this.SendPropertyChanged("First_Name");
				this.OnFirst_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._Surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Province", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Province
	{
		get
		{
			return this._Province;
		}
		set
		{
			if ((this._Province != value))
			{
				this.OnProvinceChanging(value);
				this.SendPropertyChanging();
				this._Province = value;
				this.SendPropertyChanged("Province");
				this.OnProvinceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZIP_Code", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string ZIP_Code
	{
		get
		{
			return this._ZIP_Code;
		}
		set
		{
			if ((this._ZIP_Code != value))
			{
				this.OnZIP_CodeChanging(value);
				this.SendPropertyChanging();
				this._ZIP_Code = value;
				this.SendPropertyChanged("ZIP_Code");
				this.OnZIP_CodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartInvoice", Storage="_PartInvoices", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartInvoice> PartInvoices
	{
		get
		{
			return this._PartInvoices;
		}
		set
		{
			this._PartInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcInvoice", Storage="_PcInvoices", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcInvoice> PcInvoices
	{
		get
		{
			return this._PcInvoices;
		}
		set
		{
			this._PcInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartCart", Storage="_PartCarts", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartCart> PartCarts
	{
		get
		{
			return this._PartCarts;
		}
		set
		{
			this._PartCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcCart", Storage="_PcCarts", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcCart> PcCarts
	{
		get
		{
			return this._PcCarts;
		}
		set
		{
			this._PcCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartCart1", Storage="_PartCart1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartCart1> PartCart1s
	{
		get
		{
			return this._PartCart1s;
		}
		set
		{
			this._PartCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartInvoice1", Storage="_PartInvoice1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartInvoice1> PartInvoice1s
	{
		get
		{
			return this._PartInvoice1s;
		}
		set
		{
			this._PartInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcCart1", Storage="_PcCart1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcCart1> PcCart1s
	{
		get
		{
			return this._PcCart1s;
		}
		set
		{
			this._PcCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcInvoice1", Storage="_PcInvoice1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcInvoice1> PcInvoice1s
	{
		get
		{
			return this._PcInvoice1s;
		}
		set
		{
			this._PcInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Client", Storage="_LoginTable", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable LoginTable
	{
		get
		{
			return this._LoginTable.Entity;
		}
		set
		{
			LoginTable previousValue = this._LoginTable.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable.Entity = null;
					previousValue.Client = null;
				}
				this._LoginTable.Entity = value;
				if ((value != null))
				{
					value.Client = this;
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Client", Storage="_LoginTable1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable1 LoginTable1
	{
		get
		{
			return this._LoginTable1.Entity;
		}
		set
		{
			LoginTable1 previousValue = this._LoginTable1.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable1.Entity = null;
					previousValue.Client = null;
				}
				this._LoginTable1.Entity = value;
				if ((value != null))
				{
					value.Client = this;
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
	
	private void attach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = this;
	}
	
	private void detach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CPU")]
public partial class CPU : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Cores;
	
	private string _Threads;
	
	private string _Base_Clock;
	
	private string _Boost_Clock;
	
	private string _Total_Cache;
	
	private string _Chipset;
	
	private string _TDP;
	
	private string _Max_Temp;
	
	private int _System_Memory_Speed;
	
	private string _System_Memory_Type;
	
	private string _Memory_Channels;
	
	private string _Warranty;
	
	private EntitySet<CpuToAirCooler> _CpuToAirCoolers;
	
	private EntitySet<CpuToLiquidCooler> _CpuToLiquidCoolers;
	
	private EntitySet<MoboToCpu> _MoboToCpus;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<CpuToAirCooler1> _CpuToAirCooler1s;
	
	private EntitySet<CpuToLiquidCooler1> _CpuToLiquidCooler1s;
	
	private EntitySet<MoboToCpu1> _MoboToCpu1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCoresChanging(string value);
    partial void OnCoresChanged();
    partial void OnThreadsChanging(string value);
    partial void OnThreadsChanged();
    partial void OnBase_ClockChanging(string value);
    partial void OnBase_ClockChanged();
    partial void OnBoost_ClockChanging(string value);
    partial void OnBoost_ClockChanged();
    partial void OnTotal_CacheChanging(string value);
    partial void OnTotal_CacheChanged();
    partial void OnChipsetChanging(string value);
    partial void OnChipsetChanged();
    partial void OnTDPChanging(string value);
    partial void OnTDPChanged();
    partial void OnMax_TempChanging(string value);
    partial void OnMax_TempChanged();
    partial void OnSystem_Memory_SpeedChanging(int value);
    partial void OnSystem_Memory_SpeedChanged();
    partial void OnSystem_Memory_TypeChanging(string value);
    partial void OnSystem_Memory_TypeChanged();
    partial void OnMemory_ChannelsChanging(string value);
    partial void OnMemory_ChannelsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public CPU()
	{
		this._CpuToAirCoolers = new EntitySet<CpuToAirCooler>(new Action<CpuToAirCooler>(this.attach_CpuToAirCoolers), new Action<CpuToAirCooler>(this.detach_CpuToAirCoolers));
		this._CpuToLiquidCoolers = new EntitySet<CpuToLiquidCooler>(new Action<CpuToLiquidCooler>(this.attach_CpuToLiquidCoolers), new Action<CpuToLiquidCooler>(this.detach_CpuToLiquidCoolers));
		this._MoboToCpus = new EntitySet<MoboToCpu>(new Action<MoboToCpu>(this.attach_MoboToCpus), new Action<MoboToCpu>(this.detach_MoboToCpus));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._CpuToAirCooler1s = new EntitySet<CpuToAirCooler1>(new Action<CpuToAirCooler1>(this.attach_CpuToAirCooler1s), new Action<CpuToAirCooler1>(this.detach_CpuToAirCooler1s));
		this._CpuToLiquidCooler1s = new EntitySet<CpuToLiquidCooler1>(new Action<CpuToLiquidCooler1>(this.attach_CpuToLiquidCooler1s), new Action<CpuToLiquidCooler1>(this.detach_CpuToLiquidCooler1s));
		this._MoboToCpu1s = new EntitySet<MoboToCpu1>(new Action<MoboToCpu1>(this.attach_MoboToCpu1s), new Action<MoboToCpu1>(this.detach_MoboToCpu1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cores", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cores
	{
		get
		{
			return this._Cores;
		}
		set
		{
			if ((this._Cores != value))
			{
				this.OnCoresChanging(value);
				this.SendPropertyChanging();
				this._Cores = value;
				this.SendPropertyChanged("Cores");
				this.OnCoresChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Threads", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Threads
	{
		get
		{
			return this._Threads;
		}
		set
		{
			if ((this._Threads != value))
			{
				this.OnThreadsChanging(value);
				this.SendPropertyChanging();
				this._Threads = value;
				this.SendPropertyChanged("Threads");
				this.OnThreadsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base_Clock
	{
		get
		{
			return this._Base_Clock;
		}
		set
		{
			if ((this._Base_Clock != value))
			{
				this.OnBase_ClockChanging(value);
				this.SendPropertyChanging();
				this._Base_Clock = value;
				this.SendPropertyChanged("Base_Clock");
				this.OnBase_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Boost_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Boost_Clock
	{
		get
		{
			return this._Boost_Clock;
		}
		set
		{
			if ((this._Boost_Clock != value))
			{
				this.OnBoost_ClockChanging(value);
				this.SendPropertyChanging();
				this._Boost_Clock = value;
				this.SendPropertyChanged("Boost_Clock");
				this.OnBoost_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Cache", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Total_Cache
	{
		get
		{
			return this._Total_Cache;
		}
		set
		{
			if ((this._Total_Cache != value))
			{
				this.OnTotal_CacheChanging(value);
				this.SendPropertyChanging();
				this._Total_Cache = value;
				this.SendPropertyChanged("Total_Cache");
				this.OnTotal_CacheChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chipset", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Chipset
	{
		get
		{
			return this._Chipset;
		}
		set
		{
			if ((this._Chipset != value))
			{
				this.OnChipsetChanging(value);
				this.SendPropertyChanging();
				this._Chipset = value;
				this.SendPropertyChanged("Chipset");
				this.OnChipsetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string TDP
	{
		get
		{
			return this._TDP;
		}
		set
		{
			if ((this._TDP != value))
			{
				this.OnTDPChanging(value);
				this.SendPropertyChanging();
				this._TDP = value;
				this.SendPropertyChanged("TDP");
				this.OnTDPChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Temp
	{
		get
		{
			return this._Max_Temp;
		}
		set
		{
			if ((this._Max_Temp != value))
			{
				this.OnMax_TempChanging(value);
				this.SendPropertyChanging();
				this._Max_Temp = value;
				this.SendPropertyChanged("Max_Temp");
				this.OnMax_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Memory_Speed", DbType="Int NOT NULL")]
	public int System_Memory_Speed
	{
		get
		{
			return this._System_Memory_Speed;
		}
		set
		{
			if ((this._System_Memory_Speed != value))
			{
				this.OnSystem_Memory_SpeedChanging(value);
				this.SendPropertyChanging();
				this._System_Memory_Speed = value;
				this.SendPropertyChanged("System_Memory_Speed");
				this.OnSystem_Memory_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Memory_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string System_Memory_Type
	{
		get
		{
			return this._System_Memory_Type;
		}
		set
		{
			if ((this._System_Memory_Type != value))
			{
				this.OnSystem_Memory_TypeChanging(value);
				this.SendPropertyChanging();
				this._System_Memory_Type = value;
				this.SendPropertyChanged("System_Memory_Type");
				this.OnSystem_Memory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Channels", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Channels
	{
		get
		{
			return this._Memory_Channels;
		}
		set
		{
			if ((this._Memory_Channels != value))
			{
				this.OnMemory_ChannelsChanging(value);
				this.SendPropertyChanging();
				this._Memory_Channels = value;
				this.SendPropertyChanged("Memory_Channels");
				this.OnMemory_ChannelsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToAirCooler", Storage="_CpuToAirCoolers", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToAirCooler> CpuToAirCoolers
	{
		get
		{
			return this._CpuToAirCoolers;
		}
		set
		{
			this._CpuToAirCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToLiquidCooler", Storage="_CpuToLiquidCoolers", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToLiquidCooler> CpuToLiquidCoolers
	{
		get
		{
			return this._CpuToLiquidCoolers;
		}
		set
		{
			this._CpuToLiquidCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_MoboToCpu", Storage="_MoboToCpus", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<MoboToCpu> MoboToCpus
	{
		get
		{
			return this._MoboToCpus;
		}
		set
		{
			this._MoboToCpus.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToAirCooler1", Storage="_CpuToAirCooler1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToAirCooler1> CpuToAirCooler1s
	{
		get
		{
			return this._CpuToAirCooler1s;
		}
		set
		{
			this._CpuToAirCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToLiquidCooler1", Storage="_CpuToLiquidCooler1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToLiquidCooler1> CpuToLiquidCooler1s
	{
		get
		{
			return this._CpuToLiquidCooler1s;
		}
		set
		{
			this._CpuToLiquidCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_MoboToCpu1", Storage="_MoboToCpu1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<MoboToCpu1> MoboToCpu1s
	{
		get
		{
			return this._MoboToCpu1s;
		}
		set
		{
			this._MoboToCpu1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_CPU", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.CPU = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.CPU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_CPU", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.CPU = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.CPU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CpuToAirCooler")]
public partial class CpuToAirCooler : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CPU_ID;
	
	private int _AC_ID;
	
	private EntityRef<AirCooler> _AirCooler;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<AirCooler1> _AirCooler1;
	
	private EntityRef<CPU1> _CPU1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnAC_IDChanging(int value);
    partial void OnAC_IDChanged();
    #endregion
	
	public CpuToAirCooler()
	{
		this._AirCooler = default(EntityRef<AirCooler>);
		this._CPU = default(EntityRef<CPU>);
		this._AirCooler1 = default(EntityRef<AirCooler1>);
		this._CPU1 = default(EntityRef<CPU1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int AC_ID
	{
		get
		{
			return this._AC_ID;
		}
		set
		{
			if ((this._AC_ID != value))
			{
				if ((this._AirCooler.HasLoadedOrAssignedValue || this._AirCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAC_IDChanging(value);
				this.SendPropertyChanging();
				this._AC_ID = value;
				this.SendPropertyChanged("AC_ID");
				this.OnAC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler_CpuToAirCooler", Storage="_AirCooler", ThisKey="AC_ID", OtherKey="ID", IsForeignKey=true)]
	public AirCooler AirCooler
	{
		get
		{
			return this._AirCooler.Entity;
		}
		set
		{
			AirCooler previousValue = this._AirCooler.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler.Entity = null;
					previousValue.CpuToAirCoolers.Remove(this);
				}
				this._AirCooler.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCoolers.Add(this);
					this._AC_ID = value.ID;
				}
				else
				{
					this._AC_ID = default(int);
				}
				this.SendPropertyChanged("AirCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToAirCooler", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.CpuToAirCoolers.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCoolers.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler1_CpuToAirCooler", Storage="_AirCooler1", ThisKey="AC_ID", OtherKey="ID", IsForeignKey=true)]
	public AirCooler1 AirCooler1
	{
		get
		{
			return this._AirCooler1.Entity;
		}
		set
		{
			AirCooler1 previousValue = this._AirCooler1.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler1.Entity = null;
					previousValue.CpuToAirCoolers.Remove(this);
				}
				this._AirCooler1.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCoolers.Add(this);
					this._AC_ID = value.ID;
				}
				else
				{
					this._AC_ID = default(int);
				}
				this.SendPropertyChanged("AirCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToAirCooler", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.CpuToAirCoolers.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCoolers.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CpuToLiquidCooler")]
public partial class CpuToLiquidCooler : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CPU_ID;
	
	private int _LC_ID;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnLC_IDChanging(int value);
    partial void OnLC_IDChanged();
    #endregion
	
	public CpuToLiquidCooler()
	{
		this._CPU = default(EntityRef<CPU>);
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int LC_ID
	{
		get
		{
			return this._LC_ID;
		}
		set
		{
			if ((this._LC_ID != value))
			{
				if ((this._LiquidCooler.HasLoadedOrAssignedValue || this._LiquidCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnLC_IDChanging(value);
				this.SendPropertyChanging();
				this._LC_ID = value;
				this.SendPropertyChanged("LC_ID");
				this.OnLC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToLiquidCooler", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.CpuToLiquidCoolers.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCoolers.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_CpuToLiquidCooler", Storage="_LiquidCooler", ThisKey="LC_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.CpuToLiquidCoolers.Remove(this);
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCoolers.Add(this);
					this._LC_ID = value.ID;
				}
				else
				{
					this._LC_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToLiquidCooler", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.CpuToLiquidCoolers.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCoolers.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_CpuToLiquidCooler", Storage="_LiquidCooler1", ThisKey="LC_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.CpuToLiquidCoolers.Remove(this);
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCoolers.Add(this);
					this._LC_ID = value.ID;
				}
				else
				{
					this._LC_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fans")]
public partial class Fan : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Size;
	
	private string _RPM;
	
	private string _Max_Air_Flow;
	
	private string _Noise;
	
	private string _Static_Pressure;
	
	private string _Input_Voltage;
	
	private string _MTBF;
	
	private string _Cable_Length;
	
	private int _Num_Fans;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnRPMChanging(string value);
    partial void OnRPMChanged();
    partial void OnMax_Air_FlowChanging(string value);
    partial void OnMax_Air_FlowChanged();
    partial void OnNoiseChanging(string value);
    partial void OnNoiseChanged();
    partial void OnStatic_PressureChanging(string value);
    partial void OnStatic_PressureChanged();
    partial void OnInput_VoltageChanging(string value);
    partial void OnInput_VoltageChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnNum_FansChanging(int value);
    partial void OnNum_FansChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Fan()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RPM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string RPM
	{
		get
		{
			return this._RPM;
		}
		set
		{
			if ((this._RPM != value))
			{
				this.OnRPMChanging(value);
				this.SendPropertyChanging();
				this._RPM = value;
				this.SendPropertyChanged("RPM");
				this.OnRPMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Air_Flow", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Air_Flow
	{
		get
		{
			return this._Max_Air_Flow;
		}
		set
		{
			if ((this._Max_Air_Flow != value))
			{
				this.OnMax_Air_FlowChanging(value);
				this.SendPropertyChanging();
				this._Max_Air_Flow = value;
				this.SendPropertyChanged("Max_Air_Flow");
				this.OnMax_Air_FlowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noise", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Noise
	{
		get
		{
			return this._Noise;
		}
		set
		{
			if ((this._Noise != value))
			{
				this.OnNoiseChanging(value);
				this.SendPropertyChanging();
				this._Noise = value;
				this.SendPropertyChanged("Noise");
				this.OnNoiseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Static_Pressure", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Static_Pressure
	{
		get
		{
			return this._Static_Pressure;
		}
		set
		{
			if ((this._Static_Pressure != value))
			{
				this.OnStatic_PressureChanging(value);
				this.SendPropertyChanging();
				this._Static_Pressure = value;
				this.SendPropertyChanged("Static_Pressure");
				this.OnStatic_PressureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Input_Voltage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Input_Voltage
	{
		get
		{
			return this._Input_Voltage;
		}
		set
		{
			if ((this._Input_Voltage != value))
			{
				this.OnInput_VoltageChanging(value);
				this.SendPropertyChanging();
				this._Input_Voltage = value;
				this.SendPropertyChanged("Input_Voltage");
				this.OnInput_VoltageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Fans", DbType="Int NOT NULL")]
	public int Num_Fans
	{
		get
		{
			return this._Num_Fans;
		}
		set
		{
			if ((this._Num_Fans != value))
			{
				this.OnNum_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Fans = value;
				this.SendPropertyChanged("Num_Fans");
				this.OnNum_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Fan_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Fan_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Fan", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Fan = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Fan = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Fan", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Fan = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Fan = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Fan = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Fan = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Fan = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Fan = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GPU")]
public partial class GPU : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Manufacturer;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Base_Clock_Speed;
	
	private string _Boost_Clock_Speed;
	
	private string _Stream_Processors;
	
	private string _Memory_Clock;
	
	private string _Memory_Size;
	
	private string _Memory_Type;
	
	private string _Ports;
	
	private string _Max_Digital_Resolution;
	
	private string _VR_Ready;
	
	private string _Recommended_Power_Supply;
	
	private string _Form_Factor;
	
	private string _Slot_Width;
	
	private string _Length;
	
	private string _Height;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnBase_Clock_SpeedChanging(string value);
    partial void OnBase_Clock_SpeedChanged();
    partial void OnBoost_Clock_SpeedChanging(string value);
    partial void OnBoost_Clock_SpeedChanged();
    partial void OnStream_ProcessorsChanging(string value);
    partial void OnStream_ProcessorsChanged();
    partial void OnMemory_ClockChanging(string value);
    partial void OnMemory_ClockChanged();
    partial void OnMemory_SizeChanging(string value);
    partial void OnMemory_SizeChanged();
    partial void OnMemory_TypeChanging(string value);
    partial void OnMemory_TypeChanged();
    partial void OnPortsChanging(string value);
    partial void OnPortsChanged();
    partial void OnMax_Digital_ResolutionChanging(string value);
    partial void OnMax_Digital_ResolutionChanged();
    partial void OnVR_ReadyChanging(string value);
    partial void OnVR_ReadyChanged();
    partial void OnRecommended_Power_SupplyChanging(string value);
    partial void OnRecommended_Power_SupplyChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnSlot_WidthChanging(string value);
    partial void OnSlot_WidthChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public GPU()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Manufacturer
	{
		get
		{
			return this._Manufacturer;
		}
		set
		{
			if ((this._Manufacturer != value))
			{
				this.OnManufacturerChanging(value);
				this.SendPropertyChanging();
				this._Manufacturer = value;
				this.SendPropertyChanged("Manufacturer");
				this.OnManufacturerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base_Clock_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base_Clock_Speed
	{
		get
		{
			return this._Base_Clock_Speed;
		}
		set
		{
			if ((this._Base_Clock_Speed != value))
			{
				this.OnBase_Clock_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Base_Clock_Speed = value;
				this.SendPropertyChanged("Base_Clock_Speed");
				this.OnBase_Clock_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Boost_Clock_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Boost_Clock_Speed
	{
		get
		{
			return this._Boost_Clock_Speed;
		}
		set
		{
			if ((this._Boost_Clock_Speed != value))
			{
				this.OnBoost_Clock_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Boost_Clock_Speed = value;
				this.SendPropertyChanged("Boost_Clock_Speed");
				this.OnBoost_Clock_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stream_Processors", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Stream_Processors
	{
		get
		{
			return this._Stream_Processors;
		}
		set
		{
			if ((this._Stream_Processors != value))
			{
				this.OnStream_ProcessorsChanging(value);
				this.SendPropertyChanging();
				this._Stream_Processors = value;
				this.SendPropertyChanged("Stream_Processors");
				this.OnStream_ProcessorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Clock
	{
		get
		{
			return this._Memory_Clock;
		}
		set
		{
			if ((this._Memory_Clock != value))
			{
				this.OnMemory_ClockChanging(value);
				this.SendPropertyChanging();
				this._Memory_Clock = value;
				this.SendPropertyChanged("Memory_Clock");
				this.OnMemory_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Size
	{
		get
		{
			return this._Memory_Size;
		}
		set
		{
			if ((this._Memory_Size != value))
			{
				this.OnMemory_SizeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Size = value;
				this.SendPropertyChanged("Memory_Size");
				this.OnMemory_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Type
	{
		get
		{
			return this._Memory_Type;
		}
		set
		{
			if ((this._Memory_Type != value))
			{
				this.OnMemory_TypeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Type = value;
				this.SendPropertyChanged("Memory_Type");
				this.OnMemory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ports", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Ports
	{
		get
		{
			return this._Ports;
		}
		set
		{
			if ((this._Ports != value))
			{
				this.OnPortsChanging(value);
				this.SendPropertyChanging();
				this._Ports = value;
				this.SendPropertyChanged("Ports");
				this.OnPortsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Digital_Resolution", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Max_Digital_Resolution
	{
		get
		{
			return this._Max_Digital_Resolution;
		}
		set
		{
			if ((this._Max_Digital_Resolution != value))
			{
				this.OnMax_Digital_ResolutionChanging(value);
				this.SendPropertyChanging();
				this._Max_Digital_Resolution = value;
				this.SendPropertyChanged("Max_Digital_Resolution");
				this.OnMax_Digital_ResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VR_Ready", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string VR_Ready
	{
		get
		{
			return this._VR_Ready;
		}
		set
		{
			if ((this._VR_Ready != value))
			{
				this.OnVR_ReadyChanging(value);
				this.SendPropertyChanging();
				this._VR_Ready = value;
				this.SendPropertyChanged("VR_Ready");
				this.OnVR_ReadyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Recommended_Power_Supply", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Recommended_Power_Supply
	{
		get
		{
			return this._Recommended_Power_Supply;
		}
		set
		{
			if ((this._Recommended_Power_Supply != value))
			{
				this.OnRecommended_Power_SupplyChanging(value);
				this.SendPropertyChanging();
				this._Recommended_Power_Supply = value;
				this.SendPropertyChanged("Recommended_Power_Supply");
				this.OnRecommended_Power_SupplyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slot_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Slot_Width
	{
		get
		{
			return this._Slot_Width;
		}
		set
		{
			if ((this._Slot_Width != value))
			{
				this.OnSlot_WidthChanging(value);
				this.SendPropertyChanging();
				this._Slot_Width = value;
				this.SendPropertyChanged("Slot_Width");
				this.OnSlot_WidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="GPU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="GPU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_GPU", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.GPU = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.GPU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_GPU", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.GPU = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.GPU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.GPU = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.GPU = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.GPU = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.GPU = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HDD")]
public partial class HDD : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Interface;
	
	private string _Max_Sustained_Transfer_Rate;
	
	private string _Rotational_Speed;
	
	private string _Load_Unload_Cycles;
	
	private string _Workload_Rate_Limit;
	
	private string _Power_Usage;
	
	private string _Operating_Temp;
	
	private string _Size;
	
	private string _Weight;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnInterfaceChanging(string value);
    partial void OnInterfaceChanged();
    partial void OnMax_Sustained_Transfer_RateChanging(string value);
    partial void OnMax_Sustained_Transfer_RateChanged();
    partial void OnRotational_SpeedChanging(string value);
    partial void OnRotational_SpeedChanged();
    partial void OnLoad_Unload_CyclesChanging(string value);
    partial void OnLoad_Unload_CyclesChanged();
    partial void OnWorkload_Rate_LimitChanging(string value);
    partial void OnWorkload_Rate_LimitChanged();
    partial void OnPower_UsageChanging(string value);
    partial void OnPower_UsageChanged();
    partial void OnOperating_TempChanging(string value);
    partial void OnOperating_TempChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public HDD()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Interface", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Interface
	{
		get
		{
			return this._Interface;
		}
		set
		{
			if ((this._Interface != value))
			{
				this.OnInterfaceChanging(value);
				this.SendPropertyChanging();
				this._Interface = value;
				this.SendPropertyChanged("Interface");
				this.OnInterfaceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sustained_Transfer_Rate", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sustained_Transfer_Rate
	{
		get
		{
			return this._Max_Sustained_Transfer_Rate;
		}
		set
		{
			if ((this._Max_Sustained_Transfer_Rate != value))
			{
				this.OnMax_Sustained_Transfer_RateChanging(value);
				this.SendPropertyChanging();
				this._Max_Sustained_Transfer_Rate = value;
				this.SendPropertyChanged("Max_Sustained_Transfer_Rate");
				this.OnMax_Sustained_Transfer_RateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rotational_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Rotational_Speed
	{
		get
		{
			return this._Rotational_Speed;
		}
		set
		{
			if ((this._Rotational_Speed != value))
			{
				this.OnRotational_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Rotational_Speed = value;
				this.SendPropertyChanged("Rotational_Speed");
				this.OnRotational_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Load_Unload_Cycles", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Load_Unload_Cycles
	{
		get
		{
			return this._Load_Unload_Cycles;
		}
		set
		{
			if ((this._Load_Unload_Cycles != value))
			{
				this.OnLoad_Unload_CyclesChanging(value);
				this.SendPropertyChanging();
				this._Load_Unload_Cycles = value;
				this.SendPropertyChanged("Load_Unload_Cycles");
				this.OnLoad_Unload_CyclesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Workload_Rate_Limit", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Workload_Rate_Limit
	{
		get
		{
			return this._Workload_Rate_Limit;
		}
		set
		{
			if ((this._Workload_Rate_Limit != value))
			{
				this.OnWorkload_Rate_LimitChanging(value);
				this.SendPropertyChanging();
				this._Workload_Rate_Limit = value;
				this.SendPropertyChanged("Workload_Rate_Limit");
				this.OnWorkload_Rate_LimitChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power_Usage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power_Usage
	{
		get
		{
			return this._Power_Usage;
		}
		set
		{
			if ((this._Power_Usage != value))
			{
				this.OnPower_UsageChanging(value);
				this.SendPropertyChanging();
				this._Power_Usage = value;
				this.SendPropertyChanged("Power_Usage");
				this.OnPower_UsageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operating_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Operating_Temp
	{
		get
		{
			return this._Operating_Temp;
		}
		set
		{
			if ((this._Operating_Temp != value))
			{
				this.OnOperating_TempChanging(value);
				this.SendPropertyChanging();
				this._Operating_Temp = value;
				this.SendPropertyChanged("Operating_Temp");
				this.OnOperating_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="HDD_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="HDD_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_HDD", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.HDD = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.HDD = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_HDD", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.HDD = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.HDD = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.HDD = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.HDD = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.HDD = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.HDD = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Headset")]
public partial class Headset : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Cable_Length;
	
	private string _Connector;
	
	private string _Compatibility;
	
	private string _Frequency_Response;
	
	private string _Sound_Pressure_Level;
	
	private string _Microphone;
	
	private string _MP_Frequency_Response;
	
	private string _MP_Pickup_Pattern;
	
	private string _MP_Sensitivity;
	
	private string _Colour;
	
	private string _Wearing_Style;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnConnectorChanging(string value);
    partial void OnConnectorChanged();
    partial void OnCompatibilityChanging(string value);
    partial void OnCompatibilityChanged();
    partial void OnFrequency_ResponseChanging(string value);
    partial void OnFrequency_ResponseChanged();
    partial void OnSound_Pressure_LevelChanging(string value);
    partial void OnSound_Pressure_LevelChanged();
    partial void OnMicrophoneChanging(string value);
    partial void OnMicrophoneChanged();
    partial void OnMP_Frequency_ResponseChanging(string value);
    partial void OnMP_Frequency_ResponseChanged();
    partial void OnMP_Pickup_PatternChanging(string value);
    partial void OnMP_Pickup_PatternChanged();
    partial void OnMP_SensitivityChanging(string value);
    partial void OnMP_SensitivityChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnWearing_StyleChanging(string value);
    partial void OnWearing_StyleChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Headset()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255)")]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255)")]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50)")]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connector", DbType="VarChar(50)")]
	public string Connector
	{
		get
		{
			return this._Connector;
		}
		set
		{
			if ((this._Connector != value))
			{
				this.OnConnectorChanging(value);
				this.SendPropertyChanging();
				this._Connector = value;
				this.SendPropertyChanged("Connector");
				this.OnConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Compatibility", DbType="VarChar(50)")]
	public string Compatibility
	{
		get
		{
			return this._Compatibility;
		}
		set
		{
			if ((this._Compatibility != value))
			{
				this.OnCompatibilityChanging(value);
				this.SendPropertyChanging();
				this._Compatibility = value;
				this.SendPropertyChanged("Compatibility");
				this.OnCompatibilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frequency_Response", DbType="VarChar(50)")]
	public string Frequency_Response
	{
		get
		{
			return this._Frequency_Response;
		}
		set
		{
			if ((this._Frequency_Response != value))
			{
				this.OnFrequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._Frequency_Response = value;
				this.SendPropertyChanged("Frequency_Response");
				this.OnFrequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sound_Pressure_Level", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sound_Pressure_Level
	{
		get
		{
			return this._Sound_Pressure_Level;
		}
		set
		{
			if ((this._Sound_Pressure_Level != value))
			{
				this.OnSound_Pressure_LevelChanging(value);
				this.SendPropertyChanging();
				this._Sound_Pressure_Level = value;
				this.SendPropertyChanged("Sound_Pressure_Level");
				this.OnSound_Pressure_LevelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Microphone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Microphone
	{
		get
		{
			return this._Microphone;
		}
		set
		{
			if ((this._Microphone != value))
			{
				this.OnMicrophoneChanging(value);
				this.SendPropertyChanging();
				this._Microphone = value;
				this.SendPropertyChanged("Microphone");
				this.OnMicrophoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Frequency_Response", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Frequency_Response
	{
		get
		{
			return this._MP_Frequency_Response;
		}
		set
		{
			if ((this._MP_Frequency_Response != value))
			{
				this.OnMP_Frequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._MP_Frequency_Response = value;
				this.SendPropertyChanged("MP_Frequency_Response");
				this.OnMP_Frequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Pickup_Pattern", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Pickup_Pattern
	{
		get
		{
			return this._MP_Pickup_Pattern;
		}
		set
		{
			if ((this._MP_Pickup_Pattern != value))
			{
				this.OnMP_Pickup_PatternChanging(value);
				this.SendPropertyChanging();
				this._MP_Pickup_Pattern = value;
				this.SendPropertyChanged("MP_Pickup_Pattern");
				this.OnMP_Pickup_PatternChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Sensitivity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Sensitivity
	{
		get
		{
			return this._MP_Sensitivity;
		}
		set
		{
			if ((this._MP_Sensitivity != value))
			{
				this.OnMP_SensitivityChanging(value);
				this.SendPropertyChanging();
				this._MP_Sensitivity = value;
				this.SendPropertyChanged("MP_Sensitivity");
				this.OnMP_SensitivityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wearing_Style", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Wearing_Style
	{
		get
		{
			return this._Wearing_Style;
		}
		set
		{
			if ((this._Wearing_Style != value))
			{
				this.OnWearing_StyleChanging(value);
				this.SendPropertyChanging();
				this._Wearing_Style = value;
				this.SendPropertyChanged("Wearing_Style");
				this.OnWearing_StyleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Headset_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Headset_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Headset", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Headset = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Headset = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Headset", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Headset = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Headset = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Headset = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Headset = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Headset = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Headset = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Keyboard")]
public partial class Keyboard : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Switches;
	
	private string _Programmable_Macros;
	
	private string _Connector;
	
	private string _LED_BackLight;
	
	private string _Multimedia_Keys;
	
	private string _Material;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSwitchesChanging(string value);
    partial void OnSwitchesChanged();
    partial void OnProgrammable_MacrosChanging(string value);
    partial void OnProgrammable_MacrosChanged();
    partial void OnConnectorChanging(string value);
    partial void OnConnectorChanged();
    partial void OnLED_BackLightChanging(string value);
    partial void OnLED_BackLightChanged();
    partial void OnMultimedia_KeysChanging(string value);
    partial void OnMultimedia_KeysChanged();
    partial void OnMaterialChanging(string value);
    partial void OnMaterialChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Keyboard()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Switches", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Switches
	{
		get
		{
			return this._Switches;
		}
		set
		{
			if ((this._Switches != value))
			{
				this.OnSwitchesChanging(value);
				this.SendPropertyChanging();
				this._Switches = value;
				this.SendPropertyChanged("Switches");
				this.OnSwitchesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Programmable_Macros", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Programmable_Macros
	{
		get
		{
			return this._Programmable_Macros;
		}
		set
		{
			if ((this._Programmable_Macros != value))
			{
				this.OnProgrammable_MacrosChanging(value);
				this.SendPropertyChanging();
				this._Programmable_Macros = value;
				this.SendPropertyChanged("Programmable_Macros");
				this.OnProgrammable_MacrosChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connector", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Connector
	{
		get
		{
			return this._Connector;
		}
		set
		{
			if ((this._Connector != value))
			{
				this.OnConnectorChanging(value);
				this.SendPropertyChanging();
				this._Connector = value;
				this.SendPropertyChanged("Connector");
				this.OnConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LED_BackLight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string LED_BackLight
	{
		get
		{
			return this._LED_BackLight;
		}
		set
		{
			if ((this._LED_BackLight != value))
			{
				this.OnLED_BackLightChanging(value);
				this.SendPropertyChanging();
				this._LED_BackLight = value;
				this.SendPropertyChanged("LED_BackLight");
				this.OnLED_BackLightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Multimedia_Keys", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Multimedia_Keys
	{
		get
		{
			return this._Multimedia_Keys;
		}
		set
		{
			if ((this._Multimedia_Keys != value))
			{
				this.OnMultimedia_KeysChanging(value);
				this.SendPropertyChanging();
				this._Multimedia_Keys = value;
				this.SendPropertyChanged("Multimedia_Keys");
				this.OnMultimedia_KeysChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Material", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Material
	{
		get
		{
			return this._Material;
		}
		set
		{
			if ((this._Material != value))
			{
				this.OnMaterialChanging(value);
				this.SendPropertyChanging();
				this._Material = value;
				this.SendPropertyChanged("Material");
				this.OnMaterialChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Keyboard_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Keyboard_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Keyboard", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Keyboard = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Keyboard = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Keyboard", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Keyboard = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Keyboard = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiquidCooler")]
public partial class LiquidCooler : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Fan_Size;
	
	private string _Fan_Height;
	
	private string _Radiator_Mats;
	
	private string _Radiator_Length;
	
	private string _Radiator_Width;
	
	private string _Radiator_Height;
	
	private string _Tube_Length;
	
	private string _Tube_Mats;
	
	private string _Sockets_Supported;
	
	private string _Color;
	
	private string _RGB;
	
	private string _Warranty;
	
	private EntitySet<CpuToLiquidCooler> _CpuToLiquidCoolers;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<CpuToLiquidCooler1> _CpuToLiquidCooler1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnFan_HeightChanging(string value);
    partial void OnFan_HeightChanged();
    partial void OnRadiator_MatsChanging(string value);
    partial void OnRadiator_MatsChanged();
    partial void OnRadiator_LengthChanging(string value);
    partial void OnRadiator_LengthChanged();
    partial void OnRadiator_WidthChanging(string value);
    partial void OnRadiator_WidthChanged();
    partial void OnRadiator_HeightChanging(string value);
    partial void OnRadiator_HeightChanged();
    partial void OnTube_LengthChanging(string value);
    partial void OnTube_LengthChanged();
    partial void OnTube_MatsChanging(string value);
    partial void OnTube_MatsChanged();
    partial void OnSockets_SupportedChanging(string value);
    partial void OnSockets_SupportedChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnRGBChanging(string value);
    partial void OnRGBChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public LiquidCooler()
	{
		this._CpuToLiquidCoolers = new EntitySet<CpuToLiquidCooler>(new Action<CpuToLiquidCooler>(this.attach_CpuToLiquidCoolers), new Action<CpuToLiquidCooler>(this.detach_CpuToLiquidCoolers));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._CpuToLiquidCooler1s = new EntitySet<CpuToLiquidCooler1>(new Action<CpuToLiquidCooler1>(this.attach_CpuToLiquidCooler1s), new Action<CpuToLiquidCooler1>(this.detach_CpuToLiquidCooler1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Height
	{
		get
		{
			return this._Fan_Height;
		}
		set
		{
			if ((this._Fan_Height != value))
			{
				this.OnFan_HeightChanging(value);
				this.SendPropertyChanging();
				this._Fan_Height = value;
				this.SendPropertyChanged("Fan_Height");
				this.OnFan_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Mats", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Mats
	{
		get
		{
			return this._Radiator_Mats;
		}
		set
		{
			if ((this._Radiator_Mats != value))
			{
				this.OnRadiator_MatsChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Mats = value;
				this.SendPropertyChanged("Radiator_Mats");
				this.OnRadiator_MatsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Length
	{
		get
		{
			return this._Radiator_Length;
		}
		set
		{
			if ((this._Radiator_Length != value))
			{
				this.OnRadiator_LengthChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Length = value;
				this.SendPropertyChanged("Radiator_Length");
				this.OnRadiator_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Width
	{
		get
		{
			return this._Radiator_Width;
		}
		set
		{
			if ((this._Radiator_Width != value))
			{
				this.OnRadiator_WidthChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Width = value;
				this.SendPropertyChanged("Radiator_Width");
				this.OnRadiator_WidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Height
	{
		get
		{
			return this._Radiator_Height;
		}
		set
		{
			if ((this._Radiator_Height != value))
			{
				this.OnRadiator_HeightChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Height = value;
				this.SendPropertyChanged("Radiator_Height");
				this.OnRadiator_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tube_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tube_Length
	{
		get
		{
			return this._Tube_Length;
		}
		set
		{
			if ((this._Tube_Length != value))
			{
				this.OnTube_LengthChanging(value);
				this.SendPropertyChanging();
				this._Tube_Length = value;
				this.SendPropertyChanged("Tube_Length");
				this.OnTube_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tube_Mats", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tube_Mats
	{
		get
		{
			return this._Tube_Mats;
		}
		set
		{
			if ((this._Tube_Mats != value))
			{
				this.OnTube_MatsChanging(value);
				this.SendPropertyChanging();
				this._Tube_Mats = value;
				this.SendPropertyChanged("Tube_Mats");
				this.OnTube_MatsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sockets_Supported", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Sockets_Supported
	{
		get
		{
			return this._Sockets_Supported;
		}
		set
		{
			if ((this._Sockets_Supported != value))
			{
				this.OnSockets_SupportedChanging(value);
				this.SendPropertyChanging();
				this._Sockets_Supported = value;
				this.SendPropertyChanged("Sockets_Supported");
				this.OnSockets_SupportedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Color
	{
		get
		{
			return this._Color;
		}
		set
		{
			if ((this._Color != value))
			{
				this.OnColorChanging(value);
				this.SendPropertyChanging();
				this._Color = value;
				this.SendPropertyChanged("Color");
				this.OnColorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RGB", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string RGB
	{
		get
		{
			return this._RGB;
		}
		set
		{
			if ((this._RGB != value))
			{
				this.OnRGBChanging(value);
				this.SendPropertyChanging();
				this._RGB = value;
				this.SendPropertyChanged("RGB");
				this.OnRGBChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_CpuToLiquidCooler", Storage="_CpuToLiquidCoolers", ThisKey="ID", OtherKey="LC_ID")]
	public EntitySet<CpuToLiquidCooler> CpuToLiquidCoolers
	{
		get
		{
			return this._CpuToLiquidCoolers;
		}
		set
		{
			this._CpuToLiquidCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Cooler_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_CpuToLiquidCooler1", Storage="_CpuToLiquidCooler1s", ThisKey="ID", OtherKey="LC_ID")]
	public EntitySet<CpuToLiquidCooler1> CpuToLiquidCooler1s
	{
		get
		{
			return this._CpuToLiquidCooler1s;
		}
		set
		{
			this._CpuToLiquidCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Cooler_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_LiquidCooler", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.LiquidCooler = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.LiquidCooler = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_LiquidCooler", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.LiquidCooler = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.LiquidCooler = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = this;
	}
	
	private void detach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = null;
	}
	
	private void attach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = this;
	}
	
	private void detach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginTable")]
public partial class LoginTable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private string _User_Name;
	
	private string _Password;
	
	private int _User_Type;
	
	private EntityRef<Admin> _Admin;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Admin1> _Admin1;
	
	private EntityRef<Client1> _Client1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnUser_NameChanging(string value);
    partial void OnUser_NameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUser_TypeChanging(int value);
    partial void OnUser_TypeChanged();
    #endregion
	
	public LoginTable()
	{
		this._Admin = default(EntityRef<Admin>);
		this._Client = default(EntityRef<Client>);
		this._Admin1 = default(EntityRef<Admin1>);
		this._Client1 = default(EntityRef<Client1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string User_Name
	{
		get
		{
			return this._User_Name;
		}
		set
		{
			if ((this._User_Name != value))
			{
				this.OnUser_NameChanging(value);
				this.SendPropertyChanging();
				this._User_Name = value;
				this.SendPropertyChanged("User_Name");
				this.OnUser_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="Int NOT NULL")]
	public int User_Type
	{
		get
		{
			return this._User_Type;
		}
		set
		{
			if ((this._User_Type != value))
			{
				this.OnUser_TypeChanging(value);
				this.SendPropertyChanging();
				this._User_Type = value;
				this.SendPropertyChanged("User_Type");
				this.OnUser_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Admin", Storage="_Admin", ThisKey="User_ID", OtherKey="Admin_ID", IsUnique=true, IsForeignKey=false)]
	public Admin Admin
	{
		get
		{
			return this._Admin.Entity;
		}
		set
		{
			Admin previousValue = this._Admin.Entity;
			if (((previousValue != value) 
						|| (this._Admin.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin.Entity = null;
					previousValue.LoginTable = null;
				}
				this._Admin.Entity = value;
				if ((value != null))
				{
					value.LoginTable = this;
				}
				this.SendPropertyChanged("Admin");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Client", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsUnique=true, IsForeignKey=false)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.LoginTable = null;
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.LoginTable = this;
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Admin1", Storage="_Admin1", ThisKey="User_ID", OtherKey="Admin_ID", IsUnique=true, IsForeignKey=false)]
	public Admin1 Admin1
	{
		get
		{
			return this._Admin1.Entity;
		}
		set
		{
			Admin1 previousValue = this._Admin1.Entity;
			if (((previousValue != value) 
						|| (this._Admin1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin1.Entity = null;
					previousValue.LoginTable = null;
				}
				this._Admin1.Entity = value;
				if ((value != null))
				{
					value.LoginTable = this;
				}
				this.SendPropertyChanged("Admin1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Client1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsUnique=true, IsForeignKey=false)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.LoginTable = null;
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.LoginTable = this;
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Microphone")]
public partial class Microphone : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Pick_Up_Pattern;
	
	private string _Frequency_Response;
	
	private string _Sensitivity;
	
	private string _Cable_Length;
	
	private string _Warranty;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnPick_Up_PatternChanging(string value);
    partial void OnPick_Up_PatternChanged();
    partial void OnFrequency_ResponseChanging(string value);
    partial void OnFrequency_ResponseChanged();
    partial void OnSensitivityChanging(string value);
    partial void OnSensitivityChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Microphone()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pick_Up_Pattern", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Pick_Up_Pattern
	{
		get
		{
			return this._Pick_Up_Pattern;
		}
		set
		{
			if ((this._Pick_Up_Pattern != value))
			{
				this.OnPick_Up_PatternChanging(value);
				this.SendPropertyChanging();
				this._Pick_Up_Pattern = value;
				this.SendPropertyChanged("Pick_Up_Pattern");
				this.OnPick_Up_PatternChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frequency_Response", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Frequency_Response
	{
		get
		{
			return this._Frequency_Response;
		}
		set
		{
			if ((this._Frequency_Response != value))
			{
				this.OnFrequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._Frequency_Response = value;
				this.SendPropertyChanged("Frequency_Response");
				this.OnFrequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sensitivity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sensitivity
	{
		get
		{
			return this._Sensitivity;
		}
		set
		{
			if ((this._Sensitivity != value))
			{
				this.OnSensitivityChanging(value);
				this.SendPropertyChanging();
				this._Sensitivity = value;
				this.SendPropertyChanged("Sensitivity");
				this.OnSensitivityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Microphone", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Microphone = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Microphone = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Microphone", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Microphone = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Microphone = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToCase")]
public partial class MoboToCase : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _Case_ID;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<PCCase1> _PCCase1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCase_IDChanging(int value);
    partial void OnCase_IDChanged();
    #endregion
	
	public MoboToCase()
	{
		this._Motherboard = default(EntityRef<Motherboard>);
		this._PCCase = default(EntityRef<PCCase>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._PCCase1 = default(EntityRef<PCCase1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Case_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Case_ID
	{
		get
		{
			return this._Case_ID;
		}
		set
		{
			if ((this._Case_ID != value))
			{
				if ((this._PCCase.HasLoadedOrAssignedValue || this._PCCase1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCase_IDChanging(value);
				this.SendPropertyChanging();
				this._Case_ID = value;
				this.SendPropertyChanged("Case_ID");
				this.OnCase_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCase", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToCases.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToCases.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_MoboToCase", Storage="_PCCase", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.MoboToCases.Remove(this);
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.MoboToCases.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCase", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToCases.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToCases.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_MoboToCase", Storage="_PCCase1", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.MoboToCases.Remove(this);
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.MoboToCases.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToCpu")]
public partial class MoboToCpu : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _CPU_ID;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    #endregion
	
	public MoboToCpu()
	{
		this._CPU = default(EntityRef<CPU>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_MoboToCpu", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.MoboToCpus.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.MoboToCpus.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCpu", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToCpus.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToCpus.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_MoboToCpu", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.MoboToCpus.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.MoboToCpus.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCpu", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToCpus.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToCpus.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToRam")]
public partial class MoboToRam : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _RAM_ID;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<RAM1> _RAM1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnRAM_IDChanging(int value);
    partial void OnRAM_IDChanged();
    #endregion
	
	public MoboToRam()
	{
		this._Motherboard = default(EntityRef<Motherboard>);
		this._RAM = default(EntityRef<RAM>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._RAM1 = default(EntityRef<RAM1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				if ((this._RAM.HasLoadedOrAssignedValue || this._RAM1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRAM_IDChanging(value);
				this.SendPropertyChanging();
				this._RAM_ID = value;
				this.SendPropertyChanged("RAM_ID");
				this.OnRAM_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToRam", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToRams.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToRams.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_MoboToRam", Storage="_RAM", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.MoboToRams.Remove(this);
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.MoboToRams.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToRam", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToRams.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToRams.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_MoboToRam", Storage="_RAM1", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.MoboToRams.Remove(this);
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.MoboToRams.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Monitor")]
public partial class Monitor : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _ScreenSize;
	
	private string _ScreenRatio;
	
	private string _Brightness;
	
	private string _ContrastRatio;
	
	private string _DynamicContrastRatio;
	
	private string _ViewingAngle;
	
	private string _ResponseTime;
	
	private string _Panel_Type;
	
	private string _RefreshRate;
	
	private string _Resolution;
	
	private string _Colours;
	
	private string _DisplayPortInput;
	
	private string _HDMI;
	
	private string _VGA;
	
	private string _Speakers;
	
	private string _PowerSource;
	
	private string _PowerSupply;
	
	private string _EnergyClass;
	
	private string _Swivel;
	
	private string _Tilt;
	
	private string _Pivot;
	
	private string _Regulations;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnScreenSizeChanging(string value);
    partial void OnScreenSizeChanged();
    partial void OnScreenRatioChanging(string value);
    partial void OnScreenRatioChanged();
    partial void OnBrightnessChanging(string value);
    partial void OnBrightnessChanged();
    partial void OnContrastRatioChanging(string value);
    partial void OnContrastRatioChanged();
    partial void OnDynamicContrastRatioChanging(string value);
    partial void OnDynamicContrastRatioChanged();
    partial void OnViewingAngleChanging(string value);
    partial void OnViewingAngleChanged();
    partial void OnResponseTimeChanging(string value);
    partial void OnResponseTimeChanged();
    partial void OnPanel_TypeChanging(string value);
    partial void OnPanel_TypeChanged();
    partial void OnRefreshRateChanging(string value);
    partial void OnRefreshRateChanged();
    partial void OnResolutionChanging(string value);
    partial void OnResolutionChanged();
    partial void OnColoursChanging(string value);
    partial void OnColoursChanged();
    partial void OnDisplayPortInputChanging(string value);
    partial void OnDisplayPortInputChanged();
    partial void OnHDMIChanging(string value);
    partial void OnHDMIChanged();
    partial void OnVGAChanging(string value);
    partial void OnVGAChanged();
    partial void OnSpeakersChanging(string value);
    partial void OnSpeakersChanged();
    partial void OnPowerSourceChanging(string value);
    partial void OnPowerSourceChanged();
    partial void OnPowerSupplyChanging(string value);
    partial void OnPowerSupplyChanged();
    partial void OnEnergyClassChanging(string value);
    partial void OnEnergyClassChanged();
    partial void OnSwivelChanging(string value);
    partial void OnSwivelChanged();
    partial void OnTiltChanging(string value);
    partial void OnTiltChanged();
    partial void OnPivotChanging(string value);
    partial void OnPivotChanged();
    partial void OnRegulationsChanging(string value);
    partial void OnRegulationsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Monitor()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScreenSize", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string ScreenSize
	{
		get
		{
			return this._ScreenSize;
		}
		set
		{
			if ((this._ScreenSize != value))
			{
				this.OnScreenSizeChanging(value);
				this.SendPropertyChanging();
				this._ScreenSize = value;
				this.SendPropertyChanged("ScreenSize");
				this.OnScreenSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScreenRatio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string ScreenRatio
	{
		get
		{
			return this._ScreenRatio;
		}
		set
		{
			if ((this._ScreenRatio != value))
			{
				this.OnScreenRatioChanging(value);
				this.SendPropertyChanging();
				this._ScreenRatio = value;
				this.SendPropertyChanged("ScreenRatio");
				this.OnScreenRatioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brightness", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brightness
	{
		get
		{
			return this._Brightness;
		}
		set
		{
			if ((this._Brightness != value))
			{
				this.OnBrightnessChanging(value);
				this.SendPropertyChanging();
				this._Brightness = value;
				this.SendPropertyChanged("Brightness");
				this.OnBrightnessChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContrastRatio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string ContrastRatio
	{
		get
		{
			return this._ContrastRatio;
		}
		set
		{
			if ((this._ContrastRatio != value))
			{
				this.OnContrastRatioChanging(value);
				this.SendPropertyChanging();
				this._ContrastRatio = value;
				this.SendPropertyChanged("ContrastRatio");
				this.OnContrastRatioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DynamicContrastRatio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string DynamicContrastRatio
	{
		get
		{
			return this._DynamicContrastRatio;
		}
		set
		{
			if ((this._DynamicContrastRatio != value))
			{
				this.OnDynamicContrastRatioChanging(value);
				this.SendPropertyChanging();
				this._DynamicContrastRatio = value;
				this.SendPropertyChanged("DynamicContrastRatio");
				this.OnDynamicContrastRatioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViewingAngle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string ViewingAngle
	{
		get
		{
			return this._ViewingAngle;
		}
		set
		{
			if ((this._ViewingAngle != value))
			{
				this.OnViewingAngleChanging(value);
				this.SendPropertyChanging();
				this._ViewingAngle = value;
				this.SendPropertyChanged("ViewingAngle");
				this.OnViewingAngleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResponseTime", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string ResponseTime
	{
		get
		{
			return this._ResponseTime;
		}
		set
		{
			if ((this._ResponseTime != value))
			{
				this.OnResponseTimeChanging(value);
				this.SendPropertyChanging();
				this._ResponseTime = value;
				this.SendPropertyChanged("ResponseTime");
				this.OnResponseTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Panel Type]", Storage="_Panel_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Panel_Type
	{
		get
		{
			return this._Panel_Type;
		}
		set
		{
			if ((this._Panel_Type != value))
			{
				this.OnPanel_TypeChanging(value);
				this.SendPropertyChanging();
				this._Panel_Type = value;
				this.SendPropertyChanged("Panel_Type");
				this.OnPanel_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefreshRate", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string RefreshRate
	{
		get
		{
			return this._RefreshRate;
		}
		set
		{
			if ((this._RefreshRate != value))
			{
				this.OnRefreshRateChanging(value);
				this.SendPropertyChanging();
				this._RefreshRate = value;
				this.SendPropertyChanged("RefreshRate");
				this.OnRefreshRateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolution", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Resolution
	{
		get
		{
			return this._Resolution;
		}
		set
		{
			if ((this._Resolution != value))
			{
				this.OnResolutionChanging(value);
				this.SendPropertyChanging();
				this._Resolution = value;
				this.SendPropertyChanged("Resolution");
				this.OnResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colours", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colours
	{
		get
		{
			return this._Colours;
		}
		set
		{
			if ((this._Colours != value))
			{
				this.OnColoursChanging(value);
				this.SendPropertyChanging();
				this._Colours = value;
				this.SendPropertyChanged("Colours");
				this.OnColoursChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayPortInput", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string DisplayPortInput
	{
		get
		{
			return this._DisplayPortInput;
		}
		set
		{
			if ((this._DisplayPortInput != value))
			{
				this.OnDisplayPortInputChanging(value);
				this.SendPropertyChanging();
				this._DisplayPortInput = value;
				this.SendPropertyChanged("DisplayPortInput");
				this.OnDisplayPortInputChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HDMI", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string HDMI
	{
		get
		{
			return this._HDMI;
		}
		set
		{
			if ((this._HDMI != value))
			{
				this.OnHDMIChanging(value);
				this.SendPropertyChanging();
				this._HDMI = value;
				this.SendPropertyChanged("HDMI");
				this.OnHDMIChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VGA", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string VGA
	{
		get
		{
			return this._VGA;
		}
		set
		{
			if ((this._VGA != value))
			{
				this.OnVGAChanging(value);
				this.SendPropertyChanging();
				this._VGA = value;
				this.SendPropertyChanged("VGA");
				this.OnVGAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speakers", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Speakers
	{
		get
		{
			return this._Speakers;
		}
		set
		{
			if ((this._Speakers != value))
			{
				this.OnSpeakersChanging(value);
				this.SendPropertyChanging();
				this._Speakers = value;
				this.SendPropertyChanged("Speakers");
				this.OnSpeakersChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PowerSource", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PowerSource
	{
		get
		{
			return this._PowerSource;
		}
		set
		{
			if ((this._PowerSource != value))
			{
				this.OnPowerSourceChanging(value);
				this.SendPropertyChanging();
				this._PowerSource = value;
				this.SendPropertyChanged("PowerSource");
				this.OnPowerSourceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PowerSupply", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PowerSupply
	{
		get
		{
			return this._PowerSupply;
		}
		set
		{
			if ((this._PowerSupply != value))
			{
				this.OnPowerSupplyChanging(value);
				this.SendPropertyChanging();
				this._PowerSupply = value;
				this.SendPropertyChanged("PowerSupply");
				this.OnPowerSupplyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnergyClass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string EnergyClass
	{
		get
		{
			return this._EnergyClass;
		}
		set
		{
			if ((this._EnergyClass != value))
			{
				this.OnEnergyClassChanging(value);
				this.SendPropertyChanging();
				this._EnergyClass = value;
				this.SendPropertyChanged("EnergyClass");
				this.OnEnergyClassChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Swivel", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Swivel
	{
		get
		{
			return this._Swivel;
		}
		set
		{
			if ((this._Swivel != value))
			{
				this.OnSwivelChanging(value);
				this.SendPropertyChanging();
				this._Swivel = value;
				this.SendPropertyChanged("Swivel");
				this.OnSwivelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tilt", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tilt
	{
		get
		{
			return this._Tilt;
		}
		set
		{
			if ((this._Tilt != value))
			{
				this.OnTiltChanging(value);
				this.SendPropertyChanging();
				this._Tilt = value;
				this.SendPropertyChanged("Tilt");
				this.OnTiltChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Pivot]", Storage="_Pivot", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Pivot
	{
		get
		{
			return this._Pivot;
		}
		set
		{
			if ((this._Pivot != value))
			{
				this.OnPivotChanging(value);
				this.SendPropertyChanging();
				this._Pivot = value;
				this.SendPropertyChanged("Pivot");
				this.OnPivotChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Regulations", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Regulations
	{
		get
		{
			return this._Regulations;
		}
		set
		{
			if ((this._Regulations != value))
			{
				this.OnRegulationsChanging(value);
				this.SendPropertyChanging();
				this._Regulations = value;
				this.SendPropertyChanged("Regulations");
				this.OnRegulationsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Monitor_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Monitor_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Monitor", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Monitor = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Monitor = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Monitor", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Monitor = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Monitor = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Monitor = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Monitor = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Monitor = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Monitor = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Motherboard")]
public partial class Motherboard : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Chipset;
	
	private string _Memory_Type;
	
	private int _Max_Memory_Size;
	
	private int _Max_Memory_Speed;
	
	private string _LAN;
	
	private string _Expansion_Slots;
	
	private string _Storage;
	
	private string _Internal_I_O_Connectors;
	
	private string _Back_Panel_Connectors;
	
	private string _OS_Support;
	
	private string _Form_Factor;
	
	private string _Notes;
	
	private string _Warranty;
	
	private EntitySet<MoboToCase> _MoboToCases;
	
	private EntitySet<MoboToCpu> _MoboToCpus;
	
	private EntitySet<MoboToRam> _MoboToRams;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<MoboToCase1> _MoboToCase1s;
	
	private EntitySet<MoboToCpu1> _MoboToCpu1s;
	
	private EntitySet<MoboToRam1> _MoboToRam1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnChipsetChanging(string value);
    partial void OnChipsetChanged();
    partial void OnMemory_TypeChanging(string value);
    partial void OnMemory_TypeChanged();
    partial void OnMax_Memory_SizeChanging(int value);
    partial void OnMax_Memory_SizeChanged();
    partial void OnMax_Memory_SpeedChanging(int value);
    partial void OnMax_Memory_SpeedChanged();
    partial void OnLANChanging(string value);
    partial void OnLANChanged();
    partial void OnExpansion_SlotsChanging(string value);
    partial void OnExpansion_SlotsChanged();
    partial void OnStorageChanging(string value);
    partial void OnStorageChanged();
    partial void OnInternal_I_O_ConnectorsChanging(string value);
    partial void OnInternal_I_O_ConnectorsChanged();
    partial void OnBack_Panel_ConnectorsChanging(string value);
    partial void OnBack_Panel_ConnectorsChanged();
    partial void OnOS_SupportChanging(string value);
    partial void OnOS_SupportChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Motherboard()
	{
		this._MoboToCases = new EntitySet<MoboToCase>(new Action<MoboToCase>(this.attach_MoboToCases), new Action<MoboToCase>(this.detach_MoboToCases));
		this._MoboToCpus = new EntitySet<MoboToCpu>(new Action<MoboToCpu>(this.attach_MoboToCpus), new Action<MoboToCpu>(this.detach_MoboToCpus));
		this._MoboToRams = new EntitySet<MoboToRam>(new Action<MoboToRam>(this.attach_MoboToRams), new Action<MoboToRam>(this.detach_MoboToRams));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._MoboToCase1s = new EntitySet<MoboToCase1>(new Action<MoboToCase1>(this.attach_MoboToCase1s), new Action<MoboToCase1>(this.detach_MoboToCase1s));
		this._MoboToCpu1s = new EntitySet<MoboToCpu1>(new Action<MoboToCpu1>(this.attach_MoboToCpu1s), new Action<MoboToCpu1>(this.detach_MoboToCpu1s));
		this._MoboToRam1s = new EntitySet<MoboToRam1>(new Action<MoboToRam1>(this.attach_MoboToRam1s), new Action<MoboToRam1>(this.detach_MoboToRam1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chipset", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Chipset
	{
		get
		{
			return this._Chipset;
		}
		set
		{
			if ((this._Chipset != value))
			{
				this.OnChipsetChanging(value);
				this.SendPropertyChanging();
				this._Chipset = value;
				this.SendPropertyChanged("Chipset");
				this.OnChipsetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Type", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Memory_Type
	{
		get
		{
			return this._Memory_Type;
		}
		set
		{
			if ((this._Memory_Type != value))
			{
				this.OnMemory_TypeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Type = value;
				this.SendPropertyChanged("Memory_Type");
				this.OnMemory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Memory_Size", DbType="Int NOT NULL")]
	public int Max_Memory_Size
	{
		get
		{
			return this._Max_Memory_Size;
		}
		set
		{
			if ((this._Max_Memory_Size != value))
			{
				this.OnMax_Memory_SizeChanging(value);
				this.SendPropertyChanging();
				this._Max_Memory_Size = value;
				this.SendPropertyChanged("Max_Memory_Size");
				this.OnMax_Memory_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Memory_Speed", DbType="Int NOT NULL")]
	public int Max_Memory_Speed
	{
		get
		{
			return this._Max_Memory_Speed;
		}
		set
		{
			if ((this._Max_Memory_Speed != value))
			{
				this.OnMax_Memory_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Max_Memory_Speed = value;
				this.SendPropertyChanged("Max_Memory_Speed");
				this.OnMax_Memory_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LAN", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string LAN
	{
		get
		{
			return this._LAN;
		}
		set
		{
			if ((this._LAN != value))
			{
				this.OnLANChanging(value);
				this.SendPropertyChanging();
				this._LAN = value;
				this.SendPropertyChanged("LAN");
				this.OnLANChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expansion_Slots", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Expansion_Slots
	{
		get
		{
			return this._Expansion_Slots;
		}
		set
		{
			if ((this._Expansion_Slots != value))
			{
				this.OnExpansion_SlotsChanging(value);
				this.SendPropertyChanging();
				this._Expansion_Slots = value;
				this.SendPropertyChanged("Expansion_Slots");
				this.OnExpansion_SlotsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Storage", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Storage
	{
		get
		{
			return this._Storage;
		}
		set
		{
			if ((this._Storage != value))
			{
				this.OnStorageChanging(value);
				this.SendPropertyChanging();
				this._Storage = value;
				this.SendPropertyChanged("Storage");
				this.OnStorageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Internal_I/O_Connectors]", Storage="_Internal_I_O_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Internal_I_O_Connectors
	{
		get
		{
			return this._Internal_I_O_Connectors;
		}
		set
		{
			if ((this._Internal_I_O_Connectors != value))
			{
				this.OnInternal_I_O_ConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Internal_I_O_Connectors = value;
				this.SendPropertyChanged("Internal_I_O_Connectors");
				this.OnInternal_I_O_ConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Back_Panel_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Back_Panel_Connectors
	{
		get
		{
			return this._Back_Panel_Connectors;
		}
		set
		{
			if ((this._Back_Panel_Connectors != value))
			{
				this.OnBack_Panel_ConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Back_Panel_Connectors = value;
				this.SendPropertyChanged("Back_Panel_Connectors");
				this.OnBack_Panel_ConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Support", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Support
	{
		get
		{
			return this._OS_Support;
		}
		set
		{
			if ((this._OS_Support != value))
			{
				this.OnOS_SupportChanging(value);
				this.SendPropertyChanging();
				this._OS_Support = value;
				this.SendPropertyChanged("OS_Support");
				this.OnOS_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(MAX)")]
	public string Notes
	{
		get
		{
			return this._Notes;
		}
		set
		{
			if ((this._Notes != value))
			{
				this.OnNotesChanging(value);
				this.SendPropertyChanging();
				this._Notes = value;
				this.SendPropertyChanged("Notes");
				this.OnNotesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCase", Storage="_MoboToCases", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCase> MoboToCases
	{
		get
		{
			return this._MoboToCases;
		}
		set
		{
			this._MoboToCases.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCpu", Storage="_MoboToCpus", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCpu> MoboToCpus
	{
		get
		{
			return this._MoboToCpus;
		}
		set
		{
			this._MoboToCpus.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToRam", Storage="_MoboToRams", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToRam> MoboToRams
	{
		get
		{
			return this._MoboToRams;
		}
		set
		{
			this._MoboToRams.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCase1", Storage="_MoboToCase1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCase1> MoboToCase1s
	{
		get
		{
			return this._MoboToCase1s;
		}
		set
		{
			this._MoboToCase1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCpu1", Storage="_MoboToCpu1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCpu1> MoboToCpu1s
	{
		get
		{
			return this._MoboToCpu1s;
		}
		set
		{
			this._MoboToCpu1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToRam1", Storage="_MoboToRam1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToRam1> MoboToRam1s
	{
		get
		{
			return this._MoboToRam1s;
		}
		set
		{
			this._MoboToRam1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Motherboard", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Motherboard = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Motherboard = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Motherboard", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Motherboard = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Motherboard = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mouse")]
public partial class Mouse : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Sensor;
	
	private string _Resolution;
	
	private string _Max_Acceleration;
	
	private string _Max_Speed;
	
	private string _Connection_Type;
	
	private string _Durability;
	
	private string _PTFE_Feet;
	
	private string _Battery;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Cable_Length;
	
	private string _OS_Support;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSensorChanging(string value);
    partial void OnSensorChanged();
    partial void OnResolutionChanging(string value);
    partial void OnResolutionChanged();
    partial void OnMax_AccelerationChanging(string value);
    partial void OnMax_AccelerationChanged();
    partial void OnMax_SpeedChanging(string value);
    partial void OnMax_SpeedChanged();
    partial void OnConnection_TypeChanging(string value);
    partial void OnConnection_TypeChanged();
    partial void OnDurabilityChanging(string value);
    partial void OnDurabilityChanged();
    partial void OnPTFE_FeetChanging(string value);
    partial void OnPTFE_FeetChanged();
    partial void OnBatteryChanging(string value);
    partial void OnBatteryChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnOS_SupportChanging(string value);
    partial void OnOS_SupportChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Mouse()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sensor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sensor
	{
		get
		{
			return this._Sensor;
		}
		set
		{
			if ((this._Sensor != value))
			{
				this.OnSensorChanging(value);
				this.SendPropertyChanging();
				this._Sensor = value;
				this.SendPropertyChanged("Sensor");
				this.OnSensorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolution", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Resolution
	{
		get
		{
			return this._Resolution;
		}
		set
		{
			if ((this._Resolution != value))
			{
				this.OnResolutionChanging(value);
				this.SendPropertyChanging();
				this._Resolution = value;
				this.SendPropertyChanged("Resolution");
				this.OnResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Acceleration", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Acceleration
	{
		get
		{
			return this._Max_Acceleration;
		}
		set
		{
			if ((this._Max_Acceleration != value))
			{
				this.OnMax_AccelerationChanging(value);
				this.SendPropertyChanging();
				this._Max_Acceleration = value;
				this.SendPropertyChanged("Max_Acceleration");
				this.OnMax_AccelerationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Speed
	{
		get
		{
			return this._Max_Speed;
		}
		set
		{
			if ((this._Max_Speed != value))
			{
				this.OnMax_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Max_Speed = value;
				this.SendPropertyChanged("Max_Speed");
				this.OnMax_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connection_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Connection_Type
	{
		get
		{
			return this._Connection_Type;
		}
		set
		{
			if ((this._Connection_Type != value))
			{
				this.OnConnection_TypeChanging(value);
				this.SendPropertyChanging();
				this._Connection_Type = value;
				this.SendPropertyChanged("Connection_Type");
				this.OnConnection_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Durability", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Durability
	{
		get
		{
			return this._Durability;
		}
		set
		{
			if ((this._Durability != value))
			{
				this.OnDurabilityChanging(value);
				this.SendPropertyChanging();
				this._Durability = value;
				this.SendPropertyChanged("Durability");
				this.OnDurabilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PTFE_Feet", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PTFE_Feet
	{
		get
		{
			return this._PTFE_Feet;
		}
		set
		{
			if ((this._PTFE_Feet != value))
			{
				this.OnPTFE_FeetChanging(value);
				this.SendPropertyChanging();
				this._PTFE_Feet = value;
				this.SendPropertyChanged("PTFE_Feet");
				this.OnPTFE_FeetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Battery", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Battery
	{
		get
		{
			return this._Battery;
		}
		set
		{
			if ((this._Battery != value))
			{
				this.OnBatteryChanging(value);
				this.SendPropertyChanging();
				this._Battery = value;
				this.SendPropertyChanged("Battery");
				this.OnBatteryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Support
	{
		get
		{
			return this._OS_Support;
		}
		set
		{
			if ((this._OS_Support != value))
			{
				this.OnOS_SupportChanging(value);
				this.SendPropertyChanging();
				this._OS_Support = value;
				this.SendPropertyChanged("OS_Support");
				this.OnOS_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Mouse_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Mouse_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Mouse", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Mouse = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Mouse = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Mouse", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Mouse = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Mouse = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Mouse = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Mouse = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Mouse = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Mouse = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MousePad")]
public partial class MousePad : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Colour;
	
	private string _Size;
	
	private string _Materials;
	
	private string _Base;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnBaseChanging(string value);
    partial void OnBaseChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public MousePad()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Materials
	{
		get
		{
			return this._Materials;
		}
		set
		{
			if ((this._Materials != value))
			{
				this.OnMaterialsChanging(value);
				this.SendPropertyChanging();
				this._Materials = value;
				this.SendPropertyChanged("Materials");
				this.OnMaterialsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base
	{
		get
		{
			return this._Base;
		}
		set
		{
			if ((this._Base != value))
			{
				this.OnBaseChanging(value);
				this.SendPropertyChanging();
				this._Base = value;
				this.SendPropertyChanged("Base");
				this.OnBaseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_MousePad", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.MousePad = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.MousePad = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_MousePad", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.MousePad = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.MousePad = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OperatingSystem")]
public partial class OperatingSystem : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Bit_Version;
	
	private string _OS_Version;
	
	private string _System_Requirements;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnBit_VersionChanging(string value);
    partial void OnBit_VersionChanged();
    partial void OnOS_VersionChanging(string value);
    partial void OnOS_VersionChanged();
    partial void OnSystem_RequirementsChanging(string value);
    partial void OnSystem_RequirementsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public OperatingSystem()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bit_Version", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Bit_Version
	{
		get
		{
			return this._Bit_Version;
		}
		set
		{
			if ((this._Bit_Version != value))
			{
				this.OnBit_VersionChanging(value);
				this.SendPropertyChanging();
				this._Bit_Version = value;
				this.SendPropertyChanged("Bit_Version");
				this.OnBit_VersionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Version", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Version
	{
		get
		{
			return this._OS_Version;
		}
		set
		{
			if ((this._OS_Version != value))
			{
				this.OnOS_VersionChanging(value);
				this.SendPropertyChanging();
				this._OS_Version = value;
				this.SendPropertyChanged("OS_Version");
				this.OnOS_VersionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Requirements", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string System_Requirements
	{
		get
		{
			return this._System_Requirements;
		}
		set
		{
			if ((this._System_Requirements != value))
			{
				this.OnSystem_RequirementsChanging(value);
				this.SendPropertyChanging();
				this._System_Requirements = value;
				this.SendPropertyChanged("System_Requirements");
				this.OnSystem_RequirementsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="OS_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="OS_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_OperatingSystem", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.OperatingSystem = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.OperatingSystem = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_OperatingSystem", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.OperatingSystem = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.OperatingSystem = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartsSold")]
public partial class PartsSold : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Type;
	
	private int _Quantity_Sold;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantity_SoldChanging(int value);
    partial void OnQuantity_SoldChanged();
    #endregion
	
	public PartsSold()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Sold", DbType="Int NOT NULL")]
	public int Quantity_Sold
	{
		get
		{
			return this._Quantity_Sold;
		}
		set
		{
			if ((this._Quantity_Sold != value))
			{
				this.OnQuantity_SoldChanging(value);
				this.SendPropertyChanging();
				this._Quantity_Sold = value;
				this.SendPropertyChanged("Quantity_Sold");
				this.OnQuantity_SoldChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartsSold", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartsSold = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartsSold = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartsSold", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartsSold = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartsSold = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartsStock")]
public partial class PartsStock : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Type;
	
	private int _Quantity;
	
	private decimal _Price;
	
	private string _Image;
	
	private int _Active;
	
	private int _Discount;
	
	private EntityRef<AirCooler> _AirCooler;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<Fan> _Fan;
	
	private EntityRef<GPU> _GPU;
	
	private EntityRef<HDD> _HDD;
	
	private EntityRef<Headset> _Headset;
	
	private EntityRef<Keyboard> _Keyboard;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<Microphone> _Microphone;
	
	private EntityRef<Monitor> _Monitor;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Mouse> _Mouse;
	
	private EntityRef<MousePad> _MousePad;
	
	private EntityRef<OperatingSystem> _OperatingSystem;
	
	private EntityRef<PartsSold> _PartsSold;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<PSU> _PSU;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Speaker> _Speaker;
	
	private EntityRef<SSD> _SSD;
	
	private EntitySet<PartInvoice> _PartInvoices;
	
	private EntitySet<PartCart> _PartCarts;
	
	private EntityRef<AirCooler1> _AirCooler1;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Fan1> _Fan1;
	
	private EntityRef<GPU1> _GPU1;
	
	private EntityRef<HDD1> _HDD1;
	
	private EntityRef<Headset1> _Headset1;
	
	private EntityRef<Keyboard1> _Keyboard1;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
	private EntityRef<Microphone1> _Microphone1;
	
	private EntityRef<Monitor1> _Monitor1;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<Mouse1> _Mouse1;
	
	private EntityRef<MousePad1> _MousePad1;
	
	private EntityRef<OperatingSystem1> _OperatingSystem1;
	
	private EntitySet<PartCart1> _PartCart1s;
	
	private EntitySet<PartInvoice1> _PartInvoice1s;
	
	private EntityRef<PartsSold1> _PartsSold1;
	
	private EntityRef<PCCase1> _PCCase1;
	
	private EntityRef<PSU1> _PSU1;
	
	private EntityRef<RAM1> _RAM1;
	
	private EntityRef<Speaker1> _Speaker1;
	
	private EntityRef<SSD1> _SSD1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    partial void OnDiscountChanging(int value);
    partial void OnDiscountChanged();
    #endregion
	
	public PartsStock()
	{
		this._AirCooler = default(EntityRef<AirCooler>);
		this._CPU = default(EntityRef<CPU>);
		this._Fan = default(EntityRef<Fan>);
		this._GPU = default(EntityRef<GPU>);
		this._HDD = default(EntityRef<HDD>);
		this._Headset = default(EntityRef<Headset>);
		this._Keyboard = default(EntityRef<Keyboard>);
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._Microphone = default(EntityRef<Microphone>);
		this._Monitor = default(EntityRef<Monitor>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Mouse = default(EntityRef<Mouse>);
		this._MousePad = default(EntityRef<MousePad>);
		this._OperatingSystem = default(EntityRef<OperatingSystem>);
		this._PartsSold = default(EntityRef<PartsSold>);
		this._PCCase = default(EntityRef<PCCase>);
		this._PSU = default(EntityRef<PSU>);
		this._RAM = default(EntityRef<RAM>);
		this._Speaker = default(EntityRef<Speaker>);
		this._SSD = default(EntityRef<SSD>);
		this._PartInvoices = new EntitySet<PartInvoice>(new Action<PartInvoice>(this.attach_PartInvoices), new Action<PartInvoice>(this.detach_PartInvoices));
		this._PartCarts = new EntitySet<PartCart>(new Action<PartCart>(this.attach_PartCarts), new Action<PartCart>(this.detach_PartCarts));
		this._AirCooler1 = default(EntityRef<AirCooler1>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Fan1 = default(EntityRef<Fan1>);
		this._GPU1 = default(EntityRef<GPU1>);
		this._HDD1 = default(EntityRef<HDD1>);
		this._Headset1 = default(EntityRef<Headset1>);
		this._Keyboard1 = default(EntityRef<Keyboard1>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		this._Microphone1 = default(EntityRef<Microphone1>);
		this._Monitor1 = default(EntityRef<Monitor1>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._Mouse1 = default(EntityRef<Mouse1>);
		this._MousePad1 = default(EntityRef<MousePad1>);
		this._OperatingSystem1 = default(EntityRef<OperatingSystem1>);
		this._PartCart1s = new EntitySet<PartCart1>(new Action<PartCart1>(this.attach_PartCart1s), new Action<PartCart1>(this.detach_PartCart1s));
		this._PartInvoice1s = new EntitySet<PartInvoice1>(new Action<PartInvoice1>(this.attach_PartInvoice1s), new Action<PartInvoice1>(this.detach_PartInvoice1s));
		this._PartsSold1 = default(EntityRef<PartsSold1>);
		this._PCCase1 = default(EntityRef<PCCase1>);
		this._PSU1 = default(EntityRef<PSU1>);
		this._RAM1 = default(EntityRef<RAM1>);
		this._Speaker1 = default(EntityRef<Speaker1>);
		this._SSD1 = default(EntityRef<SSD1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
	public int Active
	{
		get
		{
			return this._Active;
		}
		set
		{
			if ((this._Active != value))
			{
				this.OnActiveChanging(value);
				this.SendPropertyChanging();
				this._Active = value;
				this.SendPropertyChanged("Active");
				this.OnActiveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int NOT NULL")]
	public int Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_AirCooler", Storage="_AirCooler", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public AirCooler AirCooler
	{
		get
		{
			return this._AirCooler.Entity;
		}
		set
		{
			AirCooler previousValue = this._AirCooler.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler.Entity = null;
					previousValue.PartsStock = null;
				}
				this._AirCooler.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("AirCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_CPU", Storage="_CPU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.PartsStock = null;
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Fan", Storage="_Fan", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Fan Fan
	{
		get
		{
			return this._Fan.Entity;
		}
		set
		{
			Fan previousValue = this._Fan.Entity;
			if (((previousValue != value) 
						|| (this._Fan.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Fan.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Fan");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_GPU", Storage="_GPU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public GPU GPU
	{
		get
		{
			return this._GPU.Entity;
		}
		set
		{
			GPU previousValue = this._GPU.Entity;
			if (((previousValue != value) 
						|| (this._GPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU.Entity = null;
					previousValue.PartsStock = null;
				}
				this._GPU.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("GPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_HDD", Storage="_HDD", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public HDD HDD
	{
		get
		{
			return this._HDD.Entity;
		}
		set
		{
			HDD previousValue = this._HDD.Entity;
			if (((previousValue != value) 
						|| (this._HDD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD.Entity = null;
					previousValue.PartsStock = null;
				}
				this._HDD.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("HDD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Headset", Storage="_Headset", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Headset Headset
	{
		get
		{
			return this._Headset.Entity;
		}
		set
		{
			Headset previousValue = this._Headset.Entity;
			if (((previousValue != value) 
						|| (this._Headset.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Headset.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Headset");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Keyboard", Storage="_Keyboard", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Keyboard Keyboard
	{
		get
		{
			return this._Keyboard.Entity;
		}
		set
		{
			Keyboard previousValue = this._Keyboard.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Keyboard.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Keyboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_LiquidCooler", Storage="_LiquidCooler", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.PartsStock = null;
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Microphone", Storage="_Microphone", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Microphone Microphone
	{
		get
		{
			return this._Microphone.Entity;
		}
		set
		{
			Microphone previousValue = this._Microphone.Entity;
			if (((previousValue != value) 
						|| (this._Microphone.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Microphone.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Microphone.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Microphone");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Monitor", Storage="_Monitor", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Monitor Monitor
	{
		get
		{
			return this._Monitor.Entity;
		}
		set
		{
			Monitor previousValue = this._Monitor.Entity;
			if (((previousValue != value) 
						|| (this._Monitor.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Monitor.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Monitor");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Motherboard", Storage="_Motherboard", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Mouse", Storage="_Mouse", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Mouse Mouse
	{
		get
		{
			return this._Mouse.Entity;
		}
		set
		{
			Mouse previousValue = this._Mouse.Entity;
			if (((previousValue != value) 
						|| (this._Mouse.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Mouse.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Mouse");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_MousePad", Storage="_MousePad", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public MousePad MousePad
	{
		get
		{
			return this._MousePad.Entity;
		}
		set
		{
			MousePad previousValue = this._MousePad.Entity;
			if (((previousValue != value) 
						|| (this._MousePad.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._MousePad.Entity = null;
					previousValue.PartsStock = null;
				}
				this._MousePad.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("MousePad");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_OperatingSystem", Storage="_OperatingSystem", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public OperatingSystem OperatingSystem
	{
		get
		{
			return this._OperatingSystem.Entity;
		}
		set
		{
			OperatingSystem previousValue = this._OperatingSystem.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem.Entity = null;
					previousValue.PartsStock = null;
				}
				this._OperatingSystem.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("OperatingSystem");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartsSold", Storage="_PartsSold", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PartsSold PartsSold
	{
		get
		{
			return this._PartsSold.Entity;
		}
		set
		{
			PartsSold previousValue = this._PartsSold.Entity;
			if (((previousValue != value) 
						|| (this._PartsSold.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsSold.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PartsSold.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PartsSold");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PCCase", Storage="_PCCase", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PSU", Storage="_PSU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PSU PSU
	{
		get
		{
			return this._PSU.Entity;
		}
		set
		{
			PSU previousValue = this._PSU.Entity;
			if (((previousValue != value) 
						|| (this._PSU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PSU.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PSU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_RAM", Storage="_RAM", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.PartsStock = null;
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Speaker", Storage="_Speaker", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Speaker Speaker
	{
		get
		{
			return this._Speaker.Entity;
		}
		set
		{
			Speaker previousValue = this._Speaker.Entity;
			if (((previousValue != value) 
						|| (this._Speaker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Speaker.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Speaker");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_SSD", Storage="_SSD", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public SSD SSD
	{
		get
		{
			return this._SSD.Entity;
		}
		set
		{
			SSD previousValue = this._SSD.Entity;
			if (((previousValue != value) 
						|| (this._SSD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD.Entity = null;
					previousValue.PartsStock = null;
				}
				this._SSD.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("SSD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartInvoice", Storage="_PartInvoices", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartInvoice> PartInvoices
	{
		get
		{
			return this._PartInvoices;
		}
		set
		{
			this._PartInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartCart", Storage="_PartCarts", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartCart> PartCarts
	{
		get
		{
			return this._PartCarts;
		}
		set
		{
			this._PartCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_AirCooler1", Storage="_AirCooler1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public AirCooler1 AirCooler1
	{
		get
		{
			return this._AirCooler1.Entity;
		}
		set
		{
			AirCooler1 previousValue = this._AirCooler1.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._AirCooler1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("AirCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_CPU1", Storage="_CPU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Fan1", Storage="_Fan1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Fan1 Fan1
	{
		get
		{
			return this._Fan1.Entity;
		}
		set
		{
			Fan1 previousValue = this._Fan1.Entity;
			if (((previousValue != value) 
						|| (this._Fan1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Fan1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Fan1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_GPU1", Storage="_GPU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public GPU1 GPU1
	{
		get
		{
			return this._GPU1.Entity;
		}
		set
		{
			GPU1 previousValue = this._GPU1.Entity;
			if (((previousValue != value) 
						|| (this._GPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._GPU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("GPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_HDD1", Storage="_HDD1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public HDD1 HDD1
	{
		get
		{
			return this._HDD1.Entity;
		}
		set
		{
			HDD1 previousValue = this._HDD1.Entity;
			if (((previousValue != value) 
						|| (this._HDD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._HDD1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("HDD1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Headset1", Storage="_Headset1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Headset1 Headset1
	{
		get
		{
			return this._Headset1.Entity;
		}
		set
		{
			Headset1 previousValue = this._Headset1.Entity;
			if (((previousValue != value) 
						|| (this._Headset1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Headset1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Headset1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Keyboard1", Storage="_Keyboard1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Keyboard1 Keyboard1
	{
		get
		{
			return this._Keyboard1.Entity;
		}
		set
		{
			Keyboard1 previousValue = this._Keyboard1.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Keyboard1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Keyboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_LiquidCooler1", Storage="_LiquidCooler1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Microphone1", Storage="_Microphone1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Microphone1 Microphone1
	{
		get
		{
			return this._Microphone1.Entity;
		}
		set
		{
			Microphone1 previousValue = this._Microphone1.Entity;
			if (((previousValue != value) 
						|| (this._Microphone1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Microphone1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Microphone1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Microphone1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Monitor1", Storage="_Monitor1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Monitor1 Monitor1
	{
		get
		{
			return this._Monitor1.Entity;
		}
		set
		{
			Monitor1 previousValue = this._Monitor1.Entity;
			if (((previousValue != value) 
						|| (this._Monitor1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Monitor1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Monitor1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Motherboard1", Storage="_Motherboard1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Mouse1", Storage="_Mouse1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Mouse1 Mouse1
	{
		get
		{
			return this._Mouse1.Entity;
		}
		set
		{
			Mouse1 previousValue = this._Mouse1.Entity;
			if (((previousValue != value) 
						|| (this._Mouse1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Mouse1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Mouse1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_MousePad1", Storage="_MousePad1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public MousePad1 MousePad1
	{
		get
		{
			return this._MousePad1.Entity;
		}
		set
		{
			MousePad1 previousValue = this._MousePad1.Entity;
			if (((previousValue != value) 
						|| (this._MousePad1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._MousePad1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._MousePad1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("MousePad1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_OperatingSystem1", Storage="_OperatingSystem1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public OperatingSystem1 OperatingSystem1
	{
		get
		{
			return this._OperatingSystem1.Entity;
		}
		set
		{
			OperatingSystem1 previousValue = this._OperatingSystem1.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._OperatingSystem1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("OperatingSystem1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartCart1", Storage="_PartCart1s", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartCart1> PartCart1s
	{
		get
		{
			return this._PartCart1s;
		}
		set
		{
			this._PartCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartInvoice1", Storage="_PartInvoice1s", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartInvoice1> PartInvoice1s
	{
		get
		{
			return this._PartInvoice1s;
		}
		set
		{
			this._PartInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartsSold1", Storage="_PartsSold1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PartsSold1 PartsSold1
	{
		get
		{
			return this._PartsSold1.Entity;
		}
		set
		{
			PartsSold1 previousValue = this._PartsSold1.Entity;
			if (((previousValue != value) 
						|| (this._PartsSold1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsSold1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PartsSold1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PartsSold1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PCCase1", Storage="_PCCase1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PSU1", Storage="_PSU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PSU1 PSU1
	{
		get
		{
			return this._PSU1.Entity;
		}
		set
		{
			PSU1 previousValue = this._PSU1.Entity;
			if (((previousValue != value) 
						|| (this._PSU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._PSU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("PSU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_RAM1", Storage="_RAM1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Speaker1", Storage="_Speaker1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Speaker1 Speaker1
	{
		get
		{
			return this._Speaker1.Entity;
		}
		set
		{
			Speaker1 previousValue = this._Speaker1.Entity;
			if (((previousValue != value) 
						|| (this._Speaker1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._Speaker1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("Speaker1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_SSD1", Storage="_SSD1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public SSD1 SSD1
	{
		get
		{
			return this._SSD1.Entity;
		}
		set
		{
			SSD1 previousValue = this._SSD1.Entity;
			if (((previousValue != value) 
						|| (this._SSD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD1.Entity = null;
					previousValue.PartsStock = null;
				}
				this._SSD1.Entity = value;
				if ((value != null))
				{
					value.PartsStock = this;
				}
				this.SendPropertyChanged("SSD1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = this;
	}
	
	private void detach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = null;
	}
	
	private void attach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = this;
	}
	
	private void detach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = null;
	}
	
	private void attach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = this;
	}
	
	private void detach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = null;
	}
	
	private void attach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = this;
	}
	
	private void detach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pc")]
public partial class Pc : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PC_ID;
	
	private string _PC_Type;
	
	private int _Case_ID;
	
	private int _Mobo_ID;
	
	private int _CPU_ID;
	
	private int _RAM_ID;
	
	private int _GPU_ID;
	
	private int _Cooler_ID;
	
	private System.Nullable<int> _SSD_ID;
	
	private int _Fan_ID;
	
	private System.Nullable<int> _HDD_ID;
	
	private int _PSU_ID;
	
	private int _OS_ID;
	
	private int _Num_Fans;
	
	private int _Num_SSD;
	
	private int _Num_HDD;
	
	private System.Nullable<int> _Monitor_ID;
	
	private System.Nullable<int> _Headset_ID;
	
	private System.Nullable<int> _Keyboard_ID;
	
	private System.Nullable<int> _Mouse_ID;
	
	private System.Nullable<int> _Speaker_ID;
	
	private string _Warranty;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<Fan> _Fan;
	
	private EntityRef<GPU> _GPU;
	
	private EntityRef<HDD> _HDD;
	
	private EntityRef<Headset> _Headset;
	
	private EntityRef<Keyboard> _Keyboard;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Monitor> _Monitor;
	
	private EntityRef<Mouse> _Mouse;
	
	private EntityRef<OperatingSystem> _OperatingSystem;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<PSU> _PSU;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Speaker> _Speaker;
	
	private EntityRef<SSD> _SSD;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Fan1> _Fan1;
	
	private EntityRef<GPU1> _GPU1;
	
	private EntityRef<HDD1> _HDD1;
	
	private EntityRef<Headset1> _Headset1;
	
	private EntityRef<Keyboard1> _Keyboard1;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
	private EntityRef<Monitor1> _Monitor1;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<Mouse1> _Mouse1;
	
	private EntityRef<OperatingSystem1> _OperatingSystem1;
	
	private EntityRef<PCCase1> _PCCase1;
	
	private EntityRef<PcStock1> _PcStock1;
	
	private EntityRef<PSU1> _PSU1;
	
	private EntityRef<RAM1> _RAM1;
	
	private EntityRef<Speaker1> _Speaker1;
	
	private EntityRef<SSD1> _SSD1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnPC_TypeChanging(string value);
    partial void OnPC_TypeChanged();
    partial void OnCase_IDChanging(int value);
    partial void OnCase_IDChanged();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnRAM_IDChanging(int value);
    partial void OnRAM_IDChanged();
    partial void OnGPU_IDChanging(int value);
    partial void OnGPU_IDChanged();
    partial void OnCooler_IDChanging(int value);
    partial void OnCooler_IDChanged();
    partial void OnSSD_IDChanging(System.Nullable<int> value);
    partial void OnSSD_IDChanged();
    partial void OnFan_IDChanging(int value);
    partial void OnFan_IDChanged();
    partial void OnHDD_IDChanging(System.Nullable<int> value);
    partial void OnHDD_IDChanged();
    partial void OnPSU_IDChanging(int value);
    partial void OnPSU_IDChanged();
    partial void OnOS_IDChanging(int value);
    partial void OnOS_IDChanged();
    partial void OnNum_FansChanging(int value);
    partial void OnNum_FansChanged();
    partial void OnNum_SSDChanging(int value);
    partial void OnNum_SSDChanged();
    partial void OnNum_HDDChanging(int value);
    partial void OnNum_HDDChanged();
    partial void OnMonitor_IDChanging(System.Nullable<int> value);
    partial void OnMonitor_IDChanged();
    partial void OnHeadset_IDChanging(System.Nullable<int> value);
    partial void OnHeadset_IDChanged();
    partial void OnKeyboard_IDChanging(System.Nullable<int> value);
    partial void OnKeyboard_IDChanged();
    partial void OnMouse_IDChanging(System.Nullable<int> value);
    partial void OnMouse_IDChanged();
    partial void OnSpeaker_IDChanging(System.Nullable<int> value);
    partial void OnSpeaker_IDChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Pc()
	{
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._CPU = default(EntityRef<CPU>);
		this._Fan = default(EntityRef<Fan>);
		this._GPU = default(EntityRef<GPU>);
		this._HDD = default(EntityRef<HDD>);
		this._Headset = default(EntityRef<Headset>);
		this._Keyboard = default(EntityRef<Keyboard>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Monitor = default(EntityRef<Monitor>);
		this._Mouse = default(EntityRef<Mouse>);
		this._OperatingSystem = default(EntityRef<OperatingSystem>);
		this._PCCase = default(EntityRef<PCCase>);
		this._PcStock = default(EntityRef<PcStock>);
		this._PSU = default(EntityRef<PSU>);
		this._RAM = default(EntityRef<RAM>);
		this._Speaker = default(EntityRef<Speaker>);
		this._SSD = default(EntityRef<SSD>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Fan1 = default(EntityRef<Fan1>);
		this._GPU1 = default(EntityRef<GPU1>);
		this._HDD1 = default(EntityRef<HDD1>);
		this._Headset1 = default(EntityRef<Headset1>);
		this._Keyboard1 = default(EntityRef<Keyboard1>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		this._Monitor1 = default(EntityRef<Monitor1>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._Mouse1 = default(EntityRef<Mouse1>);
		this._OperatingSystem1 = default(EntityRef<OperatingSystem1>);
		this._PCCase1 = default(EntityRef<PCCase1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		this._PSU1 = default(EntityRef<PSU1>);
		this._RAM1 = default(EntityRef<RAM1>);
		this._Speaker1 = default(EntityRef<Speaker1>);
		this._SSD1 = default(EntityRef<SSD1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PC_Type
	{
		get
		{
			return this._PC_Type;
		}
		set
		{
			if ((this._PC_Type != value))
			{
				this.OnPC_TypeChanging(value);
				this.SendPropertyChanging();
				this._PC_Type = value;
				this.SendPropertyChanged("PC_Type");
				this.OnPC_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Case_ID", DbType="Int NOT NULL")]
	public int Case_ID
	{
		get
		{
			return this._Case_ID;
		}
		set
		{
			if ((this._Case_ID != value))
			{
				if ((this._PCCase.HasLoadedOrAssignedValue || this._PCCase1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCase_IDChanging(value);
				this.SendPropertyChanging();
				this._Case_ID = value;
				this.SendPropertyChanged("Case_ID");
				this.OnCase_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL")]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL")]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL")]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				if ((this._RAM.HasLoadedOrAssignedValue || this._RAM1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRAM_IDChanging(value);
				this.SendPropertyChanging();
				this._RAM_ID = value;
				this.SendPropertyChanged("RAM_ID");
				this.OnRAM_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPU_ID", DbType="Int NOT NULL")]
	public int GPU_ID
	{
		get
		{
			return this._GPU_ID;
		}
		set
		{
			if ((this._GPU_ID != value))
			{
				if ((this._GPU.HasLoadedOrAssignedValue || this._GPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnGPU_IDChanging(value);
				this.SendPropertyChanging();
				this._GPU_ID = value;
				this.SendPropertyChanged("GPU_ID");
				this.OnGPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cooler_ID", DbType="Int NOT NULL")]
	public int Cooler_ID
	{
		get
		{
			return this._Cooler_ID;
		}
		set
		{
			if ((this._Cooler_ID != value))
			{
				if ((this._LiquidCooler.HasLoadedOrAssignedValue || this._LiquidCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCooler_IDChanging(value);
				this.SendPropertyChanging();
				this._Cooler_ID = value;
				this.SendPropertyChanged("Cooler_ID");
				this.OnCooler_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSD_ID", DbType="Int")]
	public System.Nullable<int> SSD_ID
	{
		get
		{
			return this._SSD_ID;
		}
		set
		{
			if ((this._SSD_ID != value))
			{
				if ((this._SSD.HasLoadedOrAssignedValue || this._SSD1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSSD_IDChanging(value);
				this.SendPropertyChanging();
				this._SSD_ID = value;
				this.SendPropertyChanged("SSD_ID");
				this.OnSSD_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_ID", DbType="Int NOT NULL")]
	public int Fan_ID
	{
		get
		{
			return this._Fan_ID;
		}
		set
		{
			if ((this._Fan_ID != value))
			{
				if ((this._Fan.HasLoadedOrAssignedValue || this._Fan1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFan_IDChanging(value);
				this.SendPropertyChanging();
				this._Fan_ID = value;
				this.SendPropertyChanged("Fan_ID");
				this.OnFan_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HDD_ID", DbType="Int")]
	public System.Nullable<int> HDD_ID
	{
		get
		{
			return this._HDD_ID;
		}
		set
		{
			if ((this._HDD_ID != value))
			{
				if ((this._HDD.HasLoadedOrAssignedValue || this._HDD1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnHDD_IDChanging(value);
				this.SendPropertyChanging();
				this._HDD_ID = value;
				this.SendPropertyChanged("HDD_ID");
				this.OnHDD_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PSU_ID", DbType="Int NOT NULL")]
	public int PSU_ID
	{
		get
		{
			return this._PSU_ID;
		}
		set
		{
			if ((this._PSU_ID != value))
			{
				if ((this._PSU.HasLoadedOrAssignedValue || this._PSU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPSU_IDChanging(value);
				this.SendPropertyChanging();
				this._PSU_ID = value;
				this.SendPropertyChanged("PSU_ID");
				this.OnPSU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_ID", DbType="Int NOT NULL")]
	public int OS_ID
	{
		get
		{
			return this._OS_ID;
		}
		set
		{
			if ((this._OS_ID != value))
			{
				if ((this._OperatingSystem.HasLoadedOrAssignedValue || this._OperatingSystem1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOS_IDChanging(value);
				this.SendPropertyChanging();
				this._OS_ID = value;
				this.SendPropertyChanged("OS_ID");
				this.OnOS_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Fans", DbType="Int NOT NULL")]
	public int Num_Fans
	{
		get
		{
			return this._Num_Fans;
		}
		set
		{
			if ((this._Num_Fans != value))
			{
				this.OnNum_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Fans = value;
				this.SendPropertyChanged("Num_Fans");
				this.OnNum_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_SSD", DbType="Int NOT NULL")]
	public int Num_SSD
	{
		get
		{
			return this._Num_SSD;
		}
		set
		{
			if ((this._Num_SSD != value))
			{
				this.OnNum_SSDChanging(value);
				this.SendPropertyChanging();
				this._Num_SSD = value;
				this.SendPropertyChanged("Num_SSD");
				this.OnNum_SSDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_HDD", DbType="Int NOT NULL")]
	public int Num_HDD
	{
		get
		{
			return this._Num_HDD;
		}
		set
		{
			if ((this._Num_HDD != value))
			{
				this.OnNum_HDDChanging(value);
				this.SendPropertyChanging();
				this._Num_HDD = value;
				this.SendPropertyChanged("Num_HDD");
				this.OnNum_HDDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Monitor_ID", DbType="Int")]
	public System.Nullable<int> Monitor_ID
	{
		get
		{
			return this._Monitor_ID;
		}
		set
		{
			if ((this._Monitor_ID != value))
			{
				if ((this._Monitor.HasLoadedOrAssignedValue || this._Monitor1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMonitor_IDChanging(value);
				this.SendPropertyChanging();
				this._Monitor_ID = value;
				this.SendPropertyChanged("Monitor_ID");
				this.OnMonitor_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Headset_ID", DbType="Int")]
	public System.Nullable<int> Headset_ID
	{
		get
		{
			return this._Headset_ID;
		}
		set
		{
			if ((this._Headset_ID != value))
			{
				if ((this._Headset.HasLoadedOrAssignedValue || this._Headset1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnHeadset_IDChanging(value);
				this.SendPropertyChanging();
				this._Headset_ID = value;
				this.SendPropertyChanged("Headset_ID");
				this.OnHeadset_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keyboard_ID", DbType="Int")]
	public System.Nullable<int> Keyboard_ID
	{
		get
		{
			return this._Keyboard_ID;
		}
		set
		{
			if ((this._Keyboard_ID != value))
			{
				if ((this._Keyboard.HasLoadedOrAssignedValue || this._Keyboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnKeyboard_IDChanging(value);
				this.SendPropertyChanging();
				this._Keyboard_ID = value;
				this.SendPropertyChanged("Keyboard_ID");
				this.OnKeyboard_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mouse_ID", DbType="Int")]
	public System.Nullable<int> Mouse_ID
	{
		get
		{
			return this._Mouse_ID;
		}
		set
		{
			if ((this._Mouse_ID != value))
			{
				if ((this._Mouse.HasLoadedOrAssignedValue || this._Mouse1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMouse_IDChanging(value);
				this.SendPropertyChanging();
				this._Mouse_ID = value;
				this.SendPropertyChanged("Mouse_ID");
				this.OnMouse_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speaker_ID", DbType="Int")]
	public System.Nullable<int> Speaker_ID
	{
		get
		{
			return this._Speaker_ID;
		}
		set
		{
			if ((this._Speaker_ID != value))
			{
				if ((this._Speaker.HasLoadedOrAssignedValue || this._Speaker1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSpeaker_IDChanging(value);
				this.SendPropertyChanging();
				this._Speaker_ID = value;
				this.SendPropertyChanged("Speaker_ID");
				this.OnSpeaker_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_Pc", Storage="_LiquidCooler", ThisKey="Cooler_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Cooler_ID = value.ID;
				}
				else
				{
					this._Cooler_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_Pc", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan_Pc", Storage="_Fan", ThisKey="Fan_ID", OtherKey="ID", IsForeignKey=true)]
	public Fan Fan
	{
		get
		{
			return this._Fan.Entity;
		}
		set
		{
			Fan previousValue = this._Fan.Entity;
			if (((previousValue != value) 
						|| (this._Fan.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Fan.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Fan_ID = value.ID;
				}
				else
				{
					this._Fan_ID = default(int);
				}
				this.SendPropertyChanged("Fan");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU_Pc", Storage="_GPU", ThisKey="GPU_ID", OtherKey="ID", IsForeignKey=true)]
	public GPU GPU
	{
		get
		{
			return this._GPU.Entity;
		}
		set
		{
			GPU previousValue = this._GPU.Entity;
			if (((previousValue != value) 
						|| (this._GPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._GPU.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._GPU_ID = value.ID;
				}
				else
				{
					this._GPU_ID = default(int);
				}
				this.SendPropertyChanged("GPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD_Pc", Storage="_HDD", ThisKey="HDD_ID", OtherKey="ID", IsForeignKey=true)]
	public HDD HDD
	{
		get
		{
			return this._HDD.Entity;
		}
		set
		{
			HDD previousValue = this._HDD.Entity;
			if (((previousValue != value) 
						|| (this._HDD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._HDD.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._HDD_ID = value.ID;
				}
				else
				{
					this._HDD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("HDD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset_Pc", Storage="_Headset", ThisKey="Headset_ID", OtherKey="ID", IsForeignKey=true)]
	public Headset Headset
	{
		get
		{
			return this._Headset.Entity;
		}
		set
		{
			Headset previousValue = this._Headset.Entity;
			if (((previousValue != value) 
						|| (this._Headset.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Headset.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Headset_ID = value.ID;
				}
				else
				{
					this._Headset_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Headset");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard_Pc", Storage="_Keyboard", ThisKey="Keyboard_ID", OtherKey="ID", IsForeignKey=true)]
	public Keyboard Keyboard
	{
		get
		{
			return this._Keyboard.Entity;
		}
		set
		{
			Keyboard previousValue = this._Keyboard.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Keyboard.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Keyboard_ID = value.ID;
				}
				else
				{
					this._Keyboard_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Keyboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_Pc", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor_Pc", Storage="_Monitor", ThisKey="Monitor_ID", OtherKey="ID", IsForeignKey=true)]
	public Monitor Monitor
	{
		get
		{
			return this._Monitor.Entity;
		}
		set
		{
			Monitor previousValue = this._Monitor.Entity;
			if (((previousValue != value) 
						|| (this._Monitor.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Monitor.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Monitor_ID = value.ID;
				}
				else
				{
					this._Monitor_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Monitor");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse_Pc", Storage="_Mouse", ThisKey="Mouse_ID", OtherKey="ID", IsForeignKey=true)]
	public Mouse Mouse
	{
		get
		{
			return this._Mouse.Entity;
		}
		set
		{
			Mouse previousValue = this._Mouse.Entity;
			if (((previousValue != value) 
						|| (this._Mouse.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Mouse.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Mouse_ID = value.ID;
				}
				else
				{
					this._Mouse_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Mouse");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem_Pc", Storage="_OperatingSystem", ThisKey="OS_ID", OtherKey="ID", IsForeignKey=true)]
	public OperatingSystem OperatingSystem
	{
		get
		{
			return this._OperatingSystem.Entity;
		}
		set
		{
			OperatingSystem previousValue = this._OperatingSystem.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._OperatingSystem.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._OS_ID = value.ID;
				}
				else
				{
					this._OS_ID = default(int);
				}
				this.SendPropertyChanged("OperatingSystem");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_Pc", Storage="_PCCase", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_Pc", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.Pc = null;
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.Pc = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU_Pc", Storage="_PSU", ThisKey="PSU_ID", OtherKey="ID", IsForeignKey=true)]
	public PSU PSU
	{
		get
		{
			return this._PSU.Entity;
		}
		set
		{
			PSU previousValue = this._PSU.Entity;
			if (((previousValue != value) 
						|| (this._PSU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._PSU.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._PSU_ID = value.ID;
				}
				else
				{
					this._PSU_ID = default(int);
				}
				this.SendPropertyChanged("PSU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_Pc", Storage="_RAM", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker_Pc", Storage="_Speaker", ThisKey="Speaker_ID", OtherKey="ID", IsForeignKey=true)]
	public Speaker Speaker
	{
		get
		{
			return this._Speaker.Entity;
		}
		set
		{
			Speaker previousValue = this._Speaker.Entity;
			if (((previousValue != value) 
						|| (this._Speaker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Speaker.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Speaker_ID = value.ID;
				}
				else
				{
					this._Speaker_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Speaker");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD_Pc", Storage="_SSD", ThisKey="SSD_ID", OtherKey="ID", IsForeignKey=true)]
	public SSD SSD
	{
		get
		{
			return this._SSD.Entity;
		}
		set
		{
			SSD previousValue = this._SSD.Entity;
			if (((previousValue != value) 
						|| (this._SSD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._SSD.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._SSD_ID = value.ID;
				}
				else
				{
					this._SSD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SSD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_Pc", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan1_Pc", Storage="_Fan1", ThisKey="Fan_ID", OtherKey="ID", IsForeignKey=true)]
	public Fan1 Fan1
	{
		get
		{
			return this._Fan1.Entity;
		}
		set
		{
			Fan1 previousValue = this._Fan1.Entity;
			if (((previousValue != value) 
						|| (this._Fan1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Fan1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Fan_ID = value.ID;
				}
				else
				{
					this._Fan_ID = default(int);
				}
				this.SendPropertyChanged("Fan1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU1_Pc", Storage="_GPU1", ThisKey="GPU_ID", OtherKey="ID", IsForeignKey=true)]
	public GPU1 GPU1
	{
		get
		{
			return this._GPU1.Entity;
		}
		set
		{
			GPU1 previousValue = this._GPU1.Entity;
			if (((previousValue != value) 
						|| (this._GPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._GPU1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._GPU_ID = value.ID;
				}
				else
				{
					this._GPU_ID = default(int);
				}
				this.SendPropertyChanged("GPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD1_Pc", Storage="_HDD1", ThisKey="HDD_ID", OtherKey="ID", IsForeignKey=true)]
	public HDD1 HDD1
	{
		get
		{
			return this._HDD1.Entity;
		}
		set
		{
			HDD1 previousValue = this._HDD1.Entity;
			if (((previousValue != value) 
						|| (this._HDD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._HDD1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._HDD_ID = value.ID;
				}
				else
				{
					this._HDD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("HDD1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset1_Pc", Storage="_Headset1", ThisKey="Headset_ID", OtherKey="ID", IsForeignKey=true)]
	public Headset1 Headset1
	{
		get
		{
			return this._Headset1.Entity;
		}
		set
		{
			Headset1 previousValue = this._Headset1.Entity;
			if (((previousValue != value) 
						|| (this._Headset1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Headset1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Headset_ID = value.ID;
				}
				else
				{
					this._Headset_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Headset1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard1_Pc", Storage="_Keyboard1", ThisKey="Keyboard_ID", OtherKey="ID", IsForeignKey=true)]
	public Keyboard1 Keyboard1
	{
		get
		{
			return this._Keyboard1.Entity;
		}
		set
		{
			Keyboard1 previousValue = this._Keyboard1.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Keyboard1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Keyboard_ID = value.ID;
				}
				else
				{
					this._Keyboard_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Keyboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_Pc", Storage="_LiquidCooler1", ThisKey="Cooler_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Cooler_ID = value.ID;
				}
				else
				{
					this._Cooler_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor1_Pc", Storage="_Monitor1", ThisKey="Monitor_ID", OtherKey="ID", IsForeignKey=true)]
	public Monitor1 Monitor1
	{
		get
		{
			return this._Monitor1.Entity;
		}
		set
		{
			Monitor1 previousValue = this._Monitor1.Entity;
			if (((previousValue != value) 
						|| (this._Monitor1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Monitor1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Monitor_ID = value.ID;
				}
				else
				{
					this._Monitor_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Monitor1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_Pc", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse1_Pc", Storage="_Mouse1", ThisKey="Mouse_ID", OtherKey="ID", IsForeignKey=true)]
	public Mouse1 Mouse1
	{
		get
		{
			return this._Mouse1.Entity;
		}
		set
		{
			Mouse1 previousValue = this._Mouse1.Entity;
			if (((previousValue != value) 
						|| (this._Mouse1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Mouse1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Mouse_ID = value.ID;
				}
				else
				{
					this._Mouse_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Mouse1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem1_Pc", Storage="_OperatingSystem1", ThisKey="OS_ID", OtherKey="ID", IsForeignKey=true)]
	public OperatingSystem1 OperatingSystem1
	{
		get
		{
			return this._OperatingSystem1.Entity;
		}
		set
		{
			OperatingSystem1 previousValue = this._OperatingSystem1.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._OperatingSystem1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._OS_ID = value.ID;
				}
				else
				{
					this._OS_ID = default(int);
				}
				this.SendPropertyChanged("OperatingSystem1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_Pc", Storage="_PCCase1", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_Pc", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.Pc = null;
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.Pc = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU1_Pc", Storage="_PSU1", ThisKey="PSU_ID", OtherKey="ID", IsForeignKey=true)]
	public PSU1 PSU1
	{
		get
		{
			return this._PSU1.Entity;
		}
		set
		{
			PSU1 previousValue = this._PSU1.Entity;
			if (((previousValue != value) 
						|| (this._PSU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._PSU1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._PSU_ID = value.ID;
				}
				else
				{
					this._PSU_ID = default(int);
				}
				this.SendPropertyChanged("PSU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_Pc", Storage="_RAM1", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker1_Pc", Storage="_Speaker1", ThisKey="Speaker_ID", OtherKey="ID", IsForeignKey=true)]
	public Speaker1 Speaker1
	{
		get
		{
			return this._Speaker1.Entity;
		}
		set
		{
			Speaker1 previousValue = this._Speaker1.Entity;
			if (((previousValue != value) 
						|| (this._Speaker1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._Speaker1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._Speaker_ID = value.ID;
				}
				else
				{
					this._Speaker_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Speaker1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD1_Pc", Storage="_SSD1", ThisKey="SSD_ID", OtherKey="ID", IsForeignKey=true)]
	public SSD1 SSD1
	{
		get
		{
			return this._SSD1.Entity;
		}
		set
		{
			SSD1 previousValue = this._SSD1.Entity;
			if (((previousValue != value) 
						|| (this._SSD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD1.Entity = null;
					previousValue.Pcs.Remove(this);
				}
				this._SSD1.Entity = value;
				if ((value != null))
				{
					value.Pcs.Add(this);
					this._SSD_ID = value.ID;
				}
				else
				{
					this._SSD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SSD1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PCCase")]
public partial class PCCase : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Colour;
	
	private string _Dimensions;
	
	private string _Net_Weight;
	
	private string _Motherboard_Form_Factor;
	
	private string _Side_Window;
	
	private string _Num_HDD_Drives;
	
	private string _Num_SSD_Drives;
	
	private string _Front_I_O;
	
	private string _Expansion_Slots;
	
	private int _Num_Top_Fans;
	
	private int _Num_Bottom_Fans;
	
	private int _Num_Front_Fans;
	
	private int _Num_Back_Fans;
	
	private string _Top_Radiator_Support;
	
	private string _Front_Radiator_Support;
	
	private string _GPU_Max_Length;
	
	private string _CPU_Cooler_Height;
	
	private string _Warranty;
	
	private EntitySet<MoboToCase> _MoboToCases;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<MoboToCase1> _MoboToCase1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnNet_WeightChanging(string value);
    partial void OnNet_WeightChanged();
    partial void OnMotherboard_Form_FactorChanging(string value);
    partial void OnMotherboard_Form_FactorChanged();
    partial void OnSide_WindowChanging(string value);
    partial void OnSide_WindowChanged();
    partial void OnNum_HDD_DrivesChanging(string value);
    partial void OnNum_HDD_DrivesChanged();
    partial void OnNum_SSD_DrivesChanging(string value);
    partial void OnNum_SSD_DrivesChanged();
    partial void OnFront_I_OChanging(string value);
    partial void OnFront_I_OChanged();
    partial void OnExpansion_SlotsChanging(string value);
    partial void OnExpansion_SlotsChanged();
    partial void OnNum_Top_FansChanging(int value);
    partial void OnNum_Top_FansChanged();
    partial void OnNum_Bottom_FansChanging(int value);
    partial void OnNum_Bottom_FansChanged();
    partial void OnNum_Front_FansChanging(int value);
    partial void OnNum_Front_FansChanged();
    partial void OnNum_Back_FansChanging(int value);
    partial void OnNum_Back_FansChanged();
    partial void OnTop_Radiator_SupportChanging(string value);
    partial void OnTop_Radiator_SupportChanged();
    partial void OnFront_Radiator_SupportChanging(string value);
    partial void OnFront_Radiator_SupportChanged();
    partial void OnGPU_Max_LengthChanging(string value);
    partial void OnGPU_Max_LengthChanged();
    partial void OnCPU_Cooler_HeightChanging(string value);
    partial void OnCPU_Cooler_HeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public PCCase()
	{
		this._MoboToCases = new EntitySet<MoboToCase>(new Action<MoboToCase>(this.attach_MoboToCases), new Action<MoboToCase>(this.detach_MoboToCases));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._MoboToCase1s = new EntitySet<MoboToCase1>(new Action<MoboToCase1>(this.attach_MoboToCase1s), new Action<MoboToCase1>(this.detach_MoboToCase1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Net_Weight", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Net_Weight
	{
		get
		{
			return this._Net_Weight;
		}
		set
		{
			if ((this._Net_Weight != value))
			{
				this.OnNet_WeightChanging(value);
				this.SendPropertyChanging();
				this._Net_Weight = value;
				this.SendPropertyChanged("Net_Weight");
				this.OnNet_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Motherboard_Form_Factor", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Motherboard_Form_Factor
	{
		get
		{
			return this._Motherboard_Form_Factor;
		}
		set
		{
			if ((this._Motherboard_Form_Factor != value))
			{
				this.OnMotherboard_Form_FactorChanging(value);
				this.SendPropertyChanging();
				this._Motherboard_Form_Factor = value;
				this.SendPropertyChanged("Motherboard_Form_Factor");
				this.OnMotherboard_Form_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Side_Window", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Side_Window
	{
		get
		{
			return this._Side_Window;
		}
		set
		{
			if ((this._Side_Window != value))
			{
				this.OnSide_WindowChanging(value);
				this.SendPropertyChanging();
				this._Side_Window = value;
				this.SendPropertyChanged("Side_Window");
				this.OnSide_WindowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_HDD_Drives", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Num_HDD_Drives
	{
		get
		{
			return this._Num_HDD_Drives;
		}
		set
		{
			if ((this._Num_HDD_Drives != value))
			{
				this.OnNum_HDD_DrivesChanging(value);
				this.SendPropertyChanging();
				this._Num_HDD_Drives = value;
				this.SendPropertyChanged("Num_HDD_Drives");
				this.OnNum_HDD_DrivesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_SSD_Drives", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Num_SSD_Drives
	{
		get
		{
			return this._Num_SSD_Drives;
		}
		set
		{
			if ((this._Num_SSD_Drives != value))
			{
				this.OnNum_SSD_DrivesChanging(value);
				this.SendPropertyChanging();
				this._Num_SSD_Drives = value;
				this.SendPropertyChanged("Num_SSD_Drives");
				this.OnNum_SSD_DrivesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Front_I/O]", Storage="_Front_I_O", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Front_I_O
	{
		get
		{
			return this._Front_I_O;
		}
		set
		{
			if ((this._Front_I_O != value))
			{
				this.OnFront_I_OChanging(value);
				this.SendPropertyChanging();
				this._Front_I_O = value;
				this.SendPropertyChanged("Front_I_O");
				this.OnFront_I_OChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expansion_Slots", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Expansion_Slots
	{
		get
		{
			return this._Expansion_Slots;
		}
		set
		{
			if ((this._Expansion_Slots != value))
			{
				this.OnExpansion_SlotsChanging(value);
				this.SendPropertyChanging();
				this._Expansion_Slots = value;
				this.SendPropertyChanged("Expansion_Slots");
				this.OnExpansion_SlotsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Top_Fans", DbType="Int NOT NULL")]
	public int Num_Top_Fans
	{
		get
		{
			return this._Num_Top_Fans;
		}
		set
		{
			if ((this._Num_Top_Fans != value))
			{
				this.OnNum_Top_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Top_Fans = value;
				this.SendPropertyChanged("Num_Top_Fans");
				this.OnNum_Top_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Bottom_Fans", DbType="Int NOT NULL")]
	public int Num_Bottom_Fans
	{
		get
		{
			return this._Num_Bottom_Fans;
		}
		set
		{
			if ((this._Num_Bottom_Fans != value))
			{
				this.OnNum_Bottom_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Bottom_Fans = value;
				this.SendPropertyChanged("Num_Bottom_Fans");
				this.OnNum_Bottom_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Front_Fans", DbType="Int NOT NULL")]
	public int Num_Front_Fans
	{
		get
		{
			return this._Num_Front_Fans;
		}
		set
		{
			if ((this._Num_Front_Fans != value))
			{
				this.OnNum_Front_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Front_Fans = value;
				this.SendPropertyChanged("Num_Front_Fans");
				this.OnNum_Front_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Back_Fans", DbType="Int NOT NULL")]
	public int Num_Back_Fans
	{
		get
		{
			return this._Num_Back_Fans;
		}
		set
		{
			if ((this._Num_Back_Fans != value))
			{
				this.OnNum_Back_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Back_Fans = value;
				this.SendPropertyChanged("Num_Back_Fans");
				this.OnNum_Back_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Top_Radiator_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Top_Radiator_Support
	{
		get
		{
			return this._Top_Radiator_Support;
		}
		set
		{
			if ((this._Top_Radiator_Support != value))
			{
				this.OnTop_Radiator_SupportChanging(value);
				this.SendPropertyChanging();
				this._Top_Radiator_Support = value;
				this.SendPropertyChanged("Top_Radiator_Support");
				this.OnTop_Radiator_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Front_Radiator_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Front_Radiator_Support
	{
		get
		{
			return this._Front_Radiator_Support;
		}
		set
		{
			if ((this._Front_Radiator_Support != value))
			{
				this.OnFront_Radiator_SupportChanging(value);
				this.SendPropertyChanging();
				this._Front_Radiator_Support = value;
				this.SendPropertyChanged("Front_Radiator_Support");
				this.OnFront_Radiator_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPU_Max_Length", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string GPU_Max_Length
	{
		get
		{
			return this._GPU_Max_Length;
		}
		set
		{
			if ((this._GPU_Max_Length != value))
			{
				this.OnGPU_Max_LengthChanging(value);
				this.SendPropertyChanging();
				this._GPU_Max_Length = value;
				this.SendPropertyChanged("GPU_Max_Length");
				this.OnGPU_Max_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_Cooler_Height", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string CPU_Cooler_Height
	{
		get
		{
			return this._CPU_Cooler_Height;
		}
		set
		{
			if ((this._CPU_Cooler_Height != value))
			{
				this.OnCPU_Cooler_HeightChanging(value);
				this.SendPropertyChanging();
				this._CPU_Cooler_Height = value;
				this.SendPropertyChanged("CPU_Cooler_Height");
				this.OnCPU_Cooler_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_MoboToCase", Storage="_MoboToCases", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<MoboToCase> MoboToCases
	{
		get
		{
			return this._MoboToCases;
		}
		set
		{
			this._MoboToCases.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_MoboToCase1", Storage="_MoboToCase1s", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<MoboToCase1> MoboToCase1s
	{
		get
		{
			return this._MoboToCase1s;
		}
		set
		{
			this._MoboToCase1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PCCase", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PCCase = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PCCase = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PCCase", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PCCase = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PCCase = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = this;
	}
	
	private void detach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = null;
	}
	
	private void attach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = this;
	}
	
	private void detach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcSold")]
public partial class PcSold : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PC_ID;
	
	private string _Type;
	
	private int _Quantity_Sold;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantity_SoldChanging(int value);
    partial void OnQuantity_SoldChanged();
    #endregion
	
	public PcSold()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Sold", DbType="Int NOT NULL")]
	public int Quantity_Sold
	{
		get
		{
			return this._Quantity_Sold;
		}
		set
		{
			if ((this._Quantity_Sold != value))
			{
				this.OnQuantity_SoldChanging(value);
				this.SendPropertyChanging();
				this._Quantity_Sold = value;
				this.SendPropertyChanged("Quantity_Sold");
				this.OnQuantity_SoldChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcSold", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcSold = null;
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcSold = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcSold", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcSold = null;
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcSold = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcStock")]
public partial class PcStock : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private int _Quantity;
	
	private string _PC_Type;
	
	private decimal _Price;
	
	private string _Image;
	
	private int _Active;
	
	private int _Discount;
	
	private EntityRef<Pc> _Pc;
	
	private EntityRef<PcSold> _PcSold;
	
	private EntitySet<PcInvoice> _PcInvoices;
	
	private EntitySet<PcCart> _PcCarts;
	
	private EntityRef<Pc1> _Pc1;
	
	private EntitySet<PcCart1> _PcCart1s;
	
	private EntitySet<PcInvoice1> _PcInvoice1s;
	
	private EntityRef<PcSold1> _PcSold1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPC_TypeChanging(string value);
    partial void OnPC_TypeChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    partial void OnDiscountChanging(int value);
    partial void OnDiscountChanged();
    #endregion
	
	public PcStock()
	{
		this._Pc = default(EntityRef<Pc>);
		this._PcSold = default(EntityRef<PcSold>);
		this._PcInvoices = new EntitySet<PcInvoice>(new Action<PcInvoice>(this.attach_PcInvoices), new Action<PcInvoice>(this.detach_PcInvoices));
		this._PcCarts = new EntitySet<PcCart>(new Action<PcCart>(this.attach_PcCarts), new Action<PcCart>(this.detach_PcCarts));
		this._Pc1 = default(EntityRef<Pc1>);
		this._PcCart1s = new EntitySet<PcCart1>(new Action<PcCart1>(this.attach_PcCart1s), new Action<PcCart1>(this.detach_PcCart1s));
		this._PcInvoice1s = new EntitySet<PcInvoice1>(new Action<PcInvoice1>(this.attach_PcInvoice1s), new Action<PcInvoice1>(this.detach_PcInvoice1s));
		this._PcSold1 = default(EntityRef<PcSold1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PC_Type
	{
		get
		{
			return this._PC_Type;
		}
		set
		{
			if ((this._PC_Type != value))
			{
				this.OnPC_TypeChanging(value);
				this.SendPropertyChanging();
				this._PC_Type = value;
				this.SendPropertyChanged("PC_Type");
				this.OnPC_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
	public int Active
	{
		get
		{
			return this._Active;
		}
		set
		{
			if ((this._Active != value))
			{
				this.OnActiveChanging(value);
				this.SendPropertyChanging();
				this._Active = value;
				this.SendPropertyChanged("Active");
				this.OnActiveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int NOT NULL")]
	public int Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_Pc", Storage="_Pc", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public Pc Pc
	{
		get
		{
			return this._Pc.Entity;
		}
		set
		{
			Pc previousValue = this._Pc.Entity;
			if (((previousValue != value) 
						|| (this._Pc.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pc.Entity = null;
					previousValue.PcStock = null;
				}
				this._Pc.Entity = value;
				if ((value != null))
				{
					value.PcStock = this;
				}
				this.SendPropertyChanged("Pc");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcSold", Storage="_PcSold", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public PcSold PcSold
	{
		get
		{
			return this._PcSold.Entity;
		}
		set
		{
			PcSold previousValue = this._PcSold.Entity;
			if (((previousValue != value) 
						|| (this._PcSold.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcSold.Entity = null;
					previousValue.PcStock = null;
				}
				this._PcSold.Entity = value;
				if ((value != null))
				{
					value.PcStock = this;
				}
				this.SendPropertyChanged("PcSold");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcInvoice", Storage="_PcInvoices", ThisKey="ID", OtherKey="PC_ID")]
	public EntitySet<PcInvoice> PcInvoices
	{
		get
		{
			return this._PcInvoices;
		}
		set
		{
			this._PcInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcCart", Storage="_PcCarts", ThisKey="ID", OtherKey="Pc_ID")]
	public EntitySet<PcCart> PcCarts
	{
		get
		{
			return this._PcCarts;
		}
		set
		{
			this._PcCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_Pc1", Storage="_Pc1", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public Pc1 Pc1
	{
		get
		{
			return this._Pc1.Entity;
		}
		set
		{
			Pc1 previousValue = this._Pc1.Entity;
			if (((previousValue != value) 
						|| (this._Pc1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pc1.Entity = null;
					previousValue.PcStock = null;
				}
				this._Pc1.Entity = value;
				if ((value != null))
				{
					value.PcStock = this;
				}
				this.SendPropertyChanged("Pc1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcCart1", Storage="_PcCart1s", ThisKey="ID", OtherKey="Pc_ID")]
	public EntitySet<PcCart1> PcCart1s
	{
		get
		{
			return this._PcCart1s;
		}
		set
		{
			this._PcCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcInvoice1", Storage="_PcInvoice1s", ThisKey="ID", OtherKey="PC_ID")]
	public EntitySet<PcInvoice1> PcInvoice1s
	{
		get
		{
			return this._PcInvoice1s;
		}
		set
		{
			this._PcInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcSold1", Storage="_PcSold1", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public PcSold1 PcSold1
	{
		get
		{
			return this._PcSold1.Entity;
		}
		set
		{
			PcSold1 previousValue = this._PcSold1.Entity;
			if (((previousValue != value) 
						|| (this._PcSold1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcSold1.Entity = null;
					previousValue.PcStock = null;
				}
				this._PcSold1.Entity = value;
				if ((value != null))
				{
					value.PcStock = this;
				}
				this.SendPropertyChanged("PcSold1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = this;
	}
	
	private void detach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = null;
	}
	
	private void attach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = this;
	}
	
	private void detach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = null;
	}
	
	private void attach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = this;
	}
	
	private void detach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = null;
	}
	
	private void attach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = this;
	}
	
	private void detach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PSU")]
public partial class PSU : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Power;
	
	private string _Certification;
	
	private string _Modular;
	
	private string _Connectors;
	
	private string _MTBF;
	
	private string _Fan_Size;
	
	private string _Cables;
	
	private string _Dimensions;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnPowerChanging(string value);
    partial void OnPowerChanged();
    partial void OnCertificationChanging(string value);
    partial void OnCertificationChanged();
    partial void OnModularChanging(string value);
    partial void OnModularChanged();
    partial void OnConnectorsChanging(string value);
    partial void OnConnectorsChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnCablesChanging(string value);
    partial void OnCablesChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public PSU()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power
	{
		get
		{
			return this._Power;
		}
		set
		{
			if ((this._Power != value))
			{
				this.OnPowerChanging(value);
				this.SendPropertyChanging();
				this._Power = value;
				this.SendPropertyChanged("Power");
				this.OnPowerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Certification", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Certification
	{
		get
		{
			return this._Certification;
		}
		set
		{
			if ((this._Certification != value))
			{
				this.OnCertificationChanging(value);
				this.SendPropertyChanging();
				this._Certification = value;
				this.SendPropertyChanged("Certification");
				this.OnCertificationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modular", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Modular
	{
		get
		{
			return this._Modular;
		}
		set
		{
			if ((this._Modular != value))
			{
				this.OnModularChanging(value);
				this.SendPropertyChanging();
				this._Modular = value;
				this.SendPropertyChanged("Modular");
				this.OnModularChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Connectors
	{
		get
		{
			return this._Connectors;
		}
		set
		{
			if ((this._Connectors != value))
			{
				this.OnConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Connectors = value;
				this.SendPropertyChanged("Connectors");
				this.OnConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cables", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Cables
	{
		get
		{
			return this._Cables;
		}
		set
		{
			if ((this._Cables != value))
			{
				this.OnCablesChanging(value);
				this.SendPropertyChanging();
				this._Cables = value;
				this.SendPropertyChanged("Cables");
				this.OnCablesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="PSU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="PSU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PSU", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PSU = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PSU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PSU", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PSU = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PSU = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PSU = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PSU = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PSU = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PSU = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RAM")]
public partial class RAM : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Capacity;
	
	private string _Type;
	
	private string _Speed;
	
	private string _Latency;
	
	private string _Voltage;
	
	private string _Channel_Config;
	
	private string _Height;
	
	private string _Warranty;
	
	private EntitySet<MoboToRam> _MoboToRams;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<MoboToRam1> _MoboToRam1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCapacityChanging(string value);
    partial void OnCapacityChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSpeedChanging(string value);
    partial void OnSpeedChanged();
    partial void OnLatencyChanging(string value);
    partial void OnLatencyChanged();
    partial void OnVoltageChanging(string value);
    partial void OnVoltageChanged();
    partial void OnChannel_ConfigChanging(string value);
    partial void OnChannel_ConfigChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public RAM()
	{
		this._MoboToRams = new EntitySet<MoboToRam>(new Action<MoboToRam>(this.attach_MoboToRams), new Action<MoboToRam>(this.detach_MoboToRams));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._MoboToRam1s = new EntitySet<MoboToRam1>(new Action<MoboToRam1>(this.attach_MoboToRam1s), new Action<MoboToRam1>(this.detach_MoboToRam1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capacity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Capacity
	{
		get
		{
			return this._Capacity;
		}
		set
		{
			if ((this._Capacity != value))
			{
				this.OnCapacityChanging(value);
				this.SendPropertyChanging();
				this._Capacity = value;
				this.SendPropertyChanged("Capacity");
				this.OnCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Speed
	{
		get
		{
			return this._Speed;
		}
		set
		{
			if ((this._Speed != value))
			{
				this.OnSpeedChanging(value);
				this.SendPropertyChanging();
				this._Speed = value;
				this.SendPropertyChanged("Speed");
				this.OnSpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latency", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Latency
	{
		get
		{
			return this._Latency;
		}
		set
		{
			if ((this._Latency != value))
			{
				this.OnLatencyChanging(value);
				this.SendPropertyChanging();
				this._Latency = value;
				this.SendPropertyChanged("Latency");
				this.OnLatencyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Voltage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Voltage
	{
		get
		{
			return this._Voltage;
		}
		set
		{
			if ((this._Voltage != value))
			{
				this.OnVoltageChanging(value);
				this.SendPropertyChanging();
				this._Voltage = value;
				this.SendPropertyChanged("Voltage");
				this.OnVoltageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Channel_Config", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Channel_Config
	{
		get
		{
			return this._Channel_Config;
		}
		set
		{
			if ((this._Channel_Config != value))
			{
				this.OnChannel_ConfigChanging(value);
				this.SendPropertyChanging();
				this._Channel_Config = value;
				this.SendPropertyChanged("Channel_Config");
				this.OnChannel_ConfigChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_MoboToRam", Storage="_MoboToRams", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<MoboToRam> MoboToRams
	{
		get
		{
			return this._MoboToRams;
		}
		set
		{
			this._MoboToRams.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_MoboToRam1", Storage="_MoboToRam1s", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<MoboToRam1> MoboToRam1s
	{
		get
		{
			return this._MoboToRam1s;
		}
		set
		{
			this._MoboToRam1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_RAM", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.RAM = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.RAM = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_RAM", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.RAM = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.RAM = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.RAM = this;
	}
	
	private void detach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.RAM = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.RAM = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.RAM = null;
	}
	
	private void attach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM = this;
	}
	
	private void detach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Speaker")]
public partial class Speaker : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Satellite_Dimensions;
	
	private string _Satellite_Weight;
	
	private string _SubWoofer_Dimensions;
	
	private string _SubWoofer_Weight;
	
	private string _controls;
	
	private string _System_Requirements;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSatellite_DimensionsChanging(string value);
    partial void OnSatellite_DimensionsChanged();
    partial void OnSatellite_WeightChanging(string value);
    partial void OnSatellite_WeightChanged();
    partial void OnSubWoofer_DimensionsChanging(string value);
    partial void OnSubWoofer_DimensionsChanged();
    partial void OnSubWoofer_WeightChanging(string value);
    partial void OnSubWoofer_WeightChanged();
    partial void OncontrolsChanging(string value);
    partial void OncontrolsChanged();
    partial void OnSystem_RequirementsChanging(string value);
    partial void OnSystem_RequirementsChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Speaker()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Satellite_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Satellite_Dimensions
	{
		get
		{
			return this._Satellite_Dimensions;
		}
		set
		{
			if ((this._Satellite_Dimensions != value))
			{
				this.OnSatellite_DimensionsChanging(value);
				this.SendPropertyChanging();
				this._Satellite_Dimensions = value;
				this.SendPropertyChanged("Satellite_Dimensions");
				this.OnSatellite_DimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Satellite_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Satellite_Weight
	{
		get
		{
			return this._Satellite_Weight;
		}
		set
		{
			if ((this._Satellite_Weight != value))
			{
				this.OnSatellite_WeightChanging(value);
				this.SendPropertyChanging();
				this._Satellite_Weight = value;
				this.SendPropertyChanged("Satellite_Weight");
				this.OnSatellite_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubWoofer_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SubWoofer_Dimensions
	{
		get
		{
			return this._SubWoofer_Dimensions;
		}
		set
		{
			if ((this._SubWoofer_Dimensions != value))
			{
				this.OnSubWoofer_DimensionsChanging(value);
				this.SendPropertyChanging();
				this._SubWoofer_Dimensions = value;
				this.SendPropertyChanged("SubWoofer_Dimensions");
				this.OnSubWoofer_DimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubWoofer_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SubWoofer_Weight
	{
		get
		{
			return this._SubWoofer_Weight;
		}
		set
		{
			if ((this._SubWoofer_Weight != value))
			{
				this.OnSubWoofer_WeightChanging(value);
				this.SendPropertyChanging();
				this._SubWoofer_Weight = value;
				this.SendPropertyChanged("SubWoofer_Weight");
				this.OnSubWoofer_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_controls", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string controls
	{
		get
		{
			return this._controls;
		}
		set
		{
			if ((this._controls != value))
			{
				this.OncontrolsChanging(value);
				this.SendPropertyChanging();
				this._controls = value;
				this.SendPropertyChanged("controls");
				this.OncontrolsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[System Requirements]", Storage="_System_Requirements", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string System_Requirements
	{
		get
		{
			return this._System_Requirements;
		}
		set
		{
			if ((this._System_Requirements != value))
			{
				this.OnSystem_RequirementsChanging(value);
				this.SendPropertyChanging();
				this._System_Requirements = value;
				this.SendPropertyChanged("System_Requirements");
				this.OnSystem_RequirementsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Speaker_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Speaker_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Speaker", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Speaker = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Speaker = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Speaker", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Speaker = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Speaker = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Speaker = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Speaker = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Speaker = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Speaker = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SSD")]
public partial class SSD : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Form_Factor;
	
	private string _Capacity;
	
	private string _Interface_Type;
	
	private string _Length;
	
	private string _Width;
	
	private string _Max_Sequential_Read;
	
	private string _Max_Sequential_Write;
	
	private string _Random_Read;
	
	private string _Random_Write;
	
	private string _MTBF;
	
	private string _Operating_Temp;
	
	private string _Max_Power_Usage;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnCapacityChanging(string value);
    partial void OnCapacityChanged();
    partial void OnInterface_TypeChanging(string value);
    partial void OnInterface_TypeChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnWidthChanging(string value);
    partial void OnWidthChanged();
    partial void OnMax_Sequential_ReadChanging(string value);
    partial void OnMax_Sequential_ReadChanged();
    partial void OnMax_Sequential_WriteChanging(string value);
    partial void OnMax_Sequential_WriteChanged();
    partial void OnRandom_ReadChanging(string value);
    partial void OnRandom_ReadChanged();
    partial void OnRandom_WriteChanging(string value);
    partial void OnRandom_WriteChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnOperating_TempChanging(string value);
    partial void OnOperating_TempChanged();
    partial void OnMax_Power_UsageChanging(string value);
    partial void OnMax_Power_UsageChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public SSD()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capacity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Capacity
	{
		get
		{
			return this._Capacity;
		}
		set
		{
			if ((this._Capacity != value))
			{
				this.OnCapacityChanging(value);
				this.SendPropertyChanging();
				this._Capacity = value;
				this.SendPropertyChanged("Capacity");
				this.OnCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Interface_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Interface_Type
	{
		get
		{
			return this._Interface_Type;
		}
		set
		{
			if ((this._Interface_Type != value))
			{
				this.OnInterface_TypeChanging(value);
				this.SendPropertyChanging();
				this._Interface_Type = value;
				this.SendPropertyChanged("Interface_Type");
				this.OnInterface_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Width
	{
		get
		{
			return this._Width;
		}
		set
		{
			if ((this._Width != value))
			{
				this.OnWidthChanging(value);
				this.SendPropertyChanging();
				this._Width = value;
				this.SendPropertyChanged("Width");
				this.OnWidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sequential_Read", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sequential_Read
	{
		get
		{
			return this._Max_Sequential_Read;
		}
		set
		{
			if ((this._Max_Sequential_Read != value))
			{
				this.OnMax_Sequential_ReadChanging(value);
				this.SendPropertyChanging();
				this._Max_Sequential_Read = value;
				this.SendPropertyChanged("Max_Sequential_Read");
				this.OnMax_Sequential_ReadChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sequential_Write", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sequential_Write
	{
		get
		{
			return this._Max_Sequential_Write;
		}
		set
		{
			if ((this._Max_Sequential_Write != value))
			{
				this.OnMax_Sequential_WriteChanging(value);
				this.SendPropertyChanging();
				this._Max_Sequential_Write = value;
				this.SendPropertyChanged("Max_Sequential_Write");
				this.OnMax_Sequential_WriteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Random_Read", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Random_Read
	{
		get
		{
			return this._Random_Read;
		}
		set
		{
			if ((this._Random_Read != value))
			{
				this.OnRandom_ReadChanging(value);
				this.SendPropertyChanging();
				this._Random_Read = value;
				this.SendPropertyChanged("Random_Read");
				this.OnRandom_ReadChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Random_Write", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Random_Write
	{
		get
		{
			return this._Random_Write;
		}
		set
		{
			if ((this._Random_Write != value))
			{
				this.OnRandom_WriteChanging(value);
				this.SendPropertyChanging();
				this._Random_Write = value;
				this.SendPropertyChanged("Random_Write");
				this.OnRandom_WriteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operating_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Operating_Temp
	{
		get
		{
			return this._Operating_Temp;
		}
		set
		{
			if ((this._Operating_Temp != value))
			{
				this.OnOperating_TempChanging(value);
				this.SendPropertyChanging();
				this._Operating_Temp = value;
				this.SendPropertyChanged("Operating_Temp");
				this.OnOperating_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Power_Usage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Power_Usage
	{
		get
		{
			return this._Max_Power_Usage;
		}
		set
		{
			if ((this._Max_Power_Usage != value))
			{
				this.OnMax_Power_UsageChanging(value);
				this.SendPropertyChanging();
				this._Max_Power_Usage = value;
				this.SendPropertyChanged("Max_Power_Usage");
				this.OnMax_Power_UsageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="SSD_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="SSD_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_SSD", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.SSD = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.SSD = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_SSD", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.SSD = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.SSD = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.SSD = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.SSD = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.SSD = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.SSD = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartInvoice")]
public partial class PartInvoice : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Part_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPart_IDChanging(int value);
    partial void OnPart_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PartInvoice()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Part_ID
	{
		get
		{
			return this._Part_ID;
		}
		set
		{
			if ((this._Part_ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPart_IDChanging(value);
				this.SendPropertyChanging();
				this._Part_ID = value;
				this.SendPropertyChanged("Part_ID");
				this.OnPart_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartInvoice", Storage="_PartsStock", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartInvoices.Remove(this);
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartInvoices.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartInvoice", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PartInvoices.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PartInvoices.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartInvoice", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PartInvoices.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PartInvoices.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartInvoice", Storage="_PartsStock1", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartInvoices.Remove(this);
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartInvoices.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcInvoice")]
public partial class PcInvoice : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _PC_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PcInvoice()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcInvoice", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcInvoices.Remove(this);
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcInvoices.Add(this);
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcInvoice", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PcInvoices.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PcInvoices.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcInvoice", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PcInvoices.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PcInvoices.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcInvoice", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcInvoices.Remove(this);
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcInvoices.Add(this);
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartCart")]
public partial class PartCart : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Part_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPart_IDChanging(int value);
    partial void OnPart_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PartCart()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Part_ID
	{
		get
		{
			return this._Part_ID;
		}
		set
		{
			if ((this._Part_ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPart_IDChanging(value);
				this.SendPropertyChanging();
				this._Part_ID = value;
				this.SendPropertyChanged("Part_ID");
				this.OnPart_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartCart", Storage="_PartsStock", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartCarts.Remove(this);
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartCarts.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartCart", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PartCarts.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PartCarts.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartCart", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PartCarts.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PartCarts.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartCart", Storage="_PartsStock1", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartCarts.Remove(this);
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartCarts.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcCart")]
public partial class PcCart : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Pc_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPc_IDChanging(int value);
    partial void OnPc_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PcCart()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pc_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Pc_ID
	{
		get
		{
			return this._Pc_ID;
		}
		set
		{
			if ((this._Pc_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPc_IDChanging(value);
				this.SendPropertyChanging();
				this._Pc_ID = value;
				this.SendPropertyChanged("Pc_ID");
				this.OnPc_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcCart", Storage="_PcStock", ThisKey="Pc_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcCarts.Remove(this);
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcCarts.Add(this);
					this._Pc_ID = value.ID;
				}
				else
				{
					this._Pc_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcCart", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PcCarts.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PcCarts.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcCart", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PcCarts.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PcCarts.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcCart", Storage="_PcStock1", ThisKey="Pc_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcCarts.Remove(this);
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcCarts.Add(this);
					this._Pc_ID = value.ID;
				}
				else
				{
					this._Pc_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPosition")]
public partial class UserPosition1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PositionID;
	
	private string _Position;
	
	private EntitySet<Admin> _Admins;
	
	private EntitySet<Admin1> _Admin1s;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPositionIDChanging(int value);
    partial void OnPositionIDChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    #endregion
	
	public UserPosition1()
	{
		this._Admins = new EntitySet<Admin>(new Action<Admin>(this.attach_Admins), new Action<Admin>(this.detach_Admins));
		this._Admin1s = new EntitySet<Admin1>(new Action<Admin1>(this.attach_Admin1s), new Action<Admin1>(this.detach_Admin1s));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PositionID
	{
		get
		{
			return this._PositionID;
		}
		set
		{
			if ((this._PositionID != value))
			{
				this.OnPositionIDChanging(value);
				this.SendPropertyChanging();
				this._PositionID = value;
				this.SendPropertyChanged("PositionID");
				this.OnPositionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Position
	{
		get
		{
			return this._Position;
		}
		set
		{
			if ((this._Position != value))
			{
				this.OnPositionChanging(value);
				this.SendPropertyChanging();
				this._Position = value;
				this.SendPropertyChanged("Position");
				this.OnPositionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition1_Admin", Storage="_Admins", ThisKey="PositionID", OtherKey="Position")]
	public EntitySet<Admin> Admins
	{
		get
		{
			return this._Admins;
		}
		set
		{
			this._Admins.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition1_Admin1", Storage="_Admin1s", ThisKey="PositionID", OtherKey="Position")]
	public EntitySet<Admin1> Admin1s
	{
		get
		{
			return this._Admin1s;
		}
		set
		{
			this._Admin1s.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Admins(Admin entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition1 = this;
	}
	
	private void detach_Admins(Admin entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition1 = null;
	}
	
	private void attach_Admin1s(Admin1 entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition1 = this;
	}
	
	private void detach_Admin1s(Admin1 entity)
	{
		this.SendPropertyChanging();
		entity.UserPosition1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
public partial class Admin1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Admin_ID;
	
	private string _First_Name;
	
	private string _Surname;
	
	private string _Email;
	
	private string _Conrtact_Number;
	
	private int _Position;
	
	private EntityRef<LoginTable> _LoginTable;
	
	private EntityRef<UserPosition> _UserPosition;
	
	private EntityRef<UserPosition1> _UserPosition1;
	
	private EntityRef<LoginTable1> _LoginTable1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdmin_IDChanging(int value);
    partial void OnAdmin_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnConrtact_NumberChanging(string value);
    partial void OnConrtact_NumberChanged();
    partial void OnPositionChanging(int value);
    partial void OnPositionChanged();
    #endregion
	
	public Admin1()
	{
		this._LoginTable = default(EntityRef<LoginTable>);
		this._UserPosition = default(EntityRef<UserPosition>);
		this._UserPosition1 = default(EntityRef<UserPosition1>);
		this._LoginTable1 = default(EntityRef<LoginTable1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Admin_ID
	{
		get
		{
			return this._Admin_ID;
		}
		set
		{
			if ((this._Admin_ID != value))
			{
				if ((this._LoginTable.HasLoadedOrAssignedValue || this._LoginTable1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAdmin_IDChanging(value);
				this.SendPropertyChanging();
				this._Admin_ID = value;
				this.SendPropertyChanged("Admin_ID");
				this.OnAdmin_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string First_Name
	{
		get
		{
			return this._First_Name;
		}
		set
		{
			if ((this._First_Name != value))
			{
				this.OnFirst_NameChanging(value);
				this.SendPropertyChanging();
				this._First_Name = value;
				this.SendPropertyChanged("First_Name");
				this.OnFirst_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._Surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Conrtact_Number", DbType="VarChar(13) NOT NULL", CanBeNull=false)]
	public string Conrtact_Number
	{
		get
		{
			return this._Conrtact_Number;
		}
		set
		{
			if ((this._Conrtact_Number != value))
			{
				this.OnConrtact_NumberChanging(value);
				this.SendPropertyChanging();
				this._Conrtact_Number = value;
				this.SendPropertyChanged("Conrtact_Number");
				this.OnConrtact_NumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="Int NOT NULL")]
	public int Position
	{
		get
		{
			return this._Position;
		}
		set
		{
			if ((this._Position != value))
			{
				if ((this._UserPosition.HasLoadedOrAssignedValue || this._UserPosition1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPositionChanging(value);
				this.SendPropertyChanging();
				this._Position = value;
				this.SendPropertyChanged("Position");
				this.OnPositionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Admin1", Storage="_LoginTable", ThisKey="Admin_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable LoginTable
	{
		get
		{
			return this._LoginTable.Entity;
		}
		set
		{
			LoginTable previousValue = this._LoginTable.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable.Entity = null;
					previousValue.Admin1 = null;
				}
				this._LoginTable.Entity = value;
				if ((value != null))
				{
					value.Admin1 = this;
					this._Admin_ID = value.User_ID;
				}
				else
				{
					this._Admin_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition_Admin1", Storage="_UserPosition", ThisKey="Position", OtherKey="PositionID", IsForeignKey=true)]
	public UserPosition UserPosition
	{
		get
		{
			return this._UserPosition.Entity;
		}
		set
		{
			UserPosition previousValue = this._UserPosition.Entity;
			if (((previousValue != value) 
						|| (this._UserPosition.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._UserPosition.Entity = null;
					previousValue.Admin1s.Remove(this);
				}
				this._UserPosition.Entity = value;
				if ((value != null))
				{
					value.Admin1s.Add(this);
					this._Position = value.PositionID;
				}
				else
				{
					this._Position = default(int);
				}
				this.SendPropertyChanged("UserPosition");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserPosition1_Admin1", Storage="_UserPosition1", ThisKey="Position", OtherKey="PositionID", IsForeignKey=true)]
	public UserPosition1 UserPosition1
	{
		get
		{
			return this._UserPosition1.Entity;
		}
		set
		{
			UserPosition1 previousValue = this._UserPosition1.Entity;
			if (((previousValue != value) 
						|| (this._UserPosition1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._UserPosition1.Entity = null;
					previousValue.Admin1s.Remove(this);
				}
				this._UserPosition1.Entity = value;
				if ((value != null))
				{
					value.Admin1s.Add(this);
					this._Position = value.PositionID;
				}
				else
				{
					this._Position = default(int);
				}
				this.SendPropertyChanged("UserPosition1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Admin1", Storage="_LoginTable1", ThisKey="Admin_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable1 LoginTable1
	{
		get
		{
			return this._LoginTable1.Entity;
		}
		set
		{
			LoginTable1 previousValue = this._LoginTable1.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable1.Entity = null;
					previousValue.Admin1 = null;
				}
				this._LoginTable1.Entity = value;
				if ((value != null))
				{
					value.Admin1 = this;
					this._Admin_ID = value.User_ID;
				}
				else
				{
					this._Admin_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AirCooler")]
public partial class AirCooler1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Fan_Size;
	
	private string _Compatibility;
	
	private string _Fan_RPM;
	
	private string _Air_Flow;
	
	private string _Noise_Level;
	
	private string _Power_Connector;
	
	private string _Colour;
	
	private string _Materials;
	
	private string _Length;
	
	private string _Height;
	
	private string _Width;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<CpuToAirCooler> _CpuToAirCoolers;
	
	private EntitySet<CpuToAirCooler1> _CpuToAirCooler1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnCompatibilityChanging(string value);
    partial void OnCompatibilityChanged();
    partial void OnFan_RPMChanging(string value);
    partial void OnFan_RPMChanged();
    partial void OnAir_FlowChanging(string value);
    partial void OnAir_FlowChanged();
    partial void OnNoise_LevelChanging(string value);
    partial void OnNoise_LevelChanged();
    partial void OnPower_ConnectorChanging(string value);
    partial void OnPower_ConnectorChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWidthChanging(string value);
    partial void OnWidthChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public AirCooler1()
	{
		this._CpuToAirCoolers = new EntitySet<CpuToAirCooler>(new Action<CpuToAirCooler>(this.attach_CpuToAirCoolers), new Action<CpuToAirCooler>(this.detach_CpuToAirCoolers));
		this._CpuToAirCooler1s = new EntitySet<CpuToAirCooler1>(new Action<CpuToAirCooler1>(this.attach_CpuToAirCooler1s), new Action<CpuToAirCooler1>(this.detach_CpuToAirCooler1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Compatibility", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Compatibility
	{
		get
		{
			return this._Compatibility;
		}
		set
		{
			if ((this._Compatibility != value))
			{
				this.OnCompatibilityChanging(value);
				this.SendPropertyChanging();
				this._Compatibility = value;
				this.SendPropertyChanged("Compatibility");
				this.OnCompatibilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_RPM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_RPM
	{
		get
		{
			return this._Fan_RPM;
		}
		set
		{
			if ((this._Fan_RPM != value))
			{
				this.OnFan_RPMChanging(value);
				this.SendPropertyChanging();
				this._Fan_RPM = value;
				this.SendPropertyChanged("Fan_RPM");
				this.OnFan_RPMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Air_Flow", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Air_Flow
	{
		get
		{
			return this._Air_Flow;
		}
		set
		{
			if ((this._Air_Flow != value))
			{
				this.OnAir_FlowChanging(value);
				this.SendPropertyChanging();
				this._Air_Flow = value;
				this.SendPropertyChanged("Air_Flow");
				this.OnAir_FlowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noise_Level", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Noise_Level
	{
		get
		{
			return this._Noise_Level;
		}
		set
		{
			if ((this._Noise_Level != value))
			{
				this.OnNoise_LevelChanging(value);
				this.SendPropertyChanging();
				this._Noise_Level = value;
				this.SendPropertyChanged("Noise_Level");
				this.OnNoise_LevelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power_Connector", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power_Connector
	{
		get
		{
			return this._Power_Connector;
		}
		set
		{
			if ((this._Power_Connector != value))
			{
				this.OnPower_ConnectorChanging(value);
				this.SendPropertyChanging();
				this._Power_Connector = value;
				this.SendPropertyChanged("Power_Connector");
				this.OnPower_ConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Materials
	{
		get
		{
			return this._Materials;
		}
		set
		{
			if ((this._Materials != value))
			{
				this.OnMaterialsChanging(value);
				this.SendPropertyChanging();
				this._Materials = value;
				this.SendPropertyChanged("Materials");
				this.OnMaterialsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Width
	{
		get
		{
			return this._Width;
		}
		set
		{
			if ((this._Width != value))
			{
				this.OnWidthChanging(value);
				this.SendPropertyChanging();
				this._Width = value;
				this.SendPropertyChanged("Width");
				this.OnWidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler1_CpuToAirCooler", Storage="_CpuToAirCoolers", ThisKey="ID", OtherKey="AC_ID")]
	public EntitySet<CpuToAirCooler> CpuToAirCoolers
	{
		get
		{
			return this._CpuToAirCoolers;
		}
		set
		{
			this._CpuToAirCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler1_CpuToAirCooler1", Storage="_CpuToAirCooler1s", ThisKey="ID", OtherKey="AC_ID")]
	public EntitySet<CpuToAirCooler1> CpuToAirCooler1s
	{
		get
		{
			return this._CpuToAirCooler1s;
		}
		set
		{
			this._CpuToAirCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_AirCooler1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.AirCooler1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.AirCooler1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_AirCooler1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.AirCooler1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.AirCooler1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler1 = this;
	}
	
	private void detach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler1 = null;
	}
	
	private void attach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler1 = this;
	}
	
	private void detach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.AirCooler1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Client")]
public partial class Client1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private string _First_Name;
	
	private string _Surname;
	
	private string _Email;
	
	private string _Address;
	
	private string _City;
	
	private string _Province;
	
	private string _ZIP_Code;
	
	private EntitySet<PartInvoice> _PartInvoices;
	
	private EntitySet<PcInvoice> _PcInvoices;
	
	private EntitySet<PartCart> _PartCarts;
	
	private EntitySet<PcCart> _PcCarts;
	
	private EntitySet<PartCart1> _PartCart1s;
	
	private EntitySet<PartInvoice1> _PartInvoice1s;
	
	private EntitySet<PcCart1> _PcCart1s;
	
	private EntitySet<PcInvoice1> _PcInvoice1s;
	
	private EntityRef<LoginTable> _LoginTable;
	
	private EntityRef<LoginTable1> _LoginTable1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnProvinceChanging(string value);
    partial void OnProvinceChanged();
    partial void OnZIP_CodeChanging(string value);
    partial void OnZIP_CodeChanged();
    #endregion
	
	public Client1()
	{
		this._PartInvoices = new EntitySet<PartInvoice>(new Action<PartInvoice>(this.attach_PartInvoices), new Action<PartInvoice>(this.detach_PartInvoices));
		this._PcInvoices = new EntitySet<PcInvoice>(new Action<PcInvoice>(this.attach_PcInvoices), new Action<PcInvoice>(this.detach_PcInvoices));
		this._PartCarts = new EntitySet<PartCart>(new Action<PartCart>(this.attach_PartCarts), new Action<PartCart>(this.detach_PartCarts));
		this._PcCarts = new EntitySet<PcCart>(new Action<PcCart>(this.attach_PcCarts), new Action<PcCart>(this.detach_PcCarts));
		this._PartCart1s = new EntitySet<PartCart1>(new Action<PartCart1>(this.attach_PartCart1s), new Action<PartCart1>(this.detach_PartCart1s));
		this._PartInvoice1s = new EntitySet<PartInvoice1>(new Action<PartInvoice1>(this.attach_PartInvoice1s), new Action<PartInvoice1>(this.detach_PartInvoice1s));
		this._PcCart1s = new EntitySet<PcCart1>(new Action<PcCart1>(this.attach_PcCart1s), new Action<PcCart1>(this.detach_PcCart1s));
		this._PcInvoice1s = new EntitySet<PcInvoice1>(new Action<PcInvoice1>(this.attach_PcInvoice1s), new Action<PcInvoice1>(this.detach_PcInvoice1s));
		this._LoginTable = default(EntityRef<LoginTable>);
		this._LoginTable1 = default(EntityRef<LoginTable1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._LoginTable.HasLoadedOrAssignedValue || this._LoginTable1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string First_Name
	{
		get
		{
			return this._First_Name;
		}
		set
		{
			if ((this._First_Name != value))
			{
				this.OnFirst_NameChanging(value);
				this.SendPropertyChanging();
				this._First_Name = value;
				this.SendPropertyChanged("First_Name");
				this.OnFirst_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._Surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Province", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Province
	{
		get
		{
			return this._Province;
		}
		set
		{
			if ((this._Province != value))
			{
				this.OnProvinceChanging(value);
				this.SendPropertyChanging();
				this._Province = value;
				this.SendPropertyChanged("Province");
				this.OnProvinceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZIP_Code", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string ZIP_Code
	{
		get
		{
			return this._ZIP_Code;
		}
		set
		{
			if ((this._ZIP_Code != value))
			{
				this.OnZIP_CodeChanging(value);
				this.SendPropertyChanging();
				this._ZIP_Code = value;
				this.SendPropertyChanged("ZIP_Code");
				this.OnZIP_CodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartInvoice", Storage="_PartInvoices", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartInvoice> PartInvoices
	{
		get
		{
			return this._PartInvoices;
		}
		set
		{
			this._PartInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcInvoice", Storage="_PcInvoices", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcInvoice> PcInvoices
	{
		get
		{
			return this._PcInvoices;
		}
		set
		{
			this._PcInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartCart", Storage="_PartCarts", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartCart> PartCarts
	{
		get
		{
			return this._PartCarts;
		}
		set
		{
			this._PartCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcCart", Storage="_PcCarts", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcCart> PcCarts
	{
		get
		{
			return this._PcCarts;
		}
		set
		{
			this._PcCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartCart1", Storage="_PartCart1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartCart1> PartCart1s
	{
		get
		{
			return this._PartCart1s;
		}
		set
		{
			this._PartCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartInvoice1", Storage="_PartInvoice1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PartInvoice1> PartInvoice1s
	{
		get
		{
			return this._PartInvoice1s;
		}
		set
		{
			this._PartInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcCart1", Storage="_PcCart1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcCart1> PcCart1s
	{
		get
		{
			return this._PcCart1s;
		}
		set
		{
			this._PcCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcInvoice1", Storage="_PcInvoice1s", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<PcInvoice1> PcInvoice1s
	{
		get
		{
			return this._PcInvoice1s;
		}
		set
		{
			this._PcInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable_Client1", Storage="_LoginTable", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable LoginTable
	{
		get
		{
			return this._LoginTable.Entity;
		}
		set
		{
			LoginTable previousValue = this._LoginTable.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable.Entity = null;
					previousValue.Client1 = null;
				}
				this._LoginTable.Entity = value;
				if ((value != null))
				{
					value.Client1 = this;
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Client1", Storage="_LoginTable1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public LoginTable1 LoginTable1
	{
		get
		{
			return this._LoginTable1.Entity;
		}
		set
		{
			LoginTable1 previousValue = this._LoginTable1.Entity;
			if (((previousValue != value) 
						|| (this._LoginTable1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LoginTable1.Entity = null;
					previousValue.Client1 = null;
				}
				this._LoginTable1.Entity = value;
				if ((value != null))
				{
					value.Client1 = this;
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("LoginTable1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
	
	private void attach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = this;
	}
	
	private void detach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.Client1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CPU")]
public partial class CPU1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Cores;
	
	private string _Threads;
	
	private string _Base_Clock;
	
	private string _Boost_Clock;
	
	private string _Total_Cache;
	
	private string _Chipset;
	
	private string _TDP;
	
	private string _Max_Temp;
	
	private int _System_Memory_Speed;
	
	private string _System_Memory_Type;
	
	private string _Memory_Channels;
	
	private string _Warranty;
	
	private EntitySet<CpuToAirCooler> _CpuToAirCoolers;
	
	private EntitySet<CpuToLiquidCooler> _CpuToLiquidCoolers;
	
	private EntitySet<MoboToCpu> _MoboToCpus;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<CpuToAirCooler1> _CpuToAirCooler1s;
	
	private EntitySet<CpuToLiquidCooler1> _CpuToLiquidCooler1s;
	
	private EntitySet<MoboToCpu1> _MoboToCpu1s;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCoresChanging(string value);
    partial void OnCoresChanged();
    partial void OnThreadsChanging(string value);
    partial void OnThreadsChanged();
    partial void OnBase_ClockChanging(string value);
    partial void OnBase_ClockChanged();
    partial void OnBoost_ClockChanging(string value);
    partial void OnBoost_ClockChanged();
    partial void OnTotal_CacheChanging(string value);
    partial void OnTotal_CacheChanged();
    partial void OnChipsetChanging(string value);
    partial void OnChipsetChanged();
    partial void OnTDPChanging(string value);
    partial void OnTDPChanged();
    partial void OnMax_TempChanging(string value);
    partial void OnMax_TempChanged();
    partial void OnSystem_Memory_SpeedChanging(int value);
    partial void OnSystem_Memory_SpeedChanged();
    partial void OnSystem_Memory_TypeChanging(string value);
    partial void OnSystem_Memory_TypeChanged();
    partial void OnMemory_ChannelsChanging(string value);
    partial void OnMemory_ChannelsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public CPU1()
	{
		this._CpuToAirCoolers = new EntitySet<CpuToAirCooler>(new Action<CpuToAirCooler>(this.attach_CpuToAirCoolers), new Action<CpuToAirCooler>(this.detach_CpuToAirCoolers));
		this._CpuToLiquidCoolers = new EntitySet<CpuToLiquidCooler>(new Action<CpuToLiquidCooler>(this.attach_CpuToLiquidCoolers), new Action<CpuToLiquidCooler>(this.detach_CpuToLiquidCoolers));
		this._MoboToCpus = new EntitySet<MoboToCpu>(new Action<MoboToCpu>(this.attach_MoboToCpus), new Action<MoboToCpu>(this.detach_MoboToCpus));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._CpuToAirCooler1s = new EntitySet<CpuToAirCooler1>(new Action<CpuToAirCooler1>(this.attach_CpuToAirCooler1s), new Action<CpuToAirCooler1>(this.detach_CpuToAirCooler1s));
		this._CpuToLiquidCooler1s = new EntitySet<CpuToLiquidCooler1>(new Action<CpuToLiquidCooler1>(this.attach_CpuToLiquidCooler1s), new Action<CpuToLiquidCooler1>(this.detach_CpuToLiquidCooler1s));
		this._MoboToCpu1s = new EntitySet<MoboToCpu1>(new Action<MoboToCpu1>(this.attach_MoboToCpu1s), new Action<MoboToCpu1>(this.detach_MoboToCpu1s));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cores", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cores
	{
		get
		{
			return this._Cores;
		}
		set
		{
			if ((this._Cores != value))
			{
				this.OnCoresChanging(value);
				this.SendPropertyChanging();
				this._Cores = value;
				this.SendPropertyChanged("Cores");
				this.OnCoresChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Threads", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Threads
	{
		get
		{
			return this._Threads;
		}
		set
		{
			if ((this._Threads != value))
			{
				this.OnThreadsChanging(value);
				this.SendPropertyChanging();
				this._Threads = value;
				this.SendPropertyChanged("Threads");
				this.OnThreadsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base_Clock
	{
		get
		{
			return this._Base_Clock;
		}
		set
		{
			if ((this._Base_Clock != value))
			{
				this.OnBase_ClockChanging(value);
				this.SendPropertyChanging();
				this._Base_Clock = value;
				this.SendPropertyChanged("Base_Clock");
				this.OnBase_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Boost_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Boost_Clock
	{
		get
		{
			return this._Boost_Clock;
		}
		set
		{
			if ((this._Boost_Clock != value))
			{
				this.OnBoost_ClockChanging(value);
				this.SendPropertyChanging();
				this._Boost_Clock = value;
				this.SendPropertyChanged("Boost_Clock");
				this.OnBoost_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Cache", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Total_Cache
	{
		get
		{
			return this._Total_Cache;
		}
		set
		{
			if ((this._Total_Cache != value))
			{
				this.OnTotal_CacheChanging(value);
				this.SendPropertyChanging();
				this._Total_Cache = value;
				this.SendPropertyChanged("Total_Cache");
				this.OnTotal_CacheChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chipset", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Chipset
	{
		get
		{
			return this._Chipset;
		}
		set
		{
			if ((this._Chipset != value))
			{
				this.OnChipsetChanging(value);
				this.SendPropertyChanging();
				this._Chipset = value;
				this.SendPropertyChanged("Chipset");
				this.OnChipsetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string TDP
	{
		get
		{
			return this._TDP;
		}
		set
		{
			if ((this._TDP != value))
			{
				this.OnTDPChanging(value);
				this.SendPropertyChanging();
				this._TDP = value;
				this.SendPropertyChanged("TDP");
				this.OnTDPChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Temp
	{
		get
		{
			return this._Max_Temp;
		}
		set
		{
			if ((this._Max_Temp != value))
			{
				this.OnMax_TempChanging(value);
				this.SendPropertyChanging();
				this._Max_Temp = value;
				this.SendPropertyChanged("Max_Temp");
				this.OnMax_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Memory_Speed", DbType="Int NOT NULL")]
	public int System_Memory_Speed
	{
		get
		{
			return this._System_Memory_Speed;
		}
		set
		{
			if ((this._System_Memory_Speed != value))
			{
				this.OnSystem_Memory_SpeedChanging(value);
				this.SendPropertyChanging();
				this._System_Memory_Speed = value;
				this.SendPropertyChanged("System_Memory_Speed");
				this.OnSystem_Memory_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Memory_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string System_Memory_Type
	{
		get
		{
			return this._System_Memory_Type;
		}
		set
		{
			if ((this._System_Memory_Type != value))
			{
				this.OnSystem_Memory_TypeChanging(value);
				this.SendPropertyChanging();
				this._System_Memory_Type = value;
				this.SendPropertyChanged("System_Memory_Type");
				this.OnSystem_Memory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Channels", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Channels
	{
		get
		{
			return this._Memory_Channels;
		}
		set
		{
			if ((this._Memory_Channels != value))
			{
				this.OnMemory_ChannelsChanging(value);
				this.SendPropertyChanging();
				this._Memory_Channels = value;
				this.SendPropertyChanged("Memory_Channels");
				this.OnMemory_ChannelsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToAirCooler", Storage="_CpuToAirCoolers", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToAirCooler> CpuToAirCoolers
	{
		get
		{
			return this._CpuToAirCoolers;
		}
		set
		{
			this._CpuToAirCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToLiquidCooler", Storage="_CpuToLiquidCoolers", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToLiquidCooler> CpuToLiquidCoolers
	{
		get
		{
			return this._CpuToLiquidCoolers;
		}
		set
		{
			this._CpuToLiquidCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_MoboToCpu", Storage="_MoboToCpus", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<MoboToCpu> MoboToCpus
	{
		get
		{
			return this._MoboToCpus;
		}
		set
		{
			this._MoboToCpus.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToAirCooler1", Storage="_CpuToAirCooler1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToAirCooler1> CpuToAirCooler1s
	{
		get
		{
			return this._CpuToAirCooler1s;
		}
		set
		{
			this._CpuToAirCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToLiquidCooler1", Storage="_CpuToLiquidCooler1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<CpuToLiquidCooler1> CpuToLiquidCooler1s
	{
		get
		{
			return this._CpuToLiquidCooler1s;
		}
		set
		{
			this._CpuToLiquidCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_MoboToCpu1", Storage="_MoboToCpu1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<MoboToCpu1> MoboToCpu1s
	{
		get
		{
			return this._MoboToCpu1s;
		}
		set
		{
			this._MoboToCpu1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="CPU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_CPU1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.CPU1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.CPU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_CPU1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.CPU1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.CPU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_CpuToAirCoolers(CpuToAirCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_CpuToAirCooler1s(CpuToAirCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.CPU1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CpuToAirCooler")]
public partial class CpuToAirCooler1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CPU_ID;
	
	private int _AC_ID;
	
	private EntityRef<AirCooler> _AirCooler;
	
	private EntityRef<AirCooler1> _AirCooler1;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<CPU1> _CPU1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnAC_IDChanging(int value);
    partial void OnAC_IDChanged();
    #endregion
	
	public CpuToAirCooler1()
	{
		this._AirCooler = default(EntityRef<AirCooler>);
		this._AirCooler1 = default(EntityRef<AirCooler1>);
		this._CPU = default(EntityRef<CPU>);
		this._CPU1 = default(EntityRef<CPU1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int AC_ID
	{
		get
		{
			return this._AC_ID;
		}
		set
		{
			if ((this._AC_ID != value))
			{
				if ((this._AirCooler.HasLoadedOrAssignedValue || this._AirCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAC_IDChanging(value);
				this.SendPropertyChanging();
				this._AC_ID = value;
				this.SendPropertyChanged("AC_ID");
				this.OnAC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler_CpuToAirCooler1", Storage="_AirCooler", ThisKey="AC_ID", OtherKey="ID", IsForeignKey=true)]
	public AirCooler AirCooler
	{
		get
		{
			return this._AirCooler.Entity;
		}
		set
		{
			AirCooler previousValue = this._AirCooler.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler.Entity = null;
					previousValue.CpuToAirCooler1s.Remove(this);
				}
				this._AirCooler.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCooler1s.Add(this);
					this._AC_ID = value.ID;
				}
				else
				{
					this._AC_ID = default(int);
				}
				this.SendPropertyChanged("AirCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AirCooler1_CpuToAirCooler1", Storage="_AirCooler1", ThisKey="AC_ID", OtherKey="ID", IsForeignKey=true)]
	public AirCooler1 AirCooler1
	{
		get
		{
			return this._AirCooler1.Entity;
		}
		set
		{
			AirCooler1 previousValue = this._AirCooler1.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler1.Entity = null;
					previousValue.CpuToAirCooler1s.Remove(this);
				}
				this._AirCooler1.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCooler1s.Add(this);
					this._AC_ID = value.ID;
				}
				else
				{
					this._AC_ID = default(int);
				}
				this.SendPropertyChanged("AirCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToAirCooler1", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.CpuToAirCooler1s.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCooler1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToAirCooler1", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.CpuToAirCooler1s.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.CpuToAirCooler1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CpuToLiquidCooler")]
public partial class CpuToLiquidCooler1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CPU_ID;
	
	private int _LC_ID;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnLC_IDChanging(int value);
    partial void OnLC_IDChanged();
    #endregion
	
	public CpuToLiquidCooler1()
	{
		this._CPU = default(EntityRef<CPU>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int LC_ID
	{
		get
		{
			return this._LC_ID;
		}
		set
		{
			if ((this._LC_ID != value))
			{
				if ((this._LiquidCooler.HasLoadedOrAssignedValue || this._LiquidCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnLC_IDChanging(value);
				this.SendPropertyChanging();
				this._LC_ID = value;
				this.SendPropertyChanged("LC_ID");
				this.OnLC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_CpuToLiquidCooler1", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.CpuToLiquidCooler1s.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCooler1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_CpuToLiquidCooler1", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.CpuToLiquidCooler1s.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCooler1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_CpuToLiquidCooler1", Storage="_LiquidCooler", ThisKey="LC_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.CpuToLiquidCooler1s.Remove(this);
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCooler1s.Add(this);
					this._LC_ID = value.ID;
				}
				else
				{
					this._LC_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_CpuToLiquidCooler1", Storage="_LiquidCooler1", ThisKey="LC_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.CpuToLiquidCooler1s.Remove(this);
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.CpuToLiquidCooler1s.Add(this);
					this._LC_ID = value.ID;
				}
				else
				{
					this._LC_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fans")]
public partial class Fan1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Size;
	
	private string _RPM;
	
	private string _Max_Air_Flow;
	
	private string _Noise;
	
	private string _Static_Pressure;
	
	private string _Input_Voltage;
	
	private string _MTBF;
	
	private string _Cable_Length;
	
	private int _Num_Fans;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnRPMChanging(string value);
    partial void OnRPMChanged();
    partial void OnMax_Air_FlowChanging(string value);
    partial void OnMax_Air_FlowChanged();
    partial void OnNoiseChanging(string value);
    partial void OnNoiseChanged();
    partial void OnStatic_PressureChanging(string value);
    partial void OnStatic_PressureChanged();
    partial void OnInput_VoltageChanging(string value);
    partial void OnInput_VoltageChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnNum_FansChanging(int value);
    partial void OnNum_FansChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Fan1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RPM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string RPM
	{
		get
		{
			return this._RPM;
		}
		set
		{
			if ((this._RPM != value))
			{
				this.OnRPMChanging(value);
				this.SendPropertyChanging();
				this._RPM = value;
				this.SendPropertyChanged("RPM");
				this.OnRPMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Air_Flow", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Air_Flow
	{
		get
		{
			return this._Max_Air_Flow;
		}
		set
		{
			if ((this._Max_Air_Flow != value))
			{
				this.OnMax_Air_FlowChanging(value);
				this.SendPropertyChanging();
				this._Max_Air_Flow = value;
				this.SendPropertyChanged("Max_Air_Flow");
				this.OnMax_Air_FlowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noise", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Noise
	{
		get
		{
			return this._Noise;
		}
		set
		{
			if ((this._Noise != value))
			{
				this.OnNoiseChanging(value);
				this.SendPropertyChanging();
				this._Noise = value;
				this.SendPropertyChanged("Noise");
				this.OnNoiseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Static_Pressure", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Static_Pressure
	{
		get
		{
			return this._Static_Pressure;
		}
		set
		{
			if ((this._Static_Pressure != value))
			{
				this.OnStatic_PressureChanging(value);
				this.SendPropertyChanging();
				this._Static_Pressure = value;
				this.SendPropertyChanged("Static_Pressure");
				this.OnStatic_PressureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Input_Voltage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Input_Voltage
	{
		get
		{
			return this._Input_Voltage;
		}
		set
		{
			if ((this._Input_Voltage != value))
			{
				this.OnInput_VoltageChanging(value);
				this.SendPropertyChanging();
				this._Input_Voltage = value;
				this.SendPropertyChanged("Input_Voltage");
				this.OnInput_VoltageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Fans", DbType="Int NOT NULL")]
	public int Num_Fans
	{
		get
		{
			return this._Num_Fans;
		}
		set
		{
			if ((this._Num_Fans != value))
			{
				this.OnNum_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Fans = value;
				this.SendPropertyChanged("Num_Fans");
				this.OnNum_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Fan_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Fan_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Fan1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Fan1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Fan1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Fan1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Fan1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Fan1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Fan1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Fan1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Fan1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Fan1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GPU")]
public partial class GPU1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Manufacturer;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Base_Clock_Speed;
	
	private string _Boost_Clock_Speed;
	
	private string _Stream_Processors;
	
	private string _Memory_Clock;
	
	private string _Memory_Size;
	
	private string _Memory_Type;
	
	private string _Ports;
	
	private string _Max_Digital_Resolution;
	
	private string _VR_Ready;
	
	private string _Recommended_Power_Supply;
	
	private string _Form_Factor;
	
	private string _Slot_Width;
	
	private string _Length;
	
	private string _Height;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnBase_Clock_SpeedChanging(string value);
    partial void OnBase_Clock_SpeedChanged();
    partial void OnBoost_Clock_SpeedChanging(string value);
    partial void OnBoost_Clock_SpeedChanged();
    partial void OnStream_ProcessorsChanging(string value);
    partial void OnStream_ProcessorsChanged();
    partial void OnMemory_ClockChanging(string value);
    partial void OnMemory_ClockChanged();
    partial void OnMemory_SizeChanging(string value);
    partial void OnMemory_SizeChanged();
    partial void OnMemory_TypeChanging(string value);
    partial void OnMemory_TypeChanged();
    partial void OnPortsChanging(string value);
    partial void OnPortsChanged();
    partial void OnMax_Digital_ResolutionChanging(string value);
    partial void OnMax_Digital_ResolutionChanged();
    partial void OnVR_ReadyChanging(string value);
    partial void OnVR_ReadyChanged();
    partial void OnRecommended_Power_SupplyChanging(string value);
    partial void OnRecommended_Power_SupplyChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnSlot_WidthChanging(string value);
    partial void OnSlot_WidthChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public GPU1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Manufacturer
	{
		get
		{
			return this._Manufacturer;
		}
		set
		{
			if ((this._Manufacturer != value))
			{
				this.OnManufacturerChanging(value);
				this.SendPropertyChanging();
				this._Manufacturer = value;
				this.SendPropertyChanged("Manufacturer");
				this.OnManufacturerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base_Clock_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base_Clock_Speed
	{
		get
		{
			return this._Base_Clock_Speed;
		}
		set
		{
			if ((this._Base_Clock_Speed != value))
			{
				this.OnBase_Clock_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Base_Clock_Speed = value;
				this.SendPropertyChanged("Base_Clock_Speed");
				this.OnBase_Clock_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Boost_Clock_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Boost_Clock_Speed
	{
		get
		{
			return this._Boost_Clock_Speed;
		}
		set
		{
			if ((this._Boost_Clock_Speed != value))
			{
				this.OnBoost_Clock_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Boost_Clock_Speed = value;
				this.SendPropertyChanged("Boost_Clock_Speed");
				this.OnBoost_Clock_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stream_Processors", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Stream_Processors
	{
		get
		{
			return this._Stream_Processors;
		}
		set
		{
			if ((this._Stream_Processors != value))
			{
				this.OnStream_ProcessorsChanging(value);
				this.SendPropertyChanging();
				this._Stream_Processors = value;
				this.SendPropertyChanged("Stream_Processors");
				this.OnStream_ProcessorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Clock", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Clock
	{
		get
		{
			return this._Memory_Clock;
		}
		set
		{
			if ((this._Memory_Clock != value))
			{
				this.OnMemory_ClockChanging(value);
				this.SendPropertyChanging();
				this._Memory_Clock = value;
				this.SendPropertyChanged("Memory_Clock");
				this.OnMemory_ClockChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Size
	{
		get
		{
			return this._Memory_Size;
		}
		set
		{
			if ((this._Memory_Size != value))
			{
				this.OnMemory_SizeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Size = value;
				this.SendPropertyChanged("Memory_Size");
				this.OnMemory_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Memory_Type
	{
		get
		{
			return this._Memory_Type;
		}
		set
		{
			if ((this._Memory_Type != value))
			{
				this.OnMemory_TypeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Type = value;
				this.SendPropertyChanged("Memory_Type");
				this.OnMemory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ports", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Ports
	{
		get
		{
			return this._Ports;
		}
		set
		{
			if ((this._Ports != value))
			{
				this.OnPortsChanging(value);
				this.SendPropertyChanging();
				this._Ports = value;
				this.SendPropertyChanged("Ports");
				this.OnPortsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Digital_Resolution", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Max_Digital_Resolution
	{
		get
		{
			return this._Max_Digital_Resolution;
		}
		set
		{
			if ((this._Max_Digital_Resolution != value))
			{
				this.OnMax_Digital_ResolutionChanging(value);
				this.SendPropertyChanging();
				this._Max_Digital_Resolution = value;
				this.SendPropertyChanged("Max_Digital_Resolution");
				this.OnMax_Digital_ResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VR_Ready", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string VR_Ready
	{
		get
		{
			return this._VR_Ready;
		}
		set
		{
			if ((this._VR_Ready != value))
			{
				this.OnVR_ReadyChanging(value);
				this.SendPropertyChanging();
				this._VR_Ready = value;
				this.SendPropertyChanged("VR_Ready");
				this.OnVR_ReadyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Recommended_Power_Supply", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Recommended_Power_Supply
	{
		get
		{
			return this._Recommended_Power_Supply;
		}
		set
		{
			if ((this._Recommended_Power_Supply != value))
			{
				this.OnRecommended_Power_SupplyChanging(value);
				this.SendPropertyChanging();
				this._Recommended_Power_Supply = value;
				this.SendPropertyChanged("Recommended_Power_Supply");
				this.OnRecommended_Power_SupplyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slot_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Slot_Width
	{
		get
		{
			return this._Slot_Width;
		}
		set
		{
			if ((this._Slot_Width != value))
			{
				this.OnSlot_WidthChanging(value);
				this.SendPropertyChanging();
				this._Slot_Width = value;
				this.SendPropertyChanged("Slot_Width");
				this.OnSlot_WidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="GPU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="GPU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_GPU1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.GPU1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.GPU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_GPU1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.GPU1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.GPU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.GPU1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.GPU1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.GPU1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.GPU1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HDD")]
public partial class HDD1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Interface;
	
	private string _Max_Sustained_Transfer_Rate;
	
	private string _Rotational_Speed;
	
	private string _Load_Unload_Cycles;
	
	private string _Workload_Rate_Limit;
	
	private string _Power_Usage;
	
	private string _Operating_Temp;
	
	private string _Size;
	
	private string _Weight;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnInterfaceChanging(string value);
    partial void OnInterfaceChanged();
    partial void OnMax_Sustained_Transfer_RateChanging(string value);
    partial void OnMax_Sustained_Transfer_RateChanged();
    partial void OnRotational_SpeedChanging(string value);
    partial void OnRotational_SpeedChanged();
    partial void OnLoad_Unload_CyclesChanging(string value);
    partial void OnLoad_Unload_CyclesChanged();
    partial void OnWorkload_Rate_LimitChanging(string value);
    partial void OnWorkload_Rate_LimitChanged();
    partial void OnPower_UsageChanging(string value);
    partial void OnPower_UsageChanged();
    partial void OnOperating_TempChanging(string value);
    partial void OnOperating_TempChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public HDD1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Interface", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Interface
	{
		get
		{
			return this._Interface;
		}
		set
		{
			if ((this._Interface != value))
			{
				this.OnInterfaceChanging(value);
				this.SendPropertyChanging();
				this._Interface = value;
				this.SendPropertyChanged("Interface");
				this.OnInterfaceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sustained_Transfer_Rate", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sustained_Transfer_Rate
	{
		get
		{
			return this._Max_Sustained_Transfer_Rate;
		}
		set
		{
			if ((this._Max_Sustained_Transfer_Rate != value))
			{
				this.OnMax_Sustained_Transfer_RateChanging(value);
				this.SendPropertyChanging();
				this._Max_Sustained_Transfer_Rate = value;
				this.SendPropertyChanged("Max_Sustained_Transfer_Rate");
				this.OnMax_Sustained_Transfer_RateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rotational_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Rotational_Speed
	{
		get
		{
			return this._Rotational_Speed;
		}
		set
		{
			if ((this._Rotational_Speed != value))
			{
				this.OnRotational_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Rotational_Speed = value;
				this.SendPropertyChanged("Rotational_Speed");
				this.OnRotational_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Load_Unload_Cycles", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Load_Unload_Cycles
	{
		get
		{
			return this._Load_Unload_Cycles;
		}
		set
		{
			if ((this._Load_Unload_Cycles != value))
			{
				this.OnLoad_Unload_CyclesChanging(value);
				this.SendPropertyChanging();
				this._Load_Unload_Cycles = value;
				this.SendPropertyChanged("Load_Unload_Cycles");
				this.OnLoad_Unload_CyclesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Workload_Rate_Limit", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Workload_Rate_Limit
	{
		get
		{
			return this._Workload_Rate_Limit;
		}
		set
		{
			if ((this._Workload_Rate_Limit != value))
			{
				this.OnWorkload_Rate_LimitChanging(value);
				this.SendPropertyChanging();
				this._Workload_Rate_Limit = value;
				this.SendPropertyChanged("Workload_Rate_Limit");
				this.OnWorkload_Rate_LimitChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power_Usage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power_Usage
	{
		get
		{
			return this._Power_Usage;
		}
		set
		{
			if ((this._Power_Usage != value))
			{
				this.OnPower_UsageChanging(value);
				this.SendPropertyChanging();
				this._Power_Usage = value;
				this.SendPropertyChanged("Power_Usage");
				this.OnPower_UsageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operating_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Operating_Temp
	{
		get
		{
			return this._Operating_Temp;
		}
		set
		{
			if ((this._Operating_Temp != value))
			{
				this.OnOperating_TempChanging(value);
				this.SendPropertyChanging();
				this._Operating_Temp = value;
				this.SendPropertyChanged("Operating_Temp");
				this.OnOperating_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="HDD_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="HDD_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_HDD1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.HDD1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.HDD1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_HDD1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.HDD1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.HDD1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.HDD1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.HDD1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.HDD1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.HDD1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Headset")]
public partial class Headset1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Cable_Length;
	
	private string _Connector;
	
	private string _Frequency_Response;
	
	private string _Sound_Pressure_Level;
	
	private string _Microphone;
	
	private string _MP_Frequency_Response;
	
	private string _MP_Pickup_Pattern;
	
	private string _MP_Sensitivity;
	
	private string _Colour;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnConnectorChanging(string value);
    partial void OnConnectorChanged();
    partial void OnFrequency_ResponseChanging(string value);
    partial void OnFrequency_ResponseChanged();
    partial void OnSound_Pressure_LevelChanging(string value);
    partial void OnSound_Pressure_LevelChanged();
    partial void OnMicrophoneChanging(string value);
    partial void OnMicrophoneChanged();
    partial void OnMP_Frequency_ResponseChanging(string value);
    partial void OnMP_Frequency_ResponseChanged();
    partial void OnMP_Pickup_PatternChanging(string value);
    partial void OnMP_Pickup_PatternChanged();
    partial void OnMP_SensitivityChanging(string value);
    partial void OnMP_SensitivityChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Headset1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connector", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Connector
	{
		get
		{
			return this._Connector;
		}
		set
		{
			if ((this._Connector != value))
			{
				this.OnConnectorChanging(value);
				this.SendPropertyChanging();
				this._Connector = value;
				this.SendPropertyChanged("Connector");
				this.OnConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frequency_Response", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Frequency_Response
	{
		get
		{
			return this._Frequency_Response;
		}
		set
		{
			if ((this._Frequency_Response != value))
			{
				this.OnFrequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._Frequency_Response = value;
				this.SendPropertyChanged("Frequency_Response");
				this.OnFrequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sound_Pressure_Level", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sound_Pressure_Level
	{
		get
		{
			return this._Sound_Pressure_Level;
		}
		set
		{
			if ((this._Sound_Pressure_Level != value))
			{
				this.OnSound_Pressure_LevelChanging(value);
				this.SendPropertyChanging();
				this._Sound_Pressure_Level = value;
				this.SendPropertyChanged("Sound_Pressure_Level");
				this.OnSound_Pressure_LevelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Microphone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Microphone
	{
		get
		{
			return this._Microphone;
		}
		set
		{
			if ((this._Microphone != value))
			{
				this.OnMicrophoneChanging(value);
				this.SendPropertyChanging();
				this._Microphone = value;
				this.SendPropertyChanged("Microphone");
				this.OnMicrophoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Frequency_Response", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Frequency_Response
	{
		get
		{
			return this._MP_Frequency_Response;
		}
		set
		{
			if ((this._MP_Frequency_Response != value))
			{
				this.OnMP_Frequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._MP_Frequency_Response = value;
				this.SendPropertyChanged("MP_Frequency_Response");
				this.OnMP_Frequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Pickup_Pattern", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Pickup_Pattern
	{
		get
		{
			return this._MP_Pickup_Pattern;
		}
		set
		{
			if ((this._MP_Pickup_Pattern != value))
			{
				this.OnMP_Pickup_PatternChanging(value);
				this.SendPropertyChanging();
				this._MP_Pickup_Pattern = value;
				this.SendPropertyChanged("MP_Pickup_Pattern");
				this.OnMP_Pickup_PatternChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MP_Sensitivity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MP_Sensitivity
	{
		get
		{
			return this._MP_Sensitivity;
		}
		set
		{
			if ((this._MP_Sensitivity != value))
			{
				this.OnMP_SensitivityChanging(value);
				this.SendPropertyChanging();
				this._MP_Sensitivity = value;
				this.SendPropertyChanged("MP_Sensitivity");
				this.OnMP_SensitivityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Headset_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Headset_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Headset1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Headset1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Headset1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Headset1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Headset1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Headset1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Headset1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Headset1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Headset1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Headset1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Keyboard")]
public partial class Keyboard1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Switches;
	
	private string _Programmable_Macros;
	
	private string _Connector;
	
	private string _LED_BackLight;
	
	private string _Multimedia_Keys;
	
	private string _Material;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSwitchesChanging(string value);
    partial void OnSwitchesChanged();
    partial void OnProgrammable_MacrosChanging(string value);
    partial void OnProgrammable_MacrosChanged();
    partial void OnConnectorChanging(string value);
    partial void OnConnectorChanged();
    partial void OnLED_BackLightChanging(string value);
    partial void OnLED_BackLightChanged();
    partial void OnMultimedia_KeysChanging(string value);
    partial void OnMultimedia_KeysChanged();
    partial void OnMaterialChanging(string value);
    partial void OnMaterialChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Keyboard1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Switches", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Switches
	{
		get
		{
			return this._Switches;
		}
		set
		{
			if ((this._Switches != value))
			{
				this.OnSwitchesChanging(value);
				this.SendPropertyChanging();
				this._Switches = value;
				this.SendPropertyChanged("Switches");
				this.OnSwitchesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Programmable_Macros", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Programmable_Macros
	{
		get
		{
			return this._Programmable_Macros;
		}
		set
		{
			if ((this._Programmable_Macros != value))
			{
				this.OnProgrammable_MacrosChanging(value);
				this.SendPropertyChanging();
				this._Programmable_Macros = value;
				this.SendPropertyChanged("Programmable_Macros");
				this.OnProgrammable_MacrosChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connector", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Connector
	{
		get
		{
			return this._Connector;
		}
		set
		{
			if ((this._Connector != value))
			{
				this.OnConnectorChanging(value);
				this.SendPropertyChanging();
				this._Connector = value;
				this.SendPropertyChanged("Connector");
				this.OnConnectorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LED_BackLight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string LED_BackLight
	{
		get
		{
			return this._LED_BackLight;
		}
		set
		{
			if ((this._LED_BackLight != value))
			{
				this.OnLED_BackLightChanging(value);
				this.SendPropertyChanging();
				this._LED_BackLight = value;
				this.SendPropertyChanged("LED_BackLight");
				this.OnLED_BackLightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Multimedia_Keys", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Multimedia_Keys
	{
		get
		{
			return this._Multimedia_Keys;
		}
		set
		{
			if ((this._Multimedia_Keys != value))
			{
				this.OnMultimedia_KeysChanging(value);
				this.SendPropertyChanging();
				this._Multimedia_Keys = value;
				this.SendPropertyChanged("Multimedia_Keys");
				this.OnMultimedia_KeysChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Material", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Material
	{
		get
		{
			return this._Material;
		}
		set
		{
			if ((this._Material != value))
			{
				this.OnMaterialChanging(value);
				this.SendPropertyChanging();
				this._Material = value;
				this.SendPropertyChanged("Material");
				this.OnMaterialChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Keyboard_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Keyboard_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Keyboard1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Keyboard1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Keyboard1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Keyboard1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Keyboard1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Keyboard1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Keyboard1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiquidCooler")]
public partial class LiquidCooler1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Fan_Size;
	
	private string _Fan_Height;
	
	private string _Radiator_Mats;
	
	private string _Radiator_Length;
	
	private string _Radiator_Width;
	
	private string _Radiator_Height;
	
	private string _Tube_Length;
	
	private string _Tube_Mats;
	
	private string _Sockets_Supported;
	
	private string _Color;
	
	private string _RGB;
	
	private string _Warranty;
	
	private EntitySet<CpuToLiquidCooler> _CpuToLiquidCoolers;
	
	private EntitySet<CpuToLiquidCooler1> _CpuToLiquidCooler1s;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnFan_HeightChanging(string value);
    partial void OnFan_HeightChanged();
    partial void OnRadiator_MatsChanging(string value);
    partial void OnRadiator_MatsChanged();
    partial void OnRadiator_LengthChanging(string value);
    partial void OnRadiator_LengthChanged();
    partial void OnRadiator_WidthChanging(string value);
    partial void OnRadiator_WidthChanged();
    partial void OnRadiator_HeightChanging(string value);
    partial void OnRadiator_HeightChanged();
    partial void OnTube_LengthChanging(string value);
    partial void OnTube_LengthChanged();
    partial void OnTube_MatsChanging(string value);
    partial void OnTube_MatsChanged();
    partial void OnSockets_SupportedChanging(string value);
    partial void OnSockets_SupportedChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnRGBChanging(string value);
    partial void OnRGBChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public LiquidCooler1()
	{
		this._CpuToLiquidCoolers = new EntitySet<CpuToLiquidCooler>(new Action<CpuToLiquidCooler>(this.attach_CpuToLiquidCoolers), new Action<CpuToLiquidCooler>(this.detach_CpuToLiquidCoolers));
		this._CpuToLiquidCooler1s = new EntitySet<CpuToLiquidCooler1>(new Action<CpuToLiquidCooler1>(this.attach_CpuToLiquidCooler1s), new Action<CpuToLiquidCooler1>(this.detach_CpuToLiquidCooler1s));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Height
	{
		get
		{
			return this._Fan_Height;
		}
		set
		{
			if ((this._Fan_Height != value))
			{
				this.OnFan_HeightChanging(value);
				this.SendPropertyChanging();
				this._Fan_Height = value;
				this.SendPropertyChanged("Fan_Height");
				this.OnFan_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Mats", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Mats
	{
		get
		{
			return this._Radiator_Mats;
		}
		set
		{
			if ((this._Radiator_Mats != value))
			{
				this.OnRadiator_MatsChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Mats = value;
				this.SendPropertyChanged("Radiator_Mats");
				this.OnRadiator_MatsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Length
	{
		get
		{
			return this._Radiator_Length;
		}
		set
		{
			if ((this._Radiator_Length != value))
			{
				this.OnRadiator_LengthChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Length = value;
				this.SendPropertyChanged("Radiator_Length");
				this.OnRadiator_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Width
	{
		get
		{
			return this._Radiator_Width;
		}
		set
		{
			if ((this._Radiator_Width != value))
			{
				this.OnRadiator_WidthChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Width = value;
				this.SendPropertyChanged("Radiator_Width");
				this.OnRadiator_WidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radiator_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Radiator_Height
	{
		get
		{
			return this._Radiator_Height;
		}
		set
		{
			if ((this._Radiator_Height != value))
			{
				this.OnRadiator_HeightChanging(value);
				this.SendPropertyChanging();
				this._Radiator_Height = value;
				this.SendPropertyChanged("Radiator_Height");
				this.OnRadiator_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tube_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tube_Length
	{
		get
		{
			return this._Tube_Length;
		}
		set
		{
			if ((this._Tube_Length != value))
			{
				this.OnTube_LengthChanging(value);
				this.SendPropertyChanging();
				this._Tube_Length = value;
				this.SendPropertyChanged("Tube_Length");
				this.OnTube_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tube_Mats", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tube_Mats
	{
		get
		{
			return this._Tube_Mats;
		}
		set
		{
			if ((this._Tube_Mats != value))
			{
				this.OnTube_MatsChanging(value);
				this.SendPropertyChanging();
				this._Tube_Mats = value;
				this.SendPropertyChanged("Tube_Mats");
				this.OnTube_MatsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sockets_Supported", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Sockets_Supported
	{
		get
		{
			return this._Sockets_Supported;
		}
		set
		{
			if ((this._Sockets_Supported != value))
			{
				this.OnSockets_SupportedChanging(value);
				this.SendPropertyChanging();
				this._Sockets_Supported = value;
				this.SendPropertyChanged("Sockets_Supported");
				this.OnSockets_SupportedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Color
	{
		get
		{
			return this._Color;
		}
		set
		{
			if ((this._Color != value))
			{
				this.OnColorChanging(value);
				this.SendPropertyChanging();
				this._Color = value;
				this.SendPropertyChanged("Color");
				this.OnColorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RGB", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string RGB
	{
		get
		{
			return this._RGB;
		}
		set
		{
			if ((this._RGB != value))
			{
				this.OnRGBChanging(value);
				this.SendPropertyChanging();
				this._RGB = value;
				this.SendPropertyChanged("RGB");
				this.OnRGBChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_CpuToLiquidCooler", Storage="_CpuToLiquidCoolers", ThisKey="ID", OtherKey="LC_ID")]
	public EntitySet<CpuToLiquidCooler> CpuToLiquidCoolers
	{
		get
		{
			return this._CpuToLiquidCoolers;
		}
		set
		{
			this._CpuToLiquidCoolers.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_CpuToLiquidCooler1", Storage="_CpuToLiquidCooler1s", ThisKey="ID", OtherKey="LC_ID")]
	public EntitySet<CpuToLiquidCooler1> CpuToLiquidCooler1s
	{
		get
		{
			return this._CpuToLiquidCooler1s;
		}
		set
		{
			this._CpuToLiquidCooler1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Cooler_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Cooler_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_LiquidCooler1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.LiquidCooler1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.LiquidCooler1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_LiquidCooler1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.LiquidCooler1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.LiquidCooler1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = this;
	}
	
	private void detach_CpuToLiquidCoolers(CpuToLiquidCooler entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = null;
	}
	
	private void attach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = this;
	}
	
	private void detach_CpuToLiquidCooler1s(CpuToLiquidCooler1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.LiquidCooler1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginTable")]
public partial class LoginTable1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private string _User_Name;
	
	private string _Password;
	
	private int _User_Type;
	
	private EntityRef<Admin> _Admin;
	
	private EntityRef<Admin1> _Admin1;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnUser_NameChanging(string value);
    partial void OnUser_NameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUser_TypeChanging(int value);
    partial void OnUser_TypeChanged();
    #endregion
	
	public LoginTable1()
	{
		this._Admin = default(EntityRef<Admin>);
		this._Admin1 = default(EntityRef<Admin1>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string User_Name
	{
		get
		{
			return this._User_Name;
		}
		set
		{
			if ((this._User_Name != value))
			{
				this.OnUser_NameChanging(value);
				this.SendPropertyChanging();
				this._User_Name = value;
				this.SendPropertyChanged("User_Name");
				this.OnUser_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="Int NOT NULL")]
	public int User_Type
	{
		get
		{
			return this._User_Type;
		}
		set
		{
			if ((this._User_Type != value))
			{
				this.OnUser_TypeChanging(value);
				this.SendPropertyChanging();
				this._User_Type = value;
				this.SendPropertyChanged("User_Type");
				this.OnUser_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Admin", Storage="_Admin", ThisKey="User_ID", OtherKey="Admin_ID", IsUnique=true, IsForeignKey=false)]
	public Admin Admin
	{
		get
		{
			return this._Admin.Entity;
		}
		set
		{
			Admin previousValue = this._Admin.Entity;
			if (((previousValue != value) 
						|| (this._Admin.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin.Entity = null;
					previousValue.LoginTable1 = null;
				}
				this._Admin.Entity = value;
				if ((value != null))
				{
					value.LoginTable1 = this;
				}
				this.SendPropertyChanged("Admin");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Admin1", Storage="_Admin1", ThisKey="User_ID", OtherKey="Admin_ID", IsUnique=true, IsForeignKey=false)]
	public Admin1 Admin1
	{
		get
		{
			return this._Admin1.Entity;
		}
		set
		{
			Admin1 previousValue = this._Admin1.Entity;
			if (((previousValue != value) 
						|| (this._Admin1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin1.Entity = null;
					previousValue.LoginTable1 = null;
				}
				this._Admin1.Entity = value;
				if ((value != null))
				{
					value.LoginTable1 = this;
				}
				this.SendPropertyChanged("Admin1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Client", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsUnique=true, IsForeignKey=false)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.LoginTable1 = null;
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.LoginTable1 = this;
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginTable1_Client1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsUnique=true, IsForeignKey=false)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.LoginTable1 = null;
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.LoginTable1 = this;
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Microphone")]
public partial class Microphone1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Pick_Up_Pattern;
	
	private string _Frequency_Response;
	
	private string _Sensitivity;
	
	private string _Cable_Length;
	
	private string _Warranty;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnPick_Up_PatternChanging(string value);
    partial void OnPick_Up_PatternChanged();
    partial void OnFrequency_ResponseChanging(string value);
    partial void OnFrequency_ResponseChanged();
    partial void OnSensitivityChanging(string value);
    partial void OnSensitivityChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Microphone1()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pick_Up_Pattern", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Pick_Up_Pattern
	{
		get
		{
			return this._Pick_Up_Pattern;
		}
		set
		{
			if ((this._Pick_Up_Pattern != value))
			{
				this.OnPick_Up_PatternChanging(value);
				this.SendPropertyChanging();
				this._Pick_Up_Pattern = value;
				this.SendPropertyChanged("Pick_Up_Pattern");
				this.OnPick_Up_PatternChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Frequency_Response", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Frequency_Response
	{
		get
		{
			return this._Frequency_Response;
		}
		set
		{
			if ((this._Frequency_Response != value))
			{
				this.OnFrequency_ResponseChanging(value);
				this.SendPropertyChanging();
				this._Frequency_Response = value;
				this.SendPropertyChanged("Frequency_Response");
				this.OnFrequency_ResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sensitivity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sensitivity
	{
		get
		{
			return this._Sensitivity;
		}
		set
		{
			if ((this._Sensitivity != value))
			{
				this.OnSensitivityChanging(value);
				this.SendPropertyChanging();
				this._Sensitivity = value;
				this.SendPropertyChanged("Sensitivity");
				this.OnSensitivityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Microphone1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Microphone1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Microphone1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Microphone1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Microphone1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Microphone1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToCase")]
public partial class MoboToCase1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _Case_ID;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<PCCase1> _PCCase1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCase_IDChanging(int value);
    partial void OnCase_IDChanged();
    #endregion
	
	public MoboToCase1()
	{
		this._PCCase = default(EntityRef<PCCase>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._PCCase1 = default(EntityRef<PCCase1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Case_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Case_ID
	{
		get
		{
			return this._Case_ID;
		}
		set
		{
			if ((this._Case_ID != value))
			{
				if ((this._PCCase.HasLoadedOrAssignedValue || this._PCCase1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCase_IDChanging(value);
				this.SendPropertyChanging();
				this._Case_ID = value;
				this.SendPropertyChanged("Case_ID");
				this.OnCase_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_MoboToCase1", Storage="_PCCase", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.MoboToCase1s.Remove(this);
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.MoboToCase1s.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCase1", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToCase1s.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToCase1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCase1", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToCase1s.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToCase1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_MoboToCase1", Storage="_PCCase1", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.MoboToCase1s.Remove(this);
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.MoboToCase1s.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToCpu")]
public partial class MoboToCpu1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _CPU_ID;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    #endregion
	
	public MoboToCpu1()
	{
		this._CPU = default(EntityRef<CPU>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_MoboToCpu1", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.MoboToCpu1s.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.MoboToCpu1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_MoboToCpu1", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.MoboToCpu1s.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.MoboToCpu1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToCpu1", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToCpu1s.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToCpu1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCpu1", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToCpu1s.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToCpu1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoboToRam")]
public partial class MoboToRam1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Mobo_ID;
	
	private int _RAM_ID;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<RAM1> _RAM1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnRAM_IDChanging(int value);
    partial void OnRAM_IDChanged();
    #endregion
	
	public MoboToRam1()
	{
		this._Motherboard = default(EntityRef<Motherboard>);
		this._RAM = default(EntityRef<RAM>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._RAM1 = default(EntityRef<RAM1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				if ((this._RAM.HasLoadedOrAssignedValue || this._RAM1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRAM_IDChanging(value);
				this.SendPropertyChanging();
				this._RAM_ID = value;
				this.SendPropertyChanged("RAM_ID");
				this.OnRAM_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_MoboToRam1", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.MoboToRam1s.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.MoboToRam1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_MoboToRam1", Storage="_RAM", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.MoboToRam1s.Remove(this);
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.MoboToRam1s.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToRam1", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.MoboToRam1s.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.MoboToRam1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_MoboToRam1", Storage="_RAM1", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.MoboToRam1s.Remove(this);
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.MoboToRam1s.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Monitor")]
public partial class Monitor1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Screen_Size;
	
	private string _Screen_Ratio;
	
	private string _Brightness;
	
	private string _Contrast_Ratio;
	
	private string _Viewing_Angle;
	
	private string _Response_Time;
	
	private string _Panel_Type;
	
	private string _Refresh_Rate;
	
	private string _Resolution;
	
	private string _Colours;
	
	private string _Display_Connectors;
	
	private string _Speakers;
	
	private string _Swivel;
	
	private string _Tilt;
	
	private string _Pivot;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnScreen_SizeChanging(string value);
    partial void OnScreen_SizeChanged();
    partial void OnScreen_RatioChanging(string value);
    partial void OnScreen_RatioChanged();
    partial void OnBrightnessChanging(string value);
    partial void OnBrightnessChanged();
    partial void OnContrast_RatioChanging(string value);
    partial void OnContrast_RatioChanged();
    partial void OnViewing_AngleChanging(string value);
    partial void OnViewing_AngleChanged();
    partial void OnResponse_TimeChanging(string value);
    partial void OnResponse_TimeChanged();
    partial void OnPanel_TypeChanging(string value);
    partial void OnPanel_TypeChanged();
    partial void OnRefresh_RateChanging(string value);
    partial void OnRefresh_RateChanged();
    partial void OnResolutionChanging(string value);
    partial void OnResolutionChanged();
    partial void OnColoursChanging(string value);
    partial void OnColoursChanged();
    partial void OnDisplay_ConnectorsChanging(string value);
    partial void OnDisplay_ConnectorsChanged();
    partial void OnSpeakersChanging(string value);
    partial void OnSpeakersChanged();
    partial void OnSwivelChanging(string value);
    partial void OnSwivelChanged();
    partial void OnTiltChanging(string value);
    partial void OnTiltChanged();
    partial void OnPivotChanging(string value);
    partial void OnPivotChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Monitor1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Screen_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Screen_Size
	{
		get
		{
			return this._Screen_Size;
		}
		set
		{
			if ((this._Screen_Size != value))
			{
				this.OnScreen_SizeChanging(value);
				this.SendPropertyChanging();
				this._Screen_Size = value;
				this.SendPropertyChanged("Screen_Size");
				this.OnScreen_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Screen_Ratio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Screen_Ratio
	{
		get
		{
			return this._Screen_Ratio;
		}
		set
		{
			if ((this._Screen_Ratio != value))
			{
				this.OnScreen_RatioChanging(value);
				this.SendPropertyChanging();
				this._Screen_Ratio = value;
				this.SendPropertyChanged("Screen_Ratio");
				this.OnScreen_RatioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brightness", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brightness
	{
		get
		{
			return this._Brightness;
		}
		set
		{
			if ((this._Brightness != value))
			{
				this.OnBrightnessChanging(value);
				this.SendPropertyChanging();
				this._Brightness = value;
				this.SendPropertyChanged("Brightness");
				this.OnBrightnessChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrast_Ratio", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Contrast_Ratio
	{
		get
		{
			return this._Contrast_Ratio;
		}
		set
		{
			if ((this._Contrast_Ratio != value))
			{
				this.OnContrast_RatioChanging(value);
				this.SendPropertyChanging();
				this._Contrast_Ratio = value;
				this.SendPropertyChanged("Contrast_Ratio");
				this.OnContrast_RatioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Viewing_Angle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Viewing_Angle
	{
		get
		{
			return this._Viewing_Angle;
		}
		set
		{
			if ((this._Viewing_Angle != value))
			{
				this.OnViewing_AngleChanging(value);
				this.SendPropertyChanging();
				this._Viewing_Angle = value;
				this.SendPropertyChanged("Viewing_Angle");
				this.OnViewing_AngleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Response_Time", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Response_Time
	{
		get
		{
			return this._Response_Time;
		}
		set
		{
			if ((this._Response_Time != value))
			{
				this.OnResponse_TimeChanging(value);
				this.SendPropertyChanging();
				this._Response_Time = value;
				this.SendPropertyChanged("Response_Time");
				this.OnResponse_TimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Panel_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Panel_Type
	{
		get
		{
			return this._Panel_Type;
		}
		set
		{
			if ((this._Panel_Type != value))
			{
				this.OnPanel_TypeChanging(value);
				this.SendPropertyChanging();
				this._Panel_Type = value;
				this.SendPropertyChanged("Panel_Type");
				this.OnPanel_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Refresh_Rate", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Refresh_Rate
	{
		get
		{
			return this._Refresh_Rate;
		}
		set
		{
			if ((this._Refresh_Rate != value))
			{
				this.OnRefresh_RateChanging(value);
				this.SendPropertyChanging();
				this._Refresh_Rate = value;
				this.SendPropertyChanged("Refresh_Rate");
				this.OnRefresh_RateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolution", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Resolution
	{
		get
		{
			return this._Resolution;
		}
		set
		{
			if ((this._Resolution != value))
			{
				this.OnResolutionChanging(value);
				this.SendPropertyChanging();
				this._Resolution = value;
				this.SendPropertyChanged("Resolution");
				this.OnResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colours", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Colours
	{
		get
		{
			return this._Colours;
		}
		set
		{
			if ((this._Colours != value))
			{
				this.OnColoursChanging(value);
				this.SendPropertyChanging();
				this._Colours = value;
				this.SendPropertyChanged("Colours");
				this.OnColoursChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Display_Connectors", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Display_Connectors
	{
		get
		{
			return this._Display_Connectors;
		}
		set
		{
			if ((this._Display_Connectors != value))
			{
				this.OnDisplay_ConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Display_Connectors = value;
				this.SendPropertyChanged("Display_Connectors");
				this.OnDisplay_ConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speakers", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Speakers
	{
		get
		{
			return this._Speakers;
		}
		set
		{
			if ((this._Speakers != value))
			{
				this.OnSpeakersChanging(value);
				this.SendPropertyChanging();
				this._Speakers = value;
				this.SendPropertyChanged("Speakers");
				this.OnSpeakersChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Swivel", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Swivel
	{
		get
		{
			return this._Swivel;
		}
		set
		{
			if ((this._Swivel != value))
			{
				this.OnSwivelChanging(value);
				this.SendPropertyChanging();
				this._Swivel = value;
				this.SendPropertyChanged("Swivel");
				this.OnSwivelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tilt", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tilt
	{
		get
		{
			return this._Tilt;
		}
		set
		{
			if ((this._Tilt != value))
			{
				this.OnTiltChanging(value);
				this.SendPropertyChanging();
				this._Tilt = value;
				this.SendPropertyChanged("Tilt");
				this.OnTiltChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Pivot]", Storage="_Pivot", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Pivot
	{
		get
		{
			return this._Pivot;
		}
		set
		{
			if ((this._Pivot != value))
			{
				this.OnPivotChanging(value);
				this.SendPropertyChanging();
				this._Pivot = value;
				this.SendPropertyChanged("Pivot");
				this.OnPivotChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Monitor_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Monitor_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Monitor1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Monitor1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Monitor1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Monitor1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Monitor1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Monitor1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Monitor1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Monitor1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Monitor1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Monitor1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Motherboard")]
public partial class Motherboard1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Chipset;
	
	private string _Memory_Type;
	
	private int _Max_Memory_Size;
	
	private int _Max_Memory_Speed;
	
	private string _LAN;
	
	private string _Expansion_Slots;
	
	private string _Storage;
	
	private string _Internal_I_O_Connectors;
	
	private string _Back_Panel_Connectors;
	
	private string _OS_Support;
	
	private string _Form_Factor;
	
	private string _Notes;
	
	private string _Warranty;
	
	private EntitySet<MoboToCase> _MoboToCases;
	
	private EntitySet<MoboToCase1> _MoboToCase1s;
	
	private EntitySet<MoboToCpu> _MoboToCpus;
	
	private EntitySet<MoboToCpu1> _MoboToCpu1s;
	
	private EntitySet<MoboToRam> _MoboToRams;
	
	private EntitySet<MoboToRam1> _MoboToRam1s;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnChipsetChanging(string value);
    partial void OnChipsetChanged();
    partial void OnMemory_TypeChanging(string value);
    partial void OnMemory_TypeChanged();
    partial void OnMax_Memory_SizeChanging(int value);
    partial void OnMax_Memory_SizeChanged();
    partial void OnMax_Memory_SpeedChanging(int value);
    partial void OnMax_Memory_SpeedChanged();
    partial void OnLANChanging(string value);
    partial void OnLANChanged();
    partial void OnExpansion_SlotsChanging(string value);
    partial void OnExpansion_SlotsChanged();
    partial void OnStorageChanging(string value);
    partial void OnStorageChanged();
    partial void OnInternal_I_O_ConnectorsChanging(string value);
    partial void OnInternal_I_O_ConnectorsChanged();
    partial void OnBack_Panel_ConnectorsChanging(string value);
    partial void OnBack_Panel_ConnectorsChanged();
    partial void OnOS_SupportChanging(string value);
    partial void OnOS_SupportChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Motherboard1()
	{
		this._MoboToCases = new EntitySet<MoboToCase>(new Action<MoboToCase>(this.attach_MoboToCases), new Action<MoboToCase>(this.detach_MoboToCases));
		this._MoboToCase1s = new EntitySet<MoboToCase1>(new Action<MoboToCase1>(this.attach_MoboToCase1s), new Action<MoboToCase1>(this.detach_MoboToCase1s));
		this._MoboToCpus = new EntitySet<MoboToCpu>(new Action<MoboToCpu>(this.attach_MoboToCpus), new Action<MoboToCpu>(this.detach_MoboToCpus));
		this._MoboToCpu1s = new EntitySet<MoboToCpu1>(new Action<MoboToCpu1>(this.attach_MoboToCpu1s), new Action<MoboToCpu1>(this.detach_MoboToCpu1s));
		this._MoboToRams = new EntitySet<MoboToRam>(new Action<MoboToRam>(this.attach_MoboToRams), new Action<MoboToRam>(this.detach_MoboToRams));
		this._MoboToRam1s = new EntitySet<MoboToRam1>(new Action<MoboToRam1>(this.attach_MoboToRam1s), new Action<MoboToRam1>(this.detach_MoboToRam1s));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chipset", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Chipset
	{
		get
		{
			return this._Chipset;
		}
		set
		{
			if ((this._Chipset != value))
			{
				this.OnChipsetChanging(value);
				this.SendPropertyChanging();
				this._Chipset = value;
				this.SendPropertyChanged("Chipset");
				this.OnChipsetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memory_Type", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Memory_Type
	{
		get
		{
			return this._Memory_Type;
		}
		set
		{
			if ((this._Memory_Type != value))
			{
				this.OnMemory_TypeChanging(value);
				this.SendPropertyChanging();
				this._Memory_Type = value;
				this.SendPropertyChanged("Memory_Type");
				this.OnMemory_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Memory_Size", DbType="Int NOT NULL")]
	public int Max_Memory_Size
	{
		get
		{
			return this._Max_Memory_Size;
		}
		set
		{
			if ((this._Max_Memory_Size != value))
			{
				this.OnMax_Memory_SizeChanging(value);
				this.SendPropertyChanging();
				this._Max_Memory_Size = value;
				this.SendPropertyChanged("Max_Memory_Size");
				this.OnMax_Memory_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Memory_Speed", DbType="Int NOT NULL")]
	public int Max_Memory_Speed
	{
		get
		{
			return this._Max_Memory_Speed;
		}
		set
		{
			if ((this._Max_Memory_Speed != value))
			{
				this.OnMax_Memory_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Max_Memory_Speed = value;
				this.SendPropertyChanged("Max_Memory_Speed");
				this.OnMax_Memory_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LAN", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string LAN
	{
		get
		{
			return this._LAN;
		}
		set
		{
			if ((this._LAN != value))
			{
				this.OnLANChanging(value);
				this.SendPropertyChanging();
				this._LAN = value;
				this.SendPropertyChanged("LAN");
				this.OnLANChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expansion_Slots", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Expansion_Slots
	{
		get
		{
			return this._Expansion_Slots;
		}
		set
		{
			if ((this._Expansion_Slots != value))
			{
				this.OnExpansion_SlotsChanging(value);
				this.SendPropertyChanging();
				this._Expansion_Slots = value;
				this.SendPropertyChanged("Expansion_Slots");
				this.OnExpansion_SlotsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Storage", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Storage
	{
		get
		{
			return this._Storage;
		}
		set
		{
			if ((this._Storage != value))
			{
				this.OnStorageChanging(value);
				this.SendPropertyChanging();
				this._Storage = value;
				this.SendPropertyChanged("Storage");
				this.OnStorageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Internal_I/O_Connectors]", Storage="_Internal_I_O_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Internal_I_O_Connectors
	{
		get
		{
			return this._Internal_I_O_Connectors;
		}
		set
		{
			if ((this._Internal_I_O_Connectors != value))
			{
				this.OnInternal_I_O_ConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Internal_I_O_Connectors = value;
				this.SendPropertyChanged("Internal_I_O_Connectors");
				this.OnInternal_I_O_ConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Back_Panel_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Back_Panel_Connectors
	{
		get
		{
			return this._Back_Panel_Connectors;
		}
		set
		{
			if ((this._Back_Panel_Connectors != value))
			{
				this.OnBack_Panel_ConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Back_Panel_Connectors = value;
				this.SendPropertyChanged("Back_Panel_Connectors");
				this.OnBack_Panel_ConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Support", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Support
	{
		get
		{
			return this._OS_Support;
		}
		set
		{
			if ((this._OS_Support != value))
			{
				this.OnOS_SupportChanging(value);
				this.SendPropertyChanging();
				this._OS_Support = value;
				this.SendPropertyChanged("OS_Support");
				this.OnOS_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(MAX)")]
	public string Notes
	{
		get
		{
			return this._Notes;
		}
		set
		{
			if ((this._Notes != value))
			{
				this.OnNotesChanging(value);
				this.SendPropertyChanging();
				this._Notes = value;
				this.SendPropertyChanged("Notes");
				this.OnNotesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCase", Storage="_MoboToCases", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCase> MoboToCases
	{
		get
		{
			return this._MoboToCases;
		}
		set
		{
			this._MoboToCases.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCase1", Storage="_MoboToCase1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCase1> MoboToCase1s
	{
		get
		{
			return this._MoboToCase1s;
		}
		set
		{
			this._MoboToCase1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCpu", Storage="_MoboToCpus", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCpu> MoboToCpus
	{
		get
		{
			return this._MoboToCpus;
		}
		set
		{
			this._MoboToCpus.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToCpu1", Storage="_MoboToCpu1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToCpu1> MoboToCpu1s
	{
		get
		{
			return this._MoboToCpu1s;
		}
		set
		{
			this._MoboToCpu1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToRam", Storage="_MoboToRams", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToRam> MoboToRams
	{
		get
		{
			return this._MoboToRams;
		}
		set
		{
			this._MoboToRams.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_MoboToRam1", Storage="_MoboToRam1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<MoboToRam1> MoboToRam1s
	{
		get
		{
			return this._MoboToRam1s;
		}
		set
		{
			this._MoboToRam1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Mobo_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Motherboard1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Motherboard1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Motherboard1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Motherboard1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Motherboard1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Motherboard1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToCpus(MoboToCpu entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToCpu1s(MoboToCpu1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Motherboard1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mouse")]
public partial class Mouse1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Sensor;
	
	private string _Resolution;
	
	private string _Max_Acceleration;
	
	private string _Max_Speed;
	
	private string _Connection_Type;
	
	private string _Durability;
	
	private string _PTFE_Feet;
	
	private string _Battery;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Cable_Length;
	
	private string _OS_Support;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnSensorChanging(string value);
    partial void OnSensorChanged();
    partial void OnResolutionChanging(string value);
    partial void OnResolutionChanged();
    partial void OnMax_AccelerationChanging(string value);
    partial void OnMax_AccelerationChanged();
    partial void OnMax_SpeedChanging(string value);
    partial void OnMax_SpeedChanged();
    partial void OnConnection_TypeChanging(string value);
    partial void OnConnection_TypeChanged();
    partial void OnDurabilityChanging(string value);
    partial void OnDurabilityChanged();
    partial void OnPTFE_FeetChanging(string value);
    partial void OnPTFE_FeetChanged();
    partial void OnBatteryChanging(string value);
    partial void OnBatteryChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnCable_LengthChanging(string value);
    partial void OnCable_LengthChanged();
    partial void OnOS_SupportChanging(string value);
    partial void OnOS_SupportChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Mouse1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sensor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Sensor
	{
		get
		{
			return this._Sensor;
		}
		set
		{
			if ((this._Sensor != value))
			{
				this.OnSensorChanging(value);
				this.SendPropertyChanging();
				this._Sensor = value;
				this.SendPropertyChanged("Sensor");
				this.OnSensorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolution", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Resolution
	{
		get
		{
			return this._Resolution;
		}
		set
		{
			if ((this._Resolution != value))
			{
				this.OnResolutionChanging(value);
				this.SendPropertyChanging();
				this._Resolution = value;
				this.SendPropertyChanged("Resolution");
				this.OnResolutionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Acceleration", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Acceleration
	{
		get
		{
			return this._Max_Acceleration;
		}
		set
		{
			if ((this._Max_Acceleration != value))
			{
				this.OnMax_AccelerationChanging(value);
				this.SendPropertyChanging();
				this._Max_Acceleration = value;
				this.SendPropertyChanged("Max_Acceleration");
				this.OnMax_AccelerationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Speed
	{
		get
		{
			return this._Max_Speed;
		}
		set
		{
			if ((this._Max_Speed != value))
			{
				this.OnMax_SpeedChanging(value);
				this.SendPropertyChanging();
				this._Max_Speed = value;
				this.SendPropertyChanged("Max_Speed");
				this.OnMax_SpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connection_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Connection_Type
	{
		get
		{
			return this._Connection_Type;
		}
		set
		{
			if ((this._Connection_Type != value))
			{
				this.OnConnection_TypeChanging(value);
				this.SendPropertyChanging();
				this._Connection_Type = value;
				this.SendPropertyChanged("Connection_Type");
				this.OnConnection_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Durability", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Durability
	{
		get
		{
			return this._Durability;
		}
		set
		{
			if ((this._Durability != value))
			{
				this.OnDurabilityChanging(value);
				this.SendPropertyChanging();
				this._Durability = value;
				this.SendPropertyChanged("Durability");
				this.OnDurabilityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PTFE_Feet", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PTFE_Feet
	{
		get
		{
			return this._PTFE_Feet;
		}
		set
		{
			if ((this._PTFE_Feet != value))
			{
				this.OnPTFE_FeetChanging(value);
				this.SendPropertyChanging();
				this._PTFE_Feet = value;
				this.SendPropertyChanged("PTFE_Feet");
				this.OnPTFE_FeetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Battery", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Battery
	{
		get
		{
			return this._Battery;
		}
		set
		{
			if ((this._Battery != value))
			{
				this.OnBatteryChanging(value);
				this.SendPropertyChanging();
				this._Battery = value;
				this.SendPropertyChanged("Battery");
				this.OnBatteryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cable_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Cable_Length
	{
		get
		{
			return this._Cable_Length;
		}
		set
		{
			if ((this._Cable_Length != value))
			{
				this.OnCable_LengthChanging(value);
				this.SendPropertyChanging();
				this._Cable_Length = value;
				this.SendPropertyChanged("Cable_Length");
				this.OnCable_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Support
	{
		get
		{
			return this._OS_Support;
		}
		set
		{
			if ((this._OS_Support != value))
			{
				this.OnOS_SupportChanging(value);
				this.SendPropertyChanging();
				this._OS_Support = value;
				this.SendPropertyChanged("OS_Support");
				this.OnOS_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Mouse_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Mouse_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Mouse1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Mouse1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Mouse1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Mouse1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Mouse1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Mouse1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Mouse1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Mouse1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Mouse1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Mouse1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MousePad")]
public partial class MousePad1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Colour;
	
	private string _Size;
	
	private string _Materials;
	
	private string _Base;
	
	private string _Dimensions;
	
	private string _Weight;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnMaterialsChanging(string value);
    partial void OnMaterialsChanged();
    partial void OnBaseChanging(string value);
    partial void OnBaseChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWeightChanging(string value);
    partial void OnWeightChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public MousePad1()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materials", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Materials
	{
		get
		{
			return this._Materials;
		}
		set
		{
			if ((this._Materials != value))
			{
				this.OnMaterialsChanging(value);
				this.SendPropertyChanging();
				this._Materials = value;
				this.SendPropertyChanged("Materials");
				this.OnMaterialsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Base", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Base
	{
		get
		{
			return this._Base;
		}
		set
		{
			if ((this._Base != value))
			{
				this.OnBaseChanging(value);
				this.SendPropertyChanging();
				this._Base = value;
				this.SendPropertyChanged("Base");
				this.OnBaseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_MousePad1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.MousePad1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.MousePad1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_MousePad1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.MousePad1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.MousePad1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OperatingSystem")]
public partial class OperatingSystem1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Bit_Version;
	
	private string _OS_Version;
	
	private string _System_Requirements;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnBit_VersionChanging(string value);
    partial void OnBit_VersionChanged();
    partial void OnOS_VersionChanging(string value);
    partial void OnOS_VersionChanged();
    partial void OnSystem_RequirementsChanging(string value);
    partial void OnSystem_RequirementsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public OperatingSystem1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bit_Version", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Bit_Version
	{
		get
		{
			return this._Bit_Version;
		}
		set
		{
			if ((this._Bit_Version != value))
			{
				this.OnBit_VersionChanging(value);
				this.SendPropertyChanging();
				this._Bit_Version = value;
				this.SendPropertyChanged("Bit_Version");
				this.OnBit_VersionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_Version", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string OS_Version
	{
		get
		{
			return this._OS_Version;
		}
		set
		{
			if ((this._OS_Version != value))
			{
				this.OnOS_VersionChanging(value);
				this.SendPropertyChanging();
				this._OS_Version = value;
				this.SendPropertyChanged("OS_Version");
				this.OnOS_VersionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Requirements", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string System_Requirements
	{
		get
		{
			return this._System_Requirements;
		}
		set
		{
			if ((this._System_Requirements != value))
			{
				this.OnSystem_RequirementsChanging(value);
				this.SendPropertyChanging();
				this._System_Requirements = value;
				this.SendPropertyChanged("System_Requirements");
				this.OnSystem_RequirementsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="OS_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="OS_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_OperatingSystem1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.OperatingSystem1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.OperatingSystem1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_OperatingSystem1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.OperatingSystem1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.OperatingSystem1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.OperatingSystem1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartCart")]
public partial class PartCart1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Part_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPart_IDChanging(int value);
    partial void OnPart_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PartCart1()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Part_ID
	{
		get
		{
			return this._Part_ID;
		}
		set
		{
			if ((this._Part_ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPart_IDChanging(value);
				this.SendPropertyChanging();
				this._Part_ID = value;
				this.SendPropertyChanged("Part_ID");
				this.OnPart_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartCart1", Storage="_PartsStock", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartCart1s.Remove(this);
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartCart1s.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartCart1", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PartCart1s.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PartCart1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartCart1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PartCart1s.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PartCart1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartCart1", Storage="_PartsStock1", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartCart1s.Remove(this);
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartCart1s.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartInvoice")]
public partial class PartInvoice1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Part_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPart_IDChanging(int value);
    partial void OnPart_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PartInvoice1()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Part_ID
	{
		get
		{
			return this._Part_ID;
		}
		set
		{
			if ((this._Part_ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPart_IDChanging(value);
				this.SendPropertyChanging();
				this._Part_ID = value;
				this.SendPropertyChanged("Part_ID");
				this.OnPart_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartInvoice1", Storage="_PartsStock", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartInvoice1s.Remove(this);
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartInvoice1s.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PartInvoice1", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PartInvoice1s.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PartInvoice1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PartInvoice1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PartInvoice1s.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PartInvoice1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartInvoice1", Storage="_PartsStock1", ThisKey="Part_ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartInvoice1s.Remove(this);
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartInvoice1s.Add(this);
					this._Part_ID = value.ID;
				}
				else
				{
					this._Part_ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartsSold")]
public partial class PartsSold1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Type;
	
	private int _Quantity_Sold;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantity_SoldChanging(int value);
    partial void OnQuantity_SoldChanged();
    #endregion
	
	public PartsSold1()
	{
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Sold", DbType="Int NOT NULL")]
	public int Quantity_Sold
	{
		get
		{
			return this._Quantity_Sold;
		}
		set
		{
			if ((this._Quantity_Sold != value))
			{
				this.OnQuantity_SoldChanging(value);
				this.SendPropertyChanging();
				this._Quantity_Sold = value;
				this.SendPropertyChanged("Quantity_Sold");
				this.OnQuantity_SoldChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PartsSold1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PartsSold1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PartsSold1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartsSold1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PartsSold1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PartsSold1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PartsStock")]
public partial class PartsStock1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Type;
	
	private int _Quantity;
	
	private decimal _Price;
	
	private string _Image;
	
	private int _Active;
	
	private int _Discount;
	
	private EntityRef<AirCooler> _AirCooler;
	
	private EntityRef<AirCooler1> _AirCooler1;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Fan> _Fan;
	
	private EntityRef<Fan1> _Fan1;
	
	private EntityRef<GPU> _GPU;
	
	private EntityRef<GPU1> _GPU1;
	
	private EntityRef<HDD> _HDD;
	
	private EntityRef<HDD1> _HDD1;
	
	private EntityRef<Headset> _Headset;
	
	private EntityRef<Headset1> _Headset1;
	
	private EntityRef<Keyboard> _Keyboard;
	
	private EntityRef<Keyboard1> _Keyboard1;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
	private EntityRef<Microphone> _Microphone;
	
	private EntityRef<Microphone1> _Microphone1;
	
	private EntityRef<Monitor> _Monitor;
	
	private EntityRef<Monitor1> _Monitor1;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<Mouse> _Mouse;
	
	private EntityRef<Mouse1> _Mouse1;
	
	private EntityRef<MousePad> _MousePad;
	
	private EntityRef<MousePad1> _MousePad1;
	
	private EntityRef<OperatingSystem> _OperatingSystem;
	
	private EntityRef<OperatingSystem1> _OperatingSystem1;
	
	private EntityRef<PartsSold> _PartsSold;
	
	private EntityRef<PartsSold1> _PartsSold1;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<PSU> _PSU;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Speaker> _Speaker;
	
	private EntityRef<SSD> _SSD;
	
	private EntitySet<PartInvoice> _PartInvoices;
	
	private EntitySet<PartInvoice1> _PartInvoice1s;
	
	private EntitySet<PartCart> _PartCarts;
	
	private EntitySet<PartCart1> _PartCart1s;
	
	private EntityRef<PCCase1> _PCCase1;
	
	private EntityRef<PSU1> _PSU1;
	
	private EntityRef<RAM1> _RAM1;
	
	private EntityRef<Speaker1> _Speaker1;
	
	private EntityRef<SSD1> _SSD1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    partial void OnDiscountChanging(int value);
    partial void OnDiscountChanged();
    #endregion
	
	public PartsStock1()
	{
		this._AirCooler = default(EntityRef<AirCooler>);
		this._AirCooler1 = default(EntityRef<AirCooler1>);
		this._CPU = default(EntityRef<CPU>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Fan = default(EntityRef<Fan>);
		this._Fan1 = default(EntityRef<Fan1>);
		this._GPU = default(EntityRef<GPU>);
		this._GPU1 = default(EntityRef<GPU1>);
		this._HDD = default(EntityRef<HDD>);
		this._HDD1 = default(EntityRef<HDD1>);
		this._Headset = default(EntityRef<Headset>);
		this._Headset1 = default(EntityRef<Headset1>);
		this._Keyboard = default(EntityRef<Keyboard>);
		this._Keyboard1 = default(EntityRef<Keyboard1>);
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		this._Microphone = default(EntityRef<Microphone>);
		this._Microphone1 = default(EntityRef<Microphone1>);
		this._Monitor = default(EntityRef<Monitor>);
		this._Monitor1 = default(EntityRef<Monitor1>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._Mouse = default(EntityRef<Mouse>);
		this._Mouse1 = default(EntityRef<Mouse1>);
		this._MousePad = default(EntityRef<MousePad>);
		this._MousePad1 = default(EntityRef<MousePad1>);
		this._OperatingSystem = default(EntityRef<OperatingSystem>);
		this._OperatingSystem1 = default(EntityRef<OperatingSystem1>);
		this._PartsSold = default(EntityRef<PartsSold>);
		this._PartsSold1 = default(EntityRef<PartsSold1>);
		this._PCCase = default(EntityRef<PCCase>);
		this._PSU = default(EntityRef<PSU>);
		this._RAM = default(EntityRef<RAM>);
		this._Speaker = default(EntityRef<Speaker>);
		this._SSD = default(EntityRef<SSD>);
		this._PartInvoices = new EntitySet<PartInvoice>(new Action<PartInvoice>(this.attach_PartInvoices), new Action<PartInvoice>(this.detach_PartInvoices));
		this._PartInvoice1s = new EntitySet<PartInvoice1>(new Action<PartInvoice1>(this.attach_PartInvoice1s), new Action<PartInvoice1>(this.detach_PartInvoice1s));
		this._PartCarts = new EntitySet<PartCart>(new Action<PartCart>(this.attach_PartCarts), new Action<PartCart>(this.detach_PartCarts));
		this._PartCart1s = new EntitySet<PartCart1>(new Action<PartCart1>(this.attach_PartCart1s), new Action<PartCart1>(this.detach_PartCart1s));
		this._PCCase1 = default(EntityRef<PCCase1>);
		this._PSU1 = default(EntityRef<PSU1>);
		this._RAM1 = default(EntityRef<RAM1>);
		this._Speaker1 = default(EntityRef<Speaker1>);
		this._SSD1 = default(EntityRef<SSD1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
	public int Active
	{
		get
		{
			return this._Active;
		}
		set
		{
			if ((this._Active != value))
			{
				this.OnActiveChanging(value);
				this.SendPropertyChanging();
				this._Active = value;
				this.SendPropertyChanged("Active");
				this.OnActiveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int NOT NULL")]
	public int Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_AirCooler", Storage="_AirCooler", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public AirCooler AirCooler
	{
		get
		{
			return this._AirCooler.Entity;
		}
		set
		{
			AirCooler previousValue = this._AirCooler.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._AirCooler.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("AirCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_AirCooler1", Storage="_AirCooler1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public AirCooler1 AirCooler1
	{
		get
		{
			return this._AirCooler1.Entity;
		}
		set
		{
			AirCooler1 previousValue = this._AirCooler1.Entity;
			if (((previousValue != value) 
						|| (this._AirCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._AirCooler1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._AirCooler1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("AirCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_CPU", Storage="_CPU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_CPU1", Storage="_CPU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Fan", Storage="_Fan", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Fan Fan
	{
		get
		{
			return this._Fan.Entity;
		}
		set
		{
			Fan previousValue = this._Fan.Entity;
			if (((previousValue != value) 
						|| (this._Fan.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Fan.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Fan");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Fan1", Storage="_Fan1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Fan1 Fan1
	{
		get
		{
			return this._Fan1.Entity;
		}
		set
		{
			Fan1 previousValue = this._Fan1.Entity;
			if (((previousValue != value) 
						|| (this._Fan1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Fan1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Fan1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_GPU", Storage="_GPU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public GPU GPU
	{
		get
		{
			return this._GPU.Entity;
		}
		set
		{
			GPU previousValue = this._GPU.Entity;
			if (((previousValue != value) 
						|| (this._GPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._GPU.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("GPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_GPU1", Storage="_GPU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public GPU1 GPU1
	{
		get
		{
			return this._GPU1.Entity;
		}
		set
		{
			GPU1 previousValue = this._GPU1.Entity;
			if (((previousValue != value) 
						|| (this._GPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._GPU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("GPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_HDD", Storage="_HDD", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public HDD HDD
	{
		get
		{
			return this._HDD.Entity;
		}
		set
		{
			HDD previousValue = this._HDD.Entity;
			if (((previousValue != value) 
						|| (this._HDD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._HDD.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("HDD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_HDD1", Storage="_HDD1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public HDD1 HDD1
	{
		get
		{
			return this._HDD1.Entity;
		}
		set
		{
			HDD1 previousValue = this._HDD1.Entity;
			if (((previousValue != value) 
						|| (this._HDD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._HDD1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("HDD1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Headset", Storage="_Headset", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Headset Headset
	{
		get
		{
			return this._Headset.Entity;
		}
		set
		{
			Headset previousValue = this._Headset.Entity;
			if (((previousValue != value) 
						|| (this._Headset.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Headset.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Headset");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Headset1", Storage="_Headset1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Headset1 Headset1
	{
		get
		{
			return this._Headset1.Entity;
		}
		set
		{
			Headset1 previousValue = this._Headset1.Entity;
			if (((previousValue != value) 
						|| (this._Headset1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Headset1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Headset1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Keyboard", Storage="_Keyboard", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Keyboard Keyboard
	{
		get
		{
			return this._Keyboard.Entity;
		}
		set
		{
			Keyboard previousValue = this._Keyboard.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Keyboard.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Keyboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Keyboard1", Storage="_Keyboard1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Keyboard1 Keyboard1
	{
		get
		{
			return this._Keyboard1.Entity;
		}
		set
		{
			Keyboard1 previousValue = this._Keyboard1.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Keyboard1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Keyboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_LiquidCooler", Storage="_LiquidCooler", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_LiquidCooler1", Storage="_LiquidCooler1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Microphone", Storage="_Microphone", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Microphone Microphone
	{
		get
		{
			return this._Microphone.Entity;
		}
		set
		{
			Microphone previousValue = this._Microphone.Entity;
			if (((previousValue != value) 
						|| (this._Microphone.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Microphone.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Microphone.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Microphone");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Microphone1", Storage="_Microphone1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Microphone1 Microphone1
	{
		get
		{
			return this._Microphone1.Entity;
		}
		set
		{
			Microphone1 previousValue = this._Microphone1.Entity;
			if (((previousValue != value) 
						|| (this._Microphone1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Microphone1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Microphone1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Microphone1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Monitor", Storage="_Monitor", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Monitor Monitor
	{
		get
		{
			return this._Monitor.Entity;
		}
		set
		{
			Monitor previousValue = this._Monitor.Entity;
			if (((previousValue != value) 
						|| (this._Monitor.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Monitor.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Monitor");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Monitor1", Storage="_Monitor1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Monitor1 Monitor1
	{
		get
		{
			return this._Monitor1.Entity;
		}
		set
		{
			Monitor1 previousValue = this._Monitor1.Entity;
			if (((previousValue != value) 
						|| (this._Monitor1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Monitor1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Monitor1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Motherboard", Storage="_Motherboard", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Motherboard1", Storage="_Motherboard1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Mouse", Storage="_Mouse", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Mouse Mouse
	{
		get
		{
			return this._Mouse.Entity;
		}
		set
		{
			Mouse previousValue = this._Mouse.Entity;
			if (((previousValue != value) 
						|| (this._Mouse.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Mouse.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Mouse");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Mouse1", Storage="_Mouse1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Mouse1 Mouse1
	{
		get
		{
			return this._Mouse1.Entity;
		}
		set
		{
			Mouse1 previousValue = this._Mouse1.Entity;
			if (((previousValue != value) 
						|| (this._Mouse1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Mouse1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Mouse1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_MousePad", Storage="_MousePad", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public MousePad MousePad
	{
		get
		{
			return this._MousePad.Entity;
		}
		set
		{
			MousePad previousValue = this._MousePad.Entity;
			if (((previousValue != value) 
						|| (this._MousePad.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._MousePad.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._MousePad.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("MousePad");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_MousePad1", Storage="_MousePad1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public MousePad1 MousePad1
	{
		get
		{
			return this._MousePad1.Entity;
		}
		set
		{
			MousePad1 previousValue = this._MousePad1.Entity;
			if (((previousValue != value) 
						|| (this._MousePad1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._MousePad1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._MousePad1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("MousePad1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_OperatingSystem", Storage="_OperatingSystem", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public OperatingSystem OperatingSystem
	{
		get
		{
			return this._OperatingSystem.Entity;
		}
		set
		{
			OperatingSystem previousValue = this._OperatingSystem.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._OperatingSystem.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("OperatingSystem");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_OperatingSystem1", Storage="_OperatingSystem1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public OperatingSystem1 OperatingSystem1
	{
		get
		{
			return this._OperatingSystem1.Entity;
		}
		set
		{
			OperatingSystem1 previousValue = this._OperatingSystem1.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._OperatingSystem1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("OperatingSystem1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartsSold", Storage="_PartsSold", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PartsSold PartsSold
	{
		get
		{
			return this._PartsSold.Entity;
		}
		set
		{
			PartsSold previousValue = this._PartsSold.Entity;
			if (((previousValue != value) 
						|| (this._PartsSold.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsSold.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PartsSold.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PartsSold");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartsSold1", Storage="_PartsSold1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PartsSold1 PartsSold1
	{
		get
		{
			return this._PartsSold1.Entity;
		}
		set
		{
			PartsSold1 previousValue = this._PartsSold1.Entity;
			if (((previousValue != value) 
						|| (this._PartsSold1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsSold1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PartsSold1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PartsSold1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PCCase", Storage="_PCCase", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PSU", Storage="_PSU", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PSU PSU
	{
		get
		{
			return this._PSU.Entity;
		}
		set
		{
			PSU previousValue = this._PSU.Entity;
			if (((previousValue != value) 
						|| (this._PSU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PSU.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PSU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_RAM", Storage="_RAM", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Speaker", Storage="_Speaker", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Speaker Speaker
	{
		get
		{
			return this._Speaker.Entity;
		}
		set
		{
			Speaker previousValue = this._Speaker.Entity;
			if (((previousValue != value) 
						|| (this._Speaker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Speaker.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Speaker");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_SSD", Storage="_SSD", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public SSD SSD
	{
		get
		{
			return this._SSD.Entity;
		}
		set
		{
			SSD previousValue = this._SSD.Entity;
			if (((previousValue != value) 
						|| (this._SSD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._SSD.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("SSD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartInvoice", Storage="_PartInvoices", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartInvoice> PartInvoices
	{
		get
		{
			return this._PartInvoices;
		}
		set
		{
			this._PartInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartInvoice1", Storage="_PartInvoice1s", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartInvoice1> PartInvoice1s
	{
		get
		{
			return this._PartInvoice1s;
		}
		set
		{
			this._PartInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartCart", Storage="_PartCarts", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartCart> PartCarts
	{
		get
		{
			return this._PartCarts;
		}
		set
		{
			this._PartCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PartCart1", Storage="_PartCart1s", ThisKey="ID", OtherKey="Part_ID")]
	public EntitySet<PartCart1> PartCart1s
	{
		get
		{
			return this._PartCart1s;
		}
		set
		{
			this._PartCart1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PCCase1", Storage="_PCCase1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PSU1", Storage="_PSU1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public PSU1 PSU1
	{
		get
		{
			return this._PSU1.Entity;
		}
		set
		{
			PSU1 previousValue = this._PSU1.Entity;
			if (((previousValue != value) 
						|| (this._PSU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._PSU1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("PSU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_RAM1", Storage="_RAM1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Speaker1", Storage="_Speaker1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public Speaker1 Speaker1
	{
		get
		{
			return this._Speaker1.Entity;
		}
		set
		{
			Speaker1 previousValue = this._Speaker1.Entity;
			if (((previousValue != value) 
						|| (this._Speaker1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._Speaker1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("Speaker1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_SSD1", Storage="_SSD1", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
	public SSD1 SSD1
	{
		get
		{
			return this._SSD1.Entity;
		}
		set
		{
			SSD1 previousValue = this._SSD1.Entity;
			if (((previousValue != value) 
						|| (this._SSD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD1.Entity = null;
					previousValue.PartsStock1 = null;
				}
				this._SSD1.Entity = value;
				if ((value != null))
				{
					value.PartsStock1 = this;
				}
				this.SendPropertyChanged("SSD1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = this;
	}
	
	private void detach_PartInvoices(PartInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = null;
	}
	
	private void attach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = this;
	}
	
	private void detach_PartInvoice1s(PartInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = null;
	}
	
	private void attach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = this;
	}
	
	private void detach_PartCarts(PartCart entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = null;
	}
	
	private void attach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = this;
	}
	
	private void detach_PartCart1s(PartCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PartsStock1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pc")]
public partial class Pc1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PC_ID;
	
	private string _PC_Type;
	
	private int _Case_ID;
	
	private int _Mobo_ID;
	
	private int _CPU_ID;
	
	private int _RAM_ID;
	
	private int _GPU_ID;
	
	private int _Cooler_ID;
	
	private System.Nullable<int> _SSD_ID;
	
	private int _Fan_ID;
	
	private System.Nullable<int> _HDD_ID;
	
	private int _PSU_ID;
	
	private int _OS_ID;
	
	private int _Num_Fans;
	
	private int _Num_SSD;
	
	private int _Num_HDD;
	
	private System.Nullable<int> _Monitor_ID;
	
	private System.Nullable<int> _Headset_ID;
	
	private System.Nullable<int> _Keyboard_ID;
	
	private System.Nullable<int> _Mouse_ID;
	
	private System.Nullable<int> _Speaker_ID;
	
	private string _Warranty;
	
	private EntityRef<PCCase> _PCCase;
	
	private EntityRef<LiquidCooler> _LiquidCooler;
	
	private EntityRef<LiquidCooler1> _LiquidCooler1;
	
	private EntityRef<CPU> _CPU;
	
	private EntityRef<CPU1> _CPU1;
	
	private EntityRef<Fan> _Fan;
	
	private EntityRef<Fan1> _Fan1;
	
	private EntityRef<GPU> _GPU;
	
	private EntityRef<GPU1> _GPU1;
	
	private EntityRef<HDD> _HDD;
	
	private EntityRef<HDD1> _HDD1;
	
	private EntityRef<Headset> _Headset;
	
	private EntityRef<Headset1> _Headset1;
	
	private EntityRef<Keyboard> _Keyboard;
	
	private EntityRef<Keyboard1> _Keyboard1;
	
	private EntityRef<Motherboard> _Motherboard;
	
	private EntityRef<Motherboard1> _Motherboard1;
	
	private EntityRef<Monitor> _Monitor;
	
	private EntityRef<Monitor1> _Monitor1;
	
	private EntityRef<Mouse> _Mouse;
	
	private EntityRef<Mouse1> _Mouse1;
	
	private EntityRef<OperatingSystem> _OperatingSystem;
	
	private EntityRef<OperatingSystem1> _OperatingSystem1;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<PSU> _PSU;
	
	private EntityRef<RAM> _RAM;
	
	private EntityRef<Speaker> _Speaker;
	
	private EntityRef<SSD> _SSD;
	
	private EntityRef<PCCase1> _PCCase1;
	
	private EntityRef<PcStock1> _PcStock1;
	
	private EntityRef<PSU1> _PSU1;
	
	private EntityRef<RAM1> _RAM1;
	
	private EntityRef<Speaker1> _Speaker1;
	
	private EntityRef<SSD1> _SSD1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnPC_TypeChanging(string value);
    partial void OnPC_TypeChanged();
    partial void OnCase_IDChanging(int value);
    partial void OnCase_IDChanged();
    partial void OnMobo_IDChanging(int value);
    partial void OnMobo_IDChanged();
    partial void OnCPU_IDChanging(int value);
    partial void OnCPU_IDChanged();
    partial void OnRAM_IDChanging(int value);
    partial void OnRAM_IDChanged();
    partial void OnGPU_IDChanging(int value);
    partial void OnGPU_IDChanged();
    partial void OnCooler_IDChanging(int value);
    partial void OnCooler_IDChanged();
    partial void OnSSD_IDChanging(System.Nullable<int> value);
    partial void OnSSD_IDChanged();
    partial void OnFan_IDChanging(int value);
    partial void OnFan_IDChanged();
    partial void OnHDD_IDChanging(System.Nullable<int> value);
    partial void OnHDD_IDChanged();
    partial void OnPSU_IDChanging(int value);
    partial void OnPSU_IDChanged();
    partial void OnOS_IDChanging(int value);
    partial void OnOS_IDChanged();
    partial void OnNum_FansChanging(int value);
    partial void OnNum_FansChanged();
    partial void OnNum_SSDChanging(int value);
    partial void OnNum_SSDChanged();
    partial void OnNum_HDDChanging(int value);
    partial void OnNum_HDDChanged();
    partial void OnMonitor_IDChanging(System.Nullable<int> value);
    partial void OnMonitor_IDChanged();
    partial void OnHeadset_IDChanging(System.Nullable<int> value);
    partial void OnHeadset_IDChanged();
    partial void OnKeyboard_IDChanging(System.Nullable<int> value);
    partial void OnKeyboard_IDChanged();
    partial void OnMouse_IDChanging(System.Nullable<int> value);
    partial void OnMouse_IDChanged();
    partial void OnSpeaker_IDChanging(System.Nullable<int> value);
    partial void OnSpeaker_IDChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Pc1()
	{
		this._PCCase = default(EntityRef<PCCase>);
		this._LiquidCooler = default(EntityRef<LiquidCooler>);
		this._LiquidCooler1 = default(EntityRef<LiquidCooler1>);
		this._CPU = default(EntityRef<CPU>);
		this._CPU1 = default(EntityRef<CPU1>);
		this._Fan = default(EntityRef<Fan>);
		this._Fan1 = default(EntityRef<Fan1>);
		this._GPU = default(EntityRef<GPU>);
		this._GPU1 = default(EntityRef<GPU1>);
		this._HDD = default(EntityRef<HDD>);
		this._HDD1 = default(EntityRef<HDD1>);
		this._Headset = default(EntityRef<Headset>);
		this._Headset1 = default(EntityRef<Headset1>);
		this._Keyboard = default(EntityRef<Keyboard>);
		this._Keyboard1 = default(EntityRef<Keyboard1>);
		this._Motherboard = default(EntityRef<Motherboard>);
		this._Motherboard1 = default(EntityRef<Motherboard1>);
		this._Monitor = default(EntityRef<Monitor>);
		this._Monitor1 = default(EntityRef<Monitor1>);
		this._Mouse = default(EntityRef<Mouse>);
		this._Mouse1 = default(EntityRef<Mouse1>);
		this._OperatingSystem = default(EntityRef<OperatingSystem>);
		this._OperatingSystem1 = default(EntityRef<OperatingSystem1>);
		this._PcStock = default(EntityRef<PcStock>);
		this._PSU = default(EntityRef<PSU>);
		this._RAM = default(EntityRef<RAM>);
		this._Speaker = default(EntityRef<Speaker>);
		this._SSD = default(EntityRef<SSD>);
		this._PCCase1 = default(EntityRef<PCCase1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		this._PSU1 = default(EntityRef<PSU1>);
		this._RAM1 = default(EntityRef<RAM1>);
		this._Speaker1 = default(EntityRef<Speaker1>);
		this._SSD1 = default(EntityRef<SSD1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PC_Type
	{
		get
		{
			return this._PC_Type;
		}
		set
		{
			if ((this._PC_Type != value))
			{
				this.OnPC_TypeChanging(value);
				this.SendPropertyChanging();
				this._PC_Type = value;
				this.SendPropertyChanged("PC_Type");
				this.OnPC_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Case_ID", DbType="Int NOT NULL")]
	public int Case_ID
	{
		get
		{
			return this._Case_ID;
		}
		set
		{
			if ((this._Case_ID != value))
			{
				if ((this._PCCase.HasLoadedOrAssignedValue || this._PCCase1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCase_IDChanging(value);
				this.SendPropertyChanging();
				this._Case_ID = value;
				this.SendPropertyChanged("Case_ID");
				this.OnCase_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobo_ID", DbType="Int NOT NULL")]
	public int Mobo_ID
	{
		get
		{
			return this._Mobo_ID;
		}
		set
		{
			if ((this._Mobo_ID != value))
			{
				if ((this._Motherboard.HasLoadedOrAssignedValue || this._Motherboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMobo_IDChanging(value);
				this.SendPropertyChanging();
				this._Mobo_ID = value;
				this.SendPropertyChanged("Mobo_ID");
				this.OnMobo_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_ID", DbType="Int NOT NULL")]
	public int CPU_ID
	{
		get
		{
			return this._CPU_ID;
		}
		set
		{
			if ((this._CPU_ID != value))
			{
				if ((this._CPU.HasLoadedOrAssignedValue || this._CPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCPU_IDChanging(value);
				this.SendPropertyChanging();
				this._CPU_ID = value;
				this.SendPropertyChanged("CPU_ID");
				this.OnCPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAM_ID", DbType="Int NOT NULL")]
	public int RAM_ID
	{
		get
		{
			return this._RAM_ID;
		}
		set
		{
			if ((this._RAM_ID != value))
			{
				if ((this._RAM.HasLoadedOrAssignedValue || this._RAM1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnRAM_IDChanging(value);
				this.SendPropertyChanging();
				this._RAM_ID = value;
				this.SendPropertyChanged("RAM_ID");
				this.OnRAM_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPU_ID", DbType="Int NOT NULL")]
	public int GPU_ID
	{
		get
		{
			return this._GPU_ID;
		}
		set
		{
			if ((this._GPU_ID != value))
			{
				if ((this._GPU.HasLoadedOrAssignedValue || this._GPU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnGPU_IDChanging(value);
				this.SendPropertyChanging();
				this._GPU_ID = value;
				this.SendPropertyChanged("GPU_ID");
				this.OnGPU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cooler_ID", DbType="Int NOT NULL")]
	public int Cooler_ID
	{
		get
		{
			return this._Cooler_ID;
		}
		set
		{
			if ((this._Cooler_ID != value))
			{
				if ((this._LiquidCooler.HasLoadedOrAssignedValue || this._LiquidCooler1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCooler_IDChanging(value);
				this.SendPropertyChanging();
				this._Cooler_ID = value;
				this.SendPropertyChanged("Cooler_ID");
				this.OnCooler_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSD_ID", DbType="Int")]
	public System.Nullable<int> SSD_ID
	{
		get
		{
			return this._SSD_ID;
		}
		set
		{
			if ((this._SSD_ID != value))
			{
				if ((this._SSD.HasLoadedOrAssignedValue || this._SSD1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSSD_IDChanging(value);
				this.SendPropertyChanging();
				this._SSD_ID = value;
				this.SendPropertyChanged("SSD_ID");
				this.OnSSD_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_ID", DbType="Int NOT NULL")]
	public int Fan_ID
	{
		get
		{
			return this._Fan_ID;
		}
		set
		{
			if ((this._Fan_ID != value))
			{
				if ((this._Fan.HasLoadedOrAssignedValue || this._Fan1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFan_IDChanging(value);
				this.SendPropertyChanging();
				this._Fan_ID = value;
				this.SendPropertyChanged("Fan_ID");
				this.OnFan_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HDD_ID", DbType="Int")]
	public System.Nullable<int> HDD_ID
	{
		get
		{
			return this._HDD_ID;
		}
		set
		{
			if ((this._HDD_ID != value))
			{
				if ((this._HDD.HasLoadedOrAssignedValue || this._HDD1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnHDD_IDChanging(value);
				this.SendPropertyChanging();
				this._HDD_ID = value;
				this.SendPropertyChanged("HDD_ID");
				this.OnHDD_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PSU_ID", DbType="Int NOT NULL")]
	public int PSU_ID
	{
		get
		{
			return this._PSU_ID;
		}
		set
		{
			if ((this._PSU_ID != value))
			{
				if ((this._PSU.HasLoadedOrAssignedValue || this._PSU1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPSU_IDChanging(value);
				this.SendPropertyChanging();
				this._PSU_ID = value;
				this.SendPropertyChanged("PSU_ID");
				this.OnPSU_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OS_ID", DbType="Int NOT NULL")]
	public int OS_ID
	{
		get
		{
			return this._OS_ID;
		}
		set
		{
			if ((this._OS_ID != value))
			{
				if ((this._OperatingSystem.HasLoadedOrAssignedValue || this._OperatingSystem1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOS_IDChanging(value);
				this.SendPropertyChanging();
				this._OS_ID = value;
				this.SendPropertyChanged("OS_ID");
				this.OnOS_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Fans", DbType="Int NOT NULL")]
	public int Num_Fans
	{
		get
		{
			return this._Num_Fans;
		}
		set
		{
			if ((this._Num_Fans != value))
			{
				this.OnNum_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Fans = value;
				this.SendPropertyChanged("Num_Fans");
				this.OnNum_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_SSD", DbType="Int NOT NULL")]
	public int Num_SSD
	{
		get
		{
			return this._Num_SSD;
		}
		set
		{
			if ((this._Num_SSD != value))
			{
				this.OnNum_SSDChanging(value);
				this.SendPropertyChanging();
				this._Num_SSD = value;
				this.SendPropertyChanged("Num_SSD");
				this.OnNum_SSDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_HDD", DbType="Int NOT NULL")]
	public int Num_HDD
	{
		get
		{
			return this._Num_HDD;
		}
		set
		{
			if ((this._Num_HDD != value))
			{
				this.OnNum_HDDChanging(value);
				this.SendPropertyChanging();
				this._Num_HDD = value;
				this.SendPropertyChanged("Num_HDD");
				this.OnNum_HDDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Monitor_ID", DbType="Int")]
	public System.Nullable<int> Monitor_ID
	{
		get
		{
			return this._Monitor_ID;
		}
		set
		{
			if ((this._Monitor_ID != value))
			{
				if ((this._Monitor.HasLoadedOrAssignedValue || this._Monitor1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMonitor_IDChanging(value);
				this.SendPropertyChanging();
				this._Monitor_ID = value;
				this.SendPropertyChanged("Monitor_ID");
				this.OnMonitor_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Headset_ID", DbType="Int")]
	public System.Nullable<int> Headset_ID
	{
		get
		{
			return this._Headset_ID;
		}
		set
		{
			if ((this._Headset_ID != value))
			{
				if ((this._Headset.HasLoadedOrAssignedValue || this._Headset1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnHeadset_IDChanging(value);
				this.SendPropertyChanging();
				this._Headset_ID = value;
				this.SendPropertyChanged("Headset_ID");
				this.OnHeadset_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keyboard_ID", DbType="Int")]
	public System.Nullable<int> Keyboard_ID
	{
		get
		{
			return this._Keyboard_ID;
		}
		set
		{
			if ((this._Keyboard_ID != value))
			{
				if ((this._Keyboard.HasLoadedOrAssignedValue || this._Keyboard1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnKeyboard_IDChanging(value);
				this.SendPropertyChanging();
				this._Keyboard_ID = value;
				this.SendPropertyChanged("Keyboard_ID");
				this.OnKeyboard_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mouse_ID", DbType="Int")]
	public System.Nullable<int> Mouse_ID
	{
		get
		{
			return this._Mouse_ID;
		}
		set
		{
			if ((this._Mouse_ID != value))
			{
				if ((this._Mouse.HasLoadedOrAssignedValue || this._Mouse1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnMouse_IDChanging(value);
				this.SendPropertyChanging();
				this._Mouse_ID = value;
				this.SendPropertyChanged("Mouse_ID");
				this.OnMouse_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speaker_ID", DbType="Int")]
	public System.Nullable<int> Speaker_ID
	{
		get
		{
			return this._Speaker_ID;
		}
		set
		{
			if ((this._Speaker_ID != value))
			{
				if ((this._Speaker.HasLoadedOrAssignedValue || this._Speaker1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSpeaker_IDChanging(value);
				this.SendPropertyChanging();
				this._Speaker_ID = value;
				this.SendPropertyChanged("Speaker_ID");
				this.OnSpeaker_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase_Pc1", Storage="_PCCase", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase PCCase
	{
		get
		{
			return this._PCCase.Entity;
		}
		set
		{
			PCCase previousValue = this._PCCase.Entity;
			if (((previousValue != value) 
						|| (this._PCCase.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._PCCase.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler_Pc1", Storage="_LiquidCooler", ThisKey="Cooler_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler LiquidCooler
	{
		get
		{
			return this._LiquidCooler.Entity;
		}
		set
		{
			LiquidCooler previousValue = this._LiquidCooler.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._LiquidCooler.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Cooler_ID = value.ID;
				}
				else
				{
					this._Cooler_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LiquidCooler1_Pc1", Storage="_LiquidCooler1", ThisKey="Cooler_ID", OtherKey="ID", IsForeignKey=true)]
	public LiquidCooler1 LiquidCooler1
	{
		get
		{
			return this._LiquidCooler1.Entity;
		}
		set
		{
			LiquidCooler1 previousValue = this._LiquidCooler1.Entity;
			if (((previousValue != value) 
						|| (this._LiquidCooler1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LiquidCooler1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._LiquidCooler1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Cooler_ID = value.ID;
				}
				else
				{
					this._Cooler_ID = default(int);
				}
				this.SendPropertyChanged("LiquidCooler1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU_Pc1", Storage="_CPU", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU CPU
	{
		get
		{
			return this._CPU.Entity;
		}
		set
		{
			CPU previousValue = this._CPU.Entity;
			if (((previousValue != value) 
						|| (this._CPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._CPU.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CPU1_Pc1", Storage="_CPU1", ThisKey="CPU_ID", OtherKey="ID", IsForeignKey=true)]
	public CPU1 CPU1
	{
		get
		{
			return this._CPU1.Entity;
		}
		set
		{
			CPU1 previousValue = this._CPU1.Entity;
			if (((previousValue != value) 
						|| (this._CPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CPU1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._CPU1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._CPU_ID = value.ID;
				}
				else
				{
					this._CPU_ID = default(int);
				}
				this.SendPropertyChanged("CPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan_Pc1", Storage="_Fan", ThisKey="Fan_ID", OtherKey="ID", IsForeignKey=true)]
	public Fan Fan
	{
		get
		{
			return this._Fan.Entity;
		}
		set
		{
			Fan previousValue = this._Fan.Entity;
			if (((previousValue != value) 
						|| (this._Fan.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Fan.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Fan_ID = value.ID;
				}
				else
				{
					this._Fan_ID = default(int);
				}
				this.SendPropertyChanged("Fan");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fan1_Pc1", Storage="_Fan1", ThisKey="Fan_ID", OtherKey="ID", IsForeignKey=true)]
	public Fan1 Fan1
	{
		get
		{
			return this._Fan1.Entity;
		}
		set
		{
			Fan1 previousValue = this._Fan1.Entity;
			if (((previousValue != value) 
						|| (this._Fan1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Fan1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Fan1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Fan_ID = value.ID;
				}
				else
				{
					this._Fan_ID = default(int);
				}
				this.SendPropertyChanged("Fan1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU_Pc1", Storage="_GPU", ThisKey="GPU_ID", OtherKey="ID", IsForeignKey=true)]
	public GPU GPU
	{
		get
		{
			return this._GPU.Entity;
		}
		set
		{
			GPU previousValue = this._GPU.Entity;
			if (((previousValue != value) 
						|| (this._GPU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._GPU.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._GPU_ID = value.ID;
				}
				else
				{
					this._GPU_ID = default(int);
				}
				this.SendPropertyChanged("GPU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GPU1_Pc1", Storage="_GPU1", ThisKey="GPU_ID", OtherKey="ID", IsForeignKey=true)]
	public GPU1 GPU1
	{
		get
		{
			return this._GPU1.Entity;
		}
		set
		{
			GPU1 previousValue = this._GPU1.Entity;
			if (((previousValue != value) 
						|| (this._GPU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._GPU1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._GPU1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._GPU_ID = value.ID;
				}
				else
				{
					this._GPU_ID = default(int);
				}
				this.SendPropertyChanged("GPU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD_Pc1", Storage="_HDD", ThisKey="HDD_ID", OtherKey="ID", IsForeignKey=true)]
	public HDD HDD
	{
		get
		{
			return this._HDD.Entity;
		}
		set
		{
			HDD previousValue = this._HDD.Entity;
			if (((previousValue != value) 
						|| (this._HDD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._HDD.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._HDD_ID = value.ID;
				}
				else
				{
					this._HDD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("HDD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HDD1_Pc1", Storage="_HDD1", ThisKey="HDD_ID", OtherKey="ID", IsForeignKey=true)]
	public HDD1 HDD1
	{
		get
		{
			return this._HDD1.Entity;
		}
		set
		{
			HDD1 previousValue = this._HDD1.Entity;
			if (((previousValue != value) 
						|| (this._HDD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._HDD1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._HDD1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._HDD_ID = value.ID;
				}
				else
				{
					this._HDD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("HDD1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset_Pc1", Storage="_Headset", ThisKey="Headset_ID", OtherKey="ID", IsForeignKey=true)]
	public Headset Headset
	{
		get
		{
			return this._Headset.Entity;
		}
		set
		{
			Headset previousValue = this._Headset.Entity;
			if (((previousValue != value) 
						|| (this._Headset.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Headset.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Headset_ID = value.ID;
				}
				else
				{
					this._Headset_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Headset");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headset1_Pc1", Storage="_Headset1", ThisKey="Headset_ID", OtherKey="ID", IsForeignKey=true)]
	public Headset1 Headset1
	{
		get
		{
			return this._Headset1.Entity;
		}
		set
		{
			Headset1 previousValue = this._Headset1.Entity;
			if (((previousValue != value) 
						|| (this._Headset1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Headset1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Headset1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Headset_ID = value.ID;
				}
				else
				{
					this._Headset_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Headset1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard_Pc1", Storage="_Keyboard", ThisKey="Keyboard_ID", OtherKey="ID", IsForeignKey=true)]
	public Keyboard Keyboard
	{
		get
		{
			return this._Keyboard.Entity;
		}
		set
		{
			Keyboard previousValue = this._Keyboard.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Keyboard.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Keyboard_ID = value.ID;
				}
				else
				{
					this._Keyboard_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Keyboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyboard1_Pc1", Storage="_Keyboard1", ThisKey="Keyboard_ID", OtherKey="ID", IsForeignKey=true)]
	public Keyboard1 Keyboard1
	{
		get
		{
			return this._Keyboard1.Entity;
		}
		set
		{
			Keyboard1 previousValue = this._Keyboard1.Entity;
			if (((previousValue != value) 
						|| (this._Keyboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Keyboard1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Keyboard1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Keyboard_ID = value.ID;
				}
				else
				{
					this._Keyboard_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Keyboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard_Pc1", Storage="_Motherboard", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard Motherboard
	{
		get
		{
			return this._Motherboard.Entity;
		}
		set
		{
			Motherboard previousValue = this._Motherboard.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Motherboard.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motherboard1_Pc1", Storage="_Motherboard1", ThisKey="Mobo_ID", OtherKey="ID", IsForeignKey=true)]
	public Motherboard1 Motherboard1
	{
		get
		{
			return this._Motherboard1.Entity;
		}
		set
		{
			Motherboard1 previousValue = this._Motherboard1.Entity;
			if (((previousValue != value) 
						|| (this._Motherboard1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Motherboard1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Motherboard1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Mobo_ID = value.ID;
				}
				else
				{
					this._Mobo_ID = default(int);
				}
				this.SendPropertyChanged("Motherboard1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor_Pc1", Storage="_Monitor", ThisKey="Monitor_ID", OtherKey="ID", IsForeignKey=true)]
	public Monitor Monitor
	{
		get
		{
			return this._Monitor.Entity;
		}
		set
		{
			Monitor previousValue = this._Monitor.Entity;
			if (((previousValue != value) 
						|| (this._Monitor.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Monitor.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Monitor_ID = value.ID;
				}
				else
				{
					this._Monitor_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Monitor");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Monitor1_Pc1", Storage="_Monitor1", ThisKey="Monitor_ID", OtherKey="ID", IsForeignKey=true)]
	public Monitor1 Monitor1
	{
		get
		{
			return this._Monitor1.Entity;
		}
		set
		{
			Monitor1 previousValue = this._Monitor1.Entity;
			if (((previousValue != value) 
						|| (this._Monitor1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Monitor1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Monitor1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Monitor_ID = value.ID;
				}
				else
				{
					this._Monitor_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Monitor1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse_Pc1", Storage="_Mouse", ThisKey="Mouse_ID", OtherKey="ID", IsForeignKey=true)]
	public Mouse Mouse
	{
		get
		{
			return this._Mouse.Entity;
		}
		set
		{
			Mouse previousValue = this._Mouse.Entity;
			if (((previousValue != value) 
						|| (this._Mouse.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Mouse.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Mouse_ID = value.ID;
				}
				else
				{
					this._Mouse_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Mouse");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mouse1_Pc1", Storage="_Mouse1", ThisKey="Mouse_ID", OtherKey="ID", IsForeignKey=true)]
	public Mouse1 Mouse1
	{
		get
		{
			return this._Mouse1.Entity;
		}
		set
		{
			Mouse1 previousValue = this._Mouse1.Entity;
			if (((previousValue != value) 
						|| (this._Mouse1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Mouse1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Mouse1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Mouse_ID = value.ID;
				}
				else
				{
					this._Mouse_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Mouse1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem_Pc1", Storage="_OperatingSystem", ThisKey="OS_ID", OtherKey="ID", IsForeignKey=true)]
	public OperatingSystem OperatingSystem
	{
		get
		{
			return this._OperatingSystem.Entity;
		}
		set
		{
			OperatingSystem previousValue = this._OperatingSystem.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._OperatingSystem.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._OS_ID = value.ID;
				}
				else
				{
					this._OS_ID = default(int);
				}
				this.SendPropertyChanged("OperatingSystem");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OperatingSystem1_Pc1", Storage="_OperatingSystem1", ThisKey="OS_ID", OtherKey="ID", IsForeignKey=true)]
	public OperatingSystem1 OperatingSystem1
	{
		get
		{
			return this._OperatingSystem1.Entity;
		}
		set
		{
			OperatingSystem1 previousValue = this._OperatingSystem1.Entity;
			if (((previousValue != value) 
						|| (this._OperatingSystem1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OperatingSystem1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._OperatingSystem1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._OS_ID = value.ID;
				}
				else
				{
					this._OS_ID = default(int);
				}
				this.SendPropertyChanged("OperatingSystem1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_Pc1", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.Pc1 = null;
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.Pc1 = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU_Pc1", Storage="_PSU", ThisKey="PSU_ID", OtherKey="ID", IsForeignKey=true)]
	public PSU PSU
	{
		get
		{
			return this._PSU.Entity;
		}
		set
		{
			PSU previousValue = this._PSU.Entity;
			if (((previousValue != value) 
						|| (this._PSU.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._PSU.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._PSU_ID = value.ID;
				}
				else
				{
					this._PSU_ID = default(int);
				}
				this.SendPropertyChanged("PSU");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM_Pc1", Storage="_RAM", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM RAM
	{
		get
		{
			return this._RAM.Entity;
		}
		set
		{
			RAM previousValue = this._RAM.Entity;
			if (((previousValue != value) 
						|| (this._RAM.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._RAM.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker_Pc1", Storage="_Speaker", ThisKey="Speaker_ID", OtherKey="ID", IsForeignKey=true)]
	public Speaker Speaker
	{
		get
		{
			return this._Speaker.Entity;
		}
		set
		{
			Speaker previousValue = this._Speaker.Entity;
			if (((previousValue != value) 
						|| (this._Speaker.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Speaker.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Speaker_ID = value.ID;
				}
				else
				{
					this._Speaker_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Speaker");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD_Pc1", Storage="_SSD", ThisKey="SSD_ID", OtherKey="ID", IsForeignKey=true)]
	public SSD SSD
	{
		get
		{
			return this._SSD.Entity;
		}
		set
		{
			SSD previousValue = this._SSD.Entity;
			if (((previousValue != value) 
						|| (this._SSD.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._SSD.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._SSD_ID = value.ID;
				}
				else
				{
					this._SSD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SSD");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_Pc1", Storage="_PCCase1", ThisKey="Case_ID", OtherKey="ID", IsForeignKey=true)]
	public PCCase1 PCCase1
	{
		get
		{
			return this._PCCase1.Entity;
		}
		set
		{
			PCCase1 previousValue = this._PCCase1.Entity;
			if (((previousValue != value) 
						|| (this._PCCase1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PCCase1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._PCCase1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Case_ID = value.ID;
				}
				else
				{
					this._Case_ID = default(int);
				}
				this.SendPropertyChanged("PCCase1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_Pc1", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.Pc1 = null;
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.Pc1 = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU1_Pc1", Storage="_PSU1", ThisKey="PSU_ID", OtherKey="ID", IsForeignKey=true)]
	public PSU1 PSU1
	{
		get
		{
			return this._PSU1.Entity;
		}
		set
		{
			PSU1 previousValue = this._PSU1.Entity;
			if (((previousValue != value) 
						|| (this._PSU1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PSU1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._PSU1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._PSU_ID = value.ID;
				}
				else
				{
					this._PSU_ID = default(int);
				}
				this.SendPropertyChanged("PSU1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_Pc1", Storage="_RAM1", ThisKey="RAM_ID", OtherKey="ID", IsForeignKey=true)]
	public RAM1 RAM1
	{
		get
		{
			return this._RAM1.Entity;
		}
		set
		{
			RAM1 previousValue = this._RAM1.Entity;
			if (((previousValue != value) 
						|| (this._RAM1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._RAM1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._RAM1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._RAM_ID = value.ID;
				}
				else
				{
					this._RAM_ID = default(int);
				}
				this.SendPropertyChanged("RAM1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker1_Pc1", Storage="_Speaker1", ThisKey="Speaker_ID", OtherKey="ID", IsForeignKey=true)]
	public Speaker1 Speaker1
	{
		get
		{
			return this._Speaker1.Entity;
		}
		set
		{
			Speaker1 previousValue = this._Speaker1.Entity;
			if (((previousValue != value) 
						|| (this._Speaker1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Speaker1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._Speaker1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._Speaker_ID = value.ID;
				}
				else
				{
					this._Speaker_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Speaker1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD1_Pc1", Storage="_SSD1", ThisKey="SSD_ID", OtherKey="ID", IsForeignKey=true)]
	public SSD1 SSD1
	{
		get
		{
			return this._SSD1.Entity;
		}
		set
		{
			SSD1 previousValue = this._SSD1.Entity;
			if (((previousValue != value) 
						|| (this._SSD1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SSD1.Entity = null;
					previousValue.Pc1s.Remove(this);
				}
				this._SSD1.Entity = value;
				if ((value != null))
				{
					value.Pc1s.Add(this);
					this._SSD_ID = value.ID;
				}
				else
				{
					this._SSD_ID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SSD1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcCart")]
public partial class PcCart1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _Pc_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPc_IDChanging(int value);
    partial void OnPc_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PcCart1()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pc_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Pc_ID
	{
		get
		{
			return this._Pc_ID;
		}
		set
		{
			if ((this._Pc_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPc_IDChanging(value);
				this.SendPropertyChanging();
				this._Pc_ID = value;
				this.SendPropertyChanged("Pc_ID");
				this.OnPc_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcCart1", Storage="_PcStock", ThisKey="Pc_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcCart1s.Remove(this);
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcCart1s.Add(this);
					this._Pc_ID = value.ID;
				}
				else
				{
					this._Pc_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcCart1", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PcCart1s.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PcCart1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcCart1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PcCart1s.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PcCart1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcCart1", Storage="_PcStock1", ThisKey="Pc_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcCart1s.Remove(this);
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcCart1s.Add(this);
					this._Pc_ID = value.ID;
				}
				else
				{
					this._Pc_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PCCase")]
public partial class PCCase1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Colour;
	
	private string _Dimensions;
	
	private string _Net_Weight;
	
	private string _Motherboard_Form_Factor;
	
	private string _Side_Window;
	
	private string _Num_HDD_Drives;
	
	private string _Num_SSD_Drives;
	
	private string _Front_I_O;
	
	private string _Expansion_Slots;
	
	private int _Num_Top_Fans;
	
	private int _Num_Bottom_Fans;
	
	private int _Num_Front_Fans;
	
	private int _Num_Back_Fans;
	
	private string _Top_Radiator_Support;
	
	private string _Front_Radiator_Support;
	
	private string _GPU_Max_Length;
	
	private string _CPU_Cooler_Height;
	
	private string _Warranty;
	
	private EntitySet<MoboToCase> _MoboToCases;
	
	private EntitySet<MoboToCase1> _MoboToCase1s;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnColourChanging(string value);
    partial void OnColourChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnNet_WeightChanging(string value);
    partial void OnNet_WeightChanged();
    partial void OnMotherboard_Form_FactorChanging(string value);
    partial void OnMotherboard_Form_FactorChanged();
    partial void OnSide_WindowChanging(string value);
    partial void OnSide_WindowChanged();
    partial void OnNum_HDD_DrivesChanging(string value);
    partial void OnNum_HDD_DrivesChanged();
    partial void OnNum_SSD_DrivesChanging(string value);
    partial void OnNum_SSD_DrivesChanged();
    partial void OnFront_I_OChanging(string value);
    partial void OnFront_I_OChanged();
    partial void OnExpansion_SlotsChanging(string value);
    partial void OnExpansion_SlotsChanged();
    partial void OnNum_Top_FansChanging(int value);
    partial void OnNum_Top_FansChanged();
    partial void OnNum_Bottom_FansChanging(int value);
    partial void OnNum_Bottom_FansChanged();
    partial void OnNum_Front_FansChanging(int value);
    partial void OnNum_Front_FansChanged();
    partial void OnNum_Back_FansChanging(int value);
    partial void OnNum_Back_FansChanged();
    partial void OnTop_Radiator_SupportChanging(string value);
    partial void OnTop_Radiator_SupportChanged();
    partial void OnFront_Radiator_SupportChanging(string value);
    partial void OnFront_Radiator_SupportChanged();
    partial void OnGPU_Max_LengthChanging(string value);
    partial void OnGPU_Max_LengthChanged();
    partial void OnCPU_Cooler_HeightChanging(string value);
    partial void OnCPU_Cooler_HeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public PCCase1()
	{
		this._MoboToCases = new EntitySet<MoboToCase>(new Action<MoboToCase>(this.attach_MoboToCases), new Action<MoboToCase>(this.detach_MoboToCases));
		this._MoboToCase1s = new EntitySet<MoboToCase1>(new Action<MoboToCase1>(this.attach_MoboToCase1s), new Action<MoboToCase1>(this.detach_MoboToCase1s));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colour", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Colour
	{
		get
		{
			return this._Colour;
		}
		set
		{
			if ((this._Colour != value))
			{
				this.OnColourChanging(value);
				this.SendPropertyChanging();
				this._Colour = value;
				this.SendPropertyChanged("Colour");
				this.OnColourChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Net_Weight", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Net_Weight
	{
		get
		{
			return this._Net_Weight;
		}
		set
		{
			if ((this._Net_Weight != value))
			{
				this.OnNet_WeightChanging(value);
				this.SendPropertyChanging();
				this._Net_Weight = value;
				this.SendPropertyChanged("Net_Weight");
				this.OnNet_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Motherboard_Form_Factor", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string Motherboard_Form_Factor
	{
		get
		{
			return this._Motherboard_Form_Factor;
		}
		set
		{
			if ((this._Motherboard_Form_Factor != value))
			{
				this.OnMotherboard_Form_FactorChanging(value);
				this.SendPropertyChanging();
				this._Motherboard_Form_Factor = value;
				this.SendPropertyChanged("Motherboard_Form_Factor");
				this.OnMotherboard_Form_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Side_Window", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Side_Window
	{
		get
		{
			return this._Side_Window;
		}
		set
		{
			if ((this._Side_Window != value))
			{
				this.OnSide_WindowChanging(value);
				this.SendPropertyChanging();
				this._Side_Window = value;
				this.SendPropertyChanged("Side_Window");
				this.OnSide_WindowChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_HDD_Drives", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Num_HDD_Drives
	{
		get
		{
			return this._Num_HDD_Drives;
		}
		set
		{
			if ((this._Num_HDD_Drives != value))
			{
				this.OnNum_HDD_DrivesChanging(value);
				this.SendPropertyChanging();
				this._Num_HDD_Drives = value;
				this.SendPropertyChanged("Num_HDD_Drives");
				this.OnNum_HDD_DrivesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_SSD_Drives", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Num_SSD_Drives
	{
		get
		{
			return this._Num_SSD_Drives;
		}
		set
		{
			if ((this._Num_SSD_Drives != value))
			{
				this.OnNum_SSD_DrivesChanging(value);
				this.SendPropertyChanging();
				this._Num_SSD_Drives = value;
				this.SendPropertyChanged("Num_SSD_Drives");
				this.OnNum_SSD_DrivesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Front_I/O]", Storage="_Front_I_O", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Front_I_O
	{
		get
		{
			return this._Front_I_O;
		}
		set
		{
			if ((this._Front_I_O != value))
			{
				this.OnFront_I_OChanging(value);
				this.SendPropertyChanging();
				this._Front_I_O = value;
				this.SendPropertyChanged("Front_I_O");
				this.OnFront_I_OChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expansion_Slots", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Expansion_Slots
	{
		get
		{
			return this._Expansion_Slots;
		}
		set
		{
			if ((this._Expansion_Slots != value))
			{
				this.OnExpansion_SlotsChanging(value);
				this.SendPropertyChanging();
				this._Expansion_Slots = value;
				this.SendPropertyChanged("Expansion_Slots");
				this.OnExpansion_SlotsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Top_Fans", DbType="Int NOT NULL")]
	public int Num_Top_Fans
	{
		get
		{
			return this._Num_Top_Fans;
		}
		set
		{
			if ((this._Num_Top_Fans != value))
			{
				this.OnNum_Top_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Top_Fans = value;
				this.SendPropertyChanged("Num_Top_Fans");
				this.OnNum_Top_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Bottom_Fans", DbType="Int NOT NULL")]
	public int Num_Bottom_Fans
	{
		get
		{
			return this._Num_Bottom_Fans;
		}
		set
		{
			if ((this._Num_Bottom_Fans != value))
			{
				this.OnNum_Bottom_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Bottom_Fans = value;
				this.SendPropertyChanged("Num_Bottom_Fans");
				this.OnNum_Bottom_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Front_Fans", DbType="Int NOT NULL")]
	public int Num_Front_Fans
	{
		get
		{
			return this._Num_Front_Fans;
		}
		set
		{
			if ((this._Num_Front_Fans != value))
			{
				this.OnNum_Front_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Front_Fans = value;
				this.SendPropertyChanged("Num_Front_Fans");
				this.OnNum_Front_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Num_Back_Fans", DbType="Int NOT NULL")]
	public int Num_Back_Fans
	{
		get
		{
			return this._Num_Back_Fans;
		}
		set
		{
			if ((this._Num_Back_Fans != value))
			{
				this.OnNum_Back_FansChanging(value);
				this.SendPropertyChanging();
				this._Num_Back_Fans = value;
				this.SendPropertyChanged("Num_Back_Fans");
				this.OnNum_Back_FansChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Top_Radiator_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Top_Radiator_Support
	{
		get
		{
			return this._Top_Radiator_Support;
		}
		set
		{
			if ((this._Top_Radiator_Support != value))
			{
				this.OnTop_Radiator_SupportChanging(value);
				this.SendPropertyChanging();
				this._Top_Radiator_Support = value;
				this.SendPropertyChanged("Top_Radiator_Support");
				this.OnTop_Radiator_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Front_Radiator_Support", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Front_Radiator_Support
	{
		get
		{
			return this._Front_Radiator_Support;
		}
		set
		{
			if ((this._Front_Radiator_Support != value))
			{
				this.OnFront_Radiator_SupportChanging(value);
				this.SendPropertyChanging();
				this._Front_Radiator_Support = value;
				this.SendPropertyChanged("Front_Radiator_Support");
				this.OnFront_Radiator_SupportChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPU_Max_Length", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string GPU_Max_Length
	{
		get
		{
			return this._GPU_Max_Length;
		}
		set
		{
			if ((this._GPU_Max_Length != value))
			{
				this.OnGPU_Max_LengthChanging(value);
				this.SendPropertyChanging();
				this._GPU_Max_Length = value;
				this.SendPropertyChanged("GPU_Max_Length");
				this.OnGPU_Max_LengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPU_Cooler_Height", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string CPU_Cooler_Height
	{
		get
		{
			return this._CPU_Cooler_Height;
		}
		set
		{
			if ((this._CPU_Cooler_Height != value))
			{
				this.OnCPU_Cooler_HeightChanging(value);
				this.SendPropertyChanging();
				this._CPU_Cooler_Height = value;
				this.SendPropertyChanged("CPU_Cooler_Height");
				this.OnCPU_Cooler_HeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="NChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_MoboToCase", Storage="_MoboToCases", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<MoboToCase> MoboToCases
	{
		get
		{
			return this._MoboToCases;
		}
		set
		{
			this._MoboToCases.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_MoboToCase1", Storage="_MoboToCase1s", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<MoboToCase1> MoboToCase1s
	{
		get
		{
			return this._MoboToCase1s;
		}
		set
		{
			this._MoboToCase1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PCCase1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Case_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PCCase1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PCCase1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PCCase1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PCCase1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PCCase1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PCCase1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = this;
	}
	
	private void detach_MoboToCases(MoboToCase entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = null;
	}
	
	private void attach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = this;
	}
	
	private void detach_MoboToCase1s(MoboToCase1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PCCase1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcInvoice")]
public partial class PcInvoice1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private int _PC_ID;
	
	private int _Qua;
	
	private decimal _Total_Price;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<Client> _Client;
	
	private EntityRef<Client1> _Client1;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnQuaChanging(int value);
    partial void OnQuaChanged();
    partial void OnTotal_PriceChanging(decimal value);
    partial void OnTotal_PriceChanged();
    #endregion
	
	public PcInvoice1()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._Client = default(EntityRef<Client>);
		this._Client1 = default(EntityRef<Client1>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if ((this._Client.HasLoadedOrAssignedValue || this._Client1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qua", DbType="Int NOT NULL")]
	public int Qua
	{
		get
		{
			return this._Qua;
		}
		set
		{
			if ((this._Qua != value))
			{
				this.OnQuaChanging(value);
				this.SendPropertyChanging();
				this._Qua = value;
				this.SendPropertyChanged("Qua");
				this.OnQuaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Price", DbType="Money NOT NULL")]
	public decimal Total_Price
	{
		get
		{
			return this._Total_Price;
		}
		set
		{
			if ((this._Total_Price != value))
			{
				this.OnTotal_PriceChanging(value);
				this.SendPropertyChanging();
				this._Total_Price = value;
				this.SendPropertyChanged("Total_Price");
				this.OnTotal_PriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcInvoice1", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcInvoice1s.Remove(this);
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcInvoice1s.Add(this);
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_PcInvoice1", Storage="_Client", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client Client
	{
		get
		{
			return this._Client.Entity;
		}
		set
		{
			Client previousValue = this._Client.Entity;
			if (((previousValue != value) 
						|| (this._Client.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client.Entity = null;
					previousValue.PcInvoice1s.Remove(this);
				}
				this._Client.Entity = value;
				if ((value != null))
				{
					value.PcInvoice1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client1_PcInvoice1", Storage="_Client1", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Client1 Client1
	{
		get
		{
			return this._Client1.Entity;
		}
		set
		{
			Client1 previousValue = this._Client1.Entity;
			if (((previousValue != value) 
						|| (this._Client1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Client1.Entity = null;
					previousValue.PcInvoice1s.Remove(this);
				}
				this._Client1.Entity = value;
				if ((value != null))
				{
					value.PcInvoice1s.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Client1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcInvoice1", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcInvoice1s.Remove(this);
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcInvoice1s.Add(this);
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcSold")]
public partial class PcSold1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PC_ID;
	
	private string _Type;
	
	private int _Quantity_Sold;
	
	private EntityRef<PcStock> _PcStock;
	
	private EntityRef<PcStock1> _PcStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPC_IDChanging(int value);
    partial void OnPC_IDChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnQuantity_SoldChanging(int value);
    partial void OnQuantity_SoldChanged();
    #endregion
	
	public PcSold1()
	{
		this._PcStock = default(EntityRef<PcStock>);
		this._PcStock1 = default(EntityRef<PcStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int PC_ID
	{
		get
		{
			return this._PC_ID;
		}
		set
		{
			if ((this._PC_ID != value))
			{
				if ((this._PcStock.HasLoadedOrAssignedValue || this._PcStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPC_IDChanging(value);
				this.SendPropertyChanging();
				this._PC_ID = value;
				this.SendPropertyChanged("PC_ID");
				this.OnPC_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity_Sold", DbType="Int NOT NULL")]
	public int Quantity_Sold
	{
		get
		{
			return this._Quantity_Sold;
		}
		set
		{
			if ((this._Quantity_Sold != value))
			{
				this.OnQuantity_SoldChanging(value);
				this.SendPropertyChanging();
				this._Quantity_Sold = value;
				this.SendPropertyChanged("Quantity_Sold");
				this.OnQuantity_SoldChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock_PcSold1", Storage="_PcStock", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock PcStock
	{
		get
		{
			return this._PcStock.Entity;
		}
		set
		{
			PcStock previousValue = this._PcStock.Entity;
			if (((previousValue != value) 
						|| (this._PcStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock.Entity = null;
					previousValue.PcSold1 = null;
				}
				this._PcStock.Entity = value;
				if ((value != null))
				{
					value.PcSold1 = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcSold1", Storage="_PcStock1", ThisKey="PC_ID", OtherKey="ID", IsForeignKey=true)]
	public PcStock1 PcStock1
	{
		get
		{
			return this._PcStock1.Entity;
		}
		set
		{
			PcStock1 previousValue = this._PcStock1.Entity;
			if (((previousValue != value) 
						|| (this._PcStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcStock1.Entity = null;
					previousValue.PcSold1 = null;
				}
				this._PcStock1.Entity = value;
				if ((value != null))
				{
					value.PcSold1 = this;
					this._PC_ID = value.ID;
				}
				else
				{
					this._PC_ID = default(int);
				}
				this.SendPropertyChanged("PcStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PcStock")]
public partial class PcStock1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private int _Quantity;
	
	private string _PC_Type;
	
	private decimal _Price;
	
	private string _Image;
	
	private int _Active;
	
	private int _Discount;
	
	private EntityRef<Pc> _Pc;
	
	private EntityRef<Pc1> _Pc1;
	
	private EntityRef<PcSold> _PcSold;
	
	private EntityRef<PcSold1> _PcSold1;
	
	private EntitySet<PcInvoice> _PcInvoices;
	
	private EntitySet<PcInvoice1> _PcInvoice1s;
	
	private EntitySet<PcCart> _PcCarts;
	
	private EntitySet<PcCart1> _PcCart1s;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPC_TypeChanging(string value);
    partial void OnPC_TypeChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    partial void OnDiscountChanging(int value);
    partial void OnDiscountChanged();
    #endregion
	
	public PcStock1()
	{
		this._Pc = default(EntityRef<Pc>);
		this._Pc1 = default(EntityRef<Pc1>);
		this._PcSold = default(EntityRef<PcSold>);
		this._PcSold1 = default(EntityRef<PcSold1>);
		this._PcInvoices = new EntitySet<PcInvoice>(new Action<PcInvoice>(this.attach_PcInvoices), new Action<PcInvoice>(this.detach_PcInvoices));
		this._PcInvoice1s = new EntitySet<PcInvoice1>(new Action<PcInvoice1>(this.attach_PcInvoice1s), new Action<PcInvoice1>(this.detach_PcInvoice1s));
		this._PcCarts = new EntitySet<PcCart>(new Action<PcCart>(this.attach_PcCarts), new Action<PcCart>(this.detach_PcCarts));
		this._PcCart1s = new EntitySet<PcCart1>(new Action<PcCart1>(this.attach_PcCart1s), new Action<PcCart1>(this.detach_PcCart1s));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PC_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string PC_Type
	{
		get
		{
			return this._PC_Type;
		}
		set
		{
			if ((this._PC_Type != value))
			{
				this.OnPC_TypeChanging(value);
				this.SendPropertyChanging();
				this._PC_Type = value;
				this.SendPropertyChanged("PC_Type");
				this.OnPC_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
	public int Active
	{
		get
		{
			return this._Active;
		}
		set
		{
			if ((this._Active != value))
			{
				this.OnActiveChanging(value);
				this.SendPropertyChanging();
				this._Active = value;
				this.SendPropertyChanged("Active");
				this.OnActiveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int NOT NULL")]
	public int Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_Pc", Storage="_Pc", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public Pc Pc
	{
		get
		{
			return this._Pc.Entity;
		}
		set
		{
			Pc previousValue = this._Pc.Entity;
			if (((previousValue != value) 
						|| (this._Pc.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pc.Entity = null;
					previousValue.PcStock1 = null;
				}
				this._Pc.Entity = value;
				if ((value != null))
				{
					value.PcStock1 = this;
				}
				this.SendPropertyChanged("Pc");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_Pc1", Storage="_Pc1", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public Pc1 Pc1
	{
		get
		{
			return this._Pc1.Entity;
		}
		set
		{
			Pc1 previousValue = this._Pc1.Entity;
			if (((previousValue != value) 
						|| (this._Pc1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pc1.Entity = null;
					previousValue.PcStock1 = null;
				}
				this._Pc1.Entity = value;
				if ((value != null))
				{
					value.PcStock1 = this;
				}
				this.SendPropertyChanged("Pc1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcSold", Storage="_PcSold", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public PcSold PcSold
	{
		get
		{
			return this._PcSold.Entity;
		}
		set
		{
			PcSold previousValue = this._PcSold.Entity;
			if (((previousValue != value) 
						|| (this._PcSold.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcSold.Entity = null;
					previousValue.PcStock1 = null;
				}
				this._PcSold.Entity = value;
				if ((value != null))
				{
					value.PcStock1 = this;
				}
				this.SendPropertyChanged("PcSold");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcSold1", Storage="_PcSold1", ThisKey="ID", OtherKey="PC_ID", IsUnique=true, IsForeignKey=false)]
	public PcSold1 PcSold1
	{
		get
		{
			return this._PcSold1.Entity;
		}
		set
		{
			PcSold1 previousValue = this._PcSold1.Entity;
			if (((previousValue != value) 
						|| (this._PcSold1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PcSold1.Entity = null;
					previousValue.PcStock1 = null;
				}
				this._PcSold1.Entity = value;
				if ((value != null))
				{
					value.PcStock1 = this;
				}
				this.SendPropertyChanged("PcSold1");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcInvoice", Storage="_PcInvoices", ThisKey="ID", OtherKey="PC_ID")]
	public EntitySet<PcInvoice> PcInvoices
	{
		get
		{
			return this._PcInvoices;
		}
		set
		{
			this._PcInvoices.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcInvoice1", Storage="_PcInvoice1s", ThisKey="ID", OtherKey="PC_ID")]
	public EntitySet<PcInvoice1> PcInvoice1s
	{
		get
		{
			return this._PcInvoice1s;
		}
		set
		{
			this._PcInvoice1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcCart", Storage="_PcCarts", ThisKey="ID", OtherKey="Pc_ID")]
	public EntitySet<PcCart> PcCarts
	{
		get
		{
			return this._PcCarts;
		}
		set
		{
			this._PcCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PcStock1_PcCart1", Storage="_PcCart1s", ThisKey="ID", OtherKey="Pc_ID")]
	public EntitySet<PcCart1> PcCart1s
	{
		get
		{
			return this._PcCart1s;
		}
		set
		{
			this._PcCart1s.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = this;
	}
	
	private void detach_PcInvoices(PcInvoice entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = null;
	}
	
	private void attach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = this;
	}
	
	private void detach_PcInvoice1s(PcInvoice1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = null;
	}
	
	private void attach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = this;
	}
	
	private void detach_PcCarts(PcCart entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = null;
	}
	
	private void attach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = this;
	}
	
	private void detach_PcCart1s(PcCart1 entity)
	{
		this.SendPropertyChanging();
		entity.PcStock1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PSU")]
public partial class PSU1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Power;
	
	private string _Certification;
	
	private string _Modular;
	
	private string _Connectors;
	
	private string _MTBF;
	
	private string _Fan_Size;
	
	private string _Cables;
	
	private string _Dimensions;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnPowerChanging(string value);
    partial void OnPowerChanged();
    partial void OnCertificationChanging(string value);
    partial void OnCertificationChanged();
    partial void OnModularChanging(string value);
    partial void OnModularChanged();
    partial void OnConnectorsChanging(string value);
    partial void OnConnectorsChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnFan_SizeChanging(string value);
    partial void OnFan_SizeChanged();
    partial void OnCablesChanging(string value);
    partial void OnCablesChanged();
    partial void OnDimensionsChanging(string value);
    partial void OnDimensionsChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public PSU1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Power
	{
		get
		{
			return this._Power;
		}
		set
		{
			if ((this._Power != value))
			{
				this.OnPowerChanging(value);
				this.SendPropertyChanging();
				this._Power = value;
				this.SendPropertyChanged("Power");
				this.OnPowerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Certification", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Certification
	{
		get
		{
			return this._Certification;
		}
		set
		{
			if ((this._Certification != value))
			{
				this.OnCertificationChanging(value);
				this.SendPropertyChanging();
				this._Certification = value;
				this.SendPropertyChanged("Certification");
				this.OnCertificationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modular", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Modular
	{
		get
		{
			return this._Modular;
		}
		set
		{
			if ((this._Modular != value))
			{
				this.OnModularChanging(value);
				this.SendPropertyChanging();
				this._Modular = value;
				this.SendPropertyChanged("Modular");
				this.OnModularChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Connectors", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Connectors
	{
		get
		{
			return this._Connectors;
		}
		set
		{
			if ((this._Connectors != value))
			{
				this.OnConnectorsChanging(value);
				this.SendPropertyChanging();
				this._Connectors = value;
				this.SendPropertyChanged("Connectors");
				this.OnConnectorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan_Size", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Fan_Size
	{
		get
		{
			return this._Fan_Size;
		}
		set
		{
			if ((this._Fan_Size != value))
			{
				this.OnFan_SizeChanging(value);
				this.SendPropertyChanging();
				this._Fan_Size = value;
				this.SendPropertyChanged("Fan_Size");
				this.OnFan_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cables", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Cables
	{
		get
		{
			return this._Cables;
		}
		set
		{
			if ((this._Cables != value))
			{
				this.OnCablesChanging(value);
				this.SendPropertyChanging();
				this._Cables = value;
				this.SendPropertyChanged("Cables");
				this.OnCablesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Dimensions
	{
		get
		{
			return this._Dimensions;
		}
		set
		{
			if ((this._Dimensions != value))
			{
				this.OnDimensionsChanging(value);
				this.SendPropertyChanging();
				this._Dimensions = value;
				this.SendPropertyChanged("Dimensions");
				this.OnDimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="PSU_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PSU1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="PSU_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_PSU1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.PSU1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.PSU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_PSU1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.PSU1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.PSU1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PSU1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.PSU1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PSU1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.PSU1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RAM")]
public partial class RAM1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Capacity;
	
	private string _Type;
	
	private string _Speed;
	
	private string _Latency;
	
	private string _Voltage;
	
	private string _Channel_Config;
	
	private string _Height;
	
	private string _Warranty;
	
	private EntitySet<MoboToRam> _MoboToRams;
	
	private EntitySet<MoboToRam1> _MoboToRam1s;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnCapacityChanging(string value);
    partial void OnCapacityChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSpeedChanging(string value);
    partial void OnSpeedChanged();
    partial void OnLatencyChanging(string value);
    partial void OnLatencyChanged();
    partial void OnVoltageChanging(string value);
    partial void OnVoltageChanged();
    partial void OnChannel_ConfigChanging(string value);
    partial void OnChannel_ConfigChanged();
    partial void OnHeightChanging(string value);
    partial void OnHeightChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public RAM1()
	{
		this._MoboToRams = new EntitySet<MoboToRam>(new Action<MoboToRam>(this.attach_MoboToRams), new Action<MoboToRam>(this.detach_MoboToRams));
		this._MoboToRam1s = new EntitySet<MoboToRam1>(new Action<MoboToRam1>(this.attach_MoboToRam1s), new Action<MoboToRam1>(this.detach_MoboToRam1s));
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capacity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Capacity
	{
		get
		{
			return this._Capacity;
		}
		set
		{
			if ((this._Capacity != value))
			{
				this.OnCapacityChanging(value);
				this.SendPropertyChanging();
				this._Capacity = value;
				this.SendPropertyChanged("Capacity");
				this.OnCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Speed
	{
		get
		{
			return this._Speed;
		}
		set
		{
			if ((this._Speed != value))
			{
				this.OnSpeedChanging(value);
				this.SendPropertyChanging();
				this._Speed = value;
				this.SendPropertyChanged("Speed");
				this.OnSpeedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latency", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Latency
	{
		get
		{
			return this._Latency;
		}
		set
		{
			if ((this._Latency != value))
			{
				this.OnLatencyChanging(value);
				this.SendPropertyChanging();
				this._Latency = value;
				this.SendPropertyChanged("Latency");
				this.OnLatencyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Voltage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Voltage
	{
		get
		{
			return this._Voltage;
		}
		set
		{
			if ((this._Voltage != value))
			{
				this.OnVoltageChanging(value);
				this.SendPropertyChanging();
				this._Voltage = value;
				this.SendPropertyChanged("Voltage");
				this.OnVoltageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Channel_Config", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Channel_Config
	{
		get
		{
			return this._Channel_Config;
		}
		set
		{
			if ((this._Channel_Config != value))
			{
				this.OnChannel_ConfigChanging(value);
				this.SendPropertyChanging();
				this._Channel_Config = value;
				this.SendPropertyChanged("Channel_Config");
				this.OnChannel_ConfigChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Height
	{
		get
		{
			return this._Height;
		}
		set
		{
			if ((this._Height != value))
			{
				this.OnHeightChanging(value);
				this.SendPropertyChanging();
				this._Height = value;
				this.SendPropertyChanged("Height");
				this.OnHeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_MoboToRam", Storage="_MoboToRams", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<MoboToRam> MoboToRams
	{
		get
		{
			return this._MoboToRams;
		}
		set
		{
			this._MoboToRams.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_MoboToRam1", Storage="_MoboToRam1s", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<MoboToRam1> MoboToRam1s
	{
		get
		{
			return this._MoboToRam1s;
		}
		set
		{
			this._MoboToRam1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RAM1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="RAM_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_RAM1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.RAM1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.RAM1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_RAM1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.RAM1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.RAM1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = this;
	}
	
	private void detach_MoboToRams(MoboToRam entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = null;
	}
	
	private void attach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = this;
	}
	
	private void detach_MoboToRam1s(MoboToRam1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = null;
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.RAM1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Speaker")]
public partial class Speaker1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Satellite_Dimensions;
	
	private string _Satellite_Weight;
	
	private string _SubWoofer_Dimensions;
	
	private string _SubWoofer_Weight;
	
	private string _controls;
	
	private string _System_Requirements;
	
	private string _Features;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSatellite_DimensionsChanging(string value);
    partial void OnSatellite_DimensionsChanged();
    partial void OnSatellite_WeightChanging(string value);
    partial void OnSatellite_WeightChanged();
    partial void OnSubWoofer_DimensionsChanging(string value);
    partial void OnSubWoofer_DimensionsChanged();
    partial void OnSubWoofer_WeightChanging(string value);
    partial void OnSubWoofer_WeightChanged();
    partial void OncontrolsChanging(string value);
    partial void OncontrolsChanged();
    partial void OnSystem_RequirementsChanging(string value);
    partial void OnSystem_RequirementsChanged();
    partial void OnFeaturesChanging(string value);
    partial void OnFeaturesChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public Speaker1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Satellite_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Satellite_Dimensions
	{
		get
		{
			return this._Satellite_Dimensions;
		}
		set
		{
			if ((this._Satellite_Dimensions != value))
			{
				this.OnSatellite_DimensionsChanging(value);
				this.SendPropertyChanging();
				this._Satellite_Dimensions = value;
				this.SendPropertyChanged("Satellite_Dimensions");
				this.OnSatellite_DimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Satellite_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Satellite_Weight
	{
		get
		{
			return this._Satellite_Weight;
		}
		set
		{
			if ((this._Satellite_Weight != value))
			{
				this.OnSatellite_WeightChanging(value);
				this.SendPropertyChanging();
				this._Satellite_Weight = value;
				this.SendPropertyChanged("Satellite_Weight");
				this.OnSatellite_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubWoofer_Dimensions", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SubWoofer_Dimensions
	{
		get
		{
			return this._SubWoofer_Dimensions;
		}
		set
		{
			if ((this._SubWoofer_Dimensions != value))
			{
				this.OnSubWoofer_DimensionsChanging(value);
				this.SendPropertyChanging();
				this._SubWoofer_Dimensions = value;
				this.SendPropertyChanged("SubWoofer_Dimensions");
				this.OnSubWoofer_DimensionsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubWoofer_Weight", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string SubWoofer_Weight
	{
		get
		{
			return this._SubWoofer_Weight;
		}
		set
		{
			if ((this._SubWoofer_Weight != value))
			{
				this.OnSubWoofer_WeightChanging(value);
				this.SendPropertyChanging();
				this._SubWoofer_Weight = value;
				this.SendPropertyChanged("SubWoofer_Weight");
				this.OnSubWoofer_WeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_controls", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string controls
	{
		get
		{
			return this._controls;
		}
		set
		{
			if ((this._controls != value))
			{
				this.OncontrolsChanging(value);
				this.SendPropertyChanging();
				this._controls = value;
				this.SendPropertyChanged("controls");
				this.OncontrolsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_System_Requirements", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string System_Requirements
	{
		get
		{
			return this._System_Requirements;
		}
		set
		{
			if ((this._System_Requirements != value))
			{
				this.OnSystem_RequirementsChanging(value);
				this.SendPropertyChanging();
				this._System_Requirements = value;
				this.SendPropertyChanged("System_Requirements");
				this.OnSystem_RequirementsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Features", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Features
	{
		get
		{
			return this._Features;
		}
		set
		{
			if ((this._Features != value))
			{
				this.OnFeaturesChanging(value);
				this.SendPropertyChanging();
				this._Features = value;
				this.SendPropertyChanged("Features");
				this.OnFeaturesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="Speaker_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Speaker1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="Speaker_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_Speaker1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.Speaker1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.Speaker1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_Speaker1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.Speaker1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.Speaker1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Speaker1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.Speaker1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Speaker1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.Speaker1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SSD")]
public partial class SSD1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Model;
	
	private string _Brand;
	
	private string _Series;
	
	private string _Form_Factor;
	
	private string _Capacity;
	
	private string _Interface_Type;
	
	private string _Length;
	
	private string _Width;
	
	private string _Max_Sequential_Read;
	
	private string _Max_Sequential_Write;
	
	private string _Random_Read;
	
	private string _Random_Write;
	
	private string _MTBF;
	
	private string _Operating_Temp;
	
	private string _Max_Power_Usage;
	
	private string _Warranty;
	
	private EntitySet<Pc> _Pcs;
	
	private EntitySet<Pc1> _Pc1s;
	
	private EntityRef<PartsStock> _PartsStock;
	
	private EntityRef<PartsStock1> _PartsStock1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnSeriesChanging(string value);
    partial void OnSeriesChanged();
    partial void OnForm_FactorChanging(string value);
    partial void OnForm_FactorChanged();
    partial void OnCapacityChanging(string value);
    partial void OnCapacityChanged();
    partial void OnInterface_TypeChanging(string value);
    partial void OnInterface_TypeChanged();
    partial void OnLengthChanging(string value);
    partial void OnLengthChanged();
    partial void OnWidthChanging(string value);
    partial void OnWidthChanged();
    partial void OnMax_Sequential_ReadChanging(string value);
    partial void OnMax_Sequential_ReadChanged();
    partial void OnMax_Sequential_WriteChanging(string value);
    partial void OnMax_Sequential_WriteChanged();
    partial void OnRandom_ReadChanging(string value);
    partial void OnRandom_ReadChanged();
    partial void OnRandom_WriteChanging(string value);
    partial void OnRandom_WriteChanged();
    partial void OnMTBFChanging(string value);
    partial void OnMTBFChanged();
    partial void OnOperating_TempChanging(string value);
    partial void OnOperating_TempChanged();
    partial void OnMax_Power_UsageChanging(string value);
    partial void OnMax_Power_UsageChanged();
    partial void OnWarrantyChanging(string value);
    partial void OnWarrantyChanged();
    #endregion
	
	public SSD1()
	{
		this._Pcs = new EntitySet<Pc>(new Action<Pc>(this.attach_Pcs), new Action<Pc>(this.detach_Pcs));
		this._Pc1s = new EntitySet<Pc1>(new Action<Pc1>(this.attach_Pc1s), new Action<Pc1>(this.detach_Pc1s));
		this._PartsStock = default(EntityRef<PartsStock>);
		this._PartsStock1 = default(EntityRef<PartsStock1>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				if ((this._PartsStock.HasLoadedOrAssignedValue || this._PartsStock1.HasLoadedOrAssignedValue))
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Model
	{
		get
		{
			return this._Model;
		}
		set
		{
			if ((this._Model != value))
			{
				this.OnModelChanging(value);
				this.SendPropertyChanging();
				this._Model = value;
				this.SendPropertyChanged("Model");
				this.OnModelChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Brand
	{
		get
		{
			return this._Brand;
		}
		set
		{
			if ((this._Brand != value))
			{
				this.OnBrandChanging(value);
				this.SendPropertyChanging();
				this._Brand = value;
				this.SendPropertyChanged("Brand");
				this.OnBrandChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Series", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Series
	{
		get
		{
			return this._Series;
		}
		set
		{
			if ((this._Series != value))
			{
				this.OnSeriesChanging(value);
				this.SendPropertyChanging();
				this._Series = value;
				this.SendPropertyChanged("Series");
				this.OnSeriesChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Form_Factor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Form_Factor
	{
		get
		{
			return this._Form_Factor;
		}
		set
		{
			if ((this._Form_Factor != value))
			{
				this.OnForm_FactorChanging(value);
				this.SendPropertyChanging();
				this._Form_Factor = value;
				this.SendPropertyChanged("Form_Factor");
				this.OnForm_FactorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capacity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Capacity
	{
		get
		{
			return this._Capacity;
		}
		set
		{
			if ((this._Capacity != value))
			{
				this.OnCapacityChanging(value);
				this.SendPropertyChanging();
				this._Capacity = value;
				this.SendPropertyChanged("Capacity");
				this.OnCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Interface_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Interface_Type
	{
		get
		{
			return this._Interface_Type;
		}
		set
		{
			if ((this._Interface_Type != value))
			{
				this.OnInterface_TypeChanging(value);
				this.SendPropertyChanging();
				this._Interface_Type = value;
				this.SendPropertyChanged("Interface_Type");
				this.OnInterface_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Length
	{
		get
		{
			return this._Length;
		}
		set
		{
			if ((this._Length != value))
			{
				this.OnLengthChanging(value);
				this.SendPropertyChanging();
				this._Length = value;
				this.SendPropertyChanged("Length");
				this.OnLengthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Width
	{
		get
		{
			return this._Width;
		}
		set
		{
			if ((this._Width != value))
			{
				this.OnWidthChanging(value);
				this.SendPropertyChanging();
				this._Width = value;
				this.SendPropertyChanged("Width");
				this.OnWidthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sequential_Read", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sequential_Read
	{
		get
		{
			return this._Max_Sequential_Read;
		}
		set
		{
			if ((this._Max_Sequential_Read != value))
			{
				this.OnMax_Sequential_ReadChanging(value);
				this.SendPropertyChanging();
				this._Max_Sequential_Read = value;
				this.SendPropertyChanged("Max_Sequential_Read");
				this.OnMax_Sequential_ReadChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Sequential_Write", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Sequential_Write
	{
		get
		{
			return this._Max_Sequential_Write;
		}
		set
		{
			if ((this._Max_Sequential_Write != value))
			{
				this.OnMax_Sequential_WriteChanging(value);
				this.SendPropertyChanging();
				this._Max_Sequential_Write = value;
				this.SendPropertyChanged("Max_Sequential_Write");
				this.OnMax_Sequential_WriteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Random_Read", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Random_Read
	{
		get
		{
			return this._Random_Read;
		}
		set
		{
			if ((this._Random_Read != value))
			{
				this.OnRandom_ReadChanging(value);
				this.SendPropertyChanging();
				this._Random_Read = value;
				this.SendPropertyChanged("Random_Read");
				this.OnRandom_ReadChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Random_Write", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Random_Write
	{
		get
		{
			return this._Random_Write;
		}
		set
		{
			if ((this._Random_Write != value))
			{
				this.OnRandom_WriteChanging(value);
				this.SendPropertyChanging();
				this._Random_Write = value;
				this.SendPropertyChanged("Random_Write");
				this.OnRandom_WriteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MTBF", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string MTBF
	{
		get
		{
			return this._MTBF;
		}
		set
		{
			if ((this._MTBF != value))
			{
				this.OnMTBFChanging(value);
				this.SendPropertyChanging();
				this._MTBF = value;
				this.SendPropertyChanged("MTBF");
				this.OnMTBFChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operating_Temp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Operating_Temp
	{
		get
		{
			return this._Operating_Temp;
		}
		set
		{
			if ((this._Operating_Temp != value))
			{
				this.OnOperating_TempChanging(value);
				this.SendPropertyChanging();
				this._Operating_Temp = value;
				this.SendPropertyChanged("Operating_Temp");
				this.OnOperating_TempChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Max_Power_Usage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Max_Power_Usage
	{
		get
		{
			return this._Max_Power_Usage;
		}
		set
		{
			if ((this._Max_Power_Usage != value))
			{
				this.OnMax_Power_UsageChanging(value);
				this.SendPropertyChanging();
				this._Max_Power_Usage = value;
				this.SendPropertyChanged("Max_Power_Usage");
				this.OnMax_Power_UsageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Warranty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Warranty
	{
		get
		{
			return this._Warranty;
		}
		set
		{
			if ((this._Warranty != value))
			{
				this.OnWarrantyChanging(value);
				this.SendPropertyChanging();
				this._Warranty = value;
				this.SendPropertyChanged("Warranty");
				this.OnWarrantyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD1_Pc", Storage="_Pcs", ThisKey="ID", OtherKey="SSD_ID")]
	public EntitySet<Pc> Pcs
	{
		get
		{
			return this._Pcs;
		}
		set
		{
			this._Pcs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SSD1_Pc1", Storage="_Pc1s", ThisKey="ID", OtherKey="SSD_ID")]
	public EntitySet<Pc1> Pc1s
	{
		get
		{
			return this._Pc1s;
		}
		set
		{
			this._Pc1s.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock_SSD1", Storage="_PartsStock", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock PartsStock
	{
		get
		{
			return this._PartsStock.Entity;
		}
		set
		{
			PartsStock previousValue = this._PartsStock.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock.Entity = null;
					previousValue.SSD1 = null;
				}
				this._PartsStock.Entity = value;
				if ((value != null))
				{
					value.SSD1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PartsStock1_SSD1", Storage="_PartsStock1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
	public PartsStock1 PartsStock1
	{
		get
		{
			return this._PartsStock1.Entity;
		}
		set
		{
			PartsStock1 previousValue = this._PartsStock1.Entity;
			if (((previousValue != value) 
						|| (this._PartsStock1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PartsStock1.Entity = null;
					previousValue.SSD1 = null;
				}
				this._PartsStock1.Entity = value;
				if ((value != null))
				{
					value.SSD1 = this;
					this._ID = value.ID;
				}
				else
				{
					this._ID = default(int);
				}
				this.SendPropertyChanged("PartsStock1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.SSD1 = this;
	}
	
	private void detach_Pcs(Pc entity)
	{
		this.SendPropertyChanging();
		entity.SSD1 = null;
	}
	
	private void attach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.SSD1 = this;
	}
	
	private void detach_Pc1s(Pc1 entity)
	{
		this.SendPropertyChanging();
		entity.SSD1 = null;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    CyberLlamaDatabaseDataContext db = new CyberLlamaDatabaseDataContext();


    //Login, registering of users
    public string Login(string strUserName, string strPassword)
    {
        try
        {
            var hash = HashUserInfo.hash(strPassword, strUserName);
            var User = db.LoginTables.Where(x => x.User_Name.Equals(strUserName) && x.Password.Equals(hash))
                    .Select(y => y).FirstOrDefault();
            if (User != null)
            {
                
                var newLogin = db.loginStats.Where(x => x.User_Id.Equals(User.User_ID)).Select(y => y).FirstOrDefault();
                if(newLogin != null)
                {
                    newLogin.Date = DateTime.Now;
                }
                db.SubmitChanges();
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
        //make sure the passwords match
        if (password.Equals(confirm))
        {
            if (db.LoginTables.Where(x => x.User_Name.Equals(UserName)).Select(y => y.User_Name).FirstOrDefault() == null)
            {
                //add to the database the new employee
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
                //the userName or email already exists
                return -1;
            }
        }
        else
        {
            //the passwords do not match
            return -2;
        }
    }

    public int addClient(string fName, string sName, string eMail, string address, string city, string province, string zipCode, string UserName, string password, string confirm)
    {
        //make sure the passwords match
        if (password.Equals(confirm))
        {
            //make sure username or email dont already exist
            if (db.LoginTables.Where(x => x.User_Name.Equals(UserName)).Select(y => y.User_Name).FirstOrDefault() == null
                && db.Clients.Where(z => z.Email.Equals(eMail)).Select(p => p.Email).FirstOrDefault() == null)
            {
                var newLogin = new LoginTable
                {
                    User_Name = UserName,
                    Password = HashUserInfo.hash(password, UserName),
                    //change this to a constant value
                    User_Type = 7,
                    Client = new Client
                    {
                        First_Name = fName,
                        Surname = sName,
                        Email = eMail,
                        Address = address,
                        City = city,
                        Province = province,
                        ZIP_Code = zipCode,
                    }
                };
                db.LoginTables.InsertOnSubmit(newLogin);
                
                try
                {
                    db.SubmitChanges();
                    var newRegister = new RegisterStat
                    {
                        User_Id = newLogin.User_ID,
                        Date = DateTime.Now
                    };
                    db.RegisterStats.InsertOnSubmit(newRegister);
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

    public bool editClient(cClient client)
    {
        var oldClient = db.Clients.Where(x => client.ID.Equals(x.User_ID)).FirstOrDefault();
        oldClient.ZIP_Code = client.ZipCode;
        oldClient.Surname = client.Surname;
        oldClient.Province = client.province;
        oldClient.Address = client.Address;
        oldClient.City = client.city;
        oldClient.Email = client.email;
        oldClient.First_Name = client.firstName;

        try{
            db.SubmitChanges();
            return true;
        } catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

    }

    public List<string> getUserPositions()
    {
        return db.UserPositions.Select(x => x.Position).ToList();
    }

    public List<cEmployee> getAllEmployees()
    {

        return db.Admins.Select(x => new cEmployee
        {
            Admin_ID = x.Admin_ID,
            First_Name = x.First_Name,
            Surname = x.Surname,
            Email = x.Email,
            Contact_Number = x.Conrtact_Number,
            Position = x.Position
        }).ToList();     
    }

    //Adding new Products to the DB
    //Adding new Air Cooler
    public bool addAirCooler(cAirCooler newAC, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newAC.model,
            Type = "AirCooler",
            Quantity = qua,
            Price = (decimal)newAC.price,
            Active = newAC.active,
            Discount = newAC.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var AC = new AirCooler
        {
            ID = part.ID,
            Model = newAC.model,
            Brand = newAC.brand,
            Series = newAC.series,

            Fan_Size = newAC.fan_size,
            Compatibility = newAC.chipset,
            Fan_RPM = newAC.fan_rpm,
            Air_Flow = newAC.air_flow,
            Noise_Level = newAC.noise_level,
            Power_Connector = newAC.power_connector,
            Colour = newAC.colour,
            Materials = newAC.materials,
            Length = newAC.length,
            Height = newAC.height,
            Width = newAC.width,
            Features = newAC.features,
            Warranty = newAC.warranty,
            Weight = newAC.weight,
            PartsStock = part
            
        };

        
        db.PartsStocks.InsertOnSubmit(part);
        db.AirCoolers.InsertOnSubmit(AC);
        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        


        //Check for the compatible chipsets
        String str = AC.Compatibility;
        char[] seperator = { ',', ' ' };
        String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        String chip = null;

        for (int i = 0; i < strList.Length; i++)
        {
            chip = strList[i];
            dynamic cpuList = (from c in db.CPUs where c.Chipset.Equals(chip) select c).ToList();
            
            foreach (CPU c in cpuList)
            {
                bool link = linkAcToCPU(c.ID, AC.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }
        return true;
    }

    //Adding new Pc Case
    public bool addCase(cCase newCase, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newCase.model,
            Type = "Case",
            Quantity = qua,
            Price = (decimal)newCase.price,
            Active = newCase.active,
            Discount = newCase.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var Case = new PCCase
        {
            ID = part.ID,
            Model = newCase.model,
            Brand = newCase.brand,
            Series = newCase.series,
            Colour = newCase.colour,
            Dimensions = newCase.dimensions,
            Net_Weight = newCase.net_weight,
            Motherboard_Form_Factor = newCase.mobo_form_factor,
            Side_Window = newCase.side_window,
            Num_Front_Fans = newCase.num_front_fans,
            Num_Back_Fans = newCase.num_back_fans,
            Num_Top_Fans = newCase.num_top_fans,
            Num_Bottom_Fans = newCase.num_bottom_fans,
            Top_Radiator_Support = newCase.top_rad_length,
            Front_Radiator_Support = newCase.front_rad_length,
            GPU_Max_Length = newCase.gpu_max_length,
            Expansion_Slots = newCase.expansion_slots,
            Front_I_O = newCase.front_io,
            CPU_Cooler_Height = newCase.cpu_cooler_max_height,
            Warranty = newCase.warranty,
            PartsStock = part,
            Num_HDD_Drives = Convert.ToString(newCase.num_hdd_drives),
            Num_SSD_Drives = Convert.ToString(newCase.num_ssd_drives)
            
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.PCCases.InsertOnSubmit(Case);
        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }


        //Check for the compatible form Factors
        String ff = Case.Motherboard_Form_Factor;

        dynamic moboList = (from c in db.Motherboards where (c.Form_Factor).Equals(ff) select c);

        foreach (Motherboard m in moboList)
        {
            bool link = linkMoboToCase(m.ID, Case.ID);
            if (link == false)
            {
                return false;
            }
        }

        return true;
        
    }

    //Adding new CPU
    public bool addCPU(cCPU newCPU, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newCPU.model,
            Type = "CPU",
            Quantity = qua,
            Price = (decimal)newCPU.price,
            Active = newCPU.active,
            Discount = newCPU.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var cpu = new CPU
        {
            ID = part.ID,
            Model = newCPU.model,
            Brand = newCPU.brand,
            Series = newCPU.series,
            Cores = newCPU.cores,
            Threads = newCPU.threads,
            Base_Clock = newCPU.base_clock,
            Boost_Clock = newCPU.boost_clock,
            Total_Cache = newCPU.total_cache,
            TDP = Convert.ToString(newCPU.tdp),
            Max_Temp = newCPU.max_temp,
            System_Memory_Speed = Convert.ToInt32(newCPU.max_mem_speed),
            System_Memory_Type = newCPU.mem_type,
            Memory_Channels = newCPU.mem_channels,
            Warranty = newCPU.warranty,
            Chipset = newCPU.Chipset,
            PartsStock = part
        };


        db.PartsStocks.InsertOnSubmit(part);
        db.CPUs.InsertOnSubmit(cpu);
        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }


        //Check for the compatible chipsets
        dynamic ACList = (from c in db.AirCoolers select c);

        foreach (AirCooler ac in ACList)
        {
            String str = ac.Compatibility;
            char[] seperator = { ',', ' ' };
            String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            String chip = null;

            for (int i = 0; i < strList.Length; i++)
            {
                chip = strList[i];
                bool link = linkAcToCPU(ac.ID, cpu.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        dynamic LCList = (from c in db.LiquidCoolers select c);

        foreach (LiquidCooler lc in LCList)
        {
            String str = lc.Sockets_Supported;
            char[] seperator = { ',', ' ' };
            String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            String chip = null;

            for (int i = 0; i < strList.Length; i++)
            {
                chip = strList[i];
                bool link = linkLcToCPU(lc.ID, cpu.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        //Motherboard Copatability
        dynamic moboList = (from c in db.Motherboards where (cpu.Chipset).Equals(c.Chipset) select c);

        foreach (Motherboard c in moboList)
        {
            bool link = linkMoboToCPU(c.ID, cpu.ID);
            if (link == false)
            {
                continue;
            }
        }
        return true;
        
    }

    //Adding new  Fan
    public bool addFan(cFan newFan, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newFan.model,
            Type = "Fan",
            Quantity = qua,
            Price = (decimal)newFan.price,
            Active = newFan.active,
            Discount = newFan.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var fan = new Fan
        {
            ID = part.ID,
            Model = newFan.model,
            Brand = newFan.brand,
            Series = newFan.series,
            Size = newFan.size,
            RPM = newFan.rpm,
            Max_Air_Flow = newFan.max_air_flow,
            Noise = newFan.noise,
            Static_Pressure = newFan.static_pressure,
            Input_Voltage = newFan.input_voltage,
            MTBF = newFan.mtbf,
            Cable_Length = newFan.cable_length,
            Num_Fans = newFan.num_fans,
            Warranty = newFan.warranty,
            PartsStock = part
        };
        db.PartsStocks.InsertOnSubmit(part);
        db.Fans.InsertOnSubmit(fan);
        

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new GPU
    public bool addGPU(cGPU newGPU, int qua, decimal price, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newGPU.model,
            Type = "GPU",
            Quantity = qua,
            Price = (decimal)price,
            Active = newGPU.active,
            Discount = newGPU.discount,
            Image = image,
            
        };

        //Add new Part to its respective Table
        var gpu = new GPU
        {
            Manufacturer = newGPU.manufacturer,
            ID = part.ID,
            Model = newGPU.model,
            Brand = newGPU.brand,
            Series = newGPU.series,
            Base_Clock_Speed = newGPU.base_clock,
            Boost_Clock_Speed = newGPU.boost_clock,
            Stream_Processors = newGPU.stream_proccessors,
            Memory_Clock = newGPU.mem_speed,
            Memory_Size = newGPU.mem_size,
            Memory_Type = newGPU.mem_type,
            Ports = newGPU.ports,
            Max_Digital_Resolution = newGPU.max_resolution,
            VR_Ready = newGPU.vr_ready,
            Recommended_Power_Supply = newGPU.recommended_psu_power,
            Form_Factor = newGPU.form_factor,
            Slot_Width = newGPU.slot_width,
            Length = Convert.ToString(newGPU.length),
            Height = Convert.ToString(newGPU.height),
            Warranty = newGPU.warranty,
            PartsStock = part

        };

        db.GPUs.InsertOnSubmit(gpu);
        db.PartsStocks.InsertOnSubmit(part);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new HDD
    public bool addHDD(cHDD newHDD, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newHDD.model,
            Type = "HDD",
            Quantity = qua,
            Price = (decimal)newHDD.price,
            Active = newHDD.active,
            Discount = newHDD.discount,
            Image= image
        };

        //Add new Part to its respective Table
        var hdd = new HDD
        {
            ID = part.ID,
            Model = newHDD.model,
            Brand = newHDD.brand,
            Series = newHDD.series,
            Interface = newHDD.interface_type,
            Max_Sustained_Transfer_Rate = newHDD.max_sustained_transfer_rate,
            Rotational_Speed = newHDD.rotational_speed,
            Load_Unload_Cycles = newHDD.load_unload_cycles,
            Power_Usage = newHDD.avg_power_usage,
            Operating_Temp = newHDD.operation_temp,
            Size = newHDD.size,
            Weight = newHDD.weight,
            Warranty = newHDD.warranty,
            Storage = newHDD.storage,
            Workload_Rate_Limit = newHDD.Workload_Rate_Limit,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.HDDs.InsertOnSubmit(hdd);
        

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Add new Headset
    public bool addHeadset(cHeadset newHeadset, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newHeadset.model,
            Type = "Headset",
            Quantity = qua,
            Price = (decimal)newHeadset.price,
            Active = newHeadset.active,
            Discount = newHeadset.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Headset temp = new Headset
        {
            ID = part.ID,
            Model = newHeadset.model,
            Brand = newHeadset.brand,
            Series = newHeadset.series,
            Cable_Length = newHeadset.cable_length,
            Connector = newHeadset.connector,
            Frequency_Response = newHeadset.frequency_response,
            Microphone = newHeadset.microphone,
            MP_Frequency_Response = newHeadset.mp_frequency_response,
            MP_Pickup_Pattern = newHeadset.mp_pickup_pattern,
            MP_Sensitivity = newHeadset.mp_sensitivity,
            Colour = newHeadset.colour,
            Wearing_Style = newHeadset.wearing_style,
            Warranty = newHeadset.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Headsets.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Add new Keyboard
    public bool addKeyboard(cKeyboard newKeyboard, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newKeyboard.model,
            Type = "Keyboard",
            Quantity = qua,
            Price = (decimal)newKeyboard.price,
            Active = newKeyboard.active,
            Discount = newKeyboard.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Keyboard temp = new Keyboard
        {
            ID = part.ID,
            Model = newKeyboard.model,
            Brand = newKeyboard.brand,
            Series = newKeyboard.series,
            Switches = newKeyboard.switches,
            Programmable_Macros = newKeyboard.programmable_macros,
            Connector = newKeyboard.connector,
            LED_BackLight = newKeyboard.led_backlight,
            Multimedia_Keys = newKeyboard.multimedia_keys,
            Material = newKeyboard.material,
            Dimensions = newKeyboard.dimensions,
            Weight = newKeyboard.weight,
            Warranty = newKeyboard.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Keyboards.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new Liquid Cooler
    public bool addLiquidCooler(cLiquidCooler newLC, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newLC.model,
            Type = "LiquidCooler",
            Quantity = qua,
            Price = (decimal)newLC.price,
            Active = newLC.active,
            Discount = newLC.discount  ,
            Image = image
        };

        //Add new Part to its respective Table
        var LC = new LiquidCooler
        {
            ID = part.ID,
            Model = newLC.model,
            Brand = newLC.brand,
            Series = newLC.series,
            Sockets_Supported = newLC.sockets,
            Fan_Size = newLC.fan_size,
            Color = newLC.color,
            Radiator_Mats = newLC.rad_mats,
            Radiator_Length = newLC.rad_length,
            Radiator_Height = newLC.rad_height,
            Radiator_Width = newLC.rad_width,
            Tube_Length = newLC.tube_length,
            Tube_Mats = newLC.tube_mats,
            RGB = newLC.rgb,
            Warranty = newLC.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.LiquidCoolers.InsertOnSubmit(LC);
        

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }


        //Check for the compatible chipsets
        String str = LC.Sockets_Supported;
        char[] seperator = { ',', ' ' };
        String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        String chip = null;

        for (int i = 0; i < strList.Length; i++)
        {
            chip = strList[i];
            dynamic cpuList = (from c in db.CPUs where c.Chipset.Equals(chip) select c);

            foreach (CPU c in cpuList)
            {
                bool link = linkLcToCPU(c.ID, LC.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        return true;
    }

    //Adding new Microphone
    public bool addMicrophone(cMicrophone newMicrophone, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMicrophone.model,
            Type = "Microphone",
            Quantity = qua,
            Price = (decimal)newMicrophone.price,
            Active = newMicrophone.active,
            Discount = newMicrophone.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Microphone temp = new Microphone
        {
            ID = part.ID,
            Model = newMicrophone.model,
            Brand = newMicrophone.brand,
            Series = newMicrophone.series,
            Pick_Up_Pattern = newMicrophone.pick_up_pattern,
            Frequency_Response = newMicrophone.frequency_response,
            Sensitivity = newMicrophone.sensitivity,
            Cable_Length = newMicrophone.cable_length,
            Warranty = newMicrophone.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Microphones.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new Motherboard
    public bool addMobo(cMobo newMobo, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMobo.model,
            Type = "Motherboard",
            Quantity = qua,
            Price = (decimal)newMobo.price,
            Active = newMobo.active,
            Discount = newMobo.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var mobo = new Motherboard
        {
            ID = part.ID,
            Model = newMobo.model,
            Brand = newMobo.brand,
            Series = newMobo.series,
            Chipset = newMobo.chipset,
            Memory_Type = newMobo.memoryType,
            Max_Memory_Size = newMobo.max_mem_size,
            Max_Memory_Speed = newMobo.max_mem_speed,
            LAN = newMobo.lan,
            Expansion_Slots = newMobo.expansion_slots,
            Storage = newMobo.storage,
            Internal_I_O_Connectors = newMobo.internal_IO,
            Back_Panel_Connectors = newMobo.back_panel_IO,
            OS_Support = newMobo.os_support,
            Form_Factor = newMobo.form_factor,
            Notes = newMobo.notes,
            Warranty = newMobo.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Motherboards.InsertOnSubmit(mobo);
        

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        //Check for the compatible Parts

        //Cases
        dynamic CaseList = (from c in db.PCCases where c.Motherboard_Form_Factor.Equals(mobo.Form_Factor) select c);

        foreach (PCCase c in CaseList)
        {
            bool link = linkMoboToCase(mobo.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        //RAM
        dynamic RamList = (from c in db.RAMs where ((Convert.ToInt32(c.Capacity)<=mobo.Max_Memory_Size) && c.Type.Equals(mobo.Memory_Type)) select c);

        foreach (RAM c in RamList)
        {
            bool link = linkMoboToCase(mobo.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        //CPU
        dynamic CpuList = (from c in db.CPUs where c.Chipset.Equals(mobo.Chipset) select c);

        foreach (CPU c in CpuList)
        {
            bool link = linkMoboToCase(mobo.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        return true;
    }

    
    //Add new Monitor
    public bool addMonitor(cMonitor newMonitor, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMonitor.model,
            Type = "Monitor",
            Quantity = qua,
            Price = (decimal)newMonitor.price,
            Active = newMonitor.active,
            Discount = newMonitor.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Monitor temp = new Monitor
        {
            ID = part.ID,
            Model = newMonitor.model,
            Brand = newMonitor.brand,
            Series = newMonitor.series,
            ScreenSize = newMonitor.screen_size,
            ScreenRatio = newMonitor.screen_ratio,
            Brightness = newMonitor.brightness,
            ContrastRatio = newMonitor.contrast_ratio,
            ViewingAngle = newMonitor.viewing_angle,
            ResponseTime = newMonitor.response_time,
            Panel_Type = newMonitor.panel_type,
            RefreshRate = newMonitor.refresh_rate,
            Resolution = newMonitor.resolution,
            Colours = newMonitor.colours,
            DisplayPortInput = newMonitor.display_port,
            HDMI = newMonitor.hdmi,
            VGA = newMonitor.vga,
            Speakers = newMonitor.speakers,
            Swivel = newMonitor.swivel,
            Tilt = newMonitor.tilt,
            Pivot = newMonitor.pivot,
            Warranty = newMonitor.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Monitors.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Add new Mouse
    public bool addMouse(cMouse newMouse, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMouse.model,
            Type = "Mouse",
            Quantity = qua,
            Price = (decimal)newMouse.price,
            Active = newMouse.active,
            Discount = newMouse.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Mouse temp = new Mouse
        {
            ID = part.ID,
            Model = newMouse.model,
            Brand = newMouse.brand,
            Series = newMouse.series,
            Sensor = newMouse.sensor,
            Resolution = newMouse.resolution,
            Max_Acceleration = newMouse.max_acceleration,
            Max_Speed = newMouse.max_speed,
            Connection_Type = newMouse.connection_type,
            PTFE_Feet = newMouse.ptfe_feet,
            Battery = newMouse.battery,
            Dimensions = newMouse.dimensions,
            Weight = newMouse.weight,
            Cable_Length = newMouse.cable_length,
            Warranty = newMouse.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Mouses.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Add new Mousepad
    public bool addMousepad(cMousePad newMousepad, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMousepad.model,
            Type = "Mousepad",
            Quantity = qua,
            Price = (decimal)newMousepad.price,
            Active = newMousepad.active,
            Discount = newMousepad.discount,
            Image = image
        };

        //Add new Part to its respective Table
        MousePad temp = new MousePad
        {
            ID = part.ID,
            Model = newMousepad.model,
            Brand = newMousepad.brand,
            Series = newMousepad.series,
            Colour = newMousepad.colour,
            Materials = newMousepad.materials,
            Base = newMousepad.pad_base,
            Dimensions = newMousepad.dimensions,
            Warranty = newMousepad.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.MousePads.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new OS
    public bool addOS(cOS newOS, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newOS.model,
            Type = "OS",
            Quantity = qua,
            Price = (decimal)newOS.price,
            Active = newOS.active,
            Discount = newOS.discount,
            Image = image
        };

        //Add new Part to its respective Table
        OperatingSystem temp = new OperatingSystem
        {
            ID = part.ID,
            Model = newOS.model,
            Brand = newOS.brand,
            Series = newOS.series,
            Bit_Version = newOS.bit_version,
            OS_Version = newOS.os_version,
            System_Requirements = newOS.system_requirements,
            Warranty = newOS.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.OperatingSystems.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new PSU
    public bool addPSU(cPSU newPSU, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newPSU.model,
            Type = "PSU",
            Quantity = qua,
            Price = (decimal)newPSU.price,
            Active = newPSU.active,
            Discount = newPSU.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var psu = new PSU
        {
            ID = part.ID,
            Model = newPSU.model,
            Brand = newPSU.brand,
            Series = newPSU.series,
            Power = newPSU.Power,
            Certification = newPSU.certification,
            Modular = newPSU.modular,
            Connectors = newPSU.connectors,
            MTBF = newPSU.mtbf,
            Fan_Size = newPSU.fan_size,
            Cables = newPSU.cables,
            Dimensions = newPSU.dimensions,
            Warranty = newPSU.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.PSUs.InsertOnSubmit(psu);
        

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new RAM
    public bool addRAM(cRAM newRAM, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newRAM.model,
            Type = "RAM",
            Quantity = qua,
            Price = (decimal)newRAM.price,
            Active = newRAM.active,
            Discount = newRAM.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var ram = new RAM
        {
            ID = part.ID,
            Model = newRAM.model,
            Brand = newRAM.brand,
            Series = newRAM.series,
            Capacity = newRAM.capacity,
            Type = newRAM.type,
            Speed = newRAM.speed,
            Latency = newRAM.latency,
            Voltage = newRAM.voltage,
            Channel_Config = newRAM.channel_config,
            Height = newRAM.height,
            Warranty = newRAM.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.RAMs.InsertOnSubmit(ram);

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        //RAM Copatability
        dynamic moboList = (from c in db.Motherboards where ((Convert.ToInt32(ram.Capacity) <= c.Max_Memory_Size) && ram.Type.Equals(c.Memory_Type)) select c);

        foreach (Motherboard c in moboList)
        {
            bool link = linkMoboToRAM(c.ID, ram.ID);
            if (link == false)
            {
                continue;
            }
        }

        return true;

        
    }

    //Adding new SSD
    public bool addSSD(cSSD newSSD, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newSSD.model,
            Type = "SSD",
            Quantity = qua,
            Price = (decimal)newSSD.price,
            Active = newSSD.active,
            Discount = newSSD.discount,
            Image = image
        };

        //Add new Part to its respective Table
        var ssd = new SSD
        {
            ID = part.ID,
            Model = newSSD.model,
            Brand = newSSD.brand,
            Series = newSSD.series,
            Form_Factor = newSSD.form_factor,
            Capacity = newSSD.capacity,
            Interface_Type = newSSD.interface_type,
            Length = newSSD.length,
            Width = newSSD.width,
            Max_Sequential_Read = newSSD.max_seq_read,
            Max_Sequential_Write = newSSD.max_seq_write,
            Random_Read = newSSD.random_read,
            Random_Write = newSSD.random_write,
            MTBF = newSSD.mtbf,
            Operating_Temp = newSSD.operating_temp,
            Max_Power_Usage = newSSD.max_power_usage,
            Warranty = newSSD.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.SSDs.InsertOnSubmit(ssd);
        

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //
    public bool addSpeaker(cSpeaker newSpeaker, int qua, string image)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newSpeaker.model,
            Type = "Speaker",
            Quantity = qua,
            Price = (decimal)newSpeaker.price,
            Active = newSpeaker.active,
            Discount = newSpeaker.discount,
            Image = image
        };

        //Add new Part to its respective Table
        Speaker temp = new Speaker
        {
            ID = part.ID,
            Model = newSpeaker.model,
            Brand = newSpeaker.brand,
            Satellite_Dimensions = newSpeaker.satellite_dimensions,
            Satellite_Weight = newSpeaker.satellite_weight,
            SubWoofer_Dimensions = newSpeaker.subwoofer_dimensions,
            SubWoofer_Weight = newSpeaker.subwoofer_weight,
            controls = newSpeaker.controls,
            System_Requirements = newSpeaker.system_requirements,
            Features = newSpeaker.features,
            Warranty = newSpeaker.warranty,
            PartsStock = part
        };

        db.PartsStocks.InsertOnSubmit(part);
        db.Speakers.InsertOnSubmit(temp);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    //Adding new PC
    public bool addPC(cPC newPC, int qua, string image)
    {
        //Add new part to PartsStock table
        var temp = new PcStock
        {
            PC_Type = newPC.type,
            Quantity = qua,
            Price = (decimal)newPC.price,
            Active = newPC.active,
            Discount = newPC.discount,
            Image = image
        };

        db.PcStocks.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }

        //Add new Part to its respective Table
        var pc = new Pc
        {

            PC_ID = db.PcStocks.OrderByDescending(x => x.ID).FirstOrDefault().ID,
            PC_Type = temp.PC_Type,
            Case_ID = Convert.ToInt32(newPC.case_id),
            Mobo_ID = Convert.ToInt32(newPC.mobo_id),
            CPU_ID = Convert.ToInt32(newPC.cpu_id ),
            RAM_ID = Convert.ToInt32(newPC.ram_id),
            GPU_ID = Convert.ToInt32(newPC.gpu_id),
            Cooler_ID = Convert.ToInt32(newPC.cooler_id),
            SSD_ID = Convert.ToInt32(newPC.ssd_id == "" ? "0" : newPC.ssd_id),
            HDD_ID = Convert.ToInt32(newPC.hdd_id == "" ? "0" : newPC.hdd_id),
            PSU_ID = Convert.ToInt32(newPC.psu_id),
            OS_ID = Convert.ToInt32(newPC.os_id),
            Fan_ID = Convert.ToInt32(newPC.fan_id),
            Num_Fans = newPC.num_fans,
            Num_SSD = newPC.num_ssd,
            Num_HDD = newPC.num_hdd,
            Monitor_ID = Convert.ToInt32(newPC.monitor_id == "" ? "0" : newPC.monitor_id),
            Headset_ID = Convert.ToInt32(newPC.headset_id == "" ? "0" : newPC.headset_id),
            Keyboard_ID = Convert.ToInt32(newPC.keyboard_id == "" ? "0" : newPC.keyboard_id),
            Mouse_ID = Convert.ToInt32(newPC.mouse_id == "" ? "0" : newPC.mouse_id),
            Speaker_ID = Convert.ToInt32(newPC.speaker_id == "" ? "0" : newPC.speaker_id),
            Warranty = newPC.warranty
            
        };

        
        db.Pcs.InsertOnSubmit(pc);
        

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }


    //Retrieving Products from the DB

    //One at a time
    //This is the function that the wesite call to retrieve a single Part
    public c_ProductPageInfo getPart(int ID)
    {
        var part = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();

        if(part == null)
        {
            return null;
        }

        c_ProductPageInfo temp = new c_ProductPageInfo()
        {
            ID = part.ID,
            model = part.Model,
            image = part.Image,
            type = part.Type,
            Quantity = part.Quantity,
            active = part.Active,
            discount = part.Discount,
            price = part.Price,
};

        return temp;
    }

    //The following functions are used to retrieve a part from a particular table.
    //For now they are private, but if the getPart() function doesn't work, feel free to make these functions public.
    public cAirCooler getAirCooler(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.AirCoolers where p.ID == ID select p).FirstOrDefault();

        cAirCooler temp = new cAirCooler
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            fan_size = part.Fan_Size,
            chipset = part.Compatibility,
            fan_rpm = part.Fan_RPM,
            air_flow = part.Air_Flow,
            noise_level = part.Noise_Level,
            power_connector = part.Power_Connector,
            colour = part.Colour,
            materials = part.Materials,
            length = part.Length,
            height = part.Height,
            width = part.Width,
            features = part.Features,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            weight = part.Weight
        };

        return temp;
    }

    public cCase getCase(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.PCCases where p.ID == ID select p).FirstOrDefault();

        cCase temp = new cCase
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            colour = part.Colour,
            dimensions = part.Dimensions,
            net_weight = part.Net_Weight,
            mobo_form_factor = part.Motherboard_Form_Factor,
            side_window = part.Side_Window,
            num_front_fans = part.Num_Front_Fans,
            num_back_fans = part.Num_Back_Fans,
            num_top_fans = part.Num_Top_Fans,
            num_bottom_fans = part.Num_Bottom_Fans,
            top_rad_length = part.Top_Radiator_Support,
            front_rad_length = part.Front_Radiator_Support,
            gpu_max_length = part.GPU_Max_Length,
            expansion_slots = part.Expansion_Slots,
            front_io = part.Front_I_O,
            cpu_cooler_max_height = part.CPU_Cooler_Height,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            num_hdd_drives = Convert.ToInt32(part.Num_HDD_Drives),
            num_ssd_drives = Convert.ToInt32(part.Num_SSD_Drives)
        };

        return temp;
    }

    public cCPU getCPU(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.CPUs where p.ID == ID select p).FirstOrDefault();

        cCPU temp = new cCPU
        {
            id = info.ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            cores = part.Cores,
            threads = part.Threads,
            base_clock = part.Base_Clock,
            boost_clock = part.Boost_Clock,
            total_cache = part.Total_Cache,
            tdp = Convert.ToInt32(part.TDP),
            max_temp = part.Max_Temp,
            max_mem_speed = Convert.ToInt32(part.System_Memory_Speed),
            mem_type = part.System_Memory_Type,
            mem_channels = part.Memory_Channels,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            Chipset = part.Chipset
        };

        return temp;
    }

    public cFan getFan(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Fans where p.ID == ID select p).FirstOrDefault();

        cFan temp = new cFan
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            size = part.Size,
            rpm = part.RPM,
            max_air_flow = part.Max_Air_Flow,
            noise = part.Noise,
            static_pressure = part.Static_Pressure,
            input_voltage = part.Input_Voltage,
            mtbf = part.MTBF,
            cable_length = part.Cable_Length,
            num_fans = part.Num_Fans,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cGPU getGPU(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.GPUs where p.ID == ID select p).FirstOrDefault();

        cGPU temp = new cGPU
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            base_clock = part.Base_Clock_Speed,
            boost_clock = part.Boost_Clock_Speed,
            stream_proccessors = part.Stream_Processors,
            mem_speed = part.Memory_Clock,
            mem_size = part.Memory_Size,
            mem_type = part.Memory_Type,
            ports = part.Ports,
            max_resolution = part.Max_Digital_Resolution,
            vr_ready = part.VR_Ready,
            recommended_psu_power = part.Recommended_Power_Supply,
            form_factor = part.Form_Factor,
            slot_width = part.Slot_Width,
            length = part.Length,
            height = part.Height,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            manufacturer = part.Manufacturer
        };

        return temp;
    }

    public cHDD getHDD(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.HDDs where p.ID == ID select p).FirstOrDefault();

        cHDD temp = new cHDD
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            interface_type = part.Interface,
            max_sustained_transfer_rate = part.Max_Sustained_Transfer_Rate,
            rotational_speed = part.Rotational_Speed,
            load_unload_cycles = part.Load_Unload_Cycles,
            avg_power_usage = part.Power_Usage,
            operation_temp = part.Operating_Temp,
            size = part.Size,
            weight = part.Weight,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            storage = part.Storage,
            Workload_Rate_Limit = part.Workload_Rate_Limit
        };

        return temp;
    }

    public cHeadset getHeadset(int ID)
    {
        var part = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();

        var headset = (from p in db.Headsets where p.ID == ID select p).FirstOrDefault();

        cHeadset temp = new cHeadset
        {
            id = headset.ID,
            model = headset.Model,
            brand = headset.Brand,
            series = headset.Series,
            price = (double)part.Price,
            active = part.Active,
            cable_length = headset.Cable_Length,
            connector = headset.Connector,
            frequency_response = headset.Frequency_Response,
            microphone = headset.Microphone,
            mp_frequency_response = headset.MP_Frequency_Response,
            mp_pickup_pattern = headset.MP_Pickup_Pattern,
            mp_sensitivity = headset.MP_Sensitivity,
            colour = headset.Colour,
            warranty = headset.Warranty,
            discount = part.Discount,
            wearing_style = headset.Wearing_Style,
        };

        return temp;
    }

    public cLiquidCooler getLiquidCooler(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.LiquidCoolers where p.ID == ID select p).FirstOrDefault();

        cLiquidCooler temp = new cLiquidCooler
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            sockets = part.Sockets_Supported,
            fan_size = part.Fan_Size,
            color = part.Color,
            rad_mats = part.Radiator_Mats,
            rad_length = part.Radiator_Length,
            rad_height = part.Radiator_Height,
            rad_width = part.Radiator_Width,
            tube_length = part.Tube_Length,
            tube_mats = part.Tube_Mats,
            rgb = part.RGB,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cMobo getMobo(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Motherboards where p.ID == ID select p).FirstOrDefault();

        cMobo temp = new cMobo
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            chipset = part.Chipset,
            memoryType = part.Memory_Type,
            max_mem_size = part.Max_Memory_Size,
            max_mem_speed = part.Max_Memory_Speed,
            lan = part.LAN,
            expansion_slots = part.Expansion_Slots,
            storage = part.Storage,
            internal_IO = part.Internal_I_O_Connectors,
            back_panel_IO = part.Back_Panel_Connectors,
            os_support = part.OS_Support,
            form_factor = part.Form_Factor,
            notes = part.Notes,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            price = Convert.ToDouble(info.Price)
        };

        return temp;
    }

    public cPSU getPSU(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.PSUs where p.ID == ID select p).FirstOrDefault();

        cPSU temp = new cPSU
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            Power = part.Power,
            certification = part.Certification,
            modular = part.Modular,
            connectors = part.Connectors,
            mtbf = part.MTBF,
            fan_size = part.Fan_Size,
            cables = part.Cables,
            dimensions = part.Dimensions,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cRAM getRAM(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.RAMs where p.ID == ID select p).FirstOrDefault();

        cRAM temp = new cRAM
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            capacity = part.Capacity,
            type = part.Type,
            speed = part.Speed,
            latency = part.Latency,
            voltage = part.Voltage,
            channel_config = part.Channel_Config,
            height = part.Height,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cSSD getSSD(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.SSDs where p.ID == ID select p).FirstOrDefault();

        cSSD temp = new cSSD
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            form_factor = part.Form_Factor,
            capacity = part.Capacity,
            interface_type = part.Interface_Type,
            length = part.Length,
            width = part.Width,
            max_seq_read = part.Max_Sequential_Read,
            max_seq_write = part.Max_Sequential_Write,
            random_read = part.Random_Read,
            random_write = part.Random_Write,
            mtbf = part.MTBF,
            operating_temp = part.Operating_Temp,
            max_power_usage = part.Max_Power_Usage,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cKeyboard getKeyboard(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Keyboards where p.ID == ID select p).FirstOrDefault();

        cKeyboard temp = new cKeyboard
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            switches = part.Switches,
            programmable_macros = part.Programmable_Macros,
            connector = part.Connector,
            led_backlight = part.LED_BackLight,
            multimedia_keys = part.Multimedia_Keys,
            material = part.Material,
            dimensions = part.Dimensions,
            weight = part.Weight,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cMicrophone getMicrophone(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Microphones where p.ID == ID select p).FirstOrDefault();

        cMicrophone temp = new cMicrophone
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            pick_up_pattern= part.Pick_Up_Pattern,
            frequency_response= part.Frequency_Response,
            sensitivity= part.Sensitivity,
            cable_length = part.Cable_Length,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cSpeaker getSpeaker(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Speakers where p.ID == ID select p).FirstOrDefault();

        cSpeaker temp = new cSpeaker
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            price = (double)info.Price,
            satellite_dimensions = part.Satellite_Dimensions,
            satellite_weight = part.Satellite_Weight,
            subwoofer_dimensions = part.SubWoofer_Dimensions,
            subwoofer_weight = part.SubWoofer_Weight,
            controls = part.controls,
            system_requirements = part.System_Requirements,
            features = part.Features,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active
        };

        return temp;
    }

    public cMonitor getMonitor(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Monitors where p.ID == ID select p).FirstOrDefault();

        cMonitor temp = new cMonitor
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            screen_size = part.ScreenSize,
            screen_ratio = part.ScreenRatio,
            brightness = part.Brightness,
            contrast_ratio = part.ContrastRatio,
            viewing_angle = part.ViewingAngle,
            response_time = part.ResponseTime,
            panel_type = part.Panel_Type,
            refresh_rate = part.RefreshRate,
            resolution = part.Resolution,
            colours = part.Colours,
            display_port = part.DisplayPortInput,
            hdmi = part.HDMI,
            vga = part.VGA,
            speakers = part.Speakers,
            swivel = part.Swivel,
            tilt = part.Tilt,
            pivot = part.Pivot,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cMouse getMouse(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.Mouses where p.ID == ID select p).FirstOrDefault();

        cMouse temp = new cMouse
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            sensor = part.Sensor,
            resolution = part.Resolution,
            max_acceleration = part.Max_Acceleration,
            max_speed = part.Max_Speed,
            connection_type = part.Connection_Type,
            ptfe_feet = part.PTFE_Feet,
            battery = part.Battery,
            dimensions = part.Dimensions,
            weight = part.Weight,
            cable_length = part.Cable_Length,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }

    public cMousePad getMousepad(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.MousePads where p.ID == ID select p).FirstOrDefault();

        cMousePad temp = new cMousePad
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)info.Price,
            colour = part.Colour,
            materials = part.Materials,
            pad_base = part.Base,
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active,
            dimensions = part.Dimensions,
        };

        return temp;
    }

    public cPC intgetPC(int ID)
    {
        var info = (from p in db.PcStocks where p.ID == ID select p).FirstOrDefault();
        var pc = (from p in db.Pcs where p.PC_ID == ID select p).FirstOrDefault();

        cPC temp = new cPC
        {
            id = pc.PC_ID,
            type = pc.PC_Type,
            price = (double)info.Price,
            case_id = Convert.ToString(pc.Case_ID),
            mobo_id = Convert.ToString(pc.Mobo_ID),
            cpu_id = Convert.ToString(pc.CPU_ID),
            ram_id = Convert.ToString(pc.RAM_ID),
            gpu_id = Convert.ToString(pc.GPU_ID),
            cooler_id = Convert.ToString(pc.Cooler_ID),
            ssd_id = Convert.ToString(pc.SSD_ID),
            hdd_id = Convert.ToString(pc.HDD_ID),
            psu_id = Convert.ToString(pc.PSU_ID),
            os_id = Convert.ToString(pc.OS_ID),
            fan_id = Convert.ToString(pc.Fan_ID),
            num_fans = pc.Num_Fans,
            num_ssd = pc.Num_SSD,
            num_hdd = pc.Num_HDD,
            monitor_id = Convert.ToString(pc.Monitor_ID),
            headset_id = Convert.ToString(pc.Headset_ID),
            keyboard_id = Convert.ToString(pc.Keyboard_ID),
            mouse_id = Convert.ToString(pc.Mouse_ID),
            speaker_id = Convert.ToString(pc.Speaker_ID),
            warranty = pc.Warranty,
            discount = info.Discount,
            active = info.Active,
            
        };

        return temp;
    }



    public c_PcPageInfo getPcInfo(int ID)
    {
        var part = (from p in db.PcStocks where p.ID == ID select p).FirstOrDefault();

        c_PcPageInfo temp = new c_PcPageInfo()
        {
            ID = part.ID,
            image = part.Image,
            type = part.PC_Type,
            Quantity = part.Quantity,
            active = part.Active,
            discount = part.Discount,
            price = part.Price,
            
        };

        return temp;
    }

    //Return Compatable Parts
    public List<c_ProductPageInfo> getAirCoolersForCPU(int cpu_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compACList = (from c in db.CpuToAirCoolers where c.CPU_ID == cpu_ID select c);

        foreach(CpuToAirCooler compAC in compACList)
        {
            var part = getPart(compAC.AC_ID);
            
            list.Add(part);
        }

        return list;
    }
     
    public List<c_ProductPageInfo> getLiquidCoolersForCPU(int cpu_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compLCList = (from c in db.CpuToLiquidCoolers where c.CPU_ID == cpu_ID select c);

        foreach (CpuToLiquidCooler compLC in compLCList)
        {
            var part = getPart(compLC.LC_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getCPUForAirCooler(int ac_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compACList = (from c in db.CpuToAirCoolers where c.AC_ID == ac_ID select c);

        foreach (CpuToAirCooler compCPU in compACList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getCPUForLiquidCooler(int lc_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compLCList = (from c in db.CpuToLiquidCoolers where c.LC_ID == lc_ID select c);

        foreach (CpuToLiquidCooler compCPU in compLCList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getCPUForMotherboard(int mobo_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compCPUList = (from c in db.MoboToCpus where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToCpu compCPU in compCPUList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getCaseForMotherboard(int mobo_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compCaseList = (from c in db.MoboToCases where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToCase compCase in compCaseList)
        {
            var part = getPart(compCase.Case_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getRAMForMotherboard(int mobo_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();
        dynamic compRAMList = (from c in db.MoboToRams where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToRam compRAM in compRAMList)
        {
            var part = getPart(compRAM.RAM_ID);
            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getMotherboardForCPU(int cpu_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compMoboList = (from c in db.MoboToCpus where c.CPU_ID == cpu_ID select c);

        foreach (MoboToCpu compMobo in compMoboList)
        {
            var part = getPart(compMobo.Mobo_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getMotherboardForRAM(int ram_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compMoboList = (from c in db.MoboToRams where c.RAM_ID == ram_ID select c);

        foreach (MoboToRam compMobo in compMoboList)
        {
            var part = getPart(compMobo.Mobo_ID);

            list.Add(part);
        }

        return list;
    }

    public List<c_ProductPageInfo> getMotherboardForCase(int case_ID)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();

        dynamic compMoboList = (from c in db.MoboToCases where c.Case_ID == case_ID select c);

        foreach (MoboToCase compMobo in compMoboList)
        {
            var part = getPart(compMobo.Mobo_ID);

            list.Add(part);
        }

        return list;
    }


    //Return Entire Table
    public List<cAirCooler> getAllAirCooler()
    {

        List<cAirCooler> list = new List<cAirCooler>();
        List<int> ids = db.AirCoolers.Select(x => x.ID).ToList();
        
        foreach (int p in ids) {
            cAirCooler part = getAirCooler(p);
            
            list.Add(part);
        }

        return list;
    }

    public List<cCase> getAllCase()
    {
        List<cCase> list = new List<cCase>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("Case") select p);

        foreach (PartsStock p in parts)
        {
            cCase part = getCase(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCPU> getAllCPU()
    {
        List<cCPU> list = new List<cCPU>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("CPU") select p);

        foreach (PartsStock p in parts)
        {
            cCPU part = getCPU(p.ID);
            
            list.Add(part);
        }
        return list;
    }

    public List<cFan> getAllFan()
    {
        List<cFan> list = new List<cFan>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("Fan") select p);

        foreach (PartsStock p in parts)
        {
            cFan part = getFan(p.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cGPU> getAllGPU()
    {
        List<cGPU> list = new List<cGPU>();
        List<int> parts = db.GPUs.Select(x => x.ID).ToList();

        foreach (int p in parts) {
            cGPU part = getGPU(p);
            
            list.Add(part);
        }

        return list;
    }

    public List<cHDD> getAllHDD()
    {
        List<cHDD> list = new List<cHDD>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("HDD") select p);

        foreach (PartsStock p in parts)
        {
            cHDD part = getHDD(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cHeadset> getAllHeadset()
    {
        List<cHeadset> list = new List<cHeadset>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Headset") select h);

        foreach(PartsStock hs in headsetList)
        {
            cHeadset temp = getHeadset(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cMouse> getAllMouse()
    {
        List<cMouse> list = new List<cMouse>();

        dynamic mouseList = (from h in db.PartsStocks where h.Type.Equals("Mouse") select h);

        foreach (PartsStock hs in mouseList)
        {
            cMouse temp = getMouse(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cMousePad> getAllMousepad()
    {
        List<cMousePad> list = new List<cMousePad>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Mousepad") select h);

        foreach (PartsStock hs in headsetList)
        {
            cMousePad temp = getMousepad(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cKeyboard> getAllKeyboard()
    {
        List<cKeyboard> list = new List<cKeyboard>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Keyboard") select h);

        foreach (PartsStock hs in headsetList)
        {
            cKeyboard temp = getKeyboard(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cSpeaker> getAllSpeaker()
    {
        List<cSpeaker> list = new List<cSpeaker>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Speaker") select h);

        foreach (PartsStock hs in headsetList)
        {
            cSpeaker temp = getSpeaker(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cMicrophone> getAllMicrophone()
    {
        List<cMicrophone> list = new List<cMicrophone>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Microphone") select h);

        foreach (PartsStock hs in headsetList)
        {
            cMicrophone temp = getMicrophone(hs.ID);

            list.Add(temp);
        }

        return list;
    }

    public List<cMonitor> getAllMonitor()
    {
        List<cMonitor> list = new List<cMonitor>();

        dynamic headsetList = (from h in db.PartsStocks where h.Type.Equals("Monitor") select h);

        foreach (PartsStock hs in headsetList)
        {
            cMonitor temp = getMonitor(hs.ID);

            list.Add(temp);
        }

        return list;
    }



    public List<cLiquidCooler> getAllLiquidCooler()
    {
        List<cLiquidCooler> list = new List<cLiquidCooler>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("LiquidCooler") select p);

        foreach (PartsStock p in parts)
        {
            cLiquidCooler part = getLiquidCooler(p.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cMobo> getAllMobo()
    {
        List<cMobo> list = new List<cMobo>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("Motherboard") select p);

        foreach (PartsStock p in parts)
        {
            cMobo part = getMobo(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cPSU> getAllPSU()
    {
        List<cPSU> list = new List<cPSU>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("PSU") select p);

        foreach (PartsStock p in parts)
        {
            cPSU part = getPSU(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cRAM> getAllRAM()
    {
        List<cRAM> list = new List<cRAM>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("RAM") select p);

        foreach (PartsStock p in parts)
        {
            cRAM part = getRAM(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cSSD> getAllSSD()
    {
        List<cSSD> list = new List<cSSD>();
        dynamic parts = (from p in db.PartsStocks where p.Type.Equals("SSD") select p);

        foreach (PartsStock p in parts)
        {
            cSSD part = getSSD(p.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cPC> getAllPC()
    {
        List<cPC> list = new List<cPC>();
        dynamic pcs = (from p in db.PcStocks select p);

        foreach (PcStock p in pcs)
        {
            cPC pc = intgetPC(p.ID);
            
            list.Add(pc);
        }

        return list;
    }

    public cPCParts getAllPCparts()
    {
        List<cPart> parts = db.PartsStocks.Select(x => new cPart
        {
                 ID = x.ID,
                 type = x.Type,
                 Quantity = x.Quantity,
                 model = x.Model,
                 active = x.Active,
                 discount = x.Discount
        }).ToList();

        cPCParts PCParts = new cPCParts
        {
            Allcase = parts.Where(x => x.type.Equals("Case")).Select(y => y).ToList(),
            AllCooler = parts.Where(x => x.type.Equals("AirCooler") || x.type.Equals("LiquidCooler")).Select(y => y).ToList(),
            AllCPU = parts.Where(x => x.type.Equals("CPU")).Select(y => y).ToList(),
            AllFan = parts.Where(x => x.type.Equals("Fan")).Select(y => y).ToList(),
            AllGPU = parts.Where(x => x.type.Equals("GPU")).Select(y => y).ToList(),
            AllHDD = parts.Where(x => x.type.Equals("HDD")).Select(y => y).ToList(),
            AllHeadset = parts.Where(x => x.type.Equals("Headset")).Select(y => y).ToList(),
            AllKeyboard= parts.Where(x => x.type.Equals("Keyboard")).Select(y => y).ToList(),
            AllMobo = parts.Where(x => x.type.Equals("Motherboard")).Select(y => y).ToList(),
            AllMonitor  = parts.Where(x => x.type.Equals("Monitor")).Select(y => y).ToList(),
            AllMouse  = parts.Where(x => x.type.Equals("Mouse")).Select(y => y).ToList(),
            AllOS = parts.Where(x => x.type.Equals("OS")).Select(y => y).ToList(),
            AllPSU = parts.Where(x => x.type.Equals("PSU")).Select(y => y).ToList(),
            AllRAM = parts.Where(x => x.type.Equals("RAM")).Select(y => y).ToList(),
            AllSpeaker = parts.Where(x => x.type.Equals("Speaker")).Select(y => y).ToList(),
            AllSSD = parts.Where(x => x.type.Equals("SSD")).Select(y => y).ToList(),
        };
        return PCParts;

                             
    }

    //Return Items Based on parameters
    public List<cPC> getPCbyType(String Type)
    {
        List<cPC> list = new List<cPC>();
        dynamic pcs = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals(Type) select p).FirstOrDefault();

        foreach (PartsStock p in pcs)
        {
            var pc = getPart(pcs.ID);

            cPC temp = new cPC
            {
                id = pc.PC_ID,
                type = pc.PC_Type,
                price = (double)p.Price,
                case_id = Convert.ToString(pc.Case_ID),
                mobo_id = Convert.ToString(pc.Mobo_ID),
                cpu_id = Convert.ToString(pc.CPU_ID),
                ram_id = Convert.ToString(pc.RAM_ID),
                gpu_id = Convert.ToString(pc.GPU_ID),
                cooler_id = Convert.ToString(pc.Cooler_ID),
                ssd_id = Convert.ToString(pc.SSD_ID),
                hdd_id = Convert.ToString(pc.HDD_ID),
                psu_id = Convert.ToString(pc.PSU_ID),
                os_id = Convert.ToString(pc.OS_ID),
                fan_id = Convert.ToString(pc.Fan_ID),
                num_fans = pc.Num_Fans,
                num_ssd = pc.Num_SSD,
                num_hdd = pc.Num_HDD,
                monitor_id = Convert.ToString(pc.Monitor_ID),
                headset_id = Convert.ToString(pc.Headset_ID),
                keyboard_id = Convert.ToString(pc.Keyboard_ID),
                mouse_id = Convert.ToString(pc.Mouse_ID),
                speaker_id = Convert.ToString(pc.Speaker_ID),
                warranty = pc.Warranty,
                discount = p.Discount,
                active = p.Active
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cPC> getPCbyPrice(Double minPrice, Double maxPrice)
    {
        List<cPC> list = new List<cPC>();
        dynamic pcs = (from p in db.PartsStocks where p.Active == 1 select p).FirstOrDefault();

        foreach (PartsStock p in pcs)
        {
            Double price = (Double)p.Price;

            if (price >= minPrice && price <= maxPrice)
            {
                var pc = getPart(pcs.ID);
                cPC temp = new cPC
                {
                    id = pc.PC_ID,
                    type = pc.PC_Type,
                    price = (double)p.Price,
                    case_id = Convert.ToString(pc.Case_ID),
                    mobo_id = Convert.ToString(pc.Mobo_ID),
                    cpu_id = Convert.ToString(pc.CPU_ID),
                    ram_id = Convert.ToString(pc.RAM_ID),
                    gpu_id = Convert.ToString(pc.GPU_ID),
                    cooler_id = Convert.ToString(pc.Cooler_ID),
                    ssd_id = Convert.ToString(pc.SSD_ID),
                    hdd_id = Convert.ToString(pc.HDD_ID),
                    psu_id = Convert.ToString(pc.PSU_ID),
                    os_id = Convert.ToString(pc.OS_ID),
                    fan_id = Convert.ToString(pc.Fan_ID),
                    num_fans = pc.Num_Fans,
                    num_ssd = pc.Num_SSD,
                    num_hdd = pc.Num_HDD,
                    monitor_id = Convert.ToString(pc.Monitor_ID),
                    headset_id = Convert.ToString(pc.Headset_ID),
                    keyboard_id = Convert.ToString(pc.Keyboard_ID),
                    mouse_id = Convert.ToString(pc.Mouse_ID),
                    speaker_id = Convert.ToString(pc.Speaker_ID),
                    warranty = pc.Warranty,
                    discount = p.Discount,
                    active = p.Active
                };

                list.Add(temp);
            }
        }

        return list;
    }

    public cPC getPCbyID(int ID)
    {
        List<cPC> list = new List<cPC>();
        var pc = db.Pcs.Where(x => x.PC_ID.Equals(ID)).FirstOrDefault();
        var part = db.PcStocks.Where(x => x.ID.Equals(ID)).FirstOrDefault();
        cPC temp = new cPC
        {
            id = pc.PC_ID,
            type = pc.PC_Type,
            price = (double)part.Price,
            case_id = Convert.ToString(pc.Case_ID),
            mobo_id = Convert.ToString(pc.Mobo_ID),
            cpu_id = Convert.ToString(pc.CPU_ID),
            ram_id = Convert.ToString(pc.RAM_ID),
            gpu_id = Convert.ToString(pc.GPU_ID),
            cooler_id = Convert.ToString(pc.Cooler_ID),
            ssd_id = Convert.ToString(pc.SSD_ID),
            hdd_id = Convert.ToString(pc.HDD_ID),
            psu_id = Convert.ToString(pc.PSU_ID),
            os_id = Convert.ToString(pc.OS_ID),
            fan_id = Convert.ToString(pc.Fan_ID),
            num_fans = pc.Num_Fans,
            num_ssd = pc.Num_SSD,
            num_hdd = pc.Num_HDD,
            monitor_id = Convert.ToString(pc.Monitor_ID),
            headset_id = Convert.ToString(pc.Headset_ID),
            keyboard_id = Convert.ToString(pc.Keyboard_ID),
            mouse_id = Convert.ToString(pc.Mouse_ID),
            speaker_id = Convert.ToString(pc.Speaker_ID),
            warranty = pc.Warranty,
            discount = part.Discount,
            active = part.Active
        };

        return temp;
    }


    //Add to bridging table
    //Will be implemented if we need them
    private bool linkAcToCPU(int cpu_id, int ac_id)
    {
        CpuToAirCooler temp = new CpuToAirCooler
        {
            CPU_ID = cpu_id,
            AC_ID = ac_id,
        };

        db.CpuToAirCoolers.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    private bool linkLcToCPU(int cpu_id, int lc_id)
    {
        CpuToLiquidCooler temp = new CpuToLiquidCooler
        {
            CPU_ID = cpu_id,
            LC_ID = lc_id,
        };

        db.CpuToLiquidCoolers.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    private bool linkMoboToCase(int mobo_id, int case_id)
    {
        MoboToCase temp = new MoboToCase
        {
            Mobo_ID = mobo_id,
            Case_ID = case_id,
        };

        db.MoboToCases.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    private bool linkMoboToRAM(int mobo_id, int ram_id)
    {
        MoboToRam temp = new MoboToRam
        {
            Mobo_ID = mobo_id,
            RAM_ID = ram_id,
        };

        db.MoboToRams.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    private bool linkMoboToCPU(int mobo_id, int cpu_id)
    {
        MoboToCpu temp = new MoboToCpu
        {
            Mobo_ID = mobo_id,
            CPU_ID = cpu_id,
        };

        db.MoboToCpus.InsertOnSubmit(temp);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }


    //Shopping Cart Operations
    //Part Cart
    public Boolean addToPartCart(int user_ID, int part_ID, int qua, Double total_price) {
        Boolean check = checkPartCart(user_ID, part_ID);
        if (check == false)
        {
            var cartItem = new PartCart
            {
                User_ID = user_ID,
                Part_ID = part_ID,
                Qua = qua,
            };
            db.PartCarts.InsertOnSubmit(cartItem);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public Boolean removeFromPartCart(int user_ID, int part_ID) {
        var part = (from p in db.PartCarts where (p.User_ID == user_ID && p.Part_ID == part_ID) select p).FirstOrDefault();

        if (part != null)
        {
            db.PartCarts.DeleteOnSubmit(part);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public Boolean updatePartCart(int user_ID, int part_ID, int qua)
    {
        var part = (from p in db.PartCarts where (p.User_ID == user_ID && p.Part_ID == part_ID) select p).FirstOrDefault();

        if (part != null)
        {
            part.Qua = qua;
            if (qua.Equals(0))
            {
                db.PartCarts.DeleteOnSubmit(part);
            }
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }


    }

    public Boolean clearPartCart(int user_ID)
    {
        dynamic parts = (from p in db.PartCarts where p.User_ID == user_ID select p);

        foreach (PartCart p in parts)
        {
            db.PartCarts.DeleteOnSubmit(p);
        }

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Boolean checkPartCart(int user_ID, int part_ID)
    {
        var part = (from p in db.PartCarts where (p.User_ID == user_ID && p.Part_ID == part_ID) select p).FirstOrDefault();

        if (part != null) {
            return true;
        }
        else {
            return false;
        }
    }

    //Prebuilt PC Cart
    public Boolean addToPcCart(int user_ID, int pc_ID, int qua, Double total_price)
    {
        Boolean check = checkPcCart(user_ID, pc_ID);
        if (check == false)
        {
            var pc = new PcCart
            {
                User_ID = user_ID,
                Pc_ID = pc_ID,
                Qua = qua,
            };

            db.PcCarts.InsertOnSubmit(pc);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public Boolean removeFromPcCart(int user_ID, int pc_ID)
    {
        var pc = (from p in db.PcCarts where (p.User_ID == user_ID && p.Pc_ID == pc_ID) select p).FirstOrDefault();
        db.PcCarts.DeleteOnSubmit(pc);

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Boolean updatePcCart(int user_ID, int pc_ID, int qua)
    {
        var pc = (from p in db.PcCarts where (p.User_ID == user_ID && p.Pc_ID == pc_ID) select p).FirstOrDefault();
        if (pc != null)
        {
            pc.Qua = qua;

            try
            {
                if (qua.Equals(0))
                {
                    db.PcCarts.DeleteOnSubmit(pc);
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        else
        {
            return false;
        }


    }

    public Boolean clearPcCart(int user_ID)
    {
        dynamic pcs = (from p in db.PcCarts where (p.User_ID == user_ID) select p);
        foreach (PcCart pc in pcs)
        {

            db.PcCarts.DeleteOnSubmit(pc);
        }

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Boolean checkPcCart(int user_ID, int pc_ID)
    {
        var pc = (from p in db.PcCarts where (p.User_ID == user_ID && p.Pc_ID == pc_ID) select p).FirstOrDefault();

        if (pc != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Check out function
    public Boolean checkOut(int user_ID)
    {
        //whatever needs to be done
        //Remove items from carts
        //Generate Invoice
        //dynamic cartPart = (from p in db.PartCarts select p);
        //dynamic cartPC = (from p in db.PcCarts select p);

        //foreach (PartCart p in cartPart)
        //{
            /*var invoicePart = new PartInvoice
            {
                User_ID = p.User_ID,
                Part_ID = p.Part_ID,
                Qua = p.Qua,
            };

            bool sold = addPartSold(p.Part_ID, p.Qua);
            if (sold == true)
            {
                bool reducedStock = reducePcQua(p.Part_ID, p.Qua);
                if (reducedStock == true)
                {
                    db.PartInvoices.InsertOnSubmit(invoicePart);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        foreach (PcCart p in cartPC)
        {
            var invoicePC = new PcInvoice
            {
                User_ID = p.User_ID,
                PC_ID = p.Pc_ID,
                Qua = p.Qua,
                Total_Price = p.Total_Price
            };

            bool sold = addPcSold(p.Pc_ID, p.Qua);
            if (sold == true)
            {
                bool reducedStock = reducePcQua(p.Pc_ID, p.Qua);
                if (reducedStock == true)
                {
                    db.PcInvoices.InsertOnSubmit(invoicePC);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        try
        {
            db.SubmitChanges();

            bool partClear = clearPartCart(user_ID);
            bool pcClear = clearPcCart(user_ID);

            if(partClear == true && pcClear == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        catch
        {*/
            return false;
        //}
    }

    //Reduce Product Quantity
    private Boolean reducePartQua(int part_ID, int qua_sold)
    {
        var part = (from p in db.PartsStocks where p.ID == part_ID select p).FirstOrDefault();

        part.Quantity = part.Quantity - qua_sold;

        db.PartsStocks.InsertOnSubmit(part);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
        
    }

    private Boolean reducePcQua(int pc_ID, int qua_sold)
    {
        var pc = (from p in db.PcStocks where p.ID == pc_ID select p).FirstOrDefault();

        pc.Quantity = pc.Quantity - qua_sold;

        db.PcStocks.InsertOnSubmit(pc);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    //Add Amount Sold
    private Boolean addPartSold(int part_ID, int qua_sold)
    {
        var part = (from p in db.PartsStocks where p.ID==part_ID select p).FirstOrDefault();

        var sold = new PartsSold
        {
            ID = part.ID,
            Model = part.Model,
            Type = part.Type,
            Quantity_Sold = qua_sold
        };
        db.PartsSolds.InsertOnSubmit(sold);

        try
        {
            db.SubmitChanges();
        }
        catch{
            return false;
        }
        return true;
    }

    public List<cAllCart> getCartItems(int user_ID)
    {
        List<cAllCart> partCart = (from part in db.PartsStocks
                                   join cart in db.PartCarts.Where(x => x.User_ID.Equals(user_ID))
                                   on part.ID equals cart.Part_ID
                                   select new cAllCart
                                   {
                                       cart = "part",
                                       description = part.Model + " " + part.Type,
                                       imagelink = part.Image,
                                       part_id = part.ID,
                                       price = part.Price,
                                       discount = part.Discount,
                                       qua = cart.Qua,
                                       user_id = user_ID,
                                       Max_qua = part.Quantity
                                   }).ToList();

        List<cAllCart> pcCart = (from part in db.PcStocks
                                 join cart in db.PcCarts.Where(x => x.User_ID.Equals(user_ID))
                                 on part.ID equals cart.Pc_ID
                                 select new cAllCart
                                 {
                                     cart = "pc",
                                     description = part.PC_Type,
                                     imagelink = part.Image,
                                     part_id = part.ID,
                                     price = part.Price,
                                     discount = part.Discount,
                                     qua = cart.Qua,
                                     user_id = user_ID,
                                     Max_qua = part.Quantity
                                 }).ToList();


        return partCart.Concat(pcCart).ToList();
    }

    public List<c_ProductPageInfo> getAllParts(string type)
    {
        List<c_ProductPageInfo> list = new List<c_ProductPageInfo>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals(type) select p);
        foreach (PartsStock p in parts)
        {
            c_ProductPageInfo product = new c_ProductPageInfo
            {
                ID = p.ID,
                active = p.Active,
                discount = p.Discount,
                image = p.Image,
                model = p.Model,
                Quantity = p.Quantity,
                type = p.Type,
                price = p.Price
            };

            list.Add(product);
        }

        return list;


    }

    public List<c_PcPageInfo> getAllPCInfo(String Type)
    {
        List<c_PcPageInfo> list = new List<c_PcPageInfo>();
        dynamic pcs = (from p in db.PcStocks where p.Active == 1 && p.PC_Type.Equals(Type) select p);

        foreach(PcStock p in pcs)
        {
            c_PcPageInfo temp = new c_PcPageInfo
            {
                ID = p.ID,
                active = p.Active,
                discount = p.Discount,
                image = p.Image,
                Quantity = p.Quantity,
                type = p.PC_Type,
                price = p.Price
            };

            list.Add(temp);
        }

        return list;
    }

    public cClient getClient(int id)
    {
        Client client = db.Clients.Where(x => x.User_ID.Equals(id)).Select(y => y).FirstOrDefault();
        cClient returnClient = new cClient {
            Address = client.Address,
            city = client.City,
            email = client.Email,
            firstName = client.First_Name,
            ID = client.User_ID,
            province = client.Province,
            Surname = client.Surname,
            ZipCode = client.ZIP_Code

        };
        return returnClient;
    }

    public List<cInvoice> getAllInvoices(int UserID)
    {
        List<cInvoice> partInvoices  = db.PartInvoices.Where(x => x.User_ID.Equals(UserID)).Select(y =>new cInvoice{
            date = y.Date,
            InvoiceId = y.Invoice_ID,
            numItems = y.NumProducts,
            pc_ID = y.Part_ID,
            type = "PartInvoice",
            user_ID = UserID
        }).ToList();

        List<cInvoice> pcincoices = db.PcInvoices.Where(x => x.User_ID.Equals(UserID)).Select(y => new cInvoice
        {
            date = y.Date,
            InvoiceId = y.Invoice_ID,
            numItems = y.NumProducts,
            pc_ID = y.Pc_ID,
            type = "PcInvoice",
            user_ID = UserID
        }).ToList();

        return pcincoices.Concat(partInvoices).ToList();
    }

    private int getLastPartInvoiceID()
    {
        var record = db.PartInvoices.OrderByDescending(x => x.Invoice_ID).FirstOrDefault();
        if(record == null)
        {
            return 0;
        }
        else
        {
            return record.Invoice_ID;
        }
    }

    //add from car to partInvoice
    public bool addToPartInvoice(int UserID)
    {
        int InvoiceId = getLastPartInvoiceID() + 1;
        List<cInvoice> partInvoice = (from part in db.PartsStocks
                                   join cart in db.PartCarts.Where(x => x.User_ID.Equals(UserID))
                                   on part.ID equals cart.Part_ID
                                   select new cInvoice
                                   {
                                       user_ID = UserID,
                                       date = DateTime.Now,
                                       numItems = cart.Qua,
                                       pc_ID = part.ID,
                                       type = "PartInvoice"
                                   }).ToList();

        List<PartInvoice> dbInvoice = partInvoice.GroupBy(x => new { x.numItems, x.pc_ID, x.type, x.user_ID, x.date })
            .Select(y => new PartInvoice
            {
                Date = y.Key.date,
                NumProducts = y.Key.numItems,
                Part_ID = y.Key.pc_ID,
                User_ID = y.Key.user_ID,
                Invoice_ID = InvoiceId

            }).ToList();
        if (partInvoice.Count() >= 1)
        {
            db.PartInvoices.InsertAllOnSubmit(dbInvoice);
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }
        }
        return true;

        
    }

    public bool addToPcInvoice(int UserID)
    {
        int InvoiceId = getLastPartInvoiceID() + 1;
        List<cInvoice> pcInvoice = (from part in db.PcStocks
                                     join cart in db.PcCarts.Where(x => x.User_ID.Equals(UserID))
                                     on part.ID equals cart.Pc_ID
                                     select new cInvoice
                                     {
                                         user_ID = UserID,
                                         date = DateTime.Now,
                                         numItems = cart.Qua,
                                         pc_ID = part.ID,
                                         type = "PcInvoice"  
                                     }).ToList();
        List<PcInvoice> dbinvoice = pcInvoice.GroupBy(x => new { x.numItems, x.pc_ID, x.type, x.user_ID, x.date })
            .Select(y => new PcInvoice
            {
                Date = y.Key.date,
                NumProducts = y.Key.numItems,
                Pc_ID = y.Key.pc_ID,
                User_ID = y.Key.user_ID,
                Invoice_ID = InvoiceId
            }).ToList();
        if(pcInvoice.Count() >= 1)
        {
            db.PcInvoices.InsertAllOnSubmit(dbinvoice);
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }
        }
        return true;
    }

 
    public List<cAllCart> getpcinvoice(int InvoiceID)
    {

        List<cAllCart> pcCart = (from inv in db.PcInvoices.Where(y => y.Invoice_ID.Equals(InvoiceID))
                                   join stock in db.PcStocks
                                   on inv.Pc_ID equals stock.ID
                                   select new cAllCart
                                   {
                                       cart = "part",
                                       description = stock.PC_Type,
                                       imagelink = stock.Image,
                                       part_id = stock.ID,
                                       price = stock.Price,
                                       discount = stock.Discount,
                                       qua = inv.NumProducts,
                                       user_id = 0
                                   }).ToList();

        return pcCart;
    }

    public List<cAllCart> getPartInvoice(int InvoiceID)
    {
        List<cAllCart> partCart = (from inv in db.PartInvoices.Where(y => y.Invoice_ID.Equals(InvoiceID))
                                 join stock in db.PartsStocks
                                 on inv.Part_ID equals stock.ID
                                 select new cAllCart
                                 {
                                     cart = "part",
                                     description = stock.Model + " " + stock.Type,
                                     imagelink = stock.Image,
                                     part_id = stock.ID,
                                     price = stock.Price,
                                     discount = stock.Discount,
                                     qua = inv.NumProducts,
                                     user_id = 0
                                 }).ToList();

        return partCart;
    }


    public bool addToPartSold(int UserID)
    {
        List<cPartSold> partSold = (from part in db.PartsStocks
                               join cart in db.PartCarts.Where(x => x.User_ID.Equals(UserID))
                               on part.ID equals cart.Part_ID
                               select new cPartSold { 
                                   Quantity = cart.Qua,
                                   Model = part.Model,
                                   Type = part.Type,
                                   pc_ID = part.ID,
                                   date = DateTime.Now
                               }).ToList();
        PartsSold current;
        foreach (cPartSold item in partSold)
        {
            current = db.PartsSolds.Where(x => x.ID.Equals(item.pc_ID)).Select(y => y).FirstOrDefault();
            if (current == null)
            {
                PartsSold dbSold = new PartsSold
               {
                   ID = item.pc_ID,
                   Model = item.Model,
                   Quantity_Sold = item.Quantity,
                   Type = item.Type,
                   date = item.date
               };

                db.PartsSolds.InsertOnSubmit(dbSold);
            }
            else
            {
                current.Quantity_Sold += item.Quantity;
            }
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }
        }
        return true;
    }

    public bool addToPcSold(int UserID)
    {
        List<cPcSold> pcSold = (from part in db.PcStocks
                                    join cart in db.PcCarts.Where(x => x.User_ID.Equals(UserID))
                                    on part.ID equals cart.Pc_ID
                                    select new cPcSold
                                    {
                                        Quantity = cart.Qua,
                                        Type = part.PC_Type,
                                        pc_ID = part.ID,
                                        date = DateTime.Now
                                    }).ToList();
        PcSold current;
        foreach (cPcSold item in pcSold)
        {
            current = db.PcSolds.Where(x => x.PC_ID.Equals(item.pc_ID)).Select(y => y).FirstOrDefault();
            if (current == null)
            {
                PcSold dbSold = new PcSold
                {
                    PC_ID = item.pc_ID,
                    Quantity_Sold = item.Quantity,
                    Type = item.Type,
                    Date = item.date
                };
                db.PcSolds.InsertOnSubmit(dbSold);
            }
            else
            {
                current.Quantity_Sold += item.Quantity;
            }
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }
        }
        return true;
    }

    public bool decreasePartStock(int userID)
    {
        List<cAllCart> cart =  getCartItems(userID);
        PartsStock pStock;
        foreach (cAllCart item in cart)
        {
            pStock = db.PartsStocks.Where(x => x.ID.Equals(item.part_id)).Select(y => y).FirstOrDefault();
            if(pStock != null)
            {
                pStock.Quantity -= item.qua;
            }
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }

        }
        return true;
       
        
    }

   public bool decreasePcStock(int userID)
   {
        List<cAllCart> cart = getCartItems(userID);
        PcStock pStock;
        foreach (cAllCart item in cart)
        {
            pStock = db.PcStocks.Where(x => x.ID.Equals(item.part_id)).Select(y => y).FirstOrDefault();
            if (pStock != null)
            {
                pStock.Quantity -= item.qua;
            }
            try
            {
                db.SubmitChanges();
            }
            //catch exceptions
            catch (Exception ex)
            {
                //error adding into database
                ex.GetBaseException();
                return false;
            }
        }
        return true;
    }

    public List<cStock> getpartStockStats()
    {
        List<cStock> partStock = db.PartsStocks.Select(x => new cStock
        {
            Name = x.Model + " " + x.Type,
            ProductID = x.ID,
            Quantity = x.Quantity
        }).ToList();
        return partStock;
    }

    public List<cSold> getpartSoldStats()
    {
        List<cSold> partSold = db.PartsSolds.Select(x => new cSold
        {
            Name = x.Model + " " + x.Type,
            ProductID = x.ID,
            Quantity = x.Quantity_Sold,
            date = x.date
        }).ToList();
        return partSold;
    }

    public List<cStock> getpcStockStats()
    {

        List<cStock> pcStock = db.PcStocks.Select(x => new cStock
        {
            Name = x.PC_Type,
            ProductID = x.ID,
            Quantity = x.Quantity

        }).ToList();

        return pcStock;
    }

    public List<cSold> getpcSoldStats()
    {
        List<cSold> pcSold = db.PcSolds.Select(x => new cSold
        {
            Name = x.Type,
            ProductID = x.PC_ID,
            Quantity = x.Quantity_Sold,
            date = x.Date
            

        }).ToList();

        return pcSold;
    }

    public List<cLoginStat> getLoginStats()
    {
        return db.loginStats.Select(x => new cLoginStat
        {
            User_ID = x.User_Id,
            Date = x.Date
        }).ToList();
    }

    public List<cRegisterStat> getRegisterStats()
    {
        return db.RegisterStats.Select(x => new cRegisterStat
        {
            User_ID = x.User_Id,
            Date = x.Date
        }).ToList();
    }

    public bool EditAirCooler(cAirCooler newAC,PartsStock newPart , int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var AC = db.AirCoolers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        
        part.Model = newAC.model;
        part.Type = "AirCooler";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newAC.price;
        part.Active = newAC.active;
        part.Discount = newAC.discount;
        part.Image = newPart.Image;

        AC.ID = part.ID;
        AC.Model = newAC.model;
        AC.Brand = newAC.brand;
        AC.Series = newAC.series;
        AC.Fan_Size = newAC.fan_size;
        AC.Compatibility = newAC.chipset;
        AC.Fan_RPM = newAC.fan_rpm;
        AC.Air_Flow = newAC.air_flow;
        AC.Noise_Level = newAC.noise_level;
        AC.Power_Connector = newAC.power_connector;
        AC.Colour = newAC.colour;
        AC.Materials = newAC.materials;
        AC.Length = newAC.length;
        AC.Height = newAC.height;
        AC.Width = newAC.width;
        AC.Features = newAC.features;
        AC.Warranty = newAC.warranty;
        AC.Weight = newAC.weight;
        AC.PartsStock = part;

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        String str = AC.Compatibility;
        char[] seperator = { ',', ' ' };
        String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        String chip = null;

        for (int i = 0; i < strList.Length; i++)
        {
            chip = strList[i];
            dynamic cpuList = (from c in db.CPUs where c.Chipset.Equals(chip) select c).ToList();

            foreach (CPU c in cpuList)
            {
                bool link = linkAcToCPU(c.ID, AC.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }
        return true;

    }

    public bool DeleteAirCooler(int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var AC = db.AirCoolers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cputoAC = db.CpuToAirCoolers.Where(x => x.AC_ID.Equals(id)).Select(x => x);
        var partsSold = db.PartsSolds.Where(x => x.ID.Equals(id)).Select(x => x);
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }if(cputoAC != null)
        {
            db.CpuToAirCoolers.DeleteAllOnSubmit(cputoAC);
        }
        if (partsSold != null)
        {
            db.PartsSolds.DeleteAllOnSubmit(partsSold);
        }
        db.AirCoolers.DeleteOnSubmit(AC);
        db.PartsStocks.DeleteOnSubmit(part);
        try
        {
            db.SubmitChanges();
            return true;
        }catch(Exception ex)
        {
            ex.GetBaseException();
            return false;
        } 
    }

    public bool EditCase(cCase newCase, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Case = db.PCCases.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mclink = db.MoboToCases.Where(x => x.Case_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        if (mclink != null)
        {
            mclink.Case_ID = id;
        }

        part.Model = newCase.model;
        part.Type = "Case";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newCase.price;
        part.Active = newCase.active;
        part.Discount = newCase.discount;
        part.Image = newPart.Image;

        Case.ID = part.ID;
        Case.Model = newCase.model;
        Case.Brand = newCase.brand;
        Case.Series = newCase.series;
        Case.Colour = newCase.colour;
        Case.Dimensions = newCase.dimensions;
        Case.Net_Weight = newCase.net_weight;
        Case.Motherboard_Form_Factor = newCase.mobo_form_factor;
        Case.Side_Window = newCase.side_window;
        Case.Num_Front_Fans = newCase.num_front_fans;
        Case.Num_Back_Fans = newCase.num_back_fans;
        Case.Num_Top_Fans = newCase.num_top_fans;
        Case.Num_Bottom_Fans = newCase.num_bottom_fans;
        Case.Top_Radiator_Support = newCase.top_rad_length;
        Case.Front_Radiator_Support = newCase.front_rad_length;
        Case.GPU_Max_Length = newCase.gpu_max_length;
        Case.Expansion_Slots = newCase.expansion_slots;
        Case.Front_I_O = newCase.front_io;
        Case.CPU_Cooler_Height = newCase.cpu_cooler_max_height;
        Case.Warranty = newCase.warranty;
        Case.PartsStock = part;
        Case.Num_HDD_Drives = Convert.ToString(newCase.num_hdd_drives);
        Case.Num_SSD_Drives = Convert.ToString(newCase.num_ssd_drives);


        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        String ff = Case.Motherboard_Form_Factor;

        dynamic moboList = (from c in db.Motherboards where (c.Form_Factor).Equals(ff) select c);

        foreach (Motherboard m in moboList)
        {
            bool link = linkMoboToCase(m.ID, Case.ID);
            if (link == false)
            {
                return false;
            }
        }

        return true;
    }

    public bool deleteCase(int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Case = db.PCCases.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.PCCases.DeleteOnSubmit(Case);
        db.PartsStocks.DeleteOnSubmit(part);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditCPU(cCPU newCPU, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var CPU = db.CPUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mclink = db.MoboToCpus.Where(x => x.CPU_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var aclink = db.CpuToAirCoolers.Where(x => x.CPU_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var lclink = db.CpuToLiquidCoolers.Where(x => x.CPU_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        if (mclink != null)
        {
            mclink.CPU_ID = id;
        }
        if (aclink != null)
        {
            aclink.CPU_ID = id;
        }
        if (lclink != null)
        {
            lclink.CPU_ID = id;
        }

        part.Model = newCPU.model;
        part.Type = "CPU";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newCPU.price;
        part.Active = newCPU.active;
        part.Discount = newCPU.discount;
        part.Image = newPart.Image;

        CPU.ID = part.ID;
        CPU.Model = newCPU.model;
        CPU.Brand = newCPU.brand;
        CPU.Series = newCPU.series;
        CPU.Cores = newCPU.cores;
        CPU.Threads = newCPU.threads;
        CPU.Base_Clock = newCPU.base_clock;
        CPU.Boost_Clock = newCPU.boost_clock;
        CPU.Total_Cache = newCPU.total_cache;
        CPU.TDP = Convert.ToString(newCPU.tdp);
        CPU.Max_Temp = newCPU.max_temp;
        CPU.System_Memory_Speed = Convert.ToInt32(newCPU.max_mem_speed);
        CPU.System_Memory_Type = newCPU.mem_type;
        CPU.Memory_Channels = newCPU.mem_channels;
        CPU.Warranty = newCPU.warranty;
        CPU.Chipset = newCPU.Chipset;
        CPU.PartsStock = part;

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        //Check for the compatible chipsets
        dynamic ACList = (from c in db.AirCoolers select c);

        foreach (AirCooler ac in ACList)
        {
            String str = ac.Compatibility;
            char[] seperator = { ',', ' ' };
            String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            String chip = null;

            for (int i = 0; i < strList.Length; i++)
            {
                chip = strList[i];
                bool link = linkAcToCPU(ac.ID, CPU.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        dynamic LCList = (from c in db.LiquidCoolers select c);

        foreach (LiquidCooler lc in LCList)
        {
            String str = lc.Sockets_Supported;
            char[] seperator = { ',', ' ' };
            String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            String chip = null;

            for (int i = 0; i < strList.Length; i++)
            {
                chip = strList[i];
                bool link = linkLcToCPU(lc.ID, CPU.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        //Motherboard Copatability
        dynamic moboList = (from c in db.Motherboards where (CPU.Chipset).Equals(c.Chipset) select c);

        foreach (Motherboard c in moboList)
        {
            bool link = linkMoboToCPU(c.ID, CPU.ID);
            if (link == false)
            {
                continue;
            }
        }
        return true;
    }

    public bool deleteCPU(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.CPUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.CPUs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditFan(cFan newFan, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var fan = db.Fans.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newFan.model;
        part.Type = "Fan";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newFan.price;
        part.Active = newFan.active;
        part.Discount = newFan.discount;
        part.Image = newPart.Image;


        fan.ID = part.ID;
        fan.Model = newFan.model;
        fan.Brand = newFan.brand;
        fan.Series = newFan.series;
        fan.Size = newFan.size;
        fan.RPM = newFan.rpm; 
        fan.Max_Air_Flow = newFan.max_air_flow;
        fan.Noise = newFan.noise;
        fan.Static_Pressure = newFan.static_pressure;
        fan.Input_Voltage = newFan.input_voltage;
        fan.MTBF = newFan.mtbf;
        fan.Cable_Length = newFan.cable_length;
        fan.Num_Fans = newFan.num_fans;
        fan.Warranty = newFan.warranty;
        fan.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteFan(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Fans.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if(cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Fans.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditGPU(cGPU newGPU, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var GPU = db.GPUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newGPU.model;
        part.Type = "GPU";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newGPU.price;
        part.Active = newGPU.active;
        part.Discount = newGPU.discount;
        part.Image = newPart.Image;

        GPU.Manufacturer = newGPU.manufacturer;
        GPU.ID = part.ID;
        GPU.Model = newGPU.model;
        GPU.Brand = newGPU.brand;
        GPU.Series = newGPU.series;
        GPU.Base_Clock_Speed = newGPU.base_clock;
        GPU.Boost_Clock_Speed = newGPU.boost_clock;
        GPU.Stream_Processors = newGPU.stream_proccessors;
        GPU.Memory_Clock = newGPU.mem_speed;
        GPU.Memory_Size = newGPU.mem_size;
        GPU.Memory_Type = newGPU.mem_type;
        GPU.Ports = newGPU.ports;
        GPU.Max_Digital_Resolution = newGPU.max_resolution;
        GPU.VR_Ready = newGPU.vr_ready;
        GPU.Recommended_Power_Supply = newGPU.recommended_psu_power;
        GPU.Form_Factor = newGPU.form_factor;
        GPU.Slot_Width = newGPU.slot_width;
        GPU.Length = Convert.ToString(newGPU.length);
        GPU.Height = Convert.ToString(newGPU.height);
        GPU.Warranty = newGPU.warranty;
        GPU.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteGPU(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.GPUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }

        db.GPUs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditHDD(cHDD newHDD, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var HDD = db.HDDs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newHDD.model;
        part.Type = "HDD";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newHDD.price;
        part.Active = newHDD.active;
        part.Discount = newHDD.discount;
        part.Image = newPart.Image;


        HDD.ID = part.ID;
        HDD.Model = newHDD.model;
        HDD.Brand = newHDD.brand;
        HDD.Series = newHDD.series;
        HDD.Interface = newHDD.interface_type;
        HDD.Max_Sustained_Transfer_Rate = newHDD.max_sustained_transfer_rate;
        HDD.Rotational_Speed = newHDD.rotational_speed;
        HDD.Load_Unload_Cycles = newHDD.load_unload_cycles;
        HDD.Power_Usage = newHDD.avg_power_usage;
        HDD.Operating_Temp = newHDD.operation_temp;
        HDD.Size = newHDD.size;
        HDD.Weight = newHDD.weight;
        HDD.Warranty = newHDD.warranty;
        HDD.Storage = newHDD.storage;
        HDD.Workload_Rate_Limit = newHDD.Workload_Rate_Limit;
        HDD.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteHDD(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.HDDs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.HDDs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditHeadset(cHeadset newHeadset, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var headset = db.Headsets.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newHeadset.model;
        part.Type = "Headset";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newHeadset.price;
        part.Active = newHeadset.active;
        part.Discount = newHeadset.discount;
        part.Image = newPart.Image;


        headset.ID = part.ID;
        headset.Model = newHeadset.model;
        headset.Brand = newHeadset.brand;
        headset.Series = newHeadset.series;
        headset.Cable_Length = newHeadset.cable_length;
        headset.Connector = newHeadset.connector;
        headset.Frequency_Response = newHeadset.frequency_response;
        headset.Microphone = newHeadset.microphone;
        headset.MP_Frequency_Response = newHeadset.mp_frequency_response;
        headset.MP_Pickup_Pattern = newHeadset.mp_pickup_pattern;
        headset.MP_Sensitivity = newHeadset.mp_sensitivity;
        headset.Colour = newHeadset.colour;
        headset.Wearing_Style = newHeadset.wearing_style;
        headset.Warranty = newHeadset.warranty;
        headset.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteHeadset(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Headsets.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Headsets.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditKeyboard(cKeyboard newKeyboard, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Keyboard = db.Keyboards.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }


        part.Model = newKeyboard.model;
        part.Type = "Keyboard";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newKeyboard.price;
        part.Active = newKeyboard.active;
        part.Discount = newKeyboard.discount;
        part.Image = newPart.Image;


        Keyboard.ID = part.ID;
        Keyboard.Model = newKeyboard.model;
        Keyboard.Brand = newKeyboard.brand;
        Keyboard.Series = newKeyboard.series;
        Keyboard.Switches = newKeyboard.switches;
        Keyboard.Programmable_Macros = newKeyboard.programmable_macros;
        Keyboard.Connector = newKeyboard.connector;
        Keyboard.LED_BackLight = newKeyboard.led_backlight;
        Keyboard.Multimedia_Keys = newKeyboard.multimedia_keys;
        Keyboard.Material = newKeyboard.material;
        Keyboard.Dimensions = newKeyboard.dimensions;
        Keyboard.Weight = newKeyboard.weight;
        Keyboard.Warranty = newKeyboard.warranty;
        Keyboard.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteKeyboard(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Keyboards.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Keyboards.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditLiquidCooler(cLiquidCooler newLC, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var liquidCooler = db.LiquidCoolers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mclink = db.CpuToLiquidCoolers.Where(x => x.LC_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        if (mclink != null)
        {
            mclink.LC_ID = id;
        }

        part.Model = newLC.model;
        part.Type = "LiquidCooler";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newLC.price;
        part.Active = newLC.active;
        part.Discount = newLC.discount;
        part.Image = newPart.Image;

        liquidCooler.ID = part.ID;
        liquidCooler.Model = newLC.model;
        liquidCooler.Brand = newLC.brand;
        liquidCooler.Series = newLC.series;
        liquidCooler.Sockets_Supported = newLC.sockets;
        liquidCooler.Fan_Size = newLC.fan_size;
        liquidCooler.Color = newLC.color;
        liquidCooler.Radiator_Mats = newLC.rad_mats;
        liquidCooler.Radiator_Length = newLC.rad_length;
        liquidCooler.Radiator_Height = newLC.rad_height;
        liquidCooler.Radiator_Width = newLC.rad_width;
        liquidCooler.Tube_Length = newLC.tube_length;
        liquidCooler.Tube_Mats = newLC.tube_mats;
        liquidCooler.RGB = newLC.rgb;
        liquidCooler.Warranty = newLC.warranty;
        liquidCooler. PartsStock = part;

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }


        //Check for the compatible chipsets
        String str = liquidCooler.Sockets_Supported;
        char[] seperator = { ',', ' ' };
        String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        String chip = null;

        for (int i = 0; i < strList.Length; i++)
        {
            chip = strList[i];
            dynamic cpuList = (from c in db.CPUs where c.Chipset.Equals(chip) select c);

            foreach (CPU c in cpuList)
            {
                bool link = linkLcToCPU(c.ID, liquidCooler.ID);
                if (link == false)
                {
                    continue;
                }
            }
        }

        return true;
    }

    public bool deleteLiquidCooler(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.LiquidCoolers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.LiquidCoolers.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditMicrophone(cMicrophone newMicrophone, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Micraphone = db.Microphones.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newMicrophone.model;
        part.Type = "Microphone";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newMicrophone.price;
        part.Active = newMicrophone.active;
        part.Discount = newMicrophone.discount;
        part.Image = newPart.Image;

        Micraphone.ID = part.ID;
        Micraphone.Model = newMicrophone.model;
        Micraphone.Brand = newMicrophone.brand;
        Micraphone.Series = newMicrophone.series;
        Micraphone.Pick_Up_Pattern = newMicrophone.pick_up_pattern;
        Micraphone.Frequency_Response = newMicrophone.frequency_response;
        Micraphone.Sensitivity = newMicrophone.sensitivity;
        Micraphone.Cable_Length = newMicrophone.cable_length;
        Micraphone.Warranty = newMicrophone.warranty;
        Micraphone.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }

    public bool deleteMicrophone(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Microphones.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Microphones.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditMobo(cMobo newMobo, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Motherboard = db.Motherboards.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mclink = db.MoboToCases.Where(x => x.Mobo_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mcpulink = db.MoboToCpus.Where(x => x.Mobo_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mrlink = db.MoboToRams.Where(x => x.Mobo_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        if (mclink != null)
        {
            mclink.Mobo_ID = id;
        }
        if (mcpulink != null)
        {
            mcpulink.Mobo_ID = id;
        }
        if (mrlink != null)
        {
            mcpulink.Mobo_ID = id;
        }

        part.Model = newMobo.model;
        part.Type = "Motherboard";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newMobo.price;
        part.Active = newMobo.active;
        part.Discount = newMobo.discount;
        part.Image = newPart.Image;

        Motherboard.ID = part.ID;
        Motherboard.Model = newMobo.model;
        Motherboard.Brand = newMobo.brand;
        Motherboard.Series = newMobo.series;
        Motherboard.Chipset = newMobo.chipset;
        Motherboard.Memory_Type = newMobo.memoryType;
        Motherboard.Max_Memory_Size = newMobo.max_mem_size;
        Motherboard.Max_Memory_Speed = newMobo.max_mem_speed;
        Motherboard.LAN = newMobo.lan;
        Motherboard.Expansion_Slots = newMobo.expansion_slots;
        Motherboard.Storage = newMobo.storage;
        Motherboard.Internal_I_O_Connectors = newMobo.internal_IO;
        Motherboard.Back_Panel_Connectors = newMobo.back_panel_IO;
        Motherboard.OS_Support = newMobo.os_support;
        Motherboard.Form_Factor = newMobo.form_factor;
        Motherboard.Notes = newMobo.notes;
        Motherboard.Warranty = newMobo.warranty;
        Motherboard.PartsStock = part;

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        //Check for the compatible Parts

        //Cases
        dynamic CaseList = (from c in db.PCCases where c.Motherboard_Form_Factor.Equals(Motherboard.Form_Factor) select c);

        foreach (PCCase c in CaseList)
        {
            bool link = linkMoboToCase(Motherboard.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        //RAM
        dynamic RamList = (from c in db.RAMs where ((Convert.ToInt32(c.Capacity) <= Motherboard.Max_Memory_Size) && c.Type.Equals(Motherboard.Memory_Type)) select c);

        foreach (RAM c in RamList)
        {
            bool link = linkMoboToCase(Motherboard.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        //CPU
        dynamic CpuList = (from c in db.CPUs where c.Chipset.Equals(Motherboard.Chipset) select c);

        foreach (CPU c in CpuList)
        {
            bool link = linkMoboToCase(Motherboard.ID, c.ID);
            if (link == false)
            {
                continue;
            }
        }

        return true;

    }

    public bool deleteMobo(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Motherboards.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Motherboards.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditMonitor(cMonitor newMonitor, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var monitor = db.Monitors.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newMonitor.model;
        part.Type = "Monitor";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newMonitor.price;
        part.Active = newMonitor.active;
        part.Discount = newMonitor.discount;
        part.Image = newPart.Image;

        monitor.ID = part.ID;
        monitor.Model = newMonitor.model;
        monitor.Brand = newMonitor.brand;
        monitor.Series = newMonitor.series;
        monitor.ScreenSize = newMonitor.screen_size;
        monitor.ScreenRatio = newMonitor.screen_ratio;
        monitor.Brightness = newMonitor.brightness;
        monitor.ContrastRatio = newMonitor.contrast_ratio;
        monitor.ViewingAngle = newMonitor.viewing_angle;
        monitor.ResponseTime = newMonitor.response_time;
        monitor.Panel_Type = newMonitor.panel_type;
        monitor.RefreshRate = newMonitor.refresh_rate;
        monitor.Resolution = newMonitor.resolution;
           monitor.Colours = newMonitor.colours;
        monitor.DisplayPortInput = newMonitor.display_port;
           monitor.HDMI = newMonitor.hdmi;
        monitor.VGA = newMonitor.vga;
        monitor.Speakers = newMonitor.speakers;
        monitor.Swivel = newMonitor.swivel;
        monitor.Tilt = newMonitor.tilt;
        monitor.Pivot = newMonitor.pivot;
        monitor.Warranty = newMonitor.warranty;
        monitor.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteMonitor(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Monitors.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Monitors.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditMouse(cMouse newMouse, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Mouse = db.Mouses.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newMouse.model;
        part.Type = "Mouse";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newMouse.price;
        part.Active = newMouse.active;
        part.Discount = newMouse.discount;
        part.Image = newPart.Image;

        Mouse.ID = part.ID;
        Mouse.Model = newMouse.model;
        Mouse.Brand = newMouse.brand;
        Mouse.Series = newMouse.series;
        Mouse.Sensor = newMouse.sensor;
        Mouse.Resolution = newMouse.resolution;
        Mouse.Max_Acceleration = newMouse.max_acceleration; 
        Mouse.Max_Speed = newMouse.max_speed;
        Mouse.Connection_Type = newMouse.connection_type;
        Mouse.PTFE_Feet = newMouse.ptfe_feet;
        Mouse.Battery = newMouse.battery;
        Mouse.Dimensions = newMouse.dimensions;
        Mouse.Weight = newMouse.weight;
        Mouse.Cable_Length = newMouse.cable_length;
        Mouse.Warranty = newMouse.warranty;
        Mouse.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteMouse(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Mouses.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Mouses.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditMousepad(cMousePad newMousepad, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var Mousepad = db.MousePads.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newMousepad.model;
        part.Type = "Mousepad";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newMousepad.price;
        part.Active = newMousepad.active;
        part.Discount = newMousepad.discount;
        part.Image = newPart.Image;

        Mousepad.ID = part.ID;
        Mousepad.Model = newMousepad.model;
        Mousepad.Brand = newMousepad.brand;
        Mousepad.Series = newMousepad.series;
        Mousepad.Colour = newMousepad.colour;
        Mousepad.Materials = newMousepad.materials;
        Mousepad.Base = newMousepad.pad_base;
        Mousepad.Dimensions = newMousepad.dimensions;
        Mousepad.Warranty = newMousepad.warranty;
        Mousepad.PartsStock = part;
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteMousepad(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.MousePads.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.MousePads.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditOS(cOS newOS, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var oS = db.OperatingSystems.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newOS.model;
        part.Type = "OS";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newOS.price;
        part.Active = newOS.active;
        part.Discount = newOS.discount;
        part.Image = newPart.Image;

        oS.ID = part.ID;
        oS.Model = newOS.model;
        oS.Brand = newOS.brand;
        oS.Series = newOS.series;
        oS.Bit_Version = newOS.bit_version;
        oS.OS_Version = newOS.os_version;
        oS.System_Requirements = newOS.system_requirements;
        oS.Warranty = newOS.warranty;
        oS.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteOS(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.OperatingSystems.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.OperatingSystems.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditPSU(cPSU newPSU, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var psu = db.PSUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newPSU.model;
        part.Type = "PSU";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newPSU.price;
        part.Active = newPSU.active;
        part.Discount = newPSU.discount;
        part.Image = newPart.Image;


        psu.ID = part.ID;
        psu.Model = newPSU.model;
        psu.Brand = newPSU.brand;
        psu.Series = newPSU.series;
        psu.Power = newPSU.Power;
        psu.Certification = newPSU.certification;
        psu.Modular = newPSU.modular;
        psu.Connectors = newPSU.connectors;
        psu.MTBF = newPSU.mtbf;
        psu.Fan_Size = newPSU.fan_size;
        psu.Cables = newPSU.cables;
        psu.Dimensions = newPSU.dimensions;
        psu.Warranty = newPSU.warranty;
        psu.PartsStock = part;
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deletePSU(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.PSUs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.PSUs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditRAM(cRAM newRAM, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var ram = db.RAMs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var mclink = db.MoboToRams.Where(x => x.RAM_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }
        if (mclink != null)
        {
            mclink.RAM_ID = id;
        }

        part.Model = newRAM.model;
        part.Type = "RAM";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newRAM.price;
        part.Active = newRAM.active;
        part.Discount = newRAM.discount;
        part.Image = newPart.Image;

        ram.ID = part.ID;
        ram.Model = newRAM.model;
        ram.Brand = newRAM.brand;
        ram.Series = newRAM.series;
        ram.Capacity = newRAM.capacity;
        ram.Type = newRAM.type;
        ram.Speed = newRAM.speed;
        ram.Latency = newRAM.latency;
        ram.Voltage = newRAM.voltage;
        ram.Channel_Config = newRAM.channel_config;
        ram.Height = newRAM.height;
        ram.Warranty = newRAM.warranty;
        ram.PartsStock = part;

        try
        {
            db.SubmitChanges();
        }
        catch
        {
            return false;
        }

        //RAM Copatability
        dynamic moboList = (from c in db.Motherboards where ((Convert.ToInt32(ram.Capacity) <= c.Max_Memory_Size) && ram.Type.Equals(c.Memory_Type)) select c);

        foreach (Motherboard c in moboList)
        {
            bool link = linkMoboToRAM(c.ID, ram.ID);
            if (link == false)
            {
                continue;
            }
        }

        return true;
    }

    public bool deleteRAM(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.RAMs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.RAMs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditSSD(cSSD newSSD, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var ssd = db.SSDs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newSSD.model;
        part.Type = "SSD";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newSSD.price;
        part.Active = newSSD.active;
        part.Discount = newSSD.discount;
        part.Image = newPart.Image;

        ssd.ID = part.ID;
        ssd.Model = newSSD.model;
        ssd.Brand = newSSD.brand;
        ssd.Series = newSSD.series;
        ssd.Form_Factor = newSSD.form_factor;
        ssd.Capacity = newSSD.capacity;
        ssd.Interface_Type = newSSD.interface_type;
        ssd.Length = newSSD.length;
        ssd.Width = newSSD.width;
        ssd.Max_Sequential_Read = newSSD.max_seq_read;
        ssd.Max_Sequential_Write = newSSD.max_seq_write;
        ssd.Random_Read = newSSD.random_read;
        ssd.Random_Write = newSSD.random_write;
        ssd.MTBF = newSSD.mtbf;
        ssd.Operating_Temp = newSSD.operating_temp;
        ssd.Max_Power_Usage = newSSD.max_power_usage;
        ssd.Warranty = newSSD.warranty;
        ssd.PartsStock = part;
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteSSD(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.SSDs.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.SSDs.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditSpeaker(cSpeaker newSpeaker, PartsStock newPart, int id)
    {
        var part = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var speaker = db.Speakers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Part_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.Model = newSpeaker.model;
        part.Type = "Speaker";
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newSpeaker.price;
        part.Active = newSpeaker.active;
        part.Discount = newSpeaker.discount;
        part.Image = newPart.Image;

        speaker.ID = part.ID;
        speaker.Model = newSpeaker.model;
        speaker.Brand = newSpeaker.brand;
        speaker.Satellite_Dimensions = newSpeaker.satellite_dimensions;
        speaker.Satellite_Weight = newSpeaker.satellite_weight;
        speaker.SubWoofer_Dimensions = newSpeaker.subwoofer_dimensions;
        speaker.SubWoofer_Weight = newSpeaker.subwoofer_weight;
        speaker.controls = newSpeaker.controls;
        speaker.System_Requirements = newSpeaker.system_requirements;
        speaker.Features = newSpeaker.features;
        speaker.Warranty = newSpeaker.warranty;
        speaker.PartsStock = part;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deleteSpeaker(int id)
    {
        var stock = db.PartsStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var part = db.Speakers.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PartCarts.Where(x => x.Part_ID.Equals(id)).Select(x => x).FirstOrDefault();
        if (cart != null)
        {
            db.PartCarts.DeleteOnSubmit(cart);
        }
        db.Speakers.DeleteOnSubmit(part);
        db.PartsStocks.DeleteOnSubmit(stock);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return false;
        }
    }

    public bool EditPC(cPC newPC, PcStock newPart, int id)
    {
        var part = db.PcStocks.Where(x => x.ID.Equals(id)).Select(x => x).FirstOrDefault();
        var pc = db.Pcs.Where(x => x.PC_ID.Equals(id)).Select(x => x).FirstOrDefault();
        var cart = db.PcCarts.Where(x => x.Pc_ID.Equals(id)).Select(x => x).FirstOrDefault();

        if (cart != null)
        {
            cart.Pc_ID = id;
            cart.Qua = newPart.Quantity;
        }

        part.PC_Type = newPC.type;
        part.Quantity = newPart.Quantity;
        part.Price = (decimal)newPC.price;
        part.Active = newPC.active;
        part.Discount = newPC.discount;
        part.Image = newPart.Image;

        pc.PC_ID = part.ID;
        pc.Case_ID = Convert.ToInt32(newPC.case_id);
        pc.Cooler_ID = Convert.ToInt32(newPC.cooler_id);
        pc.CPU_ID = Convert.ToInt32(newPC.cpu_id);
        pc.Fan_ID = Convert.ToInt32(newPC.fan_id);
        pc.GPU_ID = Convert.ToInt32(newPC.gpu_id);
        pc.HDD_ID = Convert.ToInt32(newPC.hdd_id);
        pc.Headset_ID = Convert.ToInt32(newPC.headset_id);
        pc.Keyboard_ID = Convert.ToInt32(newPC.keyboard_id);
        pc.Mobo_ID = Convert.ToInt32(newPC.mobo_id);
        pc.Monitor_ID = Convert.ToInt32(newPC.monitor_id);
        pc.Mouse_ID = Convert.ToInt32(newPC.mouse_id);
        pc.Num_Fans = newPC.num_fans;
        pc.Num_HDD = newPC.num_hdd;
        pc.Num_SSD = newPC.num_ssd;
        pc.OS_ID = Convert.ToInt32(newPC.os_id);
        pc.PSU_ID = Convert.ToInt32(newPC.psu_id);
        pc.RAM_ID = Convert.ToInt32(newPC.ram_id);
        pc.Speaker_ID = Convert.ToInt32(newPC.speaker_id);
        pc.SSD_ID = Convert.ToInt32(newPC.ssd_id);
        pc.PC_Type = newPC.type;
        pc.Warranty = newPC.warranty;

        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool deletePC(int id)
    {
        throw new NotImplementedException();
    }
}
                                                                                 
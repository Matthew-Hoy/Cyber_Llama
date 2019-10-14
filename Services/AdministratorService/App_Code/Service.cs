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
    public bool addAirCooler(cAirCooler newAC, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newAC.model,
            Type = "Air Cooler",
            Quantity = qua,
            Price = (decimal)newAC.price,
            Active = newAC.active,
            Discount = newAC.discount
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
            Warranty = newAC.warranty
        };

        db.AirCoolers.InsertOnSubmit(AC);
        db.PartsStocks.InsertOnSubmit(part);

        
        //Check for the compatible chipsets
        String str = AC.Compatibility;
        char[] seperator = { ',', ' ' };
        String[] strList = str.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        String chip = null;

        for (int i = 0; i < strList.Length; i++)
        {
            chip = strList[i];
            dynamic cpuList = (from c in db.CPUs where c.Chipset.Equals(chip) select c);
            
            foreach (CPU c in cpuList)
            {
                bool link = linkAcToCPU(c.ID, AC.ID);
                if (link == false)
                {
                    continue;
                }
            }
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

    //Adding new Pc Case
    public bool addCase(cCase newCase, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newCase.model,
            Type = "Case",
            Quantity = qua,
            Price = (decimal)newCase.price,
            Active = newCase.active,
            Discount = newCase.discount
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
            Warranty = newCase.warranty
        };

        db.PCCases.InsertOnSubmit(Case);
        db.PartsStocks.InsertOnSubmit(part);

        
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

    //Adding new CPU
    public bool addCPU(cCPU newCPU, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newCPU.model,
            Type = "CPU",
            Quantity = qua,
            Price = (decimal)newCPU.price,
            Active = newCPU.active,
            Discount = newCPU.discount
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
            Warranty = newCPU.warranty
        };

        db.CPUs.InsertOnSubmit(cpu);
        db.PartsStocks.InsertOnSubmit(part);

        
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

    //Adding new  Fan
    public bool addFan(cFan newFan, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newFan.model,
            Type = "Fan",
            Quantity = qua,
            Price = (decimal)newFan.price,
            Active = newFan.active,
            Discount = newFan.discount
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
            Warranty = newFan.warranty
        };

        db.Fans.InsertOnSubmit(fan);
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

    //Adding new GPU
    public bool addGPU(cGPU newGPU, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newGPU.model,
            Type = "GPU",
            Quantity = qua,
            Price = (decimal)newGPU.price,
            Active = newGPU.active,
            Discount = newGPU.discount
        };

        //Add new Part to its respective Table
        var gpu = new GPU
        {
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
            Warranty = newGPU.warranty
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
    public bool addHDD(cHDD newHDD, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newHDD.model,
            Type = "HDD",
            Quantity = qua,
            Price = (decimal)newHDD.price,
            Active = newHDD.active,
            Discount = newHDD.discount
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
            Warranty = newHDD.warranty
        };

        db.HDDs.InsertOnSubmit(hdd);
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

    //Add new Headset
    public bool addHeadset(cHeadset newHeadset, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newHeadset.model,
            Type = "Headset",
            Quantity = qua,
            Price = (decimal)newHeadset.price,
            Active = newHeadset.active,
            Discount = newHeadset.discount
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
    public bool addKeyboard(cKeyboard newKeyboard, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newKeyboard.model,
            Type = "Keyboard",
            Quantity = qua,
            Price = (decimal)newKeyboard.price,
            Active = newKeyboard.active,
            Discount = newKeyboard.discount
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
            Warranty = newKeyboard.warranty
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
    public bool addLiquidCooler(cLiquidCooler newLC, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newLC.model,
            Type = "Liquid Cooler",
            Quantity = qua,
            Price = (decimal)newLC.price,
            Active = newLC.active,
            Discount = newLC.discount
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
            Warranty = newLC.warranty
        };

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

        db.LiquidCoolers.InsertOnSubmit(LC);
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

    //Adding new Microphone
    public bool addMicrophone(cMicrophone newMicrophone, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMicrophone.model,
            Type = "Microphone",
            Quantity = qua,
            Price = (decimal)newMicrophone.price,
            Active = newMicrophone.active,
            Discount = newMicrophone.discount
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
            Warranty = newMicrophone.warranty
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
    public bool addMobo(cMobo newMobo, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMobo.model,
            Type = "Motherboard",
            Quantity = qua,
            Price = (decimal)newMobo.price,
            Active = newMobo.active,
            Discount = newMobo.discount
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
            Warranty = newMobo.warranty
        };

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

        db.Motherboards.InsertOnSubmit(mobo);
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

    
    //Add new Monitor
    public bool addMonitor(cMonitor newMonitor, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMonitor.model,
            Type = "Monitor",
            Quantity = qua,
            Price = (decimal)newMonitor.price,
            Active = newMonitor.active,
            Discount = newMonitor.discount
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
    public bool addMouse(cMouse newMouse, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMouse.model,
            Type = "Mouse",
            Quantity = qua,
            Price = (decimal)newMouse.price,
            Active = newMouse.active,
            Discount = newMouse.discount
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
            Warranty = newMouse.warranty
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
    public bool addMousepad(cMousePad newMousepad, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newMousepad.model,
            Type = "Mousepad",
            Quantity = qua,
            Price = (decimal)newMousepad.price,
            Active = newMousepad.active,
            Discount = newMousepad.discount
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
            Warranty = newMousepad.warranty
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
    public bool addOS(cOS newOS, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newOS.model,
            Type = "OS",
            Quantity = qua,
            Price = (decimal)newOS.price,
            Active = newOS.active,
            Discount = newOS.discount
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
            Warranty = newOS.warranty
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
    public bool addPSU(cPSU newPSU, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newPSU.model,
            Type = "PSU",
            Quantity = qua,
            Price = (decimal)newPSU.price,
            Active = newPSU.active,
            Discount = newPSU.discount
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
            Warranty = newPSU.warranty
        };

        db.PSUs.InsertOnSubmit(psu);
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

    //Adding new RAM
    public bool addRAM(cRAM newRAM, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newRAM.model,
            Type = "RAM",
            Quantity = qua,
            Price = (decimal)newRAM.price,
            Active = newRAM.active,
            Discount = newRAM.discount
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
            Warranty = newRAM.warranty
        };

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

        db.RAMs.InsertOnSubmit(ram);
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

    //Adding new SSD
    public bool addSSD(cSSD newSSD, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newSSD.model,
            Type = "SSD",
            Quantity = qua,
            Price = (decimal)newSSD.price,
            Active = newSSD.active,
            Discount = newSSD.discount
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
            Warranty = newSSD.warranty
        };

        db.SSDs.InsertOnSubmit(ssd);
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

    //
    public bool addSpeaker(cSpeaker newSpeaker, int qua)
    {
        //Add new part to PartsStock table
        var part = new PartsStock
        {
            Model = newSpeaker.model,
            Type = "Speaker",
            Quantity = qua,
            Price = (decimal)newSpeaker.price,
            Active = newSpeaker.active,
            Discount = newSpeaker.discount
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
    public bool addPC(cPC newPC, int qua)
    {
        //Add new part to PartsStock table
        var temp = new PcStock
        {
            PC_Type = newPC.type,
            Quantity = qua,
            Price = (decimal)newPC.price,
            Active = newPC.active,
            Discount = newPC.discount
        };

        //Add new Part to its respective Table
        var pc = new Pc
        {
            PC_ID = temp.ID,
            PC_Type = temp.PC_Type,
            Case_ID = Convert.ToInt32(newPC.case_id),
            Mobo_ID = Convert.ToInt32(newPC.mobo_id),
            CPU_ID = Convert.ToInt32(newPC.cpu_id),
            RAM_ID = Convert.ToInt32(newPC.ram_id),
            GPU_ID = Convert.ToInt32(newPC.gpu_id),
            Cooler_ID = Convert.ToInt32(newPC.cooler_id),
            SSD_ID = Convert.ToInt32(newPC.ssd_id),
            HDD_ID = Convert.ToInt32(newPC.hdd_id),
            PSU_ID = Convert.ToInt32(newPC.psu_id),
            OS_ID = Convert.ToInt32(newPC.os_id),
            Fan_ID = Convert.ToInt32(newPC.fan_id),
            Num_Fans = newPC.num_fans,
            Num_SSD = newPC.num_ssd,
            Num_HDD = newPC.num_hdd,
            Monitor_ID = Convert.ToInt32(newPC.monitor_id),
            Headset_ID = Convert.ToInt32(newPC.headset_id),
            Keyboard_ID = Convert.ToInt32(newPC.keyboard_id),
            Mouse_ID = Convert.ToInt32(newPC.mouse_id),
            Speaker_ID = Convert.ToInt32(newPC.speaker_id),
            Warranty = newPC.warranty
        };

        db.Pcs.InsertOnSubmit(pc);
        db.PcStocks.InsertOnSubmit(temp);

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


    //Retrieving Products from the DB

    //One at a time
    //This is the function that the wesite call to retrieve a single Part
    public dynamic getPart(int ID)
    {
        var part = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();

        if ((part.Type).Equals("AirCooler"))
        {
            return getAirCooler(ID);
        }
        else if ((part.Type).Equals("Case"))
        {
            return getCase(ID);
        }
        else if ((part.Type).Equals("CPU"))
        {
            return getCPU(ID);
        }
        else if ((part.Type).Equals("Fan"))
        {
            return getFan(ID);
        }
        else if ((part.Type).Equals("GPU"))
        {
            return getGPU(ID);
        }
        else if ((part.Type).Equals("HDD"))
        {
            return getHDD(ID);
        }
        else if ((part.Type).Equals("LiquidCooler"))
        {
            return getLiquidCooler(ID);
        }
        else if ((part.Type).Equals("Motherboard"))
        {
            return getMobo(ID);
        }
        else if ((part.Type).Equals("PSU"))
        {
            return getPSU(ID);
        }
        else if ((part.Type).Equals("RAM"))
        {
            return getRAM(ID);
        }
        else if ((part.Type).Equals("SSD"))
        {
            return getSSD(ID);
        }
        else
        {
            return null;
        }
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
            active = info.Active
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
            active = info.Active
        };

        return temp;
    }

    public cCPU getCPU(int ID)
    {
        var info = (from p in db.PartsStocks where p.ID == ID select p).FirstOrDefault();
        var part = (from p in db.CPUs where p.ID == ID select p).FirstOrDefault();

        cCPU temp = new cCPU
        {
            id = ID,
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
            active = info.Active
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
            active = info.Active
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
            length = Convert.ToDouble(part.Length),
            height = Convert.ToDouble(part.Height),
            warranty = part.Warranty,
            discount = info.Discount,
            active = info.Active
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
            active = info.Active
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
            active = info.Active
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
            active = info.Active
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
            active = info.Active
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
            active = info.Active
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
            active = info.Active
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
            active = info.Active
        };

        return temp;
    }

    //Return Compatable Parts
    public List<cAirCooler> getAirCoolersForCPU(int cpu_ID)
    {
        List<cAirCooler> list = new List<cAirCooler>();

        dynamic compACList = (from c in db.CpuToAirCoolers where c.CPU_ID == cpu_ID select c);

        foreach(CpuToAirCooler compAC in compACList)
        {
            var part = getPart(compAC.AC_ID);
            
            list.Add(part);
        }

        return list;
    }
     
    public List<cLiquidCooler> getLiquidCoolersForCPU(int cpu_ID)
    {
        List<cLiquidCooler> list = new List<cLiquidCooler>();

        dynamic compLCList = (from c in db.CpuToLiquidCoolers where c.CPU_ID == cpu_ID select c);

        foreach (CpuToLiquidCooler compLC in compLCList)
        {
            var part = getPart(compLC.LC_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCPU> getCPUForAirCooler(int ac_ID)
    {
        List<cCPU> list = new List<cCPU>();

        dynamic compACList = (from c in db.CpuToAirCoolers where c.AC_ID == ac_ID select c);

        foreach (CpuToAirCooler compCPU in compACList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCPU> getCPUForLiquidCooler(int lc_ID)
    {
        List<cCPU> list = new List<cCPU>();

        dynamic compLCList = (from c in db.CpuToLiquidCoolers where c.LC_ID == lc_ID select c);

        foreach (CpuToLiquidCooler compCPU in compLCList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCPU> getCPUForMotherboard(int mobo_ID)
    {
        List<cCPU> list = new List<cCPU>();

        dynamic compCPUList = (from c in db.MoboToCpus where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToCpu compCPU in compCPUList)
        {
            var part = getPart(compCPU.CPU_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCase> getCaseForMotherboard(int mobo_ID)
    {
        List<cCase> list = new List<cCase>();

        dynamic compCaseList = (from c in db.MoboToCases where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToCase compCase in compCaseList)
        {
            var part = getPart(compCase.Case_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cRAM> getRAMForMotherboard(int mobo_ID)
    {
        List<cRAM> list = new List<cRAM>();

        dynamic compRAMList = (from c in db.MoboToCpus where c.Mobo_ID == mobo_ID select c);

        foreach (MoboToRam compRAM in compRAMList)
        {
            var part = getPart(compRAM.RAM_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cMobo> getMotherboardForCPU(int cpu_ID)
    {
        List<cMobo> list = new List<cMobo>();

        dynamic compMoboList = (from c in db.MoboToCpus where c.CPU_ID == cpu_ID select c);

        foreach (MoboToCpu compMobo in compMoboList)
        {
            var part = getPart(compMobo.Mobo_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cMobo> getMotherboardForRAM(int ram_ID)
    {
        List<cMobo> list = new List<cMobo>();

        dynamic compMoboList = (from c in db.MoboToRams where c.RAM_ID == ram_ID select c);

        foreach (MoboToRam compMobo in compMoboList)
        {
            var part = getPart(compMobo.Mobo_ID);

            list.Add(part);
        }

        return list;
    }

    public List<cMobo> getMotherboardForCase(int case_ID)
    {
        List<cMobo> list = new List<cMobo>();

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
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("Air Cooler") select p);
        
        foreach (PartsStock p in parts) {
            cAirCooler part = getAirCooler(parts.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cCase> getAllCase()
    {
        List<cCase> list = new List<cCase>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("Case") select p);

        foreach (PartsStock p in parts)
        {
            cCase part = getCase(parts.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cCPU> getAllCPU()
    {
        List<cCPU> list = new List<cCPU>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("CPU") select p);

        foreach (PartsStock p in parts)
        {
            cCPU part = getCPU(parts.ID);
            
            list.Add(part);
        }
        return list;
    }

    public List<cFan> getAllFan()
    {
        List<cFan> list = new List<cFan>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("Fan") select p);

        foreach (PartsStock p in parts)
        {
            cFan part = getFan(parts.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cGPU> getAllGPU()
    {
        List<cGPU> list = new List<cGPU>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("GPU") select p);

        foreach (PartsStock p in parts)
        {
            cGPU part = getGPU(parts.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cHDD> getAllHDD()
    {
        List<cHDD> list = new List<cHDD>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("HDD") select p);

        foreach (PartsStock p in parts)
        {
            cHDD part = getHDD(parts.ID);

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

    public List<cLiquidCooler> getAllLiquidCooler()
    {
        List<cLiquidCooler> list = new List<cLiquidCooler>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("Liquid Cooler") select p);

        foreach (PartsStock p in parts)
        {
            cLiquidCooler part = getPart(parts.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cMobo> getAllMobo()
    {
        List<cMobo> list = new List<cMobo>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("Motherboard") select p);

        foreach (PartsStock p in parts)
        {
            cMobo part = getPart(parts.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cPSU> getAllPSU()
    {
        List<cPSU> list = new List<cPSU>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("PSU") select p);

        foreach (PartsStock p in parts)
        {
            cPSU part = getPart(parts.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cRAM> getAllRAM()
    {
        List<cRAM> list = new List<cRAM>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("RAM") select p);

        foreach (PartsStock p in parts)
        {
            cRAM part = getPart(p.ID);

            list.Add(part);
        }

        return list;
    }

    public List<cSSD> getAllSSD()
    {
        List<cSSD> list = new List<cSSD>();
        dynamic parts = (from p in db.PartsStocks where p.Active == 1 && p.Type.Equals("SSD") select p);

        foreach (PartsStock p in parts)
        {
            cSSD part = getPart(parts.ID);
            
            list.Add(part);
        }

        return list;
    }

    public List<cPC> getAllPC()
    {
        List<cPC> list = new List<cPC>();
        dynamic pcs = (from p in db.PcStocks where p.Active == 1 select p);

        foreach (PcStock p in pcs)
        {
            cPC pc = intgetPC(pcs.ID);
            
            list.Add(pc);
        }

        return list;
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
        if (check != false)
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

    public Boolean updatePartCart(int user_ID, int part_ID, int qua, double total_price)
    {
        var part = (from p in db.PartCarts where (p.User_ID == user_ID && p.Part_ID == part_ID) select p).FirstOrDefault();

        if (part != null)
        {
            part.Qua = qua;
            db.PartCarts.InsertOnSubmit(part);

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

    public Boolean updatePcCart(int user_ID, int pc_ID, int qua, double total_price)
    {
        var pc = (from p in db.PcCarts where (p.User_ID == user_ID && p.Pc_ID == pc_ID) select p).FirstOrDefault();

        if (pc != null)
        {
            pc.Qua = qua;
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
                                       description = part.Model + " " + part.Type,
                                       imagelink = part.Image,
                                       part_id = part.ID,
                                       price = part.Price,
                                       qua = 1,
                                       user_id = user_ID
                                   }).ToList();

        List<cAllCart> pcCart = (from part in db.PcStocks
                                 join cart in db.PcCarts.Where(x => x.User_ID.Equals(user_ID))
                                 on part.ID equals cart.Pc_ID
                                 select new cAllCart
                                 {
                                     description = part.PC_Type,
                                     imagelink = part.Image,
                                     part_id = part.ID,
                                     price = part.Price,
                                     qua = 1,
                                     user_id = user_ID
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
                price = (int)p.Price
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
                price = (int)p.Price
            };

            list.Add(temp);
        }

        return list;
    }
}

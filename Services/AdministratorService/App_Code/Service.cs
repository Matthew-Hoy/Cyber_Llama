using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//using Newtonsoft.Json;


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

    public int addClient(string fName, string sName, string eMail, string address, string city, string province, string zipCode, string UserName, string password, string confirm)
    {
        if (password.Equals(confirm))
        {
            if (db.LoginTables.Where(x => x.User_Name.Equals(UserName)).Select(y => y.User_Name).FirstOrDefault() == null)
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


    //Adding new Products to the DB
    public bool addAirCooler(cAirCooler newAC, int qua)
    {
        var part = new PartsStock
        {
            Model = newAC.model,
            Type = "AirCooler",
            Quantity = qua,
        };


        var AC = new AirCooler
        {
            Model = newAC.model,
            Brand = newAC.brand,
            Series = newAC.series,
            
        };

        db.AirCoolers.InsertOnSubmit(AC);
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

    public bool addCase(cCase newCase, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addCPU(cCPU newCPU, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addFan(cFan newFan, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addGPU(cGPU newGPU, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addHDD(cHDD newHDD, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addLiquidCooler(cLiquidCooler newLC, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addMobo(cMobo newMobo, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addPSU(cPSU newPSU, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addRAM(cRAM newRAM, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addSSD(cSSD newSSD, int qua)
    {
        throw new NotImplementedException();
    }

    public bool addPC(cPC newPC, int qua)
    {
        throw new NotImplementedException();
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
    private cAirCooler getAirCooler(int ID)
    {
        var part = (from p in db.AirCoolers where p.ID == ID select p).FirstOrDefault();

        cAirCooler temp = new cAirCooler
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
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
            warranty = part.Warranty
        };

        return temp;
    }

    private cCase getCase(int ID)
    {
        var part = (from p in db.PCCases where p.ID == ID select p).FirstOrDefault();

        cCase temp = new cCase
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
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
            warranty = part.Warranty
        };

        return temp;
    }

    private cCPU getCPU(int ID)
    {
        var part = (from p in db.CPUs where p.ID == ID select p).FirstOrDefault();

        cCPU temp = new cCPU
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            cores = part.Cores,
            threads = part.Threads,
            base_clock = part.Base_Clock,
            boost_clock = part.Boost_Clock,
            total_cache = part.Total_Cache,
            cmos = part.CMOS,
            tdp = Convert.ToInt32(part.TDP),
            max_temp = part.Max_Temp,
            max_mem_speed = Convert.ToInt32(part.System_Memory_Speed),
            mem_type = part.System_Memory_Type,
            mem_channels = part.Memory_Channels,
            warranty = part.Warranty
        };

        return temp;
    }

    private cFan getFan(int ID)
    {
        var part = (from p in db.Fans where p.ID == ID select p).FirstOrDefault();

        cFan temp = new cFan
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            size = part.Size,
            rpm = part.RPM,
            max_air_flow = part.Max_Air_Flow,
            noise = part.Noise,
            static_pressure = part.Static_Pressure,
            input_voltage = part.Input_Voltage,
            mtbf =  part.MBTF,
            cable_length = part.Cable_Length,
            num_fans = part.Num_Fans,
            warranty = part.Warranty
        };

        return temp;
    }

    private cGPU getGPU(int ID)
    {
        var part = (from p in db.GPUs where p.ID == ID select p).FirstOrDefault();

        cGPU temp = new cGPU
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
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
            warranty = part.Warranty
        };

        return temp;
    }

    private cHDD getHDD(int ID)
    {
        var part = (from p in db.HDDs where p.ID == ID select p).FirstOrDefault();

        cHDD temp = new cHDD
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            interface_type = part.Interface,
            max_sustained_transfer_rate = part.Max_Sustained_Transfer_Rate,
            rotational_speed = part.Rotational_Speed,
            load_unload_cycles = part.Load_Unload_Cycles,
            avg_power_usage = part.Power_Usage,
            operation_temp = part.Operating_Temp,
            size = part.Size,
            weight = part.Weight,
            warranty = part.Warranty
        };

        return temp;
    }

    private cLiquidCooler getLiquidCooler(int ID)
    {
        var part = (from p in db.LiquidCoolers where p.ID == ID select p).FirstOrDefault();

        cLiquidCooler temp = new cLiquidCooler
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            sockets = part.Sockets_Supported,
            fan_size = part.Fan_Size,
            fan_height = part.Fan_Height,
            color = part.Color,
            rad_mats = part.Radiator_Mats,
            rad_length = part.Radiator_Length,
            rad_height = part.Radiator_Height,
            rad_width = part.Radiator_Width,
            tube_length = part.Tube_Length,
            tube_mats = part.Tube_Mats,
            rgb = part.RGB,
            warranty = part.Warranty
        };

        return temp;
    }

    private cMobo getMobo(int ID)
    {
        var part = (from p in db.Motherboards where p.ID == ID select p).FirstOrDefault();

        cMobo temp = new cMobo
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
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
            warranty = part.Warranty
        };

        return temp;
    }

    private cPSU getPSU(int ID)
    {
        var part = (from p in db.PSUs where p.ID == ID select p).FirstOrDefault();

        cPSU temp = new cPSU
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            Power = part.Power,
            certification = part.Certification,
            modular = part.Modular,
            connectors = part.Connectors,
            mtbf = part.MTBF,
            fan_size = part.Fan_Size,
            cables = part.Cables,
            dimensions = part.Dimensions,
            warranty = part.Warranty
        };

        return temp;
    }

    private cRAM getRAM(int ID)
    {
        var part = (from p in db.RAMs where p.ID == ID select p).FirstOrDefault();

        cRAM temp = new cRAM
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
            capacity = part.Capacity,
            type = part.Type,
            speed = part.Speed,
            latency = part.Latency,
            voltage = part.Voltage,
            channel_config = part.Channel_Config,
            height = part.Height,
            warranty = part.Warranty
        };

        return temp;
    }

    private cSSD getSSD(int ID)
    {
        var part = (from p in db.SSDs where p.ID == ID select p).FirstOrDefault();

        cSSD temp = new cSSD
        {
            id = ID,
            model = part.Model,
            brand = part.Brand,
            series = part.Series,
            price = (double)part.Price,
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
            warranty = part.Warranty
        };

        return temp;
    }

    public cPC getPC(int ID)
    {
        var pc = (from p in db.Pcs where p.PC_ID == ID select p).FirstOrDefault();

        cPC temp = new cPC
        {
            id = pc.PC_ID,
            type = pc.PC_Type,
            price = (double)pc.Price,
            case_id = Convert.ToString(pc.Case_ID),
            mobo_id = Convert.ToString(pc.Mobo_ID),
            cpu_id = Convert.ToString(pc.CPU_ID),
            ram_id = Convert.ToString(pc.RAM_ID),
            gpu_id = Convert.ToString(pc.GPU_ID),
            cooler_id = Convert.ToString(pc.Cooler_ID),
            ssd_id = Convert.ToString(pc.SSD_ID),
            hhd_id = Convert.ToString(pc.HDD_ID),
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
            warranty = pc.Warranty
        };

        return temp;
    }

    //Select types

    //Entire Table
    public List<cAirCooler> getAllAirCooler()
    {
        List<cAirCooler> list = new List<cAirCooler>();
        dynamic parts = (from p in db.AirCoolers select p).FirstOrDefault();

        foreach(AirCooler p in parts) {
            cAirCooler temp = new cAirCooler
            {
                id = p.ID,
                model = p.Model,
                brand = p.Brand,
                series = p.Series,
                price = (double)p.Price,
                fan_size = p.Fan_Size,
                chipset = p.Compatibility,
                fan_rpm = p.Fan_RPM,
                air_flow = p.Air_Flow,
                noise_level = p.Noise_Level,
                power_connector = p.Power_Connector,
                colour = p.Colour,
                materials = p.Materials,
                length = p.Length,
                height = p.Height,
                width = p.Width,
                features = p.Features,
                warranty = p.Warranty
            };

            list.Add(temp);
           
        }

        return list;
    }

    public List<cCase> getAllCase()
    {
        List<cCase> list = new List<cCase>();
        dynamic parts = (from p in db.PCCases select p).FirstOrDefault();

        foreach (PCCase p in parts)
        {
            cCase temp = new cCase
            {
                id = p.ID,
                model = p.Model,
                brand = p.Brand,
                series = p.Series,
                price = (double)p.Price,
                colour = p.Colour,
                dimensions = p.Dimensions,
                net_weight = p.Net_Weight,
                mobo_form_factor = p.Motherboard_Form_Factor,
                side_window = p.Side_Window,
                num_front_fans = p.Num_Front_Fans,
                num_back_fans = p.Num_Back_Fans,
                num_top_fans = p.Num_Top_Fans,
                num_bottom_fans = p.Num_Bottom_Fans,
                top_rad_length = p.Top_Radiator_Support,
                front_rad_length = p.Front_Radiator_Support,
                gpu_max_length = p.GPU_Max_Length,
                expansion_slots = p.Expansion_Slots,
                front_io = p.Front_I_O,
                cpu_cooler_max_height = p.CPU_Cooler_Height,
                warranty = p.Warranty
            };

            list.Add(temp);
        }

            return list;
    }

    public List<cCPU> getAllCPU()
    {
        List<cCPU> list = new List<cCPU>();
        dynamic parts = (from p in db.CPUs select p).FirstOrDefault();

        foreach (CPU part in parts)
        {
            cCPU temp = new cCPU
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                cores = part.Cores,
                threads = part.Threads,
                base_clock = part.Base_Clock,
                boost_clock = part.Boost_Clock,
                total_cache = part.Total_Cache,
                cmos = part.CMOS,
                tdp = Convert.ToInt32(part.TDP),
                max_temp = part.Max_Temp,
                max_mem_speed = Convert.ToInt32(part.System_Memory_Speed),
                mem_type = part.System_Memory_Type,
                mem_channels = part.Memory_Channels,
                warranty = part.Warranty
            };

            list.Add(temp);
        }
        return list;
    }

    public List<cFan> getAllFan()
    {
        List<cFan> list = new List<cFan>();
        dynamic parts = (from p in db.Fans select p).FirstOrDefault();

        foreach (Fan part in parts)
        {
            cFan temp = new cFan
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                size = part.Size,
                rpm = part.RPM,
                max_air_flow = part.Max_Air_Flow,
                noise = part.Noise,
                static_pressure = part.Static_Pressure,
                input_voltage = part.Input_Voltage,
                mtbf = part.MBTF,
                cable_length = part.Cable_Length,
                num_fans = part.Num_Fans,
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cGPU> getAllGPU()
    {
        List<cGPU> list = new List<cGPU>();
        dynamic parts = (from p in db.GPUs select p).FirstOrDefault();

        foreach (GPU part in parts)
        {
            cGPU temp = new cGPU
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
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
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cHDD> getAllHDD()
    {
        List<cHDD> list = new List<cHDD>();
        dynamic parts = (from p in db.HDDs select p).FirstOrDefault();

        foreach (HDD part in parts)
        {
            cHDD temp = new cHDD
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                interface_type = part.Interface,
                max_sustained_transfer_rate = part.Max_Sustained_Transfer_Rate,
                rotational_speed = part.Rotational_Speed,
                load_unload_cycles = part.Load_Unload_Cycles,
                avg_power_usage = part.Power_Usage,
                operation_temp = part.Operating_Temp,
                size = part.Size,
                weight = part.Weight,
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }
    
    public List<cLiquidCooler> getAllLiquidCooler()
    {
        List<cLiquidCooler> list = new List<cLiquidCooler>();
        dynamic parts = (from p in db.LiquidCoolers select p).FirstOrDefault();

        foreach (LiquidCooler part in parts)
        {
            cLiquidCooler temp = new cLiquidCooler
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                sockets = part.Sockets_Supported,
                fan_size = part.Fan_Size,
                fan_height = part.Fan_Height,
                color = part.Color,
                rad_mats = part.Radiator_Mats,
                rad_length = part.Radiator_Length,
                rad_height = part.Radiator_Height,
                rad_width = part.Radiator_Width,
                tube_length = part.Tube_Length,
                tube_mats = part.Tube_Mats,
                rgb = part.RGB,
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cMobo> getAllMobo()
    {
        List<cMobo> list = new List<cMobo>();
        dynamic parts = (from p in db.Motherboards select p).FirstOrDefault();

        foreach (Motherboard part in parts)
        {
            cMobo temp = new cMobo
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
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
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cPSU> getAllPSU()
    {
        List<cPSU> list = new List<cPSU>();
        dynamic parts = (from p in db.PSUs select p).FirstOrDefault();

        foreach (PSU part in parts)
        {
            cPSU temp = new cPSU
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                Power = part.Power,
                certification = part.Certification,
                modular = part.Modular,
                connectors = part.Connectors,
                mtbf = part.MTBF,
                fan_size = part.Fan_Size,
                cables = part.Cables,
                dimensions = part.Dimensions,
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cRAM> getAllRAM()
    {
        List<cRAM> list = new List<cRAM>();
        dynamic parts = (from p in db.RAMs select p).FirstOrDefault();

        foreach (RAM part in parts)
        {
            cRAM temp = new cRAM
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
                capacity = part.Capacity,
                type = part.Type,
                speed = part.Speed,
                latency = part.Latency,
                voltage = part.Voltage,
                channel_config = part.Channel_Config,
                height = part.Height,
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cSSD> getAllSSD()
    {
        List<cSSD> list = new List<cSSD>();
        dynamic parts = (from p in db.SSDs select p).FirstOrDefault();

        foreach (SSD part in parts)
        {
            cSSD temp = new cSSD
            {
                id = part.ID,
                model = part.Model,
                brand = part.Brand,
                series = part.Series,
                price = (double)part.Price,
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
                warranty = part.Warranty
            };

            list.Add(temp);
        }

        return list;
    }

    public List<cPC> getAllPC()
    {
        List<cPC> list = new List<cPC>();
        dynamic pcs = (from p in db.Pcs select p).FirstOrDefault();

        foreach (Pc pc in pcs)
        {
            cPC temp = new cPC
            {
                id = pc.PC_ID,
                type = pc.PC_Type,
                price = (double)pc.Price,
                case_id = Convert.ToString(pc.Case_ID),
                mobo_id = Convert.ToString(pc.Mobo_ID),
                cpu_id = Convert.ToString(pc.CPU_ID),
                ram_id = Convert.ToString(pc.RAM_ID),
                gpu_id = Convert.ToString(pc.GPU_ID),
                cooler_id = Convert.ToString(pc.Cooler_ID),
                ssd_id = Convert.ToString(pc.SSD_ID),
                hhd_id = Convert.ToString(pc.HDD_ID),
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
                warranty = pc.Warranty
            };

            list.Add(temp);
        }

        return list;
    }
    
    //Add to bridging table
}

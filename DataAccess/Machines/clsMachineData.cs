using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Machines
{
    public static class clsMachineData
    {
        //___________________________
        //Table Attributes are:
        //1.MachineID int PK
        //2.Machine Name nvarchar(200)
        //2.Machine Type nvarchar(100)
        //___________________________

        //Future Update
        //MachineType type is int
        //New Attribute is nvarchar(1000)
        //Be carefull to design code depend on this edition
        public static int AddNewMachine(string machineName, byte machineType,
            string machineDescryption)
        {
            return -1;
        }

        public static bool GetMachineByMachineID(int machineID,ref string machineName,
            ref byte machineType, ref string machineDescryption)
        {
            return false;
        }

        public static DataTable GetMachinesByMachineType(byte MachineType)
        {
            DataTable _dt=new DataTable();
            return _dt;
        }

        public static DataTable GetAllMachines()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool UpdateMachine(int machineID,
            string machineName, byte machineType,string machineDescryption)
        {
            return false;
        }

        public static bool DeleteMachine(int machineID)
        {
            //here we must check if this machine related with any machineproperty to delete it
            return false;
        }
    }
}

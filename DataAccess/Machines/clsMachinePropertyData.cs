using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Machines
{
    public static class clsMachinePropertyData
    {
        //___________________________
        //Table Attributes are:
        //1.Machine PropertyID int PK
        //2.MachineID int
        //2.PropertyID int
        //3.PropertyValue Decimal
        //___________________________

        public static int AddNewMachineProperty(int MachineID,int PropertyID,
            decimal PropertyValue)
        {
            return -1;
        }

        public static DataTable GetMachinePropertiesByMachineID(int MachineID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static DataTable GetMachinePropertiesByMahinePropertyID(int MachinePropertyID)
        {
            DataTable _dt=new DataTable();
            return _dt;
        }

        public static bool UpdateMachineProperty(int MachinePropertyID,
            int MachineID, int PropertyID, decimal PropertyValue)
        {
            return false;
        }
        public static bool DeleteMachineProperty(int MachinePropertyID)
        {
            return false;
        }
    }
}

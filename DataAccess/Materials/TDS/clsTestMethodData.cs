using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Materials.TDS
{
    public static class clsTestMethodData
    {
        //Table Attributes:
        //Table Name: Test_Methods
        //TestMethodID int PK
        //TestMethodName nvarchar(255)
        //MachineOrInstrument nvarchar(255)

        public static int AddNewTestMethod(string TestMethodName, string MachineOrInstrument)
        {
            return -1;
        }
        public static bool GetTestMethodByTestMethodID(int TestMethodID)
        {
            return false;
        }
        public static bool GetTestMethodByMachineOrInstrument(string MachineOrInstrument)
        {
            return false;
        }

        public static DataTable GetAllTestMethods()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool UpdateTestMethod(int TestMethodID,
            string TestMethodName, string MachineOrInstrument)
        {
            return false;
        }

        public static bool DeleteTestMethod(int TestMethodID)
        {
            //We don't Delete if this machine/Instrument related with any attribute in TDS Master
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Materials.COA
{
    public static class clsCOAResultData
    {
        //COA_Result
        //ResultID int PK
        //BatchID int
        //PropertyID int
        //Actual Value decimal

        public static int AddNewCOAResult(int BatchID, int PropertyID, decimal ActualValue)
        {
            return -1;
        }

        public static DataTable GetCOAResults(int BatchID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool UpdateCOAResult(int ResultID, int BatchID, int PropertyID, decimal ActualValue)
        {
            return false;
        }
        public static bool DeleteCOAResult(int ResultID)
        {
            return false;
        }

    }
}

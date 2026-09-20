using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Mixture_Master
{
    public static class clsOperationalContextData
    {
        //Operational_Contexts
        //ContextID int PK
        //Ambient Temp decimal 
        //Humedity decimal
        //Atmospheric Pressure decimal
        //Record Date DateTime

        public static int AddNewOperationalContext(decimal AmbientTemp, decimal Humedity,
            decimal AtmosphericPressure, DateTime RecordDate)
        {
            return -1;
        }
        public static bool GetOperationalContextByRecordDate(int RecordDate, ref decimal AmbientTemp,
            ref decimal Humedity, ref decimal AtmosphericPressure)
        {
            return false;
        }
        public static bool GetOperationalContextByContextID(int ContextID,
            ref decimal AmbientTemp, ref decimal Humedity, ref decimal AtmosphericPressure,
            DateTime RecordDate)
        {
            return false;
        }
        public static DataTable GetOperationalContexts()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static bool UpdateOperationalContext(int ContextID, decimal AmbientTemp,
            decimal Humedity, decimal AtmosphericPressure, DateTime RecordDate)
        {
            return false;
        }
        public static bool DeleteOperationalContext(int ContextID)
        {
            return false;
        }

    }
}

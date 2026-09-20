using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsMoldPropertyData
    {
        //___________________________
        //Table Attributes are:
        //1.MoldPropertyID int PK
        //2.MoldID int
        //2.PropertyID int
        //3.Value Decimal
        //___________________________

        //View MoldInfoView is a join between Molds and MoldProperties
        //It be used when we need formulation data
        //This View was recieved as a JSON formula 
        //rendering View is in Molds Class

        public static int AddNewPublicProperty(int MoldID, int PropertID, int PropertyValue)
        {
            //Before or through call this function, We must Check if MoldID and PropertyID are exist

            return -1;
        }
        public static bool GetMoldPropertyByID(int MoldPropertyID, ref int MoldID,
            ref int PropertyID, ref decimal PropertyValue)
        {
            return false;
        }

        public static DataTable GetAllMoldPropertiesByMoldID(int MoldID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static DataTable GetAllMoldProperties()
        {
            //Orderered and Distinct
            DataTable _dt=new DataTable();
            return _dt;
        }
        public static bool UpdateMoldProperty(int MoldPropertyID, int MoldID,
            int PropertID, decimal PropertyValue)
        {
            return true;
        }

        public static bool DeleteMoldProperty(int MoldPropertyID)
        {
            //We Delete the relationship between Mold and property
            return false;
        }

    }
}

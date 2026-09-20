using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public static class clsMoldsData
    {
        //___________________________
        //Table Attributes are:
        //1.MoldID int PK
        //2.MoldCode nvarchar(100)
        //2.Mold Shape nvarchar(100)
        //3.Volume_m3 Decimal
        //___________________________

        //View MoldInfoView is a join between Molds and MoldProperties
        //It be used when we need formulation data
        //This View was recieved as a JSON formula 
        //Here we render JSON file and send a dataTable

        public static int AddNewMold(string MoldCode,string MoldShape, decimal Volume)
        {
            return -1;
        }

        public static bool GetMoldByMoldID(int MoldID,ref string MoldCode
                                ,ref string MoldShape, ref decimal Volume)
        {
            return false;
        }

        public static bool GetMoldByVolumeRange(decimal MinVolumee, decimal MaxVolumee,
            ref int MoldID, ref string MoldCode, ref string MoldShape, ref decimal Volume)
        {
            return false;
        }

        public static bool GetMoldByMoldCode(string MoldCode, ref int MoldID,
            ref string MoldShape, ref decimal Volume)
        {
            return false; 
        }
        public static DataTable GetAllMolds()
        {
            DataTable _dt=new DataTable();

            return _dt;
        }
        public static DataTable GetMoldWithPropertiesByMoldID(int MoldID)
        {
            DataTable _dt = new DataTable();

            return _dt;
        }

        public static DataTable GetMoldWithPropertiesByMoldCode(string MoldCode)
        {

            DataTable _dt = new DataTable();

            return _dt;
        }

        public static DataTable GetMoldWithPropertiesByMinAndMaxVolume(decimal MinVolume, decimal MaxVolume)
        {

            DataTable _dt = new DataTable();

            return _dt;
        }

        public static bool UpdateMold(int MoldID, string MoldCode, string MoldShape, decimal Volume)
        {
            return false;
        }
        public static bool DeleteMold(int MoldID) 
        {
            //We must check if this mold related with other tables to cancel this deletion
            return false;
        }
    }
}

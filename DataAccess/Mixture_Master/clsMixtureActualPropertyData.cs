using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Mixture_Master
{
    public static class clsMixtureActualPropertyData
    {
        //Mixture_Actual_Properties
        //ResultID int PK
        //MixtureID int
        //PropertyID int
        //Target Value decimal
        //Actual Value decimal

        public static int AddNewMixtureActualProperty(int MixtureID, int PropertyID, decimal TargetValue,
            decimal ActualValue)
        {
            return -1;
        }
        public static bool GetMixtureActualPropertyByResultID(int ResultID,
            int MixtureID,int PropertyID, decimal TargetValue,decimal ActualValue)
        {
            return false;
        }
        public static bool GetMixtureActualPropertyByMixtureIDAndPropertyID(int MixtureID, int PropertyID,
            ref int ResultID, ref decimal TargetValue, ref decimal ActualValue)
        {
            return false;
        }
        public static DataTable GetMixtureActualPropertiesByMixtureID(int MixtureID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static bool UpdateMixtureActualProperty(int ResultID, int MixtureID, int PropertyID,
            decimal TargetValue, decimal ActualValue)
        {
            return false;
        }
        public static bool DeleteActualProperty(int ResultID)
        {
            //no other tables related with PK of this record
            return false;
        }
    }
}

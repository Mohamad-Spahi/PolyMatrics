using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Materials.COA
{
    public static class clsTDSMasterData
    {
        //TDS_Master
        //TDSID
        //MaterialID
        //PropertyID
        //TestMethodID
        //TypicalValue
        //MinValue
        //MaxValue
        //VersionNumber
        //EffectiveDate
        //IsCurrentVersion

        //TDSMasterView for get full records
        //All Read Function Depending on this view must be build here
        
        public static int AddNewTDSMaster(int MaterialID, int PropertyID,
            int TestMethodID, decimal TypicalValue, decimal MinValue, decimal MaxValue,
            int VersionNumber, DateTime EffectiveDate, bool IsCurrentVersion)
        {
            return -1;
        }

        public static bool GetTDSMasterByTDSID(int TDSID, ref int MaterialID, ref int PropertyID,
            ref int TestMethodID, ref decimal TypicalValue, ref decimal MinValue, ref decimal MaxValue,
            ref int VersionNumber, ref DateTime EffectiveDate, ref bool IsCurrentVersion)
        {
            return false;
        }

        public static bool GetTDSMasterByMaterialID(int MaterialID, ref int TDSID,
            ref int PropertyID, ref int TestMethodID, ref decimal TypicalValue,
            ref decimal MinValue, ref decimal MaxValue, ref int VersionNumber,
            ref DateTime EffectiveDate, ref bool IsCurrentVersion)
        {
            return false;
        }

        public static bool GetTDSMasterByPropertyAndTypicalValue(int PropertyID,
            decimal TypicalValue, ref int TDSID, ref int MaterialID, ref int TestMethodID,
            ref decimal MinValue, ref decimal MaxValue, ref int VersionNumber,
            ref DateTime EffectiveDate, ref bool IsCurrentVersion)
        {
            return false;
        }
        public static bool GetTDSMasterByPropertyANDValueRange(int PropertyID,
            decimal MinValue, decimal MaxValue, ref int TDSID, ref int MaterialID,
            ref int TestMethodID, ref decimal TypicalValue, ref int VarsionNumber,
            ref DateTime EffectiveDate, ref bool IsCurrentVersion)
        {
            return false;
        }
        public static DataTable GetTDSMasterView(int MaterialID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
     

        public static bool UpdateTDSMaster(int TDSID, int MasterialID, int PropertyID,
            int TestMethodID, decimal TypicalValue, decimal MinValue, decimal MaxValue,
            int VersionNumber, DateTime EffectiveDate, bool IsCurrentVersion)
        {
            return false;
        }

        public static bool DeleteTDSMaster(int TDSID)
        {
            //Here we check if this tds related with attibutes in other tables 'not Material' like MixtureMaster

            return false;
        }
    }
}

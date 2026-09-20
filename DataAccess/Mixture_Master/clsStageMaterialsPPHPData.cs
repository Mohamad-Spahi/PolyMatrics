using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Mixture_Master
{
    public static class clsStageMaterialsPPHPData
    {
        //Stage_Materials_PPHP
        //MixContentID int PK
        //StageID int 
        //BatchID int
        //PPHP Value decimal
        //CalculatedWeight_KG decimal

        //A method to get all PPHP related with Mixture Master and it's stages
        public static int AddNewStageMaterialPPHP(int StageID, int BatchID, decimal PPHPValue,
            decimal CalculatedWeight_KG)
        {
            return -1;
        }
        public static bool GetStageMaterialByMixContentID(int MixContentID, ref int StageID,
            ref int BatchID, ref decimal PPHPValue, ref decimal CalculatedWeight_KG)
        {
            return false;
        }
        public static DataTable GetStageMaterialsByStageID(int StageID,
            ref int MixContentID, ref int BatchID, ref decimal PPHPValue, ref decimal CalculatedWeight_KG)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool UpdateStageMaterialPPHP(int MixContentID, int StageID, int BatchID,
            decimal PPHPValue, decimal CalculatedWeight_KG)
        {
            return false;
        }

        public static bool DeleteStageMaterialPPHP(int MixContentID)
        {
            //We check if this PPHP is already approved by checking Mixture Master of this MixContent
            //is Approved
            return false;
        }
    }
}

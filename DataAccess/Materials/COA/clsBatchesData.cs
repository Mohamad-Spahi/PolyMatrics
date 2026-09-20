using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Materials.COA
{
    public static class clsBatchesData
    {
        //Batches
        //BatchID int PK
        //MaterialID int
        //Lot Number nvarchar(150)
        //IsActive bool

        public static int AddNewBatch(int MaterialID, string LotNumber, bool IsActive)
        {
            return -1;
        }
        public static bool GetBatchByBatchID(int BatchID,int MaterialID
            , ref string LotNumber, ref bool IsActive)
        {
            return false;
        }

        public static DataTable GetActiveBatchesByMaterialID(int MaterialID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static DataTable GetAllBatchesByMaterialID(int MaterialID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static bool UpdateBatchInfo(int BatchID)
        {
            return false;
        }

        public static bool DeleteBatch(int BatchID)
        {
            //here we will check if this batch record related with other tables to cancel this deletion
            return false;
        }

    }
}

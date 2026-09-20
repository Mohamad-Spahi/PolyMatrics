using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Mixture_Master
{
    public static class clsMixtureMasterData
    {
        //Mixture_Master
        //MixtureID int PK
        //ParentMixtureID int FK nullable
        //GradeID int 
        //ContextID int
        //MachineID int
        //MoldID int
        //TotalTargetWeight_KG decimal 
        //PorpuseDescryption nvarchar(255)
        //IsApproved bool
        //ApprovalDate

        //Read Operations must be call MixtureMasterView not the main table
        //After dermine attributes of View in the future be careful to redefine read operation methods
        public static int AddNewMixtureMaster(int? ParentMixtureID, int GradeID, int ContextID,
            int MachineID, int MoldID, decimal TotalTargetWeight_KG, string PorpuseDescryption,
            bool IsApproved, DateTime ApprovalDate)
        {
            return -1;
        }
        public static DataTable GetAllMixtureMasters()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        
        public static bool UpdateMixtureMaster(int MixtureID, int? ParentMixtureID, int GradeID,
            int ContextID, int MachineID, int MoldID, decimal TotalTargetWeight_KG,
            string PorpuseDescryption, bool IsApproved, DateTime ApprovalDate)
        {
            return false;
        }
        public static bool DeleteMixtureMaster(int MixtureID)
        {
            return false;
        }
    }
}

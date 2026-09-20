using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.Mixture_Master
{
    public static class clsMixingStagesData
    {

        //Mixing_Stages
        //StageID int PK
        //MixtureID int
        //LevelNumber int
        //StageDescryption nvarchar(255)
        //MixingRPM int
        //Time Period Seconds (we will depend this attribute as float not int)

        public static int AddNewMixingStage(int MixtureID, int LevelNumber,
            string StageDescryption, int MixingRPM, float TimePeriodSeconds)
        {
            return -1;
        }

        public static bool GetMixingStageByStageID(int StageID, ref int MixtureID,
            ref int LevelNumber, ref string StageDescryption, ref int MixingRPM,
            ref float TimePeriodSeconds)
        {
            return false;
        }


        public static DataTable GetMixingStagesByMixtureID(int MixtureID)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static bool UpdateMixingStage(int StageID, int MixtureID, int LevelNumber,
            string StageDescryption, int MixingRPM, float TimePeriodSeconds)
        {
            return false;
        }
        public static bool DeleteMixingStage(int StageID)
        {
            //here we check if there is any record in other tables relatd with this record to cancele operation
            return false;
        }
    }
}

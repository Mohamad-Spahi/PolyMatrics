using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.FoamGrades
{
    public static class FoamGradeSPECSData
    {
        //___________________________
        //Table Attributes are:
        //Table Name Foam_Grade_SPECS
        //1.FoamGradeSpecsID int PK
        //2.PropertyID int
        //2.TestMethodID int
        //3.TargetValue decimal
        //4.MinValue decimal
        //5.MaxValue decimal
        //___________________________

        public static int AddNewFoamGradeSpecs(int PropertyID,int TestMethodID,
            decimal TargetValue,decimal minValue,decimal maxValue)
        {
            return -1;
        }

        public static bool GetFoamGradeSPECSByFoamGradeSpecsID(int foamGradeSpecsID,
            ref int PropertyID,ref int TestMethodID,ref decimal TargetValue,
            ref int MinValue,ref int MaxValue)
        {
            return false;
        }
        public static DataTable GetFoamGradeSpecsByTargetValue(decimal TargetValue)
        {
            DataTable _dt=new DataTable();
            return _dt;
        }

        public static DataTable GetAllFoamGradeSpecs()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool UpdateFoamGradeSpecs(int FoamGradeSpecsID,int PropertyID,
            int TestMethodID,decimal TargetValue,decimal MinValue,decimal MaxValue)
        {
            return false;
        }

        public static bool DeleteFoamGradeSpecs(int FoamGradeSpecsID)
        {
            return false;
        }

    }
}

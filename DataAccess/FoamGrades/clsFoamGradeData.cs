using ExCSS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.FoamGrades
{
    public static class clsFoamGradeData
    {
        //___________________________
        //Table Attributes are:
        //Table Name Foam_Grades
        //1.GradeID int PK
        //2.FoamCategoryID int
        //2.GradeCode nvarchar(100)
        //3.Color nvarchar(50)
        //4.IsActive bit
        //___________________________
        

        //Future Update Color must be stored as a num not a string so we will deal with this update as default.
        public static int AddNewFoamGrade(int FoamCatergoryID, string GradeCode, int Color,
            bool IsActive)
        {
            return -1;
        }

        public static bool GetFoamGradeByGradeID(int GradeID,
            ref int FoamCatergoryID,ref string GradeCode,
            ref int Color,ref bool IsActive)
        {
            return false;
        }

        public static DataTable GetFoamGradeByFoamCategoryID(int FoamCategoryID,
            ref int GradeID, ref string GradeCode, ref int Color, ref bool IsActive)
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static DataTable GetActiveFoamGrades()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }
        public static bool UpdateFoamGrade(int GradeID,
            int FoamCategoryID, string GradeCode, int Color, bool IsActive)
        {
            return false;
        }

        public static bool DeleteFoamGrade(int GradeID)
        {
            //here we check of any tables has GradeID as FK to Delete it like Mixture_Master and FoamGradeSpecs
            //and checking if those attributes in other tables must still in the system of delete them
            return false;
        }
    }
}

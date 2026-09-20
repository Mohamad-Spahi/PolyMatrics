using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Property.FoamGrades
{
    public static class clsFoamCategoryData
    {
        //___________________________
        //Table Attributes are:
        //Table Name Foam_Categories
        //1.FoamCategoryID int PK
        //2.CategoryName int
        //___________________________
        
        //Future Update we will deal with: Add New Column FoamCategoryDescryption
        //In Addtion to edit their names to FoamCategoryName
        public static int AddNewFoamCategory(string FoamCategoryName,
            string FoamCategoryDescryption)
        {
            return -1;
        }

        public static DataTable GetAllFoamCategories()
        {
            DataTable _dt = new DataTable();
            return _dt;
        }

        public static bool GetFoamCategoryByCategoryName(string CategoryName,
            ref int FoamCategoryID, ref string FoamCategoryDescryption)
        {
            return false;
        }

        public static bool GetFoamCategoryByFoamCategoryID(int FoamCategoryID,
            ref string CategoryName, ref string FoamCategoryDescryption)
        {
            return false;
        }

        public static bool UpdateFoamCategory(int FoamCategoryID,string FoamCategoryName,
            string FoamCategoryDescryption)
        {
            return false;
        }
        public static bool DeleteFoamCategory(int FoamCategoryID)
        {
            //here we check of any other attributes in other tables are related with this 
            //Attribute we must delete them first
            return false;
        }

    }
}

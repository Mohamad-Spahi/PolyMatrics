using DataAccess.Materials;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibBusiness
{
    public class clsMaterialCategory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; }

        public int? MaterialCategoryID { get; set; }
        public string MaterialCategoryName { get; set; }
        public string MaterialCategoryDescryption { get; set; }
        
        private clsMaterialCategory(int materialCategoryID,
            string MaterialCategoryName, string MaterialCategoryDescryption)
        {
            this.MaterialCategoryID = materialCategoryID;
            this.MaterialCategoryName= MaterialCategoryName;
            this.MaterialCategoryDescryption = MaterialCategoryDescryption;

            Mode= enMode.Update;
        }
        public clsMaterialCategory()
        {
            this.MaterialCategoryID = null;
            this.MaterialCategoryName = "";
            this.MaterialCategoryDescryption= "";

            Mode= enMode.AddNew;
        }

        public static clsMaterialCategory Find(string MaterialCategoryName)
        {
            if (string.IsNullOrEmpty(MaterialCategoryName.Trim())) return null;

            int MaterialCategoryID = -1;
            string MaterialCategoryDescryption = "";

            bool IsFound=clsMaterialCategoryData.GetMaterialCategoryByCategoryName(MaterialCategoryName,
                ref MaterialCategoryID, ref MaterialCategoryDescryption);

            if (IsFound)
            {
                return new clsMaterialCategory(MaterialCategoryID, MaterialCategoryName, MaterialCategoryDescryption);
            }
            else return null;

        }
        public static clsMaterialCategory Find(int MaterialCategoryID)
        {
            if (MaterialCategoryID <= 0 || !IsMaterialCategoryExist(MaterialCategoryID)) return null;

            string MaterialCategoryName="", MaterialCategoryDescryption="";
            
            bool IsFound=clsMaterialCategoryData.GetMaterialCategoryByMaterialCategoryID(
                MaterialCategoryID,ref MaterialCategoryName,ref MaterialCategoryDescryption);

            if (IsFound)
            {
                return new clsMaterialCategory(MaterialCategoryID, MaterialCategoryName, MaterialCategoryDescryption);
            }
            else return null;
        }

        private bool _AddNewMaterialCategory()
        {
            if (string.IsNullOrEmpty(MaterialCategoryName)) return false;

            if (IsMaterialCategoryNameExist(MaterialCategoryName)) return false;

            MaterialCategoryID= clsMaterialCategoryData.AddNewMaterialCategory(MaterialCategoryName, MaterialCategoryDescryption);
            return MaterialCategoryID!= null;
        }

        private bool _UpdateMaterialCategory()
        {
            if (MaterialCategoryID != null) return false;
            if(MaterialCategoryName!= null) return false;

            if(!IsMaterialCategoryExist(MaterialCategoryID.Value)) return false;

            return clsMaterialCategoryData.UpdateMaterialCategory(MaterialCategoryID.Value,
                MaterialCategoryName, MaterialCategoryDescryption);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaterialCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                    case enMode.Update:
                    return _UpdateMaterialCategory();
            }
            return false;
        }

        public static DataTable GetAllMaterialCategories()
        {
            return clsMaterialCategoryData.GetAllMaterialCategories();
        }

        public static bool DeleteMaterialCategory(int MaterialCategoryID)
        {
            if (!IsMaterialCategoryExist(MaterialCategoryID)) return false;

            return clsMaterialCategoryData.DeleteMaterialCategory(MaterialCategoryID);
        }

        public static bool IsMaterialCategoryExist(int MaterialCategoryID)
        {
            if(MaterialCategoryID <= 0) return false;

            return clsMaterialCategoryData.IsMaterialCategoryExit(MaterialCategoryID);
        }
        public static bool IsMaterialCategoryNameExist(string MaterialCategoryName)
        {
            if (string.IsNullOrEmpty(MaterialCategoryName)) return false;
            MaterialCategoryName.Trim();
            return clsMaterialCategoryData.IsMaterialCategoryNameExist(MaterialCategoryName);
        }

    }
}

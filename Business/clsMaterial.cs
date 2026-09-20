using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Property.Materials;

namespace ClassLibBusiness
{
    public class clsMaterial
    {
        public enum enMode { AddNew=0,Update=1};
        public enMode Mode { get; set; }
        public int? MaterialID {  get; set; }
        public string TradeMaterialName {  get; set; }
        public int MaterialCategoryID {  get; set; }
        public bool IsActive {  get; set; }
        public string ChemicalName {  get; set; }
        private clsMaterialCategory _MaterialCategory {  get; set; }

        public clsMaterialCategory MaterialCategoryInfo { get {  return _MaterialCategory; }}
        private clsMaterial(int MaterialID, string TradeMaterialName,
            int MaterialCategoryID, bool IsActive, string ChemicalName)
        {
            this.MaterialID = MaterialID;
            this.TradeMaterialName = TradeMaterialName;
            this.MaterialCategoryID = MaterialCategoryID;
            this.IsActive = IsActive;
            this.ChemicalName = ChemicalName;

            _MaterialCategory = clsMaterialCategory.Find(MaterialCategoryID);
            Mode = enMode.Update;
        }

        public clsMaterial()
        {
            this.MaterialID = null;
            this.TradeMaterialName = "";
            this.MaterialCategoryID = -1;
            this.IsActive = false;
            this.ChemicalName = "";

            _MaterialCategory = new clsMaterialCategory();
            Mode = enMode.AddNew;
        }

        private bool _AddNewMaterial()
        {
            if(!IsMaterialExistByChemicalName(ChemicalName))
            MaterialID=clsMaterialData.AddNewMaterial(TradeMaterialName, MaterialCategoryID, IsActive, ChemicalName);
            return (MaterialID != null);
            
        }
        private bool _UpdateMaterial()
        {
            if (IsMaterialExist(MaterialID.Value))
                return clsMaterialData.UpdateMaterial(MaterialID.Value,
                    TradeMaterialName, MaterialCategoryID, IsActive, ChemicalName);
            
            return false;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaterial())
                    {
                        Mode = enMode.Update;
                        return true;
                    }else return false;

                case enMode.Update:
                    return _UpdateMaterial();
            }
            return false;
        }
        public static clsMaterial Find(string ChemicalName)
        {
            if(string.IsNullOrEmpty(ChemicalName)) return null;

            string TradeMaterialName = "";
            int MaterialCategoryID = -1,MaterialID=-1;
            bool IsActive = false;

            bool IsFound = clsMaterialData.GetMaterialByChemicalName(ChemicalName,
                ref MaterialID, ref TradeMaterialName, ref MaterialCategoryID, ref IsActive);

            if (IsFound)
            {
                return new clsMaterial(MaterialID, TradeMaterialName,
                    MaterialCategoryID, IsActive, ChemicalName);
            }
            else
                return null;
        }
        public static clsMaterial Find(int MaterialID)
        {
            if(MaterialID < 0) return null;

            string TradeMaterialName = "", ChemicalName = "";
            int MaterialCategoryID = -1;
            bool IsActive = false;

            bool IsFound=clsMaterialData.GetMaterialByMaterialID(MaterialID,
                ref  TradeMaterialName,ref MaterialCategoryID,ref IsActive,
                ref ChemicalName);
            if (IsFound)
            {
                return new clsMaterial(MaterialID,TradeMaterialName,
                    MaterialCategoryID,IsActive, ChemicalName);
            }else
                return null;
        }

        public static DataTable GetAllMaterials()
        {
            return clsMaterialData.GetAllMaterials();
        }

        public static bool DeleteMaterial(int MaterialID)
        {
            if(IsMaterialExist(MaterialID))
            return clsMaterialData.DeleteMaterial(MaterialID);
            else return false;
        }

        public static bool IsMaterialExistByChemicalName(string ChemicalName)
        {
            if(string.IsNullOrEmpty(ChemicalName)) return false;

            return clsMaterialData.IsMaterialExistsByChemicalName(ChemicalName);
        }
        public static bool IsMaterialExist(int MaterialID) 
        {
            if (MaterialID <= 0) return false;
            return clsMaterialData.IsMaterialExist(MaterialID);
        }
    }
}

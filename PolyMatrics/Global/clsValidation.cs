using ClassLibBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMatrics.Global
{
    public static class clsValidation
    {
       
        public static bool IsValidMaterialCategoryID(int MaterialID)
        {
            
            if (MaterialID<=0) return false;

            if (!clsMaterialCategory.IsMaterialCategoryExist(MaterialID)) return false;

            return true;
        }
        public static bool IsValidMaterialCategoryName(string MatetialCategoryName)
        {
            MatetialCategoryName.Trim();
            if(string.IsNullOrEmpty(MatetialCategoryName)) return false;

            if (!clsMaterialCategory.IsMaterialCategoryNameExist(MatetialCategoryName)) return false;

            return true;
        }
        public static bool IsValidChemicalName(string ChemicalName)
        {

            if (string.IsNullOrEmpty(ChemicalName.Trim())) return false;

            if(clsMaterial.Find(ChemicalName)== null) return false;

            return true;

        }
        public static bool IsMaterialIDValid(int MaterialID)
        {
            if (MaterialID <= 0)
            {
                MessageBox.Show("Choose Valid MaterialID grater than Zero!", "Invalid Inserted ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!clsMaterial.IsMaterialExist(MaterialID))
            {
                MessageBox.Show("Material with ID = " + MaterialID + " Does not Exist.", "Invalid Inserted ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }

            return true;
        }
    }
}

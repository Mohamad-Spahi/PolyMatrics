using ClassLibBusiness;
using PolyMatrics.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMatrics.Machines.MaterialCategories
{
    public partial class ctrlMaterialCategoryCardInfo : UserControl
    {
        private int? _MaterialCategoryID {  get; set; }
        public int? SelectedMaterialCategoryID { get { return _MaterialCategoryID; } }

        private clsMaterialCategory _MaterialCategoryInfo {  get; set; }

        public clsMaterialCategory SelectedMaterialCategory {  get { return _MaterialCategoryInfo; } }
        public ctrlMaterialCategoryCardInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(string MaterialCategoryName)
        {
            _ResetValues();
            if (clsValidation.IsValidMaterialCategoryName(MaterialCategoryName))
                _MaterialCategoryInfo = clsMaterialCategory.Find(MaterialCategoryName);

            if (_MaterialCategoryInfo == null)
            {
                lnkEditMaterialCategory.Enabled = false;
                MessageBox.Show("Soething went wrong, Please retry later.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillMaterialCategoryInfo();
        }
        public void LoadInfo(int MaterialID)
        {
            _ResetValues();

            if (!clsValidation.IsValidMaterialCategoryID(MaterialID)) return;
            
            _MaterialCategoryInfo = clsMaterialCategory.Find(MaterialID);
            if (_MaterialCategoryInfo== null)
            {
                lnkEditMaterialCategory.Enabled= false;
                MessageBox.Show("Soething went wrong, Please retry later.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillMaterialCategoryInfo();
        }
        private void FillMaterialCategoryInfo()
        {
            _MaterialCategoryID = _MaterialCategoryInfo.MaterialCategoryID;
            lblMaterialCategoryID.Text = _MaterialCategoryID.ToString();
            lblMaterialCategoryName.Text = _MaterialCategoryInfo.MaterialCategoryName;
            lblMaterialCategoryDescryption.Text = _MaterialCategoryInfo.MaterialCategoryDescryption;
            
        }
        public void ResetMaterialCategoryInfo()
        {
            _ResetValues();
        }
        private void _ResetValues()
        {
            _MaterialCategoryID = null;
            _MaterialCategoryInfo= null;

            lblMaterialCategoryID.Text = "[???]";
            lblMaterialCategoryName.Text = "Material Category Name...";
            lblMaterialCategoryDescryption.Text = "Material Category Descryption...";
        }

        private void lnkEditMaterialCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

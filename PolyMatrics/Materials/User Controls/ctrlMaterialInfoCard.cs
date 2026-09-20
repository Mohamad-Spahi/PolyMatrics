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

namespace PolyMatrics.Materials.User_Controls
{
    public partial class ctrlMaterialInfoCard : UserControl
    {
        private int? _MaterialID {  get; set; }

        private clsMaterial _MaterialInfo;

        public int? MaterialID { get {  return _MaterialID; }  }

        public clsMaterial SelectedMaterialInfo { get { return _MaterialInfo; } }
        public ctrlMaterialInfoCard()
        {
            InitializeComponent();
        }

        public bool LoadInfo(string ChemicalName)
        {
            _ResetValues();
            if(!clsValidation.IsValidChemicalName(ChemicalName))
            {
                lnkEditMaterialInfo.Enabled = false;
                MessageBox.Show("Invalid Chemical Name, please choose another one.", "Unknown Chemical Name in the System.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _MaterialInfo = clsMaterial.Find(ChemicalName);
            
            if (_MaterialInfo == null)
            {
                lnkEditMaterialInfo.Enabled = false;
                MessageBox.Show("Soething went wrong, Please retry later.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            _MaterialID= _MaterialInfo.MaterialID;
            FillMaterialInfo();
            return true;
        }
        public bool LoadInfo(int MaterialID)
        {
            _ResetValues();
           
            if (!clsValidation.IsMaterialIDValid(MaterialID))
            {
                lnkEditMaterialInfo.Enabled = false;
                MessageBox.Show("Invalid Material ID, please choose another one.", "Unknown Material ID in the System.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _MaterialInfo = clsMaterial.Find(MaterialID);
            if (_MaterialInfo == null)
            {
                lnkEditMaterialInfo.Enabled = false;
                MessageBox.Show("Soething went wrong, Please retry later.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                FillMaterialInfo();
            return true;
        }
        private void FillMaterialInfo()
        {
            _MaterialID=_MaterialInfo.MaterialID;
            lblMaterialID.Text = _MaterialID.ToString();
            lblMaterialCategory.Text = _MaterialInfo.MaterialCategoryInfo.MaterialCategoryName;
            lblTradeMaterialName.Text=_MaterialInfo.TradeMaterialName;
            lblChemicalName.Text=_MaterialInfo.ChemicalName;

            chkIsActive.Checked=_MaterialInfo.IsActive;

            lnkEditMaterialInfo.Enabled = true;
        }
        private void _ResetValues()
        {
            _MaterialID = null;
            _MaterialInfo= null;
            
            lblMaterialID.Text = "[????]";
            lblMaterialCategory.Text = "[????]";
            lblTradeMaterialName.Text = "Material Name...";
            lblChemicalName.Text = "Chemical Name...";
            chkIsActive.Checked = false;

            lnkEditMaterialInfo.Enabled = false;
        }
        private void lnkEditMaterialInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateMaterial frm=new frmAddUpdateMaterial(_MaterialID.Value);
            frm.ShowDialog();
        }
    }
}

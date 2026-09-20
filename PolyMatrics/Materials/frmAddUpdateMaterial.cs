using ClassLibBusiness;
using ExCSS;
using PolyMatrics.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace PolyMatrics.Materials
{
    public partial class frmAddUpdateMaterial : Form
    {
        // Declare a delegate
        public delegate void MaterialIDEventHandler(int MaterialID);

        // Declare an event using the delegate
        public event MaterialIDEventHandler MaterialIDBack;

        public enum enMode { AddNew = 0, Update = 1 }

        public enMode _Mode;
        private int _MaterialCategoryID {  get; set; }
        private int _MaterialID { get; set; }
        private clsMaterial _MaterialInfo;

        private string _ChemicalName { get; set; }
        private void MaterialCategorySelected(int MaterialCategoryID)
        {
            btnNext.Enabled = true;
            _MaterialCategoryID = MaterialCategoryID;
            _MaterialInfo.MaterialCategoryID= MaterialCategoryID;
            lblMaterialCategory.Text = clsMaterialCategory.Find(MaterialCategoryID).MaterialCategoryName;
        }
        public frmAddUpdateMaterial()
        {
            InitializeComponent();
            _Mode=enMode.AddNew;
        }
        public frmAddUpdateMaterial(int MaterialID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _MaterialID = MaterialID;
        }

        private void _ResetMaterialInfoTabPage()
        {
            lblMaterialID.Text = "[???]";
            lblMaterialCategory.Text = "??";
            txtTradeName.Text = "Trade Material Name...";
            txtChemicalName.Text = "Chemical Name...";
            chkIsActive.Checked = false;
            
            btnPrevious.Enabled = true;
        }

        private void _ResetMaterialCategoryTabPage()
        {
            ctrlMaterialCategoryInfoWithFilter1.ResetMaterialCategoryFilter();
            btnNext.Enabled = false;
        }
        private void _ResetDefaultValues()
        {
            _MaterialInfo = new clsMaterial();
            lblTitle.Text = "Add New Material";
            _ResetMaterialCategoryTabPage();
            _ResetMaterialInfoTabPage();
        }
        private void FillMaterialInfoTabPage()
        {
            lblMaterialID.Text = _MaterialID.ToString();
            lblMaterialCategory.Text =_MaterialInfo.MaterialCategoryInfo.MaterialCategoryName;
            txtTradeName.Text = _MaterialInfo.TradeMaterialName;
            txtChemicalName.Text = _MaterialInfo.ChemicalName;
            chkIsActive.Checked = _MaterialInfo.IsActive;
            
        }
        private void _LoadData()
        {
            lblTitle.Text = "Update Material";
            _MaterialInfo = clsMaterial.Find(_MaterialID);
            _MaterialCategoryID = _MaterialInfo.MaterialCategoryID;
            _ChemicalName= _MaterialInfo.ChemicalName;
            ctrlMaterialCategoryInfoWithFilter1.LoadInfo(_MaterialCategoryID);
            btnNext.Enabled = true;
            FillMaterialInfoTabPage();
            
        }

        private void frmAddUpdateMaterial_Load(object sender, EventArgs e)
        {
            ctrlMaterialCategoryInfoWithFilter1.OnMaterialCategorySelected += MaterialCategorySelected;
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _MaterialInfo.MaterialCategoryID = clsMaterialCategory.Find(lblMaterialCategory.Text).MaterialCategoryID.Value;
            _MaterialInfo.TradeMaterialName = txtTradeName.Text;
            _MaterialInfo.ChemicalName= txtChemicalName.Text;
            _MaterialInfo.IsActive= chkIsActive.Checked;

            if (_MaterialInfo.Save())
            {
                _MaterialID = _MaterialInfo.MaterialID.Value;
                lblMaterialID.Text = _MaterialID.ToString() ;
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Material";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                MaterialIDBack?.Invoke(_MaterialID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcMaterialDataInfo.SelectedTab = tpMaterialCategoryInfo;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMaterialDataInfo.SelectedTab = tpMaterialInfo;
        }

        private void txtTradeName_Validating(object sender, CancelEventArgs e)
        {
            TextBox TradeNameTextBox = (TextBox)sender;
            if (string.IsNullOrEmpty(TradeNameTextBox.Text.Trim())||TradeNameTextBox.Text.Contains("Material Name..."))
                {
                e.Cancel = true;
                errorProvider1.SetError(txtTradeName, "This field is required!");

            }else
                errorProvider1.SetError(txtTradeName, null);
        }

        private void txtChemicalName_Validating(object sender, CancelEventArgs e)
        {
            TextBox ChemicalName = (TextBox)sender;
            if (string.IsNullOrEmpty(ChemicalName.Text.Trim()) || ChemicalName.Text.Contains("Chemical Name..."))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTradeName, "This field is required!");
                return;
            }
            else
                errorProvider1.SetError(txtTradeName, null);

            if (txtChemicalName.Text != _ChemicalName || _MaterialInfo.Mode == clsMaterial.enMode.AddNew)
            if (clsValidation.IsValidChemicalName(ChemicalName.Text))
            {
                
                errorProvider1.SetError(txtTradeName, "This Name is Exist!, Choose new chemical name");

            }else
                errorProvider1.SetError(txtTradeName, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

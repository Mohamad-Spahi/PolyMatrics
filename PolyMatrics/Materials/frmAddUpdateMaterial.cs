using ClassLibBusiness;
using PolyMatrics.Global;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PolyMatrics.Materials
{
    public partial class frmAddUpdateMaterial : Form
    {
        // Delegate and Event for passing data back
        public delegate void MaterialIDEventHandler(int materialID);
        public event MaterialIDEventHandler MaterialIDBack;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _mode;
        private int _materialCategoryID;
        private int _materialID;
        private clsMaterial _materialInfo;
        private string _originalChemicalName;

        public frmAddUpdateMaterial()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }

        public frmAddUpdateMaterial(int materialID)
        {
            InitializeComponent();
            _mode = enMode.Update;
            _materialID = materialID;
        }

        private void frmAddUpdateMaterial_Load(object sender, EventArgs e)
        {
            ctrlMaterialCategoryInfoWithFilter1.OnMaterialCategorySelected += MaterialCategorySelected;
            _ResetDefaultValues();

            if (_mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void MaterialCategorySelected(int materialCategoryID)
        {
            btnNext.Enabled = true;
            _materialCategoryID = materialCategoryID;
            _materialInfo.MaterialCategoryID = materialCategoryID;
            
            var category = clsMaterialCategory.Find(materialCategoryID);
            if (category != null)
            {
                lblMaterialCategory.Text = category.MaterialCategoryName;
            }
        }

        private void _ResetDefaultValues()
        {
            _materialInfo = new clsMaterial();
            lblTitle.Text = "Add New Material";
            _ResetMaterialCategoryTabPage();
            _ResetMaterialInfoTabPage();
        }

        private void _ResetMaterialCategoryTabPage()
        {
            ctrlMaterialCategoryInfoWithFilter1.ResetMaterialCategoryFilter();
            btnNext.Enabled = false;
        }

        private void _ResetMaterialInfoTabPage()
        {
            lblMaterialID.Text = "[???]";
            lblMaterialCategory.Text = "[Select Category]";
            txtTradeName.Clear();
            txtChemicalName.Clear();
            chkIsActive.Checked = false;
            btnPrevious.Enabled = true;
        }

        private void _LoadData()
        {
            lblTitle.Text = "Update Material";
            _materialInfo = clsMaterial.Find(_materialID);

            if (_materialInfo == null)
            {
                MessageBox.Show("No material found with ID = " + _materialID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            _materialCategoryID = _materialInfo.MaterialCategoryID;
            _originalChemicalName = _materialInfo.ChemicalName;

            ctrlMaterialCategoryInfoWithFilter1.LoadInfo(_materialCategoryID);
            btnNext.Enabled = true;
            FillMaterialInfoTabPage();
        }

        private void FillMaterialInfoTabPage()
        {
            lblMaterialID.Text = _materialID.ToString();
            lblMaterialCategory.Text = _materialInfo.MaterialCategoryInfo?.MaterialCategoryName ?? string.Empty;
            txtTradeName.Text = _materialInfo.TradeMaterialName;
            txtChemicalName.Text = _materialInfo.ChemicalName;
            chkIsActive.Checked = _materialInfo.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Some fields are not valid! Place the mouse over the red icon(s) to see the error.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var category = clsMaterialCategory.Find(lblMaterialCategory.Text);
            if (category?.MaterialCategoryID != null)
            {
                _materialInfo.MaterialCategoryID = category.MaterialCategoryID.Value;
            }

            _materialInfo.TradeMaterialName = txtTradeName.Text.Trim();
            _materialInfo.ChemicalName = txtChemicalName.Text.Trim();
            _materialInfo.IsActive = chkIsActive.Checked;

            if (_materialInfo.Save())
            {
                _materialID = _materialInfo.MaterialID.Value;
                lblMaterialID.Text = _materialID.ToString();
                
                _mode = enMode.Update;
                lblTitle.Text = "Update Material";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MaterialIDBack?.Invoke(_materialID);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (string.IsNullOrWhiteSpace(txtTradeName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTradeName, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtTradeName, null);
            }
        }

        private void txtChemicalName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChemicalName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtChemicalName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtChemicalName, null);
            }

            // Check if chemical name changed during update, or if it's new, check for duplication
            bool isChemicalNameChanged = (_materialInfo.ChemicalName != txtChemicalName.Text.Trim());
            if (_mode == enMode.AddNew || isChemicalNameChanged)
            {
                if (clsValidation.IsValidChemicalName(txtChemicalName.Text.Trim())) // Assuming this checks if it already exists or is valid
                {
                    // Note: If IsValidChemicalName returns true when it exists:
                    // e.Cancel = true;
                    // errorProvider1.SetError(txtChemicalName, "This name already exists! Choose a new chemical name.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

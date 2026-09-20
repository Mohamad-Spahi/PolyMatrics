using ClassLibBusiness;
using PolyMatrics.Global;
using System;
using System.Windows.Forms;

namespace PolyMatrics.Materials.User_Controls
{
    public partial class ctrlMaterialInfoCard : UserControl
    {
        private int? _materialID;
        private clsMaterial _materialInfo;

        public int? MaterialID => _materialID;
        public clsMaterial SelectedMaterialInfo => _materialInfo;

        public ctrlMaterialInfoCard()
        {
            InitializeComponent();
        }

        public bool LoadInfo(string chemicalName)
        {
            _ResetValues();

            if (!clsValidation.IsValidChemicalName(chemicalName))
            {
                ShowError("Invalid Chemical Name, please choose another one.", "Unknown Chemical Name");
                return false;
            }

            _materialInfo = clsMaterial.Find(chemicalName);
            return ProcessMaterialLoading(_materialInfo);
        }

        public bool LoadInfo(int materialID)
        {
            _ResetValues();

            if (!clsValidation.IsMaterialIDValid(materialID))
            {
                ShowError("Invalid Material ID, please choose another one.", "Unknown Material ID");
                return false;
            }

            _materialInfo = clsMaterial.Find(materialID);
            return ProcessMaterialLoading(_materialInfo);
        }

        private bool ProcessMaterialLoading(clsMaterial material)
        {
            if (material == null)
            {
                ShowError("Something went wrong, please try again later.", "Unknown Error");
                return false;
            }

            _materialInfo = material;
            _materialID = material.MaterialID;
            FillMaterialInfo();
            return true;
        }

        private void ShowError(string message, string title)
        {
            lnkEditMaterialInfo.Enabled = false;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillMaterialInfo()
        {
            if (_materialInfo == null) return;

            _materialID = _materialInfo.MaterialID;
            lblMaterialID.Text = _materialID?.ToString() ?? "[????]";
            lblMaterialCategory.Text = _materialInfo.MaterialCategoryInfo?.MaterialCategoryName ?? "[????]";
            lblTradeMaterialName.Text = _materialInfo.TradeMaterialName;
            lblChemicalName.Text = _materialInfo.ChemicalName;
            chkIsActive.Checked = _materialInfo.IsActive;

            lnkEditMaterialInfo.Enabled = true;
        }

        private void _ResetValues()
        {
            _materialID = null;
            _materialInfo = null;

            lblMaterialID.Text = "[????]";
            lblMaterialCategory.Text = "[????]";
            lblTradeMaterialName.Text = "Material Name...";
            lblChemicalName.Text = "Chemical Name...";
            chkIsActive.Checked = false;

            lnkEditMaterialInfo.Enabled = false;
        }

        private void lnkEditMaterialInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_materialID.HasValue) return;

            using (var frm = new frmAddUpdateMaterial(_materialID.Value))
            {
                frm.ShowDialog();
            }

            // Optional: Reload the info after editing to reflect changes immediately
            LoadInfo(_materialID.Value);
        }
    }
}
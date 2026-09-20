using ClassLibBusiness;
using PolyMatrics.Global;
using System;
using System.Windows.Forms;

namespace PolyMatrics.Machines.MaterialCategories
{
    public partial class ctrlMaterialCategoryCardInfo : UserControl
    {
        private int? _materialCategoryID;
        public int? SelectedMaterialCategoryID => _materialCategoryID;

        private clsMaterialCategory _materialCategoryInfo;
        public clsMaterialCategory SelectedMaterialCategory => _materialCategoryInfo;

        public ctrlMaterialCategoryCardInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(string materialCategoryName)
        {
            _ResetValues();

            if (string.IsNullOrWhiteSpace(materialCategoryName))
            {
                ShowError("Invalid Material Category Name.", "Error");
                return;
            }

            _materialCategoryInfo = clsMaterialCategory.Find(materialCategoryName);

            if (_materialCategoryInfo == null)
            {
                ShowError("Something went wrong, please try again later.", "Unknown Error");
                return;
            }

            FillMaterialCategoryInfo();
        }

        public void LoadInfo(int materialCategoryID)
        {
            _ResetValues();

            if (!clsValidation.IsValidMaterialCategoryID(materialCategoryID))
            {
                ShowError("Invalid Material Category ID.", "Error");
                return;
            }

            _materialCategoryInfo = clsMaterialCategory.Find(materialCategoryID);

            if (_materialCategoryInfo == null)
            {
                ShowError("Something went wrong, please try again later.", "Unknown Error");
                return;
            }

            FillMaterialCategoryInfo();
        }

        private void ShowError(string message, string title)
        {
            lnkEditMaterialCategory.Visible = false;
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillMaterialCategoryInfo()
        {
            if (_materialCategoryInfo == null) return;

            _materialCategoryID = _materialCategoryInfo.MaterialCategoryID;
            lblMaterialCategoryID.Text = _materialCategoryID?.ToString() ?? "[???]";
            lblMaterialCategoryName.Text = _materialCategoryInfo.MaterialCategoryName;
            lblMaterialCategoryDescryption.Text = _materialCategoryInfo.MaterialCategoryDescryption; // Keep original control name matching designer

            // If you implement edit feature later, enable/show it here
            lnkEditMaterialCategory.Visible = false; // Keep hidden until implemented
        }

        public void ResetMaterialCategoryInfo()
        {
            _ResetValues();
        }

        private void _ResetValues()
        {
            _materialCategoryID = null;
            _materialCategoryInfo = null;

            lblMaterialCategoryID.Text = "[???]";
            lblMaterialCategoryName.Text = "Material Category Name...";
            lblMaterialCategoryDescryption.Text = "Material Category Description...";

            lnkEditMaterialCategory.Visible = false; // Hide unsupported features for better UX
        }

        private void lnkEditMaterialCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature will be implemented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
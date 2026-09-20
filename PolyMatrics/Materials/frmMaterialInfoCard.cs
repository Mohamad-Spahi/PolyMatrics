using ClassLibBusiness;
using PolyMatrics.Global;
using System;
using System.Windows.Forms;

namespace PolyMatrics.Materials
{
    public partial class frmMaterialInfoCard : Form
    {
        public frmMaterialInfoCard(int materialID)
        {
            InitializeComponent();

            if (!clsValidation.IsMaterialIDValid(materialID))
            {
                ShowErrorAndClose("Invalid Material ID. Please choose another one.", "Unknown Material ID");
                return;
            }

            LoadMaterialAndCategoryInfo(ctrlMaterialInfoCard1.LoadInfo(materialID));
        }

        public frmMaterialInfoCard(string chemicalName)
        {
            InitializeComponent();

            if (!clsValidation.IsValidChemicalName(chemicalName))
            {
                ShowErrorAndClose("Invalid Chemical Name. Please choose another one.", "Unknown Chemical Name");
                return;
            }

            LoadMaterialAndCategoryInfo(ctrlMaterialInfoCard1.LoadInfo(chemicalName));
        }

        /// <summary>
        /// Helper method to display an error message and safely close the form.
        /// </summary>
        private void ShowErrorAndClose(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Ensures the form closes properly without fully rendering or crashing
            this.Load += (s, e) => this.Close();
        }

        /// <summary>
        /// Loads the category info based on the loaded material details.
        /// </summary>
        private void LoadMaterialAndCategoryInfo(bool isMaterialLoadedSuccessfully)
        {
            if (isMaterialLoadedSuccessfully && ctrlMaterialInfoCard1.SelectedMaterialInfo != null)
            {
                ctrlMaterialCategoryCardInfo1.LoadInfo(ctrlMaterialInfoCard1.SelectedMaterialInfo.MaterialCategoryID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
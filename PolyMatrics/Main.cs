using PolyMatrics.Materials;
using System;
using System.Windows.Forms;

namespace PolyMatrics
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmMaterials())
            {
                frm.ShowDialog();
            }
        }

        private void manageMaterialCategoriesToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void materialTDSsToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void updateTDSToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void showMaterialCOAToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void updateCOAToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void addNewCOAToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();

        /// <summary>
        /// Displays a standardized message for features that are under development.
        /// </summary>
        private void ShowNotImplementedMessage()
        {
            MessageBox.Show("This feature will be implemented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
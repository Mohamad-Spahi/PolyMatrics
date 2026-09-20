using PolyMatrics.Materials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyMatrics.Materials.MaterialCategories;
using PolyMatrics.Machines.MaterialCategories;
namespace PolyMatrics
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void formulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showFoamResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterials frm=new frmMaterials();
            frm.ShowDialog();
        }

        private void manageMaterialCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       

       

       

        private void materialTDSsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void updateTDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void showMaterialCOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void updateCOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void addNewCOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void showFormulationStagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageFormulationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

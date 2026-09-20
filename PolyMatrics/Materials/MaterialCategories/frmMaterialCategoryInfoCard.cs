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
    public partial class frmMaterialCategoryInfoCard : Form
    {
        public frmMaterialCategoryInfoCard(int MaterialCategoryID)
        {
            InitializeComponent();

            if (!clsValidation.IsValidMaterialCategoryID(MaterialCategoryID))
            {
                MessageBox.Show("Invalid Category ID Please choose another one.", "Unknow Category ID In The System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlMaterialCategoryCardInfo1.LoadInfo(MaterialCategoryID);
        }
        public frmMaterialCategoryInfoCard(string MaterialCategoryName)
        {
            InitializeComponent();

            if (!clsValidation.IsValidMaterialCategoryName(MaterialCategoryName))
            {
                MessageBox.Show("Invalid Category Name Please choose another one.", "Unknow Category Name In The System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlMaterialCategoryCardInfo1.LoadInfo(MaterialCategoryName);
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

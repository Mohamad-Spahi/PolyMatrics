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

namespace PolyMatrics.Materials
{
    public partial class frmMaterialInfoCard : Form
    {   
        public frmMaterialInfoCard(int MaterialID)
        {
            InitializeComponent();

            if (!clsValidation.IsMaterialIDValid(MaterialID))
            {
                MessageBox.Show("Invalid MaterialID Please choose another one.", "Unknow Material ID In The System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if(ctrlMaterialInfoCard1.LoadInfo(MaterialID))
            ctrlMaterialCategoryCardInfo1.LoadInfo(ctrlMaterialInfoCard1.SelectedMaterialInfo.MaterialCategoryID);

        }
        public frmMaterialInfoCard(string ChemicalName)
        {
            InitializeComponent();

            if (!clsValidation.IsValidChemicalName(ChemicalName))
            {
                MessageBox.Show("Invalid Chemical Name Please choose another one.", "Unknow Chemical Name In The System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if(ctrlMaterialInfoCard1.LoadInfo(ChemicalName))
            ctrlMaterialCategoryCardInfo1.LoadInfo(ctrlMaterialInfoCard1.SelectedMaterialInfo.MaterialCategoryID);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

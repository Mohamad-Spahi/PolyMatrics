using ClassLibBusiness;
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
    public partial class frmMaterials : Form
    {
        private static DataTable _dtAllMaterials = clsMaterial.GetAllMaterials();

        //only select the columns that you want to show in the grid
        //With their orders you want to show
        private DataTable _dtMaterials = _dtAllMaterials.DefaultView.ToTable(false, "MaterialID",
            "TradeMaterialName", "MaterialCategoryName", "ChemicalName", "IsActive");


        private void _RefreshMaterialList()
        {
            _dtAllMaterials = clsMaterial.GetAllMaterials();

            _dtMaterials = _dtAllMaterials.DefaultView.ToTable(false, "MaterialID",
           "TradeMaterialName", "MaterialCategoryName", "ChemicalName", "IsActive");

            dgvMaterials.DataSource = _dtMaterials;
            lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();
        }

        private void _FillMaterialCategoriesComboBox()
        {
            cbMaterialCategory.Items.Clear();
            cbMaterialCategory.Items.Add("All Material Categories");
            foreach (DataRow MCRecord in clsMaterialCategory.GetAllMaterialCategories().Rows)
            {
                cbMaterialCategory.Items.Add(MCRecord["MaterialCategoryName"].ToString());
            }
        }
        public frmMaterials()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        
        {
            this.Close();
        }
        private void _FillMaterialList()
        {
            _RefreshMaterialList();
        }
        private void frmMaterials_Load(object sender, EventArgs e)
        {
            _FillMaterialCategoriesComboBox();
            _FillMaterialList();
            
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
            lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();

            if (dgvMaterials.Rows.Count > 0)
            {
                dgvMaterials.Columns[0].HeaderText = "Material ID";
                dgvMaterials.Columns[0].Width = 110;

                dgvMaterials.Columns[1].HeaderText = "Material Name";
                dgvMaterials.Columns[1].Width = 200;

                dgvMaterials.Columns[2].HeaderText = "Material Category";
                dgvMaterials.Columns[2].Width = 170;

                dgvMaterials.Columns[3].HeaderText = "Chemical Name";
                dgvMaterials.Columns[3].Width = 400;

                dgvMaterials.Columns[4].HeaderText = "Is Active";
                dgvMaterials.Columns[4].Width = 75;
            }


        }

        
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            switch (cbFilterBy.Text)
            {

                case "None":
                    txtFilterValue.Clear();
                    txtFilterValue.Visible = true;
                    txtFilterValue.Enabled = false;
                    cbIsActive.Visible = false;
                    cbMaterialCategory.Visible = false;
                    break;
                case "Material Category":
                    cbMaterialCategory.SelectedIndex = cbMaterialCategory.FindString("All Material Categories");
                    cbMaterialCategory.Visible = true;
                    txtFilterValue.Visible = false;
                    cbIsActive.Visible = false;
                    
                    break;

                case "Is Active":
                    cbIsActive.SelectedIndex = cbIsActive.FindString("All");
                    cbIsActive.Visible = true;
                    txtFilterValue.Visible= false;
                    cbMaterialCategory.Visible = false;
                    
                    break;
                default:
                    txtFilterValue.Clear();
                    txtFilterValue.Visible = true;
                    txtFilterValue.Enabled = true;
                    cbMaterialCategory.Visible = false;
                    cbIsActive.Visible = false;
                    
                    break;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Material ID":
                    FilterColumn = "MaterialID";
                    break;
                case "Material Name":
                    FilterColumn = "TradeMaterialName";
                    break;
                case "Chemical Name":
                    FilterColumn = "ChemicalName";
                    break;
                
                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (FilterColumn=="None"||txtFilterValue.Text.Trim()=="")
            {
                _dtMaterials.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "MaterialID")
                //in this case we deal with integer not string.
                _dtMaterials.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtMaterials.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",FilterColumn, txtFilterValue.Text.Trim());

            lblTotalRecords.Text=dgvMaterials.Rows.Count.ToString();    
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (cbIsActive.Text)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtMaterials.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtMaterials.DefaultView.RowFilter=string.Format("[{0}] = {1}",FilterColumn, FilterValue);

            lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();
        }

        private void cbMaterialCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "MaterialCategoryName";
           
            if (cbMaterialCategory.Text == "All Material Categories")
            {
                _dtMaterials.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();
            }
            else
            {
                _dtMaterials.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, cbMaterialCategory.Text);
                lblTotalRecords.Text=dgvMaterials.Rows.Count.ToString();    
            }

        }

        private void dgvMaterials_DoubleClick(object sender, EventArgs e)
        {

            frmMaterialInfoCard frm = new frmMaterialInfoCard(int.Parse(dgvMaterials.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

       
        private void _RefreshMaterialCategoryComboBox()
        {
            _FillMaterialCategoriesComboBox();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaterial frm=new frmAddUpdateMaterial();
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

        private void findMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindMaterial frm=new frmFindMaterial();
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

        private void showMaterialDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialInfoCard frm = new frmMaterialInfoCard(int.Parse(dgvMaterials.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

        private void addNewMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaterial frm = new frmAddUpdateMaterial();
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

        private void updateMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaterial frm = new frmAddUpdateMaterial(int.Parse(dgvMaterials.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();

            frmMaterials_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult WarningDeletionMessageResult=MessageBox.Show("Are you sure you want to delete this Material!", "Confim Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (WarningDeletionMessageResult == DialogResult.OK)
            {
                int MaterialID = (int)dgvMaterials.CurrentRow.Cells[0].Value;
                if (clsMaterial.DeleteMaterial(MaterialID))
                {
                    MessageBox.Show("Material has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMaterials_Load(null, null);
                }else
                {
                    MessageBox.Show("Material is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void showMaterialTDSsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void showMaterialCOAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implmented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            //we allow number incase Material id is selected.
            if (cbFilterBy.Text == "Material ID" )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        
        }
    }
}

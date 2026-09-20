using ClassLibBusiness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PolyMatrics.Materials
{
    public partial class frmMaterials : Form
    {
        private DataTable _dtAllMaterials;
        private DataTable _dtMaterials;

        public frmMaterials()
        {
            InitializeComponent();
        }

        private void frmMaterials_Load(object sender, EventArgs e)
        {
            InitializeMaterialScreen();
        }

        private void InitializeMaterialScreen()
        {
            _FillMaterialCategoriesComboBox();
            _RefreshMaterialList();
            
            if (cbFilterBy.Items.Count > 0)
            {
                cbFilterBy.SelectedIndex = cbFilterBy.FindStringExact("None");
            }
            
            ConfigureGridColumns();
        }

        private void _RefreshMaterialList()
        {
            _dtAllMaterials = clsMaterial.GetAllMaterials();

            // Select only required columns
            _dtMaterials = _dtAllMaterials.DefaultView.ToTable(false, 
                "MaterialID", "TradeMaterialName", "MaterialCategoryName", "ChemicalName", "IsActive");

            dgvMaterials.DataSource = _dtMaterials;
            UpdateTotalRecordsCount();
        }

        private void UpdateTotalRecordsCount()
        {
            lblTotalRecords.Text = dgvMaterials.Rows.Count.ToString();
        }

        private void ConfigureGridColumns()
        {
            if (dgvMaterials.Rows.Count == 0) return;

            string[] headers = { "Material ID", "Material Name", "Material Category", "Chemical Name", "Is Active" };
            int[] widths = { 110, 200, 170, 400, 75 };

            for (int i = 0; i < headers.Length && i < dgvMaterials.Columns.Count; i++)
            {
                dgvMaterials.Columns[i].HeaderText = headers[i];
                dgvMaterials.Columns[i].Width = widths[i];
            }
        }

        private void _FillMaterialCategoriesComboBox()
        {
            cbMaterialCategory.Items.Clear();
            cbMaterialCategory.Items.Add("All Material Categories");
            
            foreach (DataRow row in clsMaterialCategory.GetAllMaterialCategories().Rows)
            {
                cbMaterialCategory.Items.Add(row["MaterialCategoryName"].ToString());
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterOption = cbFilterBy.Text;

            txtFilterValue.Visible = (filterOption != "None" && filterOption != "Material Category" && filterOption != "Is Active");
            txtFilterValue.Enabled = txtFilterValue.Visible;
            if (txtFilterValue.Visible) txtFilterValue.Clear();

            cbMaterialCategory.Visible = (filterOption == "Material Category");
            if (cbMaterialCategory.Visible) cbMaterialCategory.SelectedIndex = cbMaterialCategory.FindStringExact("All Material Categories");

            cbIsActive.Visible = (filterOption == "Is Active");
            if (cbIsActive.Visible) cbIsActive.SelectedIndex = cbIsActive.FindStringExact("All");
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = GetFilterColumnName();
            string filterValue = txtFilterValue.Text.Trim();

            if (filterColumn == "None" || string.IsNullOrEmpty(filterValue))
            {
                _dtMaterials.DefaultView.RowFilter = string.Empty;
            }
            else if (filterColumn == "MaterialID")
            {
                _dtMaterials.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, filterValue);
            }
            else
            {
                _dtMaterials.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
            }

            UpdateTotalRecordsCount();
        }
        private string GetFilterColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Material ID": return "MaterialID";
                case "Material Name": return "TradeMaterialName";
                case "Chemical Name": return "ChemicalName";
                default: return "None";
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _dtMaterials.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string filterValue = (cbIsActive.Text == "Yes") ? "1" : "0";
                _dtMaterials.DefaultView.RowFilter = string.Format("[IsActive] = {0}", filterValue);
            }

            UpdateTotalRecordsCount();
        }

        private void cbMaterialCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaterialCategory.Text == "All Material Categories")
            {
                _dtMaterials.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                _dtMaterials.DefaultView.RowFilter = string.Format("[MaterialCategoryName] = '{0}'", cbMaterialCategory.Text);
            }

            UpdateTotalRecordsCount();
        }

        private void ShowMaterialInfo(int materialId)
        {
            using (frmMaterialInfoCard frm = new frmMaterialInfoCard(materialId))
            {
                frm.ShowDialog();
            }
            _RefreshMaterialList();
        }

        private void OpenAddUpdateForm(int? materialId = null)
        {
            Form frm = materialId.HasValue ? new frmAddUpdateMaterial(materialId.Value) : new frmAddUpdateMaterial();
            using (frm)
            {
                frm.ShowDialog();
            }
            _RefreshMaterialList();
        }

        private int? GetSelectedMaterialId()
        {
            if (dgvMaterials.CurrentRow != null && dgvMaterials.CurrentRow.Cells[0].Value != null)
            {
                return Convert.ToInt32(dgvMaterials.CurrentRow.Cells[0].Value);
            }
            return null;
        }

        private void dgvMaterials_DoubleClick(object sender, EventArgs e)
        {
            int? materialId = GetSelectedMaterialId();
            if (materialId.HasValue) ShowMaterialInfo(materialId.Value);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnAddNew_Click(object sender, EventArgs e) => OpenAddUpdateForm();

        private void findMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmFindMaterial frm = new frmFindMaterial())
            {
                frm.ShowDialog();
            }
            _RefreshMaterialList();
        }

        private void showMaterialDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? materialId = GetSelectedMaterialId();
            if (materialId.HasValue) ShowMaterialInfo(materialId.Value);
        }

        private void addNewMaterialToolStripMenuItem_Click(object sender, EventArgs e) => OpenAddUpdateForm();

        private void updateMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? materialId = GetSelectedMaterialId();
            if (materialId.HasValue) OpenAddUpdateForm(materialId.Value);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? materialId = GetSelectedMaterialId();
            if (!materialId.HasValue) return;

            var confirmResult = MessageBox.Show("Are you sure you want to delete this Material?", 
                "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
             if (confirmResult == DialogResult.OK)
            {
                if (clsMaterial.DeleteMaterial(materialId.Value))
                {
                    MessageBox.Show("Material has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshMaterialList();
                }
                else
                {
                    MessageBox.Show("Material is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showMaterialTDSsToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();
        private void showMaterialCOAsToolStripMenuItem_Click(object sender, EventArgs e) => ShowNotImplementedMessage();

        private void ShowNotImplementedMessage()
        {
            MessageBox.Show("This feature will be implemented soon.", "Spot Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Material ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}

using ClassLibBusiness;
using PolyMatrics.Machines.MaterialCategories;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace PolyMatrics.Materials.MaterialCategories.UserControls
{
    public partial class ctrlMaterialCategoryInfoWithFilter : UserControl
    {
        // Event raised when a material category is selected
        public event Action<int> OnMaterialCategorySelected;

        protected virtual void RaiseOnMaterialCategorySelected(int materialCategoryID)
        {
            OnMaterialCategorySelected?.Invoke(materialCategoryID);
        }

        private bool _showAddMaterialCategory;
        public bool ShowAddMaterialCategory
        {
            get => _showAddMaterialCategory;
            set
            {
                _showAddMaterialCategory = value;
                btnAddNewCategory.Visible = _showAddMaterialCategory;
            }
        }

        private bool _filterEnabled = true;
        public bool FilterEnabled
        {
            get => _filterEnabled;
            set
            {
                _filterEnabled = value;
                gbMaterialCategoryFilter.Enabled = _filterEnabled;
            }
        }

        public int MaterialCategoryID => ctrlMaterialCategoryCardInfo1.SelectedMaterialCategoryID ?? -1;

        public clsMaterialCategory MaterialCategoryInfo => ctrlMaterialCategoryCardInfo1.SelectedMaterialCategory;

        public ctrlMaterialCategoryInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlMaterialCategoryInfoWithFilter_Load(object sender, EventArgs e)
        {
            SetDefaultFilterSelection();
            txtFilterValue.Focus();
        }

        private void SetDefaultFilterSelection()
        {
            int index = cbFilterBy.FindStringExact("Category ID");
            if (index != -1) cbFilterBy.SelectedIndex = index;
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        public void LoadInfo(int materialCategoryID)
        {
            FilterEnabled = false;
            SetDefaultFilterSelection();
            txtFilterValue.Text = materialCategoryID.ToString();
            ctrlMaterialCategoryCardInfo1.LoadInfo(materialCategoryID);
        }

        public void LoadInfo(string materialCategoryName)
        {
            FilterEnabled = false;
            int index = cbFilterBy.FindStringExact("Category Name");
            if (index != -1) cbFilterBy.SelectedIndex = index;
            
            txtFilterValue.Text = materialCategoryName;
            ctrlMaterialCategoryCardInfo1.LoadInfo(materialCategoryName);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter key triggers search
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFind.PerformClick();
            }

            // Allow only digits if Category ID filter is selected
            if (cbFilterBy.Text == "Category ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            txtFilterValue.Focus();
        }

        private void FindNow()
        {
            string filterOption = cbFilterBy.Text;
            string filterValue = txtFilterValue.Text.Trim();
            if (filterOption == "Category ID")
            {
                if (int.TryParse(filterValue, out int categoryID))
                {
                    ctrlMaterialCategoryCardInfo1.LoadInfo(categoryID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Category ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (filterOption == "Category Name")
            {
                ctrlMaterialCategoryCardInfo1.LoadInfo(filterValue);
            }

            if (ctrlMaterialCategoryCardInfo1.SelectedMaterialCategoryID.HasValue && FilterEnabled)
            {
                RaiseOnMaterialCategorySelected(ctrlMaterialCategoryCardInfo1.SelectedMaterialCategoryID.Value);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Place the mouse over the red icon(s) to see the error.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void MaterialCategoryIDBacked(int materialCategoryID)
        {
            LoadInfo(materialCategoryID);

            if (FilterEnabled && ctrlMaterialCategoryCardInfo1.SelectedMaterialCategoryID.HasValue)
            {
                RaiseOnMaterialCategorySelected(materialCategoryID);
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAddUpdateMaterialCategory())
            {
                frm.MaterialCategoryIDBack += MaterialCategoryIDBacked;
                frm.ShowDialog();
            }
        }

        public void ResetMaterialCategoryFilter()
        {
            ctrlMaterialCategoryCardInfo1.ResetMaterialCategoryInfo();
            SetDefaultFilterSelection();
            txtFilterValue.Clear();
            FilterEnabled = true;
            txtFilterValue.Focus();
        }
    }
}
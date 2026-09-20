using ClassLibBusiness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PolyMatrics.Materials.User_Controls
{
    public partial class ctrlMaterialInfoWithFilter : UserControl
    {
        // Event raised when a material is selected
        public event Action<int> OnMaterialSelected;

        protected virtual void RaiseOnMaterialSelected(int materialID)
        {
            OnMaterialSelected?.Invoke(materialID);
        }

        private bool _showAddMaterial;
        public bool ShowAddMaterial
        {
            get => _showAddMaterial;
            set
            {
                _showAddMaterial = value;
                btnAddNewMaterial.Visible = _showAddMaterial;
            }
        }

        private bool _filterEnabled = true;
        public bool FilterEnabled
        {
            get => _filterEnabled;
            set
            {
                _filterEnabled = value;
                gbMaterialFilter.Enabled = _filterEnabled;
            }
        }

        public int MaterialID => ctrlMaterialInfoCard1.MaterialID ?? -1;

        public clsMaterial MaterialInfo => ctrlMaterialInfoCard1.SelectedMaterialInfo;

        public ctrlMaterialInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlMaterialInfoWithFilter_Load(object sender, EventArgs e)
        {
            SetDefaultFilterSelection();
            txtFilterValue.Focus();
        }

        private void SetDefaultFilterSelection()
        {
            int index = cbFilterBy.FindStringExact("Material ID");
            if (index != -1) cbFilterBy.SelectedIndex = index;
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        public void LoadInfo(int materialID)
        {
            FilterEnabled = false;
            SetDefaultFilterSelection();
            txtFilterValue.Text = materialID.ToString();
            ctrlMaterialInfoCard1.LoadInfo(materialID);
        }

        public void LoadInfo(string chemicalName)
        {
            FilterEnabled = false;
            int index = cbFilterBy.FindStringExact("Chemical Name");
            if (index != -1) cbFilterBy.SelectedIndex = index;
            
            txtFilterValue.Text = chemicalName;
            ctrlMaterialInfoCard1.LoadInfo(chemicalName);
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFind.PerformClick();
            }

            // Allow only digits if Material ID filter is selected
            if (cbFilterBy.Text == "Material ID")
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

            if (filterOption == "Material ID")
            {
                if (int.TryParse(filterValue, out int materialID))
                {
                    ctrlMaterialInfoCard1.LoadInfo(materialID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Material ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (filterOption == "Chemical Name" || filterOption == "Material Name")
            {
                ctrlMaterialInfoCard1.LoadInfo(filterValue);
            }

            if (ctrlMaterialInfoCard1.MaterialID.HasValue && FilterEnabled)
            {
                RaiseOnMaterialSelected(ctrlMaterialInfoCard1.MaterialID.Value);
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

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAddUpdateMaterial())
            {
                frm.MaterialIDBack += MaterialIDBacked;
                frm.ShowDialog();
            }
        }

        private void MaterialIDBacked(int materialID)
        {
            LoadInfo(materialID);
            
            if (FilterEnabled && ctrlMaterialInfoCard1.MaterialID.HasValue)
            {
                RaiseOnMaterialSelected(materialID);
            }
        }
    }
}
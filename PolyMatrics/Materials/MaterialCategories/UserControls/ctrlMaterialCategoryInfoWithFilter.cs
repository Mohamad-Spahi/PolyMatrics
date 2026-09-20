using ClassLibBusiness;
using PolyMatrics.Machines.MaterialCategories;
using PolyMatrics.Materials.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMatrics.Materials.MaterialCategories.UserControls
{
    public partial class ctrlMaterialCategoryInfoWithFilter : UserControl
    {
        
        public event Action<int> OnMaterialCategorySelected;
        
        protected virtual void MaterialSelected(int MaterialCategoryID)
        {

            Action<int> handler = OnMaterialCategorySelected;
            if (handler != null)
            {
                handler(MaterialCategoryID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddMaterialCategory {  get; set; }

        public bool ShowAddMaterial
        {
            get { return _ShowAddMaterialCategory; }

            set
            {
                _ShowAddMaterialCategory= value;
                btnAddNewCategory.Visible = _ShowAddMaterialCategory;
            }
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private bool _FilterEnabled { get; set; }

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gbMaterialCategoryFilter.Enabled = _FilterEnabled;
            }
        }

        private int _MaterialCategoryID {  get; set; }

        public int MaterialCategoryID { get { return  _MaterialCategoryID; }  }

        public clsMaterialCategory MaterialCategoryInfo { get { return ctrlMaterialCategoryCardInfo1.SelectedMaterialCategory; } }

        public ctrlMaterialCategoryInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadInfo(int MaterialCategoryID)
        {
            
            FilterEnabled = false;
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Category ID");
            txtFilterValue.Text=MaterialCategoryID.ToString();
            ctrlMaterialCategoryCardInfo1.LoadInfo(MaterialCategoryID);

        }
        public void LoadInfo(string MaterialCategoryName)
        {

            FilterEnabled = false;
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Category Name");
            txtFilterValue.Text = MaterialCategoryName.ToString();
            ctrlMaterialCategoryCardInfo1.LoadInfo(MaterialCategoryName);

        }
        private void ctrlMaterialCategoryInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Category ID");
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if Category id is selected
            if (cbFilterBy.Text == "Category ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Category ID":
                    ctrlMaterialCategoryCardInfo1.LoadInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "Category Name":
                    ctrlMaterialCategoryCardInfo1.LoadInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnMaterialCategorySelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnMaterialCategorySelected(ctrlMaterialCategoryCardInfo1.SelectedMaterialCategoryID.Value);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();

        }

        private void MaterialCategoryIDBacked(int MaterialCategoryID)
        {
            //Hanlde recieved MaterialID
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Category ID");
            txtFilterValue.Text = MaterialCategoryID.ToString();
            ctrlMaterialCategoryCardInfo1.LoadInfo(MaterialCategoryID);

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaterialCategory frm= new frmAddUpdateMaterialCategory();
            frm.MaterialCategoryIDBack += MaterialCategoryIDBacked;
            frm.ShowDialog();
        }

        public void ResetMaterialCategoryFilter()
        {
            ctrlMaterialCategoryCardInfo1.ResetMaterialCategoryInfo();
            ctrlMaterialCategoryInfoWithFilter_Load(null, null);
            FilterEnabled = true;
        }
    }
}

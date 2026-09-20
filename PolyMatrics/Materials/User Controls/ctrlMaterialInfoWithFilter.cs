using ClassLibBusiness;
using PolyMatrics.Global;
using PolyMatrics.Machines.MaterialCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMatrics.Materials.User_Controls
{
    public partial class ctrlMaterialInfoWithFilter : UserControl
    {
        //when Material has been Selected, then we raise event to tell other who the selected material
        public event Action<int> OnMaterialSelected;
        
        // Create a protected method to raise the event with a parameter
        protected virtual void MaterialSelected(int MaterialID)
        {
            Action<int> handler = OnMaterialSelected;
            if (handler != null)
            {
                handler(MaterialID); // Raise the event with the parameter
            }
        }
        //Control Settings: AddButton, FilterEnabled and FilterFocusing

        private bool _ShowAddMaterial {  get; set; }

        public bool ShowAddMaterial
        {
            get { return _ShowAddMaterial; }

            set
            {
                _ShowAddMaterial = value;
                btnAddNewMaterial.Visible= _ShowAddMaterial;
            }
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private bool _FilterEnabled {  get; set; }

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gbMaterialFilter.Enabled= _FilterEnabled;
            }
        }
        //Dealing with Main Varialbles: MaterialID and MaterialInfo object

        private int? _MaterialID {  get; set; }
        public int MaterialID { get { return _MaterialID.Value; } }

        public clsMaterial MaterialInfo { get { return ctrlMaterialInfoCard1.SelectedMaterialInfo; } }

        public void LoadInfo(int MaterialID)
        {

            FilterEnabled = false;
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Material ID");
            txtFilterValue.Text = MaterialID.ToString();
            ctrlMaterialInfoCard1.LoadInfo(MaterialID);

        }
        public void LoadInfo(string ChemicalName)
        {

            FilterEnabled = false;
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Material Name");
            txtFilterValue.Text = ChemicalName.ToString();
            ctrlMaterialInfoCard1.LoadInfo(ChemicalName);

        }
        public ctrlMaterialInfoWithFilter()
        {
            InitializeComponent();
        }
        private void ctrlMaterialInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Material ID");
            txtFilterValue.Focus();
        }
        

        //Error Validation Settings
        //Validate value to check the value is not nothing
        
        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        //this method responsible for manage type of keys that user entered
        //for Type Filter if this type just take numbers then 
        //txtFilterValue TextBox will not take any other type rather than numbers

        //In Addition to the key Press that handle out passing is Enter key(Character code 13)
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if Material id is selected
            if (cbFilterBy.Text == "Material ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //Here we check if value FindBy combo box is changed to reset txtFiltervalue textBox
        //And reFocus to this textbox
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        //In this Section we deal with methods that handle search 
        
        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Material ID":
                    ctrlMaterialInfoCard1.LoadInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "Chemical Name":
                    ctrlMaterialInfoCard1.LoadInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnMaterialSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnMaterialSelected(ctrlMaterialInfoCard1.MaterialID.Value);
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

        //If User choose new material.So, we must deal with the new materialID 
        //that created and returned from Add New Material Form that has event called when
        //Material ID is determined

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaterial frm=new frmAddUpdateMaterial();
            frm.MaterialIDBack += MaterialIDBacked; //subscribe to the event
            frm.ShowDialog();

        }

        private void MaterialIDBacked(int MaterialID)
        {
            //Hanlde recieved MaterialID
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Material ID");
            txtFilterValue.Text = MaterialID.ToString();
            ctrlMaterialInfoCard1.LoadInfo(MaterialID);

        }
        
    }
}

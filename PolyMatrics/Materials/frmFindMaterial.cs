using System;
using System.Windows.Forms;

namespace PolyMatrics.Materials
{
    public partial class frmFindMaterial : Form
    {
        // 1. Fixed parameter name from PersonID to MaterialID (Clean Code naming convention)
        public delegate void MaterialIDBackEventHandler(int materialID);

        // 2. Event declaration
        public event MaterialIDBackEventHandler MaterialIDDataBack;

        public frmFindMaterial()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form
            // Ensure we safely pass the ID
            int selectedMaterialId = ctrlMaterialInfoWithFilter1.MaterialID;

            MaterialIDDataBack?.Invoke(selectedMaterialId);

            // Close the form after sending data back
            this.Close();
        }
    }
}
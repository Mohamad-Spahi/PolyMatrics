using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyMatrics.Materials.MaterialCategories
{
    public partial class frmMaterialCategoryInfoWithFilter : Form
    {
        // Declare a delegate
        public delegate void CategoryIDBackEventHandler(int MaterialCategoryID);

        // Declare an event using the delegate
        public event CategoryIDBackEventHandler CategoryIDDataBack;

        public frmMaterialCategoryInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form.
            CategoryIDDataBack?.Invoke( ctrlMaterialCategoryInfoWithFilter1.MaterialCategoryID);

        }
    }
}

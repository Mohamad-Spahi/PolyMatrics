namespace PolyMatrics.Materials.MaterialCategories.UserControls
{
    partial class ctrlMaterialCategoryInfoWithFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbMaterialCategoryFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlMaterialCategoryCardInfo1 = new PolyMatrics.Machines.MaterialCategories.ctrlMaterialCategoryCardInfo();
            this.gbMaterialCategoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMaterialCategoryFilter
            // 
            this.gbMaterialCategoryFilter.Controls.Add(this.btnAddNewCategory);
            this.gbMaterialCategoryFilter.Controls.Add(this.btnFind);
            this.gbMaterialCategoryFilter.Controls.Add(this.txtFilterValue);
            this.gbMaterialCategoryFilter.Controls.Add(this.label1);
            this.gbMaterialCategoryFilter.Controls.Add(this.cbFilterBy);
            this.gbMaterialCategoryFilter.Controls.Add(this.label2);
            this.gbMaterialCategoryFilter.Location = new System.Drawing.Point(0, 0);
            this.gbMaterialCategoryFilter.Name = "gbMaterialCategoryFilter";
            this.gbMaterialCategoryFilter.Size = new System.Drawing.Size(692, 60);
            this.gbMaterialCategoryFilter.TabIndex = 2;
            this.gbMaterialCategoryFilter.TabStop = false;
            this.gbMaterialCategoryFilter.Text = "Material Category Filter";
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(619, 12);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(68, 42);
            this.btnAddNewCategory.TabIndex = 21;
            this.btnAddNewCategory.Text = "Add";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(545, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 42);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(352, 25);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(187, 26);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter Value: ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Category ID",
            "Category Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(97, 25);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 28);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlMaterialCategoryCardInfo1
            // 
            this.ctrlMaterialCategoryCardInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMaterialCategoryCardInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMaterialCategoryCardInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMaterialCategoryCardInfo1.Location = new System.Drawing.Point(0, 58);
            this.ctrlMaterialCategoryCardInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMaterialCategoryCardInfo1.Name = "ctrlMaterialCategoryCardInfo1";
            this.ctrlMaterialCategoryCardInfo1.Size = new System.Drawing.Size(641, 188);
            this.ctrlMaterialCategoryCardInfo1.TabIndex = 1;
            // 
            // ctrlMaterialCategoryInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.gbMaterialCategoryFilter);
            this.Controls.Add(this.ctrlMaterialCategoryCardInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlMaterialCategoryInfoWithFilter";
            this.Size = new System.Drawing.Size(694, 250);
            this.Load += new System.EventHandler(this.ctrlMaterialCategoryInfoWithFilter_Load);
            this.gbMaterialCategoryFilter.ResumeLayout(false);
            this.gbMaterialCategoryFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Machines.MaterialCategories.ctrlMaterialCategoryCardInfo ctrlMaterialCategoryCardInfo1;
        private System.Windows.Forms.GroupBox gbMaterialCategoryFilter;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

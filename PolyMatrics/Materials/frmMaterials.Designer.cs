namespace PolyMatrics.Materials
{
    partial class frmMaterials
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.cmsMaterialManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.findMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMaterialDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showMaterialTDSsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMaterialCOAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMaterialFilter = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbMaterialCategory = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pbMaterialImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.cmsMaterialManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbMaterialFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(922, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.ContextMenuStrip = this.cmsMaterialManagement;
            this.dgvMaterials.Location = new System.Drawing.Point(12, 324);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.Size = new System.Drawing.Size(998, 240);
            this.dgvMaterials.TabIndex = 100;
            this.dgvMaterials.TabStop = false;
            this.dgvMaterials.DoubleClick += new System.EventHandler(this.dgvMaterials_DoubleClick);
            // 
            // cmsMaterialManagement
            // 
            this.cmsMaterialManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMaterialManagement.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsMaterialManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMaterialToolStripMenuItem,
            this.showMaterialDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewMaterialToolStripMenuItem,
            this.updateMaterialToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.showMaterialTDSsToolStripMenuItem,
            this.showMaterialCOAsToolStripMenuItem});
            this.cmsMaterialManagement.Name = "cmsMaterialManagement";
            this.cmsMaterialManagement.Size = new System.Drawing.Size(225, 196);
            // 
            // findMaterialToolStripMenuItem
            // 
            this.findMaterialToolStripMenuItem.Name = "findMaterialToolStripMenuItem";
            this.findMaterialToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.findMaterialToolStripMenuItem.Text = "Find Material";
            this.findMaterialToolStripMenuItem.Click += new System.EventHandler(this.findMaterialToolStripMenuItem_Click);
            // 
            // showMaterialDetailsToolStripMenuItem
            // 
            this.showMaterialDetailsToolStripMenuItem.Name = "showMaterialDetailsToolStripMenuItem";
            this.showMaterialDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showMaterialDetailsToolStripMenuItem.Text = "Show Material Info";
            this.showMaterialDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMaterialDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // addNewMaterialToolStripMenuItem
            // 
            this.addNewMaterialToolStripMenuItem.Name = "addNewMaterialToolStripMenuItem";
            this.addNewMaterialToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.addNewMaterialToolStripMenuItem.Text = "Add New Material";
            this.addNewMaterialToolStripMenuItem.Click += new System.EventHandler(this.addNewMaterialToolStripMenuItem_Click);
            // 
            // updateMaterialToolStripMenuItem
            // 
            this.updateMaterialToolStripMenuItem.Name = "updateMaterialToolStripMenuItem";
            this.updateMaterialToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.updateMaterialToolStripMenuItem.Text = "Update";
            this.updateMaterialToolStripMenuItem.Click += new System.EventHandler(this.updateMaterialToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // showMaterialTDSsToolStripMenuItem
            // 
            this.showMaterialTDSsToolStripMenuItem.Name = "showMaterialTDSsToolStripMenuItem";
            this.showMaterialTDSsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showMaterialTDSsToolStripMenuItem.Text = "Show Material TDSs";
            this.showMaterialTDSsToolStripMenuItem.Click += new System.EventHandler(this.showMaterialTDSsToolStripMenuItem_Click);
            // 
            // showMaterialCOAsToolStripMenuItem
            // 
            this.showMaterialCOAsToolStripMenuItem.Name = "showMaterialCOAsToolStripMenuItem";
            this.showMaterialCOAsToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showMaterialCOAsToolStripMenuItem.Text = "Show Material COAs";
            this.showMaterialCOAsToolStripMenuItem.Click += new System.EventHandler(this.showMaterialCOAsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "#Total Records: ";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(155, 585);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(35, 20);
            this.lblTotalRecords.TabIndex = 100;
            this.lblTotalRecords.Text = "[??]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 39);
            this.panel1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(461, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Materials";
            // 
            // gbMaterialFilter
            // 
            this.gbMaterialFilter.Controls.Add(this.label4);
            this.gbMaterialFilter.Controls.Add(this.cbFilterBy);
            this.gbMaterialFilter.Controls.Add(this.label5);
            this.gbMaterialFilter.Controls.Add(this.cbIsActive);
            this.gbMaterialFilter.Controls.Add(this.cbMaterialCategory);
            this.gbMaterialFilter.Controls.Add(this.txtFilterValue);
            this.gbMaterialFilter.Location = new System.Drawing.Point(12, 244);
            this.gbMaterialFilter.Name = "gbMaterialFilter";
            this.gbMaterialFilter.Size = new System.Drawing.Size(615, 74);
            this.gbMaterialFilter.TabIndex = 65;
            this.gbMaterialFilter.TabStop = false;
            this.gbMaterialFilter.Text = "Material Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Filter Value: ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Material ID",
            "Material Name",
            "Material Category",
            "Is Active",
            "Chemical Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(96, 32);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(145, 28);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Filter By: ";
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(375, 34);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(116, 28);
            this.cbIsActive.TabIndex = 1;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cbMaterialCategory
            // 
            this.cbMaterialCategory.FormattingEnabled = true;
            this.cbMaterialCategory.Items.AddRange(new object[] {
            "All Material Categories"});
            this.cbMaterialCategory.Location = new System.Drawing.Point(375, 34);
            this.cbMaterialCategory.Name = "cbMaterialCategory";
            this.cbMaterialCategory.Size = new System.Drawing.Size(145, 28);
            this.cbMaterialCategory.TabIndex = 1;
            this.cbMaterialCategory.SelectedIndexChanged += new System.EventHandler(this.cbMaterialCategory_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(375, 32);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(234, 26);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.Text = "1";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(932, 270);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(68, 42);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pbMaterialImage
            // 
            this.pbMaterialImage.BackgroundImage = global::PolyMatrics.Properties.Resources.Manage_Materials;
            this.pbMaterialImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMaterialImage.Location = new System.Drawing.Point(423, 52);
            this.pbMaterialImage.Name = "pbMaterialImage";
            this.pbMaterialImage.Size = new System.Drawing.Size(219, 186);
            this.pbMaterialImage.TabIndex = 63;
            this.pbMaterialImage.TabStop = false;
            // 
            // frmMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1012, 622);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gbMaterialFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMaterialImage);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMaterials);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaterials";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.cmsMaterialManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMaterialFilter.ResumeLayout(false);
            this.gbMaterialFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsMaterialManagement;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.ToolStripMenuItem showMaterialDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem findMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showMaterialTDSsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMaterialImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem showMaterialCOAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMaterialFilter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ComboBox cbMaterialCategory;
    }
}
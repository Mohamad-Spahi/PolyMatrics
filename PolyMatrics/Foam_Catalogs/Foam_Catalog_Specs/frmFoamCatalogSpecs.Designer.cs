namespace PolyMatrics.FoamGrades.FoamGradeSPECS
{
    partial class frmFoamCatalogSpecs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsFoamCatalogSpecManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCatalogSpecsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewCatalogSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCatalogSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCatalogSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlFoamGradeInfoCard1 = new PolyMatrics.FoamGrades.UserControls.ctrlFoamCatalogInfo();
            this.ctrlFoamGradeSpecsFilter1 = new PolyMatrics.FoamCatalogs.FoamGradeSpecs.UserControls.ctrlFoamCatalogSpecsFilter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsFoamCatalogSpecManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 39);
            this.panel2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Foam Catalog Spec List";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(763, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 59;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(648, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 181);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(831, 258);
            this.dataGridView1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "#Total Records: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "??";
            // 
            // cmsFoamCatalogSpecManagement
            // 
            this.cmsFoamCatalogSpecManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsFoamCatalogSpecManagement.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsFoamCatalogSpecManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCatalogSpecsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewCatalogSpecToolStripMenuItem,
            this.updateCatalogSpecToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteCatalogSpecToolStripMenuItem});
            this.cmsFoamCatalogSpecManagement.Name = "cmsFoamCatalogSpecManagement";
            this.cmsFoamCatalogSpecManagement.Size = new System.Drawing.Size(272, 112);
            // 
            // showCatalogSpecsToolStripMenuItem
            // 
            this.showCatalogSpecsToolStripMenuItem.Name = "showCatalogSpecsToolStripMenuItem";
            this.showCatalogSpecsToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.showCatalogSpecsToolStripMenuItem.Text = "Show Catalog Spec Details";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 6);
            // 
            // addNewCatalogSpecToolStripMenuItem
            // 
            this.addNewCatalogSpecToolStripMenuItem.Name = "addNewCatalogSpecToolStripMenuItem";
            this.addNewCatalogSpecToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.addNewCatalogSpecToolStripMenuItem.Text = "Add New Catalog Spec";
            // 
            // updateCatalogSpecToolStripMenuItem
            // 
            this.updateCatalogSpecToolStripMenuItem.Name = "updateCatalogSpecToolStripMenuItem";
            this.updateCatalogSpecToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.updateCatalogSpecToolStripMenuItem.Text = "Update Catalog Spec";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(268, 6);
            // 
            // deleteCatalogSpecToolStripMenuItem
            // 
            this.deleteCatalogSpecToolStripMenuItem.Name = "deleteCatalogSpecToolStripMenuItem";
            this.deleteCatalogSpecToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.deleteCatalogSpecToolStripMenuItem.Text = "Delete Catalog Spec";
            // 
            // ctrlFoamGradeInfoCard1
            // 
            this.ctrlFoamGradeInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamGradeInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamGradeInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamGradeInfoCard1.Location = new System.Drawing.Point(0, 47);
            this.ctrlFoamGradeInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamGradeInfoCard1.Name = "ctrlFoamGradeInfoCard1";
            this.ctrlFoamGradeInfoCard1.Size = new System.Drawing.Size(641, 139);
            this.ctrlFoamGradeInfoCard1.TabIndex = 66;
            // 
            // ctrlFoamGradeSpecsFilter1
            // 
            this.ctrlFoamGradeSpecsFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamGradeSpecsFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamGradeSpecsFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamGradeSpecsFilter1.Location = new System.Drawing.Point(11, 234);
            this.ctrlFoamGradeSpecsFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamGradeSpecsFilter1.Name = "ctrlFoamGradeSpecsFilter1";
            this.ctrlFoamGradeSpecsFilter1.Size = new System.Drawing.Size(733, 71);
            this.ctrlFoamGradeSpecsFilter1.TabIndex = 60;
            // 
            // frmFoamGradeSpecsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(853, 632);
            this.Controls.Add(this.ctrlFoamGradeInfoCard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlFoamGradeSpecsFilter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFoamGradeSpecsList";
            this.Text = "frmFoamGradeSpecsList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsFoamCatalogSpecManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private FoamCatalogs.FoamGradeSpecs.UserControls.ctrlFoamCatalogSpecsFilter ctrlFoamGradeSpecsFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsFoamCatalogSpecManagement;
        private System.Windows.Forms.ToolStripMenuItem showCatalogSpecsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewCatalogSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCatalogSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteCatalogSpecToolStripMenuItem;
        private FoamGrades.UserControls.ctrlFoamCatalogInfo ctrlFoamGradeInfoCard1;
    }
}
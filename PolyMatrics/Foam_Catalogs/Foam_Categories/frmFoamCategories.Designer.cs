namespace PolyMatrics.FoamGrades.FoamCategories
{
    partial class frmFoamCategories
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsCataogManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCatalogDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewAtalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlFoamCategoryFilter1 = new PolyMatrics.FoamCatalogs.FoamCategories.UserControls.ctrlFoamCategoryFilter();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsCataogManagement.SuspendLayout();
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
            this.panel2.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Foam Categories";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(316, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 178);
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "??";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "#Total Records: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(763, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 70;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 256);
            this.dataGridView1.TabIndex = 69;
            // 
            // cmsCataogManagement
            // 
            this.cmsCataogManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCataogManagement.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsCataogManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCatalogDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewAtalogToolStripMenuItem,
            this.updateCatalogToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteCatalogToolStripMenuItem});
            this.cmsCataogManagement.Name = "cmsCataogManagement";
            this.cmsCataogManagement.Size = new System.Drawing.Size(285, 112);
            // 
            // showCatalogDetailsToolStripMenuItem
            // 
            this.showCatalogDetailsToolStripMenuItem.Name = "showCatalogDetailsToolStripMenuItem";
            this.showCatalogDetailsToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.showCatalogDetailsToolStripMenuItem.Text = "Show Foam Category Details";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(281, 6);
            // 
            // addNewAtalogToolStripMenuItem
            // 
            this.addNewAtalogToolStripMenuItem.Name = "addNewAtalogToolStripMenuItem";
            this.addNewAtalogToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.addNewAtalogToolStripMenuItem.Text = "Add New Foam Category";
            // 
            // updateCatalogToolStripMenuItem
            // 
            this.updateCatalogToolStripMenuItem.Name = "updateCatalogToolStripMenuItem";
            this.updateCatalogToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.updateCatalogToolStripMenuItem.Text = "Update Foam Category";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(281, 6);
            // 
            // deleteCatalogToolStripMenuItem
            // 
            this.deleteCatalogToolStripMenuItem.Name = "deleteCatalogToolStripMenuItem";
            this.deleteCatalogToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.deleteCatalogToolStripMenuItem.Text = "Delete Foam Category";
            // 
            // ctrlFoamCategoryFilter1
            // 
            this.ctrlFoamCategoryFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamCategoryFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamCategoryFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamCategoryFilter1.Location = new System.Drawing.Point(12, 238);
            this.ctrlFoamCategoryFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamCategoryFilter1.Name = "ctrlFoamCategoryFilter1";
            this.ctrlFoamCategoryFilter1.Size = new System.Drawing.Size(732, 70);
            this.ctrlFoamCategoryFilter1.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(763, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 46);
            this.button2.TabIndex = 76;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFoamCategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(853, 632);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ctrlFoamCategoryFilter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFoamCategoriesList";
            this.Text = "frmFoamCategoriesList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsCataogManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsCataogManagement;
        private System.Windows.Forms.ToolStripMenuItem showCatalogDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewAtalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteCatalogToolStripMenuItem;
        private FoamCatalogs.FoamCategories.UserControls.ctrlFoamCategoryFilter ctrlFoamCategoryFilter1;
        private System.Windows.Forms.Button button2;
    }
}
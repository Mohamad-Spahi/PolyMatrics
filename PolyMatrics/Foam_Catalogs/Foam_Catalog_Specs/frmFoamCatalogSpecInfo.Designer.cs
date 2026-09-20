namespace PolyMatrics.FoamGrades.FoamGradeSPECS
{
    partial class frmFoamCatalogSpecInfo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFoamCatalogInfo = new System.Windows.Forms.TabPage();
            this.ctrlFoamGradeInfoCard1 = new PolyMatrics.FoamGrades.UserControls.ctrlFoamCatalogInfo();
            this.tbFoamCategory = new System.Windows.Forms.TabPage();
            this.ctrlFoamCategoryInfoCard1 = new PolyMatrics.FoamGrades.FoamCategories.UserControls.ctrlFoamCategoryInfoCard();
            this.tbFoamCatalogSpecInfo = new System.Windows.Forms.TabPage();
            this.ctrlFoamGradeSpecCardInfo1 = new PolyMatrics.FoamGrades.FoamGradeSPECS.UserControls.ctrlFoamCatalogSpecInfo();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFoamCatalogInfo.SuspendLayout();
            this.tbFoamCategory.SuspendLayout();
            this.tbFoamCatalogSpecInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 39);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Foam Catalog Spec Details";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(606, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 58;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFoamCatalogSpecInfo);
            this.tabControl1.Controls.Add(this.tbFoamCatalogInfo);
            this.tabControl1.Controls.Add(this.tbFoamCategory);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 184);
            this.tabControl1.TabIndex = 59;
            // 
            // tbFoamCatalogInfo
            // 
            this.tbFoamCatalogInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbFoamCatalogInfo.Controls.Add(this.ctrlFoamGradeInfoCard1);
            this.tbFoamCatalogInfo.Location = new System.Drawing.Point(4, 29);
            this.tbFoamCatalogInfo.Name = "tbFoamCatalogInfo";
            this.tbFoamCatalogInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoamCatalogInfo.Size = new System.Drawing.Size(689, 151);
            this.tbFoamCatalogInfo.TabIndex = 0;
            this.tbFoamCatalogInfo.Text = "Foam Catalog Info";
            // 
            // ctrlFoamGradeInfoCard1
            // 
            this.ctrlFoamGradeInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamGradeInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamGradeInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamGradeInfoCard1.Location = new System.Drawing.Point(1, 3);
            this.ctrlFoamGradeInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamGradeInfoCard1.Name = "ctrlFoamGradeInfoCard1";
            this.ctrlFoamGradeInfoCard1.Size = new System.Drawing.Size(637, 135);
            this.ctrlFoamGradeInfoCard1.TabIndex = 0;
            // 
            // tbFoamCategory
            // 
            this.tbFoamCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbFoamCategory.Controls.Add(this.ctrlFoamCategoryInfoCard1);
            this.tbFoamCategory.Location = new System.Drawing.Point(4, 29);
            this.tbFoamCategory.Name = "tbFoamCategory";
            this.tbFoamCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoamCategory.Size = new System.Drawing.Size(689, 151);
            this.tbFoamCategory.TabIndex = 1;
            this.tbFoamCategory.Text = "Foam Category";
            // 
            // ctrlFoamCategoryInfoCard1
            // 
            this.ctrlFoamCategoryInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamCategoryInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamCategoryInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamCategoryInfoCard1.Location = new System.Drawing.Point(1, 3);
            this.ctrlFoamCategoryInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamCategoryInfoCard1.Name = "ctrlFoamCategoryInfoCard1";
            this.ctrlFoamCategoryInfoCard1.Size = new System.Drawing.Size(658, 91);
            this.ctrlFoamCategoryInfoCard1.TabIndex = 0;
            // 
            // tbFoamCatalogSpecInfo
            // 
            this.tbFoamCatalogSpecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbFoamCatalogSpecInfo.Controls.Add(this.ctrlFoamGradeSpecCardInfo1);
            this.tbFoamCatalogSpecInfo.Location = new System.Drawing.Point(4, 29);
            this.tbFoamCatalogSpecInfo.Name = "tbFoamCatalogSpecInfo";
            this.tbFoamCatalogSpecInfo.Size = new System.Drawing.Size(689, 151);
            this.tbFoamCatalogSpecInfo.TabIndex = 2;
            this.tbFoamCatalogSpecInfo.Text = "Foam Catalog Spec Info";
            // 
            // ctrlFoamGradeSpecCardInfo1
            // 
            this.ctrlFoamGradeSpecCardInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamGradeSpecCardInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamGradeSpecCardInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamGradeSpecCardInfo1.Location = new System.Drawing.Point(4, 3);
            this.ctrlFoamGradeSpecCardInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamGradeSpecCardInfo1.Name = "ctrlFoamGradeSpecCardInfo1";
            this.ctrlFoamGradeSpecCardInfo1.Size = new System.Drawing.Size(685, 144);
            this.ctrlFoamGradeSpecCardInfo1.TabIndex = 0;
            // 
            // frmFoamGradeSpecCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(696, 285);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFoamGradeSpecCardInfo";
            this.Text = "frmFoamGradeSpecCardInfo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbFoamCatalogInfo.ResumeLayout(false);
            this.tbFoamCategory.ResumeLayout(false);
            this.tbFoamCatalogSpecInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFoamCatalogSpecInfo;
        private UserControls.ctrlFoamCatalogSpecInfo ctrlFoamGradeSpecCardInfo1;
        private System.Windows.Forms.TabPage tbFoamCatalogInfo;
        private FoamGrades.UserControls.ctrlFoamCatalogInfo ctrlFoamGradeInfoCard1;
        private System.Windows.Forms.TabPage tbFoamCategory;
        private FoamCategories.UserControls.ctrlFoamCategoryInfoCard ctrlFoamCategoryInfoCard1;
    }
}
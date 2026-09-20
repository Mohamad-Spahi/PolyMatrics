namespace PolyMatrics.Materials
{
    partial class frmAddUpdateMaterial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcMaterialDataInfo = new System.Windows.Forms.TabControl();
            this.tpMaterialCategoryInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlMaterialCategoryInfoWithFilter1 = new PolyMatrics.Materials.MaterialCategories.UserControls.ctrlMaterialCategoryInfoWithFilter();
            this.tpMaterialInfo = new System.Windows.Forms.TabPage();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTradeName = new System.Windows.Forms.TextBox();
            this.lblMaterialCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaterialID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChemicalName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tcMaterialDataInfo.SuspendLayout();
            this.tpMaterialCategoryInfo.SuspendLayout();
            this.tpMaterialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(257, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Material";
            // 
            // tcMaterialDataInfo
            // 
            this.tcMaterialDataInfo.Controls.Add(this.tpMaterialCategoryInfo);
            this.tcMaterialDataInfo.Controls.Add(this.tpMaterialInfo);
            this.tcMaterialDataInfo.Location = new System.Drawing.Point(26, 250);
            this.tcMaterialDataInfo.Name = "tcMaterialDataInfo";
            this.tcMaterialDataInfo.SelectedIndex = 0;
            this.tcMaterialDataInfo.Size = new System.Drawing.Size(703, 330);
            this.tcMaterialDataInfo.TabIndex = 13;
            // 
            // tpMaterialCategoryInfo
            // 
            this.tpMaterialCategoryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tpMaterialCategoryInfo.Controls.Add(this.btnNext);
            this.tpMaterialCategoryInfo.Controls.Add(this.ctrlMaterialCategoryInfoWithFilter1);
            this.tpMaterialCategoryInfo.Location = new System.Drawing.Point(4, 29);
            this.tpMaterialCategoryInfo.Name = "tpMaterialCategoryInfo";
            this.tpMaterialCategoryInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaterialCategoryInfo.Size = new System.Drawing.Size(695, 297);
            this.tpMaterialCategoryInfo.TabIndex = 0;
            this.tpMaterialCategoryInfo.Text = "Material Category Info";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(605, 255);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 36);
            this.btnNext.TabIndex = 48;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMaterialCategoryInfoWithFilter1
            // 
            this.ctrlMaterialCategoryInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMaterialCategoryInfoWithFilter1.FilterEnabled = false;
            this.ctrlMaterialCategoryInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMaterialCategoryInfoWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMaterialCategoryInfoWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlMaterialCategoryInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMaterialCategoryInfoWithFilter1.Name = "ctrlMaterialCategoryInfoWithFilter1";
            this.ctrlMaterialCategoryInfoWithFilter1.ShowAddMaterial = false;
            this.ctrlMaterialCategoryInfoWithFilter1.Size = new System.Drawing.Size(696, 250);
            this.ctrlMaterialCategoryInfoWithFilter1.TabIndex = 0;
            // 
            // tpMaterialInfo
            // 
            this.tpMaterialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tpMaterialInfo.Controls.Add(this.btnPrevious);
            this.tpMaterialInfo.Controls.Add(this.btnSave);
            this.tpMaterialInfo.Controls.Add(this.txtTradeName);
            this.tpMaterialInfo.Controls.Add(this.lblMaterialCategory);
            this.tpMaterialInfo.Controls.Add(this.label2);
            this.tpMaterialInfo.Controls.Add(this.lblMaterialID);
            this.tpMaterialInfo.Controls.Add(this.label4);
            this.tpMaterialInfo.Controls.Add(this.txtChemicalName);
            this.tpMaterialInfo.Controls.Add(this.label6);
            this.tpMaterialInfo.Controls.Add(this.chkIsActive);
            this.tpMaterialInfo.Controls.Add(this.label3);
            this.tpMaterialInfo.Location = new System.Drawing.Point(4, 29);
            this.tpMaterialInfo.Name = "tpMaterialInfo";
            this.tpMaterialInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaterialInfo.Size = new System.Drawing.Size(695, 297);
            this.tpMaterialInfo.TabIndex = 1;
            this.tpMaterialInfo.Text = "Material Info";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(514, 255);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 39);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(605, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 39);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTradeName
            // 
            this.txtTradeName.Location = new System.Drawing.Point(12, 91);
            this.txtTradeName.Multiline = true;
            this.txtTradeName.Name = "txtTradeName";
            this.txtTradeName.Size = new System.Drawing.Size(301, 76);
            this.txtTradeName.TabIndex = 20;
            this.txtTradeName.Text = "Trade Name...";
            this.txtTradeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTradeName_Validating);
            // 
            // lblMaterialCategory
            // 
            this.lblMaterialCategory.AutoSize = true;
            this.lblMaterialCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lblMaterialCategory.Location = new System.Drawing.Point(510, 20);
            this.lblMaterialCategory.Name = "lblMaterialCategory";
            this.lblMaterialCategory.Size = new System.Drawing.Size(35, 20);
            this.lblMaterialCategory.TabIndex = 19;
            this.lblMaterialCategory.Text = "[??]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Material Category: ";
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lblMaterialID.Location = new System.Drawing.Point(185, 20);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(35, 20);
            this.lblMaterialID.TabIndex = 14;
            this.lblMaterialID.Text = "[??]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Material ID: ";
            // 
            // txtChemicalName
            // 
            this.txtChemicalName.Location = new System.Drawing.Point(344, 91);
            this.txtChemicalName.Multiline = true;
            this.txtChemicalName.Name = "txtChemicalName";
            this.txtChemicalName.Size = new System.Drawing.Size(301, 76);
            this.txtChemicalName.TabIndex = 16;
            this.txtChemicalName.Text = "Chemical Name...";
            this.txtChemicalName.Validating += new System.ComponentModel.CancelEventHandler(this.txtChemicalName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chemical Name: ";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(16, 173);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 13;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Material Name: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(666, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PolyMatrics.Properties.Resources.Add_New_Material;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(274, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 186);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddUpdateMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(760, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcMaterialDataInfo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateMaterial";
            this.Load += new System.EventHandler(this.frmAddUpdateMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcMaterialDataInfo.ResumeLayout(false);
            this.tpMaterialCategoryInfo.ResumeLayout(false);
            this.tpMaterialInfo.ResumeLayout(false);
            this.tpMaterialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcMaterialDataInfo;
        private System.Windows.Forms.TabPage tpMaterialCategoryInfo;
        private System.Windows.Forms.TabPage tpMaterialInfo;
        private System.Windows.Forms.TextBox txtTradeName;
        private System.Windows.Forms.Label lblMaterialCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaterialID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChemicalName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrevious;
        private MaterialCategories.UserControls.ctrlMaterialCategoryInfoWithFilter ctrlMaterialCategoryInfoWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
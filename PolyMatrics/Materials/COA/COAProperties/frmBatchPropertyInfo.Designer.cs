namespace PolyMatrics.Materials.COA.COAProperties
{
    partial class frmBatchPropertyInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBatchPropertyInfo = new System.Windows.Forms.TabPage();
            this.ctrlBatchPropertyInfo1 = new PolyMatrics.Materials.COA.COAProperties.User_Controls.ctrlBatchPropertyInfo();
            this.tbBatchInfo = new System.Windows.Forms.TabPage();
            this.ctrlTDSInfoCard1 = new PolyMatrics.Materials.TDS.User_Controls.ctrlTDSInfoCard();
            this.tbMaterialInfo = new System.Windows.Forms.TabPage();
            this.ctrlMaterialInfoCard1 = new PolyMatrics.Materials.User_Controls.ctrlMaterialInfoCard();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tbBatchPropertyInfo.SuspendLayout();
            this.tbBatchInfo.SuspendLayout();
            this.tbMaterialInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(653, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbBatchPropertyInfo);
            this.tabControl1.Controls.Add(this.tbBatchInfo);
            this.tabControl1.Controls.Add(this.tbMaterialInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 242);
            this.tabControl1.TabIndex = 54;
            // 
            // tbBatchPropertyInfo
            // 
            this.tbBatchPropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbBatchPropertyInfo.Controls.Add(this.ctrlBatchPropertyInfo1);
            this.tbBatchPropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbBatchPropertyInfo.Name = "tbBatchPropertyInfo";
            this.tbBatchPropertyInfo.Size = new System.Drawing.Size(738, 209);
            this.tbBatchPropertyInfo.TabIndex = 2;
            this.tbBatchPropertyInfo.Text = "Batch Property Info";
            // 
            // ctrlBatchPropertyInfo1
            // 
            this.ctrlBatchPropertyInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlBatchPropertyInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBatchPropertyInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlBatchPropertyInfo1.Location = new System.Drawing.Point(0, 4);
            this.ctrlBatchPropertyInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBatchPropertyInfo1.Name = "ctrlBatchPropertyInfo1";
            this.ctrlBatchPropertyInfo1.Size = new System.Drawing.Size(549, 128);
            this.ctrlBatchPropertyInfo1.TabIndex = 0;
            // 
            // tbBatchInfo
            // 
            this.tbBatchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbBatchInfo.Controls.Add(this.ctrlTDSInfoCard1);
            this.tbBatchInfo.Location = new System.Drawing.Point(4, 29);
            this.tbBatchInfo.Name = "tbBatchInfo";
            this.tbBatchInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbBatchInfo.Size = new System.Drawing.Size(738, 209);
            this.tbBatchInfo.TabIndex = 0;
            this.tbBatchInfo.Text = "Batch Info";
            // 
            // ctrlTDSInfoCard1
            // 
            this.ctrlTDSInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlTDSInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTDSInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlTDSInfoCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlTDSInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTDSInfoCard1.Name = "ctrlTDSInfoCard1";
            this.ctrlTDSInfoCard1.Size = new System.Drawing.Size(610, 109);
            this.ctrlTDSInfoCard1.TabIndex = 0;
            // 
            // tbMaterialInfo
            // 
            this.tbMaterialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMaterialInfo.Controls.Add(this.ctrlMaterialInfoCard1);
            this.tbMaterialInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMaterialInfo.Name = "tbMaterialInfo";
            this.tbMaterialInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMaterialInfo.Size = new System.Drawing.Size(738, 209);
            this.tbMaterialInfo.TabIndex = 1;
            this.tbMaterialInfo.Text = "Material Info";
            // 
            // ctrlMaterialInfoCard1
            // 
            this.ctrlMaterialInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMaterialInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMaterialInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMaterialInfoCard1.Location = new System.Drawing.Point(3, 2);
            this.ctrlMaterialInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMaterialInfoCard1.Name = "ctrlMaterialInfoCard1";
            this.ctrlMaterialInfoCard1.Size = new System.Drawing.Size(732, 200);
            this.ctrlMaterialInfoCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Batch Property Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 39);
            this.panel2.TabIndex = 39;
            // 
            // frmBatchPropertyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(746, 332);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBatchPropertyInfo";
            this.Text = "frmBatchPropertyInfo";
            this.tabControl1.ResumeLayout(false);
            this.tbBatchPropertyInfo.ResumeLayout(false);
            this.tbBatchInfo.ResumeLayout(false);
            this.tbMaterialInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbBatchPropertyInfo;
        private User_Controls.ctrlBatchPropertyInfo ctrlBatchPropertyInfo1;
        private System.Windows.Forms.TabPage tbBatchInfo;
        private TDS.User_Controls.ctrlTDSInfoCard ctrlTDSInfoCard1;
        private System.Windows.Forms.TabPage tbMaterialInfo;
        private Materials.User_Controls.ctrlMaterialInfoCard ctrlMaterialInfoCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
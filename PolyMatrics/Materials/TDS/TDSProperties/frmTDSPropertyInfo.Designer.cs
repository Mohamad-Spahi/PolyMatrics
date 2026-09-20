namespace PolyMatrics.Materials.TDS.TDSProperties.User_Controls
{
    partial class frmTDSPropertyInfo
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbTDSInfo = new System.Windows.Forms.TabPage();
            this.ctrlTDSInfoCard1 = new PolyMatrics.Materials.TDS.User_Controls.ctrlTDSInfoCard();
            this.tbMaterialInfo = new System.Windows.Forms.TabPage();
            this.ctrlMaterialInfoCard1 = new PolyMatrics.Materials.User_Controls.ctrlMaterialInfoCard();
            this.tbTDSPropertyInfo = new System.Windows.Forms.TabPage();
            this.ctrlTDSPropertyInfo1 = new PolyMatrics.Materials.TDS.TDSProperties.User_Controls.ctrlTDSPropertyInfo();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbTDSInfo.SuspendLayout();
            this.tbMaterialInfo.SuspendLayout();
            this.tbTDSPropertyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(746, 39);
            this.panel6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TDS Property Info";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(652, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 52;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbTDSPropertyInfo);
            this.tabControl1.Controls.Add(this.tbTDSInfo);
            this.tabControl1.Controls.Add(this.tbMaterialInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 242);
            this.tabControl1.TabIndex = 53;
            // 
            // tbTDSInfo
            // 
            this.tbTDSInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbTDSInfo.Controls.Add(this.ctrlTDSInfoCard1);
            this.tbTDSInfo.Location = new System.Drawing.Point(4, 29);
            this.tbTDSInfo.Name = "tbTDSInfo";
            this.tbTDSInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbTDSInfo.Size = new System.Drawing.Size(738, 209);
            this.tbTDSInfo.TabIndex = 0;
            this.tbTDSInfo.Text = "TDS Info";
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
            // tbTDSPropertyInfo
            // 
            this.tbTDSPropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbTDSPropertyInfo.Controls.Add(this.ctrlTDSPropertyInfo1);
            this.tbTDSPropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbTDSPropertyInfo.Name = "tbTDSPropertyInfo";
            this.tbTDSPropertyInfo.Size = new System.Drawing.Size(738, 209);
            this.tbTDSPropertyInfo.TabIndex = 2;
            this.tbTDSPropertyInfo.Text = "TDS Property Info";
            // 
            // ctrlTDSPropertyInfo1
            // 
            this.ctrlTDSPropertyInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlTDSPropertyInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTDSPropertyInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlTDSPropertyInfo1.Location = new System.Drawing.Point(4, 4);
            this.ctrlTDSPropertyInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTDSPropertyInfo1.Name = "ctrlTDSPropertyInfo1";
            this.ctrlTDSPropertyInfo1.Size = new System.Drawing.Size(538, 204);
            this.ctrlTDSPropertyInfo1.TabIndex = 0;
            // 
            // frmTDSPropertyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(746, 333);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTDSPropertyInfo";
            this.Text = "frmTDSPropertyInfo";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbTDSInfo.ResumeLayout(false);
            this.tbMaterialInfo.ResumeLayout(false);
            this.tbTDSPropertyInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbTDSInfo;
        private TDS.User_Controls.ctrlTDSInfoCard ctrlTDSInfoCard1;
        private System.Windows.Forms.TabPage tbMaterialInfo;
        private Materials.User_Controls.ctrlMaterialInfoCard ctrlMaterialInfoCard1;
        private System.Windows.Forms.TabPage tbTDSPropertyInfo;
        private ctrlTDSPropertyInfo ctrlTDSPropertyInfo1;
    }
}
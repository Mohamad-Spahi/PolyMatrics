namespace PolyMatrics.Materials.TDS
{
    partial class frmTDSInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbTDSInfo = new System.Windows.Forms.TabPage();
            this.tbMaterialInfo = new System.Windows.Forms.TabPage();
            this.ctrlTDSInfoCard1 = new PolyMatrics.Materials.TDS.User_Controls.ctrlTDSInfoCard();
            this.ctrlMaterialInfoCard1 = new PolyMatrics.Materials.User_Controls.ctrlMaterialInfoCard();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbTDSInfo.SuspendLayout();
            this.tbMaterialInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 39);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "TDS Info";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(653, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 39);
            this.button2.TabIndex = 44;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbTDSInfo);
            this.tabControl1.Controls.Add(this.tbMaterialInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 231);
            this.tabControl1.TabIndex = 45;
            // 
            // tbTDSInfo
            // 
            this.tbTDSInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbTDSInfo.Controls.Add(this.ctrlTDSInfoCard1);
            this.tbTDSInfo.Location = new System.Drawing.Point(4, 29);
            this.tbTDSInfo.Name = "tbTDSInfo";
            this.tbTDSInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbTDSInfo.Size = new System.Drawing.Size(738, 198);
            this.tbTDSInfo.TabIndex = 0;
            this.tbTDSInfo.Text = "TDS Info";
            // 
            // tbMaterialInfo
            // 
            this.tbMaterialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMaterialInfo.Controls.Add(this.ctrlMaterialInfoCard1);
            this.tbMaterialInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMaterialInfo.Name = "tbMaterialInfo";
            this.tbMaterialInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMaterialInfo.Size = new System.Drawing.Size(738, 198);
            this.tbMaterialInfo.TabIndex = 1;
            this.tbMaterialInfo.Text = "Material Info";
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
            // frmTDSInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(746, 329);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTDSInfo";
            this.Text = "frmTDSInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbTDSInfo.ResumeLayout(false);
            this.tbMaterialInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbTDSInfo;
        private User_Controls.ctrlTDSInfoCard ctrlTDSInfoCard1;
        private System.Windows.Forms.TabPage tbMaterialInfo;
        private Materials.User_Controls.ctrlMaterialInfoCard ctrlMaterialInfoCard1;
    }
}
namespace PolyMatrics.Materials.COA.User_Controls
{
    partial class frmBatchInfo
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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBatchInfo = new System.Windows.Forms.TabPage();
            this.tbMaterialInfo = new System.Windows.Forms.TabPage();
            this.ctrlMaterialInfoCard1 = new PolyMatrics.Materials.User_Controls.ctrlMaterialInfoCard();
            this.ctrlBatchInfo1 = new PolyMatrics.Materials.COA.User_Controls.ctrlBatchInfo();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbBatchInfo.SuspendLayout();
            this.tbMaterialInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 39);
            this.panel1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(293, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Batch Info";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(661, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbBatchInfo);
            this.tabControl1.Controls.Add(this.tbMaterialInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 231);
            this.tabControl1.TabIndex = 46;
            // 
            // tbBatchInfo
            // 
            this.tbBatchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbBatchInfo.Controls.Add(this.ctrlBatchInfo1);
            this.tbBatchInfo.Location = new System.Drawing.Point(4, 29);
            this.tbBatchInfo.Name = "tbBatchInfo";
            this.tbBatchInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbBatchInfo.Size = new System.Drawing.Size(738, 198);
            this.tbBatchInfo.TabIndex = 0;
            this.tbBatchInfo.Text = "Batch Info";
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
            // ctrlBatchInfo1
            // 
            this.ctrlBatchInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlBatchInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBatchInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlBatchInfo1.Location = new System.Drawing.Point(4, 5);
            this.ctrlBatchInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBatchInfo1.Name = "ctrlBatchInfo1";
            this.ctrlBatchInfo1.Size = new System.Drawing.Size(474, 108);
            this.ctrlBatchInfo1.TabIndex = 0;
            // 
            // frmBatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(745, 321);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBatchInfo";
            this.Text = "frmBatchInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbBatchInfo.ResumeLayout(false);
            this.tbMaterialInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbBatchInfo;
        private ctrlBatchInfo ctrlBatchInfo1;
        private System.Windows.Forms.TabPage tbMaterialInfo;
        private Materials.User_Controls.ctrlMaterialInfoCard ctrlMaterialInfoCard1;
    }
}
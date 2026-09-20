namespace PolyMatrics.Machines.MachineProperties
{
    partial class frmMachinePropertyInfoCard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMachinePropertyInfo = new System.Windows.Forms.TabPage();
            this.ctrlMachinePropertyInfoCard1 = new PolyMatrics.Machines.MachineProperties.User_Controls.ctrlMachinePropertyInfoCard();
            this.tbMachineInfo = new System.Windows.Forms.TabPage();
            this.ctrlMachineInfoCard1 = new PolyMatrics.Machines.User_Controls.ctrlMachineInfoCard();
            this.tbPropertyInfo = new System.Windows.Forms.TabPage();
            this.ctrlPropertyInfoCard1 = new PolyMatrics.Global.Properties.UserControls.ctrlPropertyInfoCard();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbMachinePropertyInfo.SuspendLayout();
            this.tbMachineInfo.SuspendLayout();
            this.tbPropertyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(564, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 39);
            this.panel2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Machine Property Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMachinePropertyInfo);
            this.tabControl1.Controls.Add(this.tbMachineInfo);
            this.tabControl1.Controls.Add(this.tbPropertyInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 179);
            this.tabControl1.TabIndex = 42;
            // 
            // tbMachinePropertyInfo
            // 
            this.tbMachinePropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMachinePropertyInfo.Controls.Add(this.ctrlMachinePropertyInfoCard1);
            this.tbMachinePropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMachinePropertyInfo.Name = "tbMachinePropertyInfo";
            this.tbMachinePropertyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMachinePropertyInfo.Size = new System.Drawing.Size(641, 146);
            this.tbMachinePropertyInfo.TabIndex = 0;
            this.tbMachinePropertyInfo.Text = "Machine Property Info";
            // 
            // ctrlMachinePropertyInfoCard1
            // 
            this.ctrlMachinePropertyInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMachinePropertyInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMachinePropertyInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMachinePropertyInfoCard1.Location = new System.Drawing.Point(0, 3);
            this.ctrlMachinePropertyInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMachinePropertyInfoCard1.Name = "ctrlMachinePropertyInfoCard1";
            this.ctrlMachinePropertyInfoCard1.Size = new System.Drawing.Size(628, 139);
            this.ctrlMachinePropertyInfoCard1.TabIndex = 0;
            // 
            // tbMachineInfo
            // 
            this.tbMachineInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMachineInfo.Controls.Add(this.ctrlMachineInfoCard1);
            this.tbMachineInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMachineInfo.Name = "tbMachineInfo";
            this.tbMachineInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMachineInfo.Size = new System.Drawing.Size(641, 149);
            this.tbMachineInfo.TabIndex = 1;
            this.tbMachineInfo.Text = "Machine Info";
            // 
            // ctrlMachineInfoCard1
            // 
            this.ctrlMachineInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMachineInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMachineInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMachineInfoCard1.Location = new System.Drawing.Point(2, 3);
            this.ctrlMachineInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMachineInfoCard1.Name = "ctrlMachineInfoCard1";
            this.ctrlMachineInfoCard1.Size = new System.Drawing.Size(632, 142);
            this.ctrlMachineInfoCard1.TabIndex = 0;
            // 
            // tbPropertyInfo
            // 
            this.tbPropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbPropertyInfo.Controls.Add(this.ctrlPropertyInfoCard1);
            this.tbPropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPropertyInfo.Name = "tbPropertyInfo";
            this.tbPropertyInfo.Size = new System.Drawing.Size(641, 149);
            this.tbPropertyInfo.TabIndex = 2;
            this.tbPropertyInfo.Text = "Property Info";
            // 
            // ctrlPropertyInfoCard1
            // 
            this.ctrlPropertyInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlPropertyInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPropertyInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlPropertyInfoCard1.Location = new System.Drawing.Point(3, 4);
            this.ctrlPropertyInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPropertyInfoCard1.Name = "ctrlPropertyInfoCard1";
            this.ctrlPropertyInfoCard1.Size = new System.Drawing.Size(591, 124);
            this.ctrlPropertyInfoCard1.TabIndex = 0;
            // 
            // frmMachinePropertyInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(649, 273);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMachinePropertyInfoCard";
            this.Text = "frmMachinePropertyInfoCard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbMachinePropertyInfo.ResumeLayout(false);
            this.tbMachineInfo.ResumeLayout(false);
            this.tbPropertyInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMachinePropertyInfo;
        private User_Controls.ctrlMachinePropertyInfoCard ctrlMachinePropertyInfoCard1;
        private System.Windows.Forms.TabPage tbMachineInfo;
        private Machines.User_Controls.ctrlMachineInfoCard ctrlMachineInfoCard1;
        private System.Windows.Forms.TabPage tbPropertyInfo;
        private Global.Properties.UserControls.ctrlPropertyInfoCard ctrlPropertyInfoCard1;
    }
}
namespace PolyMatrics.Machines.MachineProperties
{
    partial class frmAddUpdateMachineProperty
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMachineInfo = new System.Windows.Forms.TabPage();
            this.tbPropertyInfo = new System.Windows.Forms.TabPage();
            this.tbMachinePropertyInfo = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ctrlMachineInfoWithFilter1 = new PolyMatrics.Machines.User_Controls.ctrlMachineInfoWithFilter();
            this.ctrlPropertyInfoCardWithFilter1 = new PolyMatrics.Global.Properties.UserControls.ctrlPropertyInfoCardWithFilter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbMachineInfo.SuspendLayout();
            this.tbPropertyInfo.SuspendLayout();
            this.tbMachinePropertyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 39);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "Add New Machine Property";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 178);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMachineInfo);
            this.tabControl1.Controls.Add(this.tbPropertyInfo);
            this.tabControl1.Controls.Add(this.tbMachinePropertyInfo);
            this.tabControl1.Location = new System.Drawing.Point(7, 242);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 298);
            this.tabControl1.TabIndex = 74;
            // 
            // tbMachineInfo
            // 
            this.tbMachineInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMachineInfo.Controls.Add(this.button6);
            this.tbMachineInfo.Controls.Add(this.ctrlMachineInfoWithFilter1);
            this.tbMachineInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMachineInfo.Name = "tbMachineInfo";
            this.tbMachineInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMachineInfo.Size = new System.Drawing.Size(721, 265);
            this.tbMachineInfo.TabIndex = 0;
            this.tbMachineInfo.Text = "Machine Info";
            // 
            // tbPropertyInfo
            // 
            this.tbPropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbPropertyInfo.Controls.Add(this.button4);
            this.tbPropertyInfo.Controls.Add(this.button2);
            this.tbPropertyInfo.Controls.Add(this.ctrlPropertyInfoCardWithFilter1);
            this.tbPropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPropertyInfo.Name = "tbPropertyInfo";
            this.tbPropertyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPropertyInfo.Size = new System.Drawing.Size(721, 265);
            this.tbPropertyInfo.TabIndex = 1;
            this.tbPropertyInfo.Text = "Property Info";
            // 
            // tbMachinePropertyInfo
            // 
            this.tbMachinePropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbMachinePropertyInfo.Controls.Add(this.button1);
            this.tbMachinePropertyInfo.Controls.Add(this.button3);
            this.tbMachinePropertyInfo.Controls.Add(this.numericUpDown2);
            this.tbMachinePropertyInfo.Controls.Add(this.label17);
            this.tbMachinePropertyInfo.Controls.Add(this.label12);
            this.tbMachinePropertyInfo.Controls.Add(this.label13);
            this.tbMachinePropertyInfo.Controls.Add(this.label10);
            this.tbMachinePropertyInfo.Controls.Add(this.label11);
            this.tbMachinePropertyInfo.Controls.Add(this.label8);
            this.tbMachinePropertyInfo.Controls.Add(this.label9);
            this.tbMachinePropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbMachinePropertyInfo.Name = "tbMachinePropertyInfo";
            this.tbMachinePropertyInfo.Size = new System.Drawing.Size(721, 265);
            this.tbMachinePropertyInfo.TabIndex = 2;
            this.tbMachinePropertyInfo.Text = "Machine Property Info";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 4;
            this.numericUpDown2.Location = new System.Drawing.Point(195, 111);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Property Value: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "??";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Property Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Machine Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "??";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Machine Property ID: ";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(633, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 36);
            this.button3.TabIndex = 49;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(545, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 50;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(545, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 76;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(633, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 36);
            this.button4.TabIndex = 77;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(633, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 36);
            this.button6.TabIndex = 76;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(649, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 36);
            this.button5.TabIndex = 75;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ctrlMachineInfoWithFilter1
            // 
            this.ctrlMachineInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMachineInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMachineInfoWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMachineInfoWithFilter1.Location = new System.Drawing.Point(3, 4);
            this.ctrlMachineInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMachineInfoWithFilter1.Name = "ctrlMachineInfoWithFilter1";
            this.ctrlMachineInfoWithFilter1.Size = new System.Drawing.Size(680, 206);
            this.ctrlMachineInfoWithFilter1.TabIndex = 75;
            // 
            // ctrlPropertyInfoCardWithFilter1
            // 
            this.ctrlPropertyInfoCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlPropertyInfoCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPropertyInfoCardWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlPropertyInfoCardWithFilter1.Location = new System.Drawing.Point(0, 2);
            this.ctrlPropertyInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPropertyInfoCardWithFilter1.Name = "ctrlPropertyInfoCardWithFilter1";
            this.ctrlPropertyInfoCardWithFilter1.Size = new System.Drawing.Size(714, 200);
            this.ctrlPropertyInfoCardWithFilter1.TabIndex = 64;
            // 
            // frmAddUpdateMachineProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(743, 594);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateMachineProperty";
            this.Text = "frmAddUpdateMachineProperty";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbMachineInfo.ResumeLayout(false);
            this.tbPropertyInfo.ResumeLayout(false);
            this.tbMachinePropertyInfo.ResumeLayout(false);
            this.tbMachinePropertyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMachineInfo;
        private Machines.User_Controls.ctrlMachineInfoWithFilter ctrlMachineInfoWithFilter1;
        private System.Windows.Forms.TabPage tbPropertyInfo;
        private Global.Properties.UserControls.ctrlPropertyInfoCardWithFilter ctrlPropertyInfoCardWithFilter1;
        private System.Windows.Forms.TabPage tbMachinePropertyInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}
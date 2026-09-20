namespace PolyMatrics.FoamGrades.FoamGradeSPECS
{
    partial class frmAddUpdateFoamCatalogSpec
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFoamCatalogInfo = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.ctrlFoamGradeInfoCardWithFilter1 = new PolyMatrics.FoamGrades.UserControls.ctrlFoamCatalogInfoWithFilter();
            this.tbPropertyInfo = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ctrlPropertyInfoCardWithFilter1 = new PolyMatrics.Global.Properties.UserControls.ctrlPropertyInfoCardWithFilter();
            this.tbTestMethodInfo = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ctrlTestMethodInfoCardWithFilter1 = new PolyMatrics.Machines.TestMethods.User_Controls.ctrlTestMethodInfoCardWithFilter();
            this.tbFoamCatalogSpecInfo = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFoamCatalogInfo.SuspendLayout();
            this.tbPropertyInfo.SuspendLayout();
            this.tbTestMethodInfo.SuspendLayout();
            this.tbFoamCatalogSpecInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 39);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Add New Foam Catalog Spec";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(623, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 46);
            this.button2.TabIndex = 60;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(707, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 59;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFoamCatalogInfo);
            this.tabControl1.Controls.Add(this.tbPropertyInfo);
            this.tabControl1.Controls.Add(this.tbTestMethodInfo);
            this.tabControl1.Controls.Add(this.tbFoamCatalogSpecInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 275);
            this.tabControl1.TabIndex = 61;
            // 
            // tbFoamCatalogInfo
            // 
            this.tbFoamCatalogInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbFoamCatalogInfo.Controls.Add(this.button8);
            this.tbFoamCatalogInfo.Controls.Add(this.ctrlFoamGradeInfoCardWithFilter1);
            this.tbFoamCatalogInfo.Location = new System.Drawing.Point(4, 29);
            this.tbFoamCatalogInfo.Name = "tbFoamCatalogInfo";
            this.tbFoamCatalogInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbFoamCatalogInfo.Size = new System.Drawing.Size(781, 242);
            this.tbFoamCatalogInfo.TabIndex = 0;
            this.tbFoamCatalogInfo.Text = "Foam Catalog Info";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(695, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 46);
            this.button8.TabIndex = 63;
            this.button8.Text = "Next";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ctrlFoamGradeInfoCardWithFilter1
            // 
            this.ctrlFoamGradeInfoCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlFoamGradeInfoCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFoamGradeInfoCardWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlFoamGradeInfoCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFoamGradeInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFoamGradeInfoCardWithFilter1.Name = "ctrlFoamGradeInfoCardWithFilter1";
            this.ctrlFoamGradeInfoCardWithFilter1.Size = new System.Drawing.Size(772, 202);
            this.ctrlFoamGradeInfoCardWithFilter1.TabIndex = 0;
            // 
            // tbPropertyInfo
            // 
            this.tbPropertyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbPropertyInfo.Controls.Add(this.button7);
            this.tbPropertyInfo.Controls.Add(this.button6);
            this.tbPropertyInfo.Controls.Add(this.ctrlPropertyInfoCardWithFilter1);
            this.tbPropertyInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPropertyInfo.Name = "tbPropertyInfo";
            this.tbPropertyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPropertyInfo.Size = new System.Drawing.Size(781, 242);
            this.tbPropertyInfo.TabIndex = 1;
            this.tbPropertyInfo.Text = "Property Info";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(695, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 46);
            this.button7.TabIndex = 62;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(602, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 46);
            this.button6.TabIndex = 111;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ctrlPropertyInfoCardWithFilter1
            // 
            this.ctrlPropertyInfoCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlPropertyInfoCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPropertyInfoCardWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlPropertyInfoCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPropertyInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPropertyInfoCardWithFilter1.Name = "ctrlPropertyInfoCardWithFilter1";
            this.ctrlPropertyInfoCardWithFilter1.Size = new System.Drawing.Size(717, 200);
            this.ctrlPropertyInfoCardWithFilter1.TabIndex = 0;
            // 
            // tbTestMethodInfo
            // 
            this.tbTestMethodInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbTestMethodInfo.Controls.Add(this.button5);
            this.tbTestMethodInfo.Controls.Add(this.button3);
            this.tbTestMethodInfo.Controls.Add(this.ctrlTestMethodInfoCardWithFilter1);
            this.tbTestMethodInfo.Location = new System.Drawing.Point(4, 29);
            this.tbTestMethodInfo.Name = "tbTestMethodInfo";
            this.tbTestMethodInfo.Size = new System.Drawing.Size(781, 242);
            this.tbTestMethodInfo.TabIndex = 2;
            this.tbTestMethodInfo.Text = "Test Method Info";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(602, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 46);
            this.button5.TabIndex = 111;
            this.button5.Text = "Previous";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(695, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 46);
            this.button3.TabIndex = 63;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ctrlTestMethodInfoCardWithFilter1
            // 
            this.ctrlTestMethodInfoCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlTestMethodInfoCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTestMethodInfoCardWithFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlTestMethodInfoCardWithFilter1.Location = new System.Drawing.Point(4, 5);
            this.ctrlTestMethodInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTestMethodInfoCardWithFilter1.Name = "ctrlTestMethodInfoCardWithFilter1";
            this.ctrlTestMethodInfoCardWithFilter1.Size = new System.Drawing.Size(410, 231);
            this.ctrlTestMethodInfoCardWithFilter1.TabIndex = 0;
            // 
            // tbFoamCatalogSpecInfo
            // 
            this.tbFoamCatalogSpecInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbFoamCatalogSpecInfo.Controls.Add(this.button4);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.numericUpDown3);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.label8);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.numericUpDown2);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.numericUpDown1);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.label12);
            this.tbFoamCatalogSpecInfo.Controls.Add(this.label10);
            this.tbFoamCatalogSpecInfo.Location = new System.Drawing.Point(4, 29);
            this.tbFoamCatalogSpecInfo.Name = "tbFoamCatalogSpecInfo";
            this.tbFoamCatalogSpecInfo.Size = new System.Drawing.Size(781, 210);
            this.tbFoamCatalogSpecInfo.TabIndex = 3;
            this.tbFoamCatalogSpecInfo.Text = "Foam Catalog Spec Info";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(602, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 46);
            this.button4.TabIndex = 110;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 4;
            this.numericUpDown3.Location = new System.Drawing.Point(141, 153);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown3.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 108;
            this.label8.Text = "MinValue: ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 4;
            this.numericUpDown2.Location = new System.Drawing.Point(141, 43);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 107;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Location = new System.Drawing.Point(141, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 105;
            this.label12.Text = "MaxValue: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Target Value: ";
            // 
            // frmAddUpdateFoamGradeSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(793, 378);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateFoamGradeSpec";
            this.Text = "frmAddUpdateFoamGradeSpec";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbFoamCatalogInfo.ResumeLayout(false);
            this.tbPropertyInfo.ResumeLayout(false);
            this.tbTestMethodInfo.ResumeLayout(false);
            this.tbFoamCatalogSpecInfo.ResumeLayout(false);
            this.tbFoamCatalogSpecInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFoamCatalogInfo;
        private System.Windows.Forms.TabPage tbPropertyInfo;
        private System.Windows.Forms.TabPage tbTestMethodInfo;
        private System.Windows.Forms.TabPage tbFoamCatalogSpecInfo;
        private System.Windows.Forms.Button button8;
        private FoamGrades.UserControls.ctrlFoamCatalogInfoWithFilter ctrlFoamGradeInfoCardWithFilter1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private Global.Properties.UserControls.ctrlPropertyInfoCardWithFilter ctrlPropertyInfoCardWithFilter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private Machines.TestMethods.User_Controls.ctrlTestMethodInfoCardWithFilter ctrlTestMethodInfoCardWithFilter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}
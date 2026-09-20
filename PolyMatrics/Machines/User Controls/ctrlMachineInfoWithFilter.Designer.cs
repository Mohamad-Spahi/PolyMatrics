namespace PolyMatrics.Machines.User_Controls
{
    partial class ctrlMachineInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlMachineFilter1 = new PolyMatrics.Machines.User_Controls.ctrlMachineFilter();
            this.ctrlMachineInfoCard1 = new PolyMatrics.Machines.User_Controls.ctrlMachineInfoCard();
            this.SuspendLayout();
            // 
            // ctrlMachineFilter1
            // 
            this.ctrlMachineFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMachineFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMachineFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMachineFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlMachineFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMachineFilter1.Name = "ctrlMachineFilter1";
            this.ctrlMachineFilter1.Size = new System.Drawing.Size(679, 66);
            this.ctrlMachineFilter1.TabIndex = 1;
            // 
            // ctrlMachineInfoCard1
            // 
            this.ctrlMachineInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMachineInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMachineInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMachineInfoCard1.Location = new System.Drawing.Point(0, 61);
            this.ctrlMachineInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMachineInfoCard1.Name = "ctrlMachineInfoCard1";
            this.ctrlMachineInfoCard1.Size = new System.Drawing.Size(632, 142);
            this.ctrlMachineInfoCard1.TabIndex = 2;
            // 
            // ctrlMachineInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.ctrlMachineFilter1);
            this.Controls.Add(this.ctrlMachineInfoCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlMachineInfoWithFilter";
            this.Size = new System.Drawing.Size(680, 206);
            this.Load += new System.EventHandler(this.ctrlMachineInfoWithFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlMachineFilter ctrlMachineFilter1;
        private ctrlMachineInfoCard ctrlMachineInfoCard1;
    }
}

namespace PolyMatrics.Global.Properties.UserControls
{
    partial class ctrlPropertyInfoCardWithFilter
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
            this.ctrlPropertyFilter1 = new PolyMatrics.Global.Properties.UserControls.ctrlPropertyFilter();
            this.ctrlPropertyInfoCard1 = new PolyMatrics.Global.Properties.UserControls.ctrlPropertyInfoCard();
            this.SuspendLayout();
            // 
            // ctrlPropertyFilter1
            // 
            this.ctrlPropertyFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlPropertyFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPropertyFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlPropertyFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPropertyFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPropertyFilter1.Name = "ctrlPropertyFilter1";
            this.ctrlPropertyFilter1.Size = new System.Drawing.Size(715, 76);
            this.ctrlPropertyFilter1.TabIndex = 3;
            // 
            // ctrlPropertyInfoCard1
            // 
            this.ctrlPropertyInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlPropertyInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPropertyInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlPropertyInfoCard1.Location = new System.Drawing.Point(4, 75);
            this.ctrlPropertyInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPropertyInfoCard1.Name = "ctrlPropertyInfoCard1";
            this.ctrlPropertyInfoCard1.Size = new System.Drawing.Size(591, 124);
            this.ctrlPropertyInfoCard1.TabIndex = 4;
            // 
            // ctrlPropertyInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.ctrlPropertyInfoCard1);
            this.Controls.Add(this.ctrlPropertyFilter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlPropertyInfoCardWithFilter";
            this.Size = new System.Drawing.Size(717, 200);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlPropertyFilter ctrlPropertyFilter1;
        private ctrlPropertyInfoCard ctrlPropertyInfoCard1;
    }
}

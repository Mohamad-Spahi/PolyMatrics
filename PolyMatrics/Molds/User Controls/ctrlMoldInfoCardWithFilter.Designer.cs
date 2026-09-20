namespace PolyMatrics.Molds.User_Controls
{
    partial class ctrlMoldInfoCardWithFilter
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
            this.ctrlMoldFilter1 = new PolyMatrics.Molds.User_Controls.ctrlMoldFilter();
            this.ctrlMoldInfoCard1 = new PolyMatrics.Molds.User_Controls.ctrlMoldInfoCard();
            this.SuspendLayout();
            // 
            // ctrlMoldFilter1
            // 
            this.ctrlMoldFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMoldFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMoldFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMoldFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlMoldFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMoldFilter1.Name = "ctrlMoldFilter1";
            this.ctrlMoldFilter1.Size = new System.Drawing.Size(708, 64);
            this.ctrlMoldFilter1.TabIndex = 44;
            // 
            // ctrlMoldInfoCard1
            // 
            this.ctrlMoldInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlMoldInfoCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMoldInfoCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlMoldInfoCard1.Location = new System.Drawing.Point(0, 68);
            this.ctrlMoldInfoCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlMoldInfoCard1.Name = "ctrlMoldInfoCard1";
            this.ctrlMoldInfoCard1.Size = new System.Drawing.Size(596, 132);
            this.ctrlMoldInfoCard1.TabIndex = 45;
            // 
            // ctrlMoldInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.ctrlMoldInfoCard1);
            this.Controls.Add(this.ctrlMoldFilter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlMoldInfoCardWithFilter";
            this.Size = new System.Drawing.Size(715, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMoldFilter ctrlMoldFilter1;
        private ctrlMoldInfoCard ctrlMoldInfoCard1;
    }
}

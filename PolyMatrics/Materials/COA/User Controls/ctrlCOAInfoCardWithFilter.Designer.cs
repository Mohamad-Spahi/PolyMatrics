namespace PolyMatrics.Materials.COA.User_Controls
{
    partial class ctrlCOAInfoCardWithFilter
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
            this.ctrlCOAFilter1 = new PolyMatrics.Materials.COA.User_Controls.ctrlCOAFilter();
            this.ctrlBatchInfo1 = new PolyMatrics.Materials.COA.User_Controls.ctrlBatchInfo();
            this.SuspendLayout();
            // 
            // ctrlCOAFilter1
            // 
            this.ctrlCOAFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlCOAFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCOAFilter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlCOAFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCOAFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlCOAFilter1.Name = "ctrlCOAFilter1";
            this.ctrlCOAFilter1.Size = new System.Drawing.Size(640, 61);
            this.ctrlCOAFilter1.TabIndex = 1;
            // 
            // ctrlBatchInfo1
            // 
            this.ctrlBatchInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ctrlBatchInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBatchInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ctrlBatchInfo1.Location = new System.Drawing.Point(0, 59);
            this.ctrlBatchInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBatchInfo1.Name = "ctrlBatchInfo1";
            this.ctrlBatchInfo1.Size = new System.Drawing.Size(474, 108);
            this.ctrlBatchInfo1.TabIndex = 2;
            // 
            // ctrlCOAInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.ctrlBatchInfo1);
            this.Controls.Add(this.ctrlCOAFilter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlCOAInfoCardWithFilter";
            this.Size = new System.Drawing.Size(640, 168);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlCOAFilter ctrlCOAFilter1;
        private ctrlBatchInfo ctrlBatchInfo1;
    }
}

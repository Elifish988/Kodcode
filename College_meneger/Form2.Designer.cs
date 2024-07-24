namespace College_meneger
{
    partial class Form2
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
            this.lblCutegory = new System.Windows.Forms.Label();
            this.dtgStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCutegory
            // 
            this.lblCutegory.AutoSize = true;
            this.lblCutegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCutegory.Location = new System.Drawing.Point(316, 9);
            this.lblCutegory.Name = "lblCutegory";
            this.lblCutegory.Size = new System.Drawing.Size(138, 22);
            this.lblCutegory.TabIndex = 22;
            this.lblCutegory.Text = "רשימת התלמידים";
            // 
            // dtgStudents
            // 
            this.dtgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudents.Location = new System.Drawing.Point(0, 36);
            this.dtgStudents.Name = "dtgStudents";
            this.dtgStudents.RowHeadersWidth = 51;
            this.dtgStudents.RowTemplate.Height = 24;
            this.dtgStudents.Size = new System.Drawing.Size(801, 413);
            this.dtgStudents.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCutegory);
            this.Controls.Add(this.dtgStudents);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCutegory;
        private System.Windows.Forms.DataGridView dtgStudents;
    }
}
namespace WindowsFormsApp1
{
    partial class Form2Host
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
            this.lblCutegireHost = new System.Windows.Forms.Label();
            this.dtgCutegory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCutegory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCutegireHost
            // 
            this.lblCutegireHost.AutoSize = true;
            this.lblCutegireHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCutegireHost.Location = new System.Drawing.Point(187, 31);
            this.lblCutegireHost.Name = "lblCutegireHost";
            this.lblCutegireHost.Size = new System.Drawing.Size(108, 32);
            this.lblCutegireHost.TabIndex = 0;
            this.lblCutegireHost.Text = "קטגוריה";
            this.lblCutegireHost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtgCutegory
            // 
            this.dtgCutegory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCutegory.Location = new System.Drawing.Point(103, 93);
            this.dtgCutegory.Name = "dtgCutegory";
            this.dtgCutegory.RowHeadersWidth = 51;
            this.dtgCutegory.RowTemplate.Height = 24;
            this.dtgCutegory.Size = new System.Drawing.Size(395, 272);
            this.dtgCutegory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(267, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "הזמנות בקטגוריה";
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(100, 371);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(204, 54);
            this.btnRev.TabIndex = 3;
            this.btnRev.Text = "<<<<";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(307, 371);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(191, 54);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form2Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCutegory);
            this.Controls.Add(this.lblCutegireHost);
            this.Name = "Form2Host";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2Host_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCutegory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCutegireHost;
        private System.Windows.Forms.DataGridView dtgCutegory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnNext;
    }
}
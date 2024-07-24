namespace College_meneger
{
    partial class Form3
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
            this.dtgCurses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriat = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCurses
            // 
            this.dtgCurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurses.Location = new System.Drawing.Point(1, 46);
            this.dtgCurses.Name = "dtgCurses";
            this.dtgCurses.RowHeadersWidth = 51;
            this.dtgCurses.RowTemplate.Height = 24;
            this.dtgCurses.Size = new System.Drawing.Size(801, 345);
            this.dtgCurses.TabIndex = 19;
            this.dtgCurses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCurses_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "טבלת הקורסים הפעילים במכללה";
            // 
            // btnCriat
            // 
            this.btnCriat.Location = new System.Drawing.Point(399, 397);
            this.btnCriat.Name = "btnCriat";
            this.btnCriat.Size = new System.Drawing.Size(389, 41);
            this.btnCriat.TabIndex = 21;
            this.btnCriat.Text = "ליצירת קורס חדש";
            this.btnCriat.UseVisualStyleBackColor = true;
            this.btnCriat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Location = new System.Drawing.Point(1, 397);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(392, 41);
            this.btnDel1.TabIndex = 22;
            this.btnDel1.Text = "מחיקת קורס";
            this.btnDel1.UseVisualStyleBackColor = true;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(399, 397);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(392, 41);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "מחיקה";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(1, 397);
            this.txtDel.Multiline = true;
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(392, 41);
            this.txtDel.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.btnCriat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCurses);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCurses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriat;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDel;
    }
}
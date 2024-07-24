namespace Guests_to_Shebaas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lsbName = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDelit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ברוך הבא";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(160, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "אנא הכנס את שם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "במידה והתארחת אצלנו בעבר נא בחר את שמך מהרשימה למטה";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 119);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 38);
            this.txtName.TabIndex = 3;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // lsbName
            // 
            this.lsbName.FormattingEnabled = true;
            this.lsbName.ItemHeight = 16;
            this.lsbName.Location = new System.Drawing.Point(138, 207);
            this.lsbName.Name = "lsbName";
            this.lsbName.Size = new System.Drawing.Size(213, 196);
            this.lsbName.TabIndex = 4;

            this.lsbName.DoubleClick += new System.EventHandler(this.lsbName_DoubleClick);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(138, 411);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(213, 47);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "הכנס";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDelit
            // 
            this.btnDelit.Location = new System.Drawing.Point(138, 464);
            this.btnDelit.Name = "btnDelit";
            this.btnDelit.Size = new System.Drawing.Size(213, 47);
            this.btnDelit.TabIndex = 6;
            this.btnDelit.Text = "מחק";
            this.btnDelit.UseVisualStyleBackColor = true;
            this.btnDelit.Click += new System.EventHandler(this.btnDelit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 524);
            this.Controls.Add(this.btnDelit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lsbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lsbName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDelit;
    }
}


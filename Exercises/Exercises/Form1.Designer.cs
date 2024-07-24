namespace Exercises
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
            this.btnCar = new System.Windows.Forms.Button();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScores2 = new System.Windows.Forms.TextBox();
            this.txtScores1 = new System.Windows.Forms.TextBox();
            this.txtScores3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(164, 12);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(75, 23);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(17, 13);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(100, 22);
            this.txtCar.TabIndex = 1;
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(258, 86);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(100, 22);
            this.txtScores.TabIndex = 3;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(375, 86);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(139, 86);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "scores";
            // 
            // txtScores2
            // 
            this.txtScores2.Location = new System.Drawing.Point(258, 142);
            this.txtScores2.Name = "txtScores2";
            this.txtScores2.Size = new System.Drawing.Size(100, 22);
            this.txtScores2.TabIndex = 10;
            // 
            // txtScores1
            // 
            this.txtScores1.Location = new System.Drawing.Point(258, 114);
            this.txtScores1.Name = "txtScores1";
            this.txtScores1.Size = new System.Drawing.Size(100, 22);
            this.txtScores1.TabIndex = 11;
            // 
            // txtScores3
            // 
            this.txtScores3.Location = new System.Drawing.Point(258, 170);
            this.txtScores3.Name = "txtScores3";
            this.txtScores3.Size = new System.Drawing.Size(100, 22);
            this.txtScores3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScores3);
            this.Controls.Add(this.txtScores1);
            this.Controls.Add(this.txtScores2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.btnCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.TextBox txtScores;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScores2;
        private System.Windows.Forms.TextBox txtScores1;
        private System.Windows.Forms.TextBox txtScores3;
    }
}


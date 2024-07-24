namespace Rabanut_IDF
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
            this.cmdYear = new System.Windows.Forms.ComboBox();
            this.cmbMuns = new System.Windows.Forms.ComboBox();
            this.cmbMunsDay = new System.Windows.Forms.ComboBox();
            this.cmbWekDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRezult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdYear
            // 
            this.cmdYear.FormattingEnabled = true;
            this.cmdYear.Items.AddRange(new object[] {
            "תשפ\"ד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז",
            "תשפ\"ח",
            "תשפ\"ט"});
            this.cmdYear.Location = new System.Drawing.Point(97, 62);
            this.cmdYear.Name = "cmdYear";
            this.cmdYear.Size = new System.Drawing.Size(121, 24);
            this.cmdYear.TabIndex = 0;
            // 
            // cmbMuns
            // 
            this.cmbMuns.FormattingEnabled = true;
            this.cmbMuns.Items.AddRange(new object[] {
            "תשרי",
            "חשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיוון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMuns.Location = new System.Drawing.Point(274, 62);
            this.cmbMuns.Name = "cmbMuns";
            this.cmbMuns.Size = new System.Drawing.Size(121, 24);
            this.cmbMuns.TabIndex = 1;
            // 
            // cmbMunsDay
            // 
            this.cmbMunsDay.FormattingEnabled = true;
            this.cmbMunsDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbMunsDay.Location = new System.Drawing.Point(439, 62);
            this.cmbMunsDay.Name = "cmbMunsDay";
            this.cmbMunsDay.Size = new System.Drawing.Size(121, 24);
            this.cmbMunsDay.TabIndex = 2;
            // 
            // cmbWekDay
            // 
            this.cmbWekDay.FormattingEnabled = true;
            this.cmbWekDay.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cmbWekDay.Location = new System.Drawing.Point(601, 62);
            this.cmbWekDay.Name = "cmbWekDay";
            this.cmbWekDay.Size = new System.Drawing.Size(121, 24);
            this.cmbWekDay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(295, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "חודש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(595, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "יום בשבוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(433, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "יום בחודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(127, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "שנה";
            // 
            // txtRezult
            // 
            this.txtRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRezult.Location = new System.Drawing.Point(12, 389);
            this.txtRezult.Multiline = true;
            this.txtRezult.Name = "txtRezult";
            this.txtRezult.Size = new System.Drawing.Size(776, 49);
            this.txtRezult.TabIndex = 8;
            this.txtRezult.WordWrap = false;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnResult.Location = new System.Drawing.Point(231, 389);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(295, 49);
            this.btnResult.TabIndex = 9;
            this.btnResult.Text = "להצגת הטקסט הכשר";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtRezult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWekDay);
            this.Controls.Add(this.cmbMunsDay);
            this.Controls.Add(this.cmbMuns);
            this.Controls.Add(this.cmdYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdYear;
        private System.Windows.Forms.ComboBox cmbMuns;
        private System.Windows.Forms.ComboBox cmbMunsDay;
        private System.Windows.Forms.ComboBox cmbWekDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRezult;
        private System.Windows.Forms.Button btnResult;
    }
}


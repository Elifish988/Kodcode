namespace College
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddChoys = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbCourses = new System.Windows.Forms.ListBox();
            this.lsbMyCourses = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(212, 226);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(142, 22);
            this.txtAdd.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddChoys
            // 
            this.btnAddChoys.Location = new System.Drawing.Point(113, 197);
            this.btnAddChoys.Name = "btnAddChoys";
            this.btnAddChoys.Size = new System.Drawing.Size(241, 23);
            this.btnAddChoys.TabIndex = 23;
            this.btnAddChoys.Text = "הוסף קורס";
            this.btnAddChoys.UseVisualStyleBackColor = true;
            this.btnAddChoys.Click += new System.EventHandler(this.btnAddChoys_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(209, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "שם";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "הקורסים שלי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "הקורסים במכללה";
            // 
            // lsbCourses
            // 
            this.lsbCourses.FormattingEnabled = true;
            this.lsbCourses.ItemHeight = 16;
            this.lsbCourses.Location = new System.Drawing.Point(113, 75);
            this.lsbCourses.Name = "lsbCourses";
            this.lsbCourses.Size = new System.Drawing.Size(241, 116);
            this.lsbCourses.TabIndex = 26;
            this.lsbCourses.DoubleClick += new System.EventHandler(this.lsbCourses_DoubleClick);
            // 
            // lsbMyCourses
            // 
            this.lsbMyCourses.FormattingEnabled = true;
            this.lsbMyCourses.ItemHeight = 16;
            this.lsbMyCourses.Location = new System.Drawing.Point(113, 270);
            this.lsbMyCourses.Name = "lsbMyCourses";
            this.lsbMyCourses.Size = new System.Drawing.Size(241, 116);
            this.lsbMyCourses.TabIndex = 27;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(113, 393);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(241, 28);
            this.btnEnter.TabIndex = 28;
            this.btnEnter.Text = "לתשלום עבור קורסים קודמים";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lsbMyCourses);
            this.Controls.Add(this.lsbCourses);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddChoys);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddChoys;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbCourses;
        private System.Windows.Forms.ListBox lsbMyCourses;
        private System.Windows.Forms.Button btnEnter;
    }
}
namespace Guests_to_Shebaas
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
            this.lblCutegory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgChoosMy = new System.Windows.Forms.DataGridView();
            this.dtgCoosAll = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChoosMy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCoosAll)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(293, 210);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(241, 22);
            this.txtAdd.TabIndex = 15;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddChoys
            // 
            this.btnAddChoys.Location = new System.Drawing.Point(653, 210);
            this.btnAddChoys.Name = "btnAddChoys";
            this.btnAddChoys.Size = new System.Drawing.Size(96, 23);
            this.btnAddChoys.TabIndex = 13;
            this.btnAddChoys.Text = "הוסף מנה";
            this.btnAddChoys.UseVisualStyleBackColor = true;
            this.btnAddChoys.Click += new System.EventHandler(this.btnAddChoys_Click);
            // 
            // lblCutegory
            // 
            this.lblCutegory.AutoSize = true;
            this.lblCutegory.Location = new System.Drawing.Point(375, 24);
            this.lblCutegory.Name = "lblCutegory";
            this.lblCutegory.Size = new System.Drawing.Size(53, 16);
            this.lblCutegory.TabIndex = 12;
            this.lblCutegory.Text = "קטגוריה";
            this.lblCutegory.Click += new System.EventHandler(this.lblCutegory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "הבחירות שלי";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "הבחירות של כלל האורחים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgChoosMy
            // 
            this.dtgChoosMy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChoosMy.Location = new System.Drawing.Point(48, 258);
            this.dtgChoosMy.Name = "dtgChoosMy";
            this.dtgChoosMy.RowHeadersWidth = 51;
            this.dtgChoosMy.RowTemplate.Height = 24;
            this.dtgChoosMy.Size = new System.Drawing.Size(705, 153);
            this.dtgChoosMy.TabIndex = 9;
            this.dtgChoosMy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChoosMy_CellContentClick);
            // 
            // dtgCoosAll
            // 
            this.dtgCoosAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCoosAll.Location = new System.Drawing.Point(48, 43);
            this.dtgCoosAll.Name = "dtgCoosAll";
            this.dtgCoosAll.RowHeadersWidth = 51;
            this.dtgCoosAll.RowTemplate.Height = 24;
            this.dtgCoosAll.Size = new System.Drawing.Size(705, 150);
            this.dtgCoosAll.TabIndex = 8;
            this.dtgCoosAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCoosAll_CellClick);
            this.dtgCoosAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCoosAll_CellContentClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(311, 417);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(96, 23);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "<<<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtNext
            // 
            this.txtNext.Location = new System.Drawing.Point(413, 417);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(96, 23);
            this.txtNext.TabIndex = 17;
            this.txtNext.Text = ">>>>";
            this.txtNext.UseVisualStyleBackColor = true;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddChoys);
            this.Controls.Add(this.lblCutegory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgChoosMy);
            this.Controls.Add(this.dtgCoosAll);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChoosMy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCoosAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddChoys;
        private System.Windows.Forms.Label lblCutegory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgChoosMy;
        private System.Windows.Forms.DataGridView dtgCoosAll;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button txtNext;
    }
}
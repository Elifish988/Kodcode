namespace CoffeeMachine
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCoffee = new System.Windows.Forms.ComboBox();
            this.cmbCacoa = new System.Windows.Forms.ComboBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.cmbShoger = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelede = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(472, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם המשקה";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(294, 51);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 25);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cocoa,
            this.milk,
            this.copy,
            this.shuger,
            this.pricee});
            this.dgvMenu.Location = new System.Drawing.Point(93, 177);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(548, 210);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // cocoa
            // 
            this.cocoa.HeaderText = "קקאו";
            this.cocoa.MinimumWidth = 6;
            this.cocoa.Name = "cocoa";
            this.cocoa.Width = 60;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.Width = 60;
            // 
            // copy
            // 
            this.copy.HeaderText = "קפה";
            this.copy.MinimumWidth = 6;
            this.copy.Name = "copy";
            this.copy.Width = 60;
            // 
            // shuger
            // 
            this.shuger.HeaderText = "סוכר";
            this.shuger.MinimumWidth = 6;
            this.shuger.Name = "shuger";
            this.shuger.Width = 60;
            // 
            // pricee
            // 
            this.pricee.HeaderText = "מחיר";
            this.pricee.MinimumWidth = 6;
            this.pricee.Name = "pricee";
            this.pricee.Width = 60;
            // 
            // cmbCoffee
            // 
            this.cmbCoffee.FormattingEnabled = true;
            this.cmbCoffee.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0"});
            this.cmbCoffee.Location = new System.Drawing.Point(430, 132);
            this.cmbCoffee.Name = "cmbCoffee";
            this.cmbCoffee.Size = new System.Drawing.Size(53, 24);
            this.cmbCoffee.TabIndex = 3;
            this.cmbCoffee.Text = "0.0";
            // 
            // cmbCacoa
            // 
            this.cmbCacoa.FormattingEnabled = true;
            this.cmbCacoa.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0"});
            this.cmbCacoa.Location = new System.Drawing.Point(269, 132);
            this.cmbCacoa.Name = "cmbCacoa";
            this.cmbCacoa.Size = new System.Drawing.Size(53, 24);
            this.cmbCacoa.TabIndex = 4;
            this.cmbCacoa.Text = "0.0";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0"});
            this.cmbMilk.Location = new System.Drawing.Point(351, 132);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(53, 24);
            this.cmbMilk.TabIndex = 5;
            this.cmbMilk.Text = "0.0";
            // 
            // cmbShoger
            // 
            this.cmbShoger.FormattingEnabled = true;
            this.cmbShoger.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0"});
            this.cmbShoger.Location = new System.Drawing.Point(513, 132);
            this.cmbShoger.Name = "cmbShoger";
            this.cmbShoger.Size = new System.Drawing.Size(53, 24);
            this.cmbShoger.TabIndex = 6;
            this.cmbShoger.Text = "0.0";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 132);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(50, 24);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(211, 132);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 24);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(112, 132);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 24);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 65);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelede
            // 
            this.btnDelede.Location = new System.Drawing.Point(12, 174);
            this.btnDelede.Name = "btnDelede";
            this.btnDelede.Size = new System.Drawing.Size(75, 66);
            this.btnDelede.TabIndex = 12;
            this.btnDelede.Text = "Delete";
            this.btnDelede.UseVisualStyleBackColor = true;
            this.btnDelede.Click += new System.EventHandler(this.btnDelede_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 70);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 63);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(270, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "קקאו";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(361, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "חלב";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(440, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "קפה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(519, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "סוכר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(153, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "מחיר";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelede);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbShoger);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCacoa);
            this.Controls.Add(this.cmbCoffee);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.ComboBox cmbCoffee;
        private System.Windows.Forms.ComboBox cmbCacoa;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.ComboBox cmbShoger;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelede;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuger;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricee;
    }
}


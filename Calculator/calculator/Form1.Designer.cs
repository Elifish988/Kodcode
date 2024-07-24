namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn3 = new Button();
            btn2 = new Button();
            txtNumber1 = new TextBox();
            btn1 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btnEquals = new Button();
            btnPoint = new Button();
            lblResult = new Label();
            btnPlus = new Button();
            btnSub = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            txtNumber2 = new TextBox();
            cmbOperators = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btn3, 2, 1);
            tableLayoutPanel1.Controls.Add(btn2, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNumber1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn7, 0, 3);
            tableLayoutPanel1.Controls.Add(btn8, 1, 3);
            tableLayoutPanel1.Controls.Add(btn9, 2, 3);
            tableLayoutPanel1.Controls.Add(btn10, 1, 4);
            tableLayoutPanel1.Controls.Add(btnEquals, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPoint, 2, 4);
            tableLayoutPanel1.Controls.Add(lblResult, 3, 0);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 1);
            tableLayoutPanel1.Controls.Add(btnSub, 3, 2);
            tableLayoutPanel1.Controls.Add(btnMulti, 3, 3);
            tableLayoutPanel1.Controls.Add(btnDiv, 3, 4);
            tableLayoutPanel1.Controls.Add(txtNumber2, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbOperators, 1, 0);
            tableLayoutPanel1.Location = new Point(197, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(407, 342);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btn3
            // 
            btn3.Location = new Point(205, 67);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 64);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click_Global;
            // 
            // btn2
            // 
            btn2.Location = new Point(104, 67);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 64);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click_Global;
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber1.Location = new Point(3, 3);
            txtNumber1.Multiline = true;
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(94, 58);
            txtNumber1.TabIndex = 3;
            txtNumber1.TextAlign = HorizontalAlignment.Center;
            txtNumber1.Enter += txtNumber1_Enter;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 67);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 64);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click_Global;
            // 
            // btn4
            // 
            btn4.Location = new Point(3, 137);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 64);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click_Global;
            // 
            // btn5
            // 
            btn5.Location = new Point(104, 137);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 64);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click_Global;
            // 
            // btn6
            // 
            btn6.Location = new Point(205, 137);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 64);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click_Global;
            // 
            // btn7
            // 
            btn7.Location = new Point(3, 211);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 62);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click_Global;
            // 
            // btn8
            // 
            btn8.Location = new Point(104, 211);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 62);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click_Global;
            // 
            // btn9
            // 
            btn9.Location = new Point(205, 211);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 62);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click_Global;
            // 
            // btn10
            // 
            btn10.Location = new Point(104, 279);
            btn10.Name = "btn10";
            btn10.Size = new Size(94, 60);
            btn10.TabIndex = 14;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn_Click_Global;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(3, 279);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(94, 60);
            btnEquals.TabIndex = 1;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(205, 279);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(94, 60);
            btnPoint.TabIndex = 19;
            btnPoint.Text = "<-";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(330, 11);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 41);
            lblResult.TabIndex = 1;
            lblResult.Text = "00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.Location = new Point(306, 67);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 64);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ActiveCaption;
            btnSub.Location = new Point(306, 137);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(94, 64);
            btnSub.TabIndex = 16;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ActiveCaption;
            btnMulti.Location = new Point(306, 211);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(94, 62);
            btnMulti.TabIndex = 17;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveCaption;
            btnDiv.Location = new Point(306, 279);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 60);
            btnDiv.TabIndex = 18;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber2.Location = new Point(205, 3);
            txtNumber2.Multiline = true;
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(94, 58);
            txtNumber2.TabIndex = 21;
            txtNumber2.Enter += txtNumber2_Enter;
            // 
            // cmbOperators
            // 
            cmbOperators.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOperators.Location = new Point(104, 3);
            cmbOperators.Multiline = true;
            cmbOperators.Name = "cmbOperators";
            cmbOperators.Size = new Size(95, 58);
            cmbOperators.TabIndex = 22;
            cmbOperators.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn3;
        private Button btn2;
        private TextBox txtNumber1;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btnEquals;
        private Button btnPoint;
        private Label lblResult;
        private Button btnPlus;
        private Button btnSub;
        private Button btnMulti;
        private Button btnDiv;
        private TextBox txtNumber2;
        private TextBox cmbOperators;
    }
}

namespace WindowsFormsApp1
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
            this.txtEnterCutegor = new System.Windows.Forms.TextBox();
            this.lsbCutegory = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelit = new System.Windows.Forms.Button();
            this.btnShouOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(171, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח - הכנס קטגוריה";
            // 
            // txtEnterCutegor
            // 
            this.txtEnterCutegor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEnterCutegor.Location = new System.Drawing.Point(185, 77);
            this.txtEnterCutegor.Multiline = true;
            this.txtEnterCutegor.Name = "txtEnterCutegor";
            this.txtEnterCutegor.Size = new System.Drawing.Size(178, 38);
            this.txtEnterCutegor.TabIndex = 1;
            this.txtEnterCutegor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnterCutegor_KeyUp);
            // 
            // lsbCutegory
            // 
            this.lsbCutegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lsbCutegory.FormattingEnabled = true;
            this.lsbCutegory.ItemHeight = 25;
            this.lsbCutegory.Location = new System.Drawing.Point(185, 204);
            this.lsbCutegory.Name = "lsbCutegory";
            this.lsbCutegory.Size = new System.Drawing.Size(178, 229);
            this.lsbCutegory.TabIndex = 2;
            this.lsbCutegory.DoubleClick += new System.EventHandler(this.lsbCutegory_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(141, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelit
            // 
            this.btnDelit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelit.Location = new System.Drawing.Point(292, 136);
            this.btnDelit.Name = "btnDelit";
            this.btnDelit.Size = new System.Drawing.Size(121, 50);
            this.btnDelit.TabIndex = 4;
            this.btnDelit.Text = "מחיקה";
            this.btnDelit.UseVisualStyleBackColor = true;
            this.btnDelit.Click += new System.EventHandler(this.btnDelit_Click);
            // 
            // btnShouOrder
            // 
            this.btnShouOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShouOrder.Location = new System.Drawing.Point(29, 373);
            this.btnShouOrder.Name = "btnShouOrder";
            this.btnShouOrder.Size = new System.Drawing.Size(121, 50);
            this.btnShouOrder.TabIndex = 5;
            this.btnShouOrder.Text = "הצג הזמנה";
            this.btnShouOrder.UseVisualStyleBackColor = true;
            this.btnShouOrder.Click += new System.EventHandler(this.btnShouOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btnShouOrder);
            this.Controls.Add(this.btnDelit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbCutegory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterCutegor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterCutegor;
        private System.Windows.Forms.ListBox lsbCutegory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelit;
        private System.Windows.Forms.Button btnShouOrder;
    }
}


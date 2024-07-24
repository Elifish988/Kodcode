using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guests_to_Shebaas
{
    public partial class Form2 : Form
    {
        public List<Form2> Forms;
        public int Position;
        public string Name;
        public Form2(List<Form2> forms, int position, string categoryName, string name )
        {
            InitializeComponent();
            // הפורום בעצמו
            Forms = forms;
            // מציג מספור של פורם
            Position = position;
            // שם קטגוריה
            lblCutegory.Text = categoryName;
            Name = name;
            
        }
        public Form2()
        {
            InitializeComponent();
        }

        //היתחול טופס ומילוי טבלאות
        private void Form2_Load(object sender, EventArgs e)
        {
            //טבלת בחירות של כולם
            string[] values = { lblCutegory.Text, Name };
            //הוספה ללוח
            dtgCoosAll.DataSource = Control_Guests.ShoewEveryoneChoice(values);
            //טבלת בחירות שלי
            //הוספה ללוח
            dtgChoosMy.DataSource = Control_Guests.ShowMyChoice(values);
            //הסתרת כפתורים
            btnAdd.Visible = false; 
            txtAdd.Visible = false;
        }

        private void txtNext_Click(object sender, EventArgs e)
        {
            // בודק האם זה הפורום האחרון
            if (Position < Forms.Count - 1)
            {
                //סגירת הטופס הקודם
                Forms[Position].Visible = false;
                //פתיחת טופס חדש
                Forms[Position + 1].Show();
            }
            else
            {

                Forms[Position].Visible = false;
                Forms[0].Show();

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Position > 0)
            {

                Forms[Position].Visible = false;
                Forms[Position - 1].Show();
            }
            else
            {

                Forms[Position].Visible = false;
                Forms[Forms.Count - 1].Show();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] values = { Name, lblCutegory.Text , txtAdd.Text };
            Control_Guests.AddMael(values);
            //ניקוי רשימה ישנה
            //dtgChoosMy.DataSource = null;
            // הצגת טבלה חדשה כולל התוספת החדשה
            string[] values2 = { Name, lblCutegory.Text };
            DataTable updatedData = Control_Guests.ShowMyChoice(values2);
            dtgChoosMy.DataSource = updatedData;
            //ניקוי טקסט בוקס
            txtAdd.Text = string.Empty;

        }

        //הכנסת ערך מטבלה שנמצאת בדאטה גריט אל טקסט בוקס על ידי לחיצה
        private void dtgCoosAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // קבלת הערך של התא שנבחר
                string cellValue = dtgCoosAll.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // הצגת הערך ב-TextBox
                txtAdd.Text = cellValue;
            }
        }

        //הצגת כפתורים כבויים
        private void btnAddChoys_Click(object sender, EventArgs e)
        {
            if(btnAdd.Visible == true)
            {
                btnAdd.Visible = false;
                txtAdd.Visible = false;
                btnAddChoys.Text = "הוסף מנה";
            }
            else
            {
                btnAdd.Visible = true;
                txtAdd.Visible = true;
                btnAddChoys.Text = "סגור";
            }

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCutegory_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgChoosMy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCoosAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

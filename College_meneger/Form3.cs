using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace College_meneger
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtgCurses.DataSource = Cntrol_Colleg_meneger.ShoewCurses();
            btnDel.Visible = false;
            txtDel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_course בreate_course = new Create_course();
            בreate_course.Show();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            btnDel.Visible = true;
            txtDel.Visible = true;
            btnDel1.Visible = false;
            btnCriat.Visible = false;
        }

        private void dtgCurses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // קבלת הערך של התא שנבחר
                string cellValue = dtgCurses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // הצגת הערך ב-TextBox
                txtDel.Text = cellValue;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string [] values = { txtDel.Text  };
            Cntrol_Colleg_meneger.DellCourse(values);
            MessageBox.Show("הקורס " + txtDel.Text + " נמחק בהצלחה");
            dtgCurses.DataSource = Cntrol_Colleg_meneger.ShoewCurses();
            //ניקוי טקסט בוקס
            txtDel.Text = string.Empty;
        }
    }
}

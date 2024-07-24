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

namespace College
{
    public partial class Form2 : Form
    {

        
        public Form2(string name)
        {
            InitializeComponent();    
            lblName.Text = name;
            

        }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> Courses = Control_College.GetCourses();
            foreach (string Course in Courses)
            lsbCourses.Items.Add(Course);
            List<string> Courses1 = Control_College.GetCoursesMy(lblName.Text);
            foreach (string Course1 in Courses1)
            lsbMyCourses.Items.Add(Course1);
            //הסתרת כפתורים
            btnAdd.Visible = false;
            txtAdd.Visible = false;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChoys_Click(object sender, EventArgs e)
        {
            if (btnAdd.Visible == true)
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

        private void lsbCourses_DoubleClick(object sender, EventArgs e)
        {
            if (lsbCourses.SelectedItem != null)
            {
                txtAdd.Text = lsbCourses.SelectedItem.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] values = { lblName.Text, txtAdd.Text };
            Control_College.AddCourse(values);
            //ניקוי רשימה ישנה
            lsbMyCourses.Items.Clear();
            // הצגת טבלה חדשה כולל התוספת החדשה
            List<string> Courses1 = Control_College.GetCoursesMy(lblName.Text);
            foreach (string Course1 in Courses1)
            lsbMyCourses.Items.Add(Course1);
            //ניקוי טקסט בוקס
            txtAdd.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnPay form3 = new btnPay(lblName.Text);
            form3.Show();
        }
    }
}

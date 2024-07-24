using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_meneger
{
    public partial class Create_course : Form
    {
        public Create_course()
        {
            InitializeComponent();
        }

        private void Create_course_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] values = {int.Parse(txtPrase.Text), txtName.Text, null, int.Parse(txtDase.Text), int.Parse(txtHowers.Text) };
            Cntrol_Colleg_meneger.AddCourse(values);
            MessageBox.Show("הקורס " + txtName.Text + "נוסף בהצלחה");

            //ניקוי טקסט בוקס
            txtPrase.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDate.Text = string.Empty; 
            txtDase.Text = string.Empty; 
            txtHowers.Text = string.Empty;
        }
    }
}

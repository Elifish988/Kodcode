using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categries = Control_College.GetNams();
            foreach (string category in categries)
            lsbName.Items.Add(category);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            lsbName.Items.Clear();
            string[] parameters = { "@Letter" };
            string[] values = { txtName.Text };
            List<string> categries = Control_College.SelectNams(parameters, values);

            foreach (string category in categries)
            lsbName.Items.Add(category);
        }

        // הוספת שם


        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {

                string[] values = { txtName.Text, txtId.Text };
                Control_College.AddName(values);
                //ניקוי רשימה ישנה
                lsbName.Items.Clear();
                Form2 form2 = new Form2(txtName.Text);
                txtName.Clear();
                txtId.Clear();
                List<string> categries = Control_College.GetNams();
                foreach (string category in categries)
                lsbName.Items.Add(category);
                form2.Show();
            }
            else
            {
                MessageBox.Show("לא הוכנסה תעודת זהות");
            }
        }


        // הוספת איבר מרשימה על ידי דאבל קליק
        private void lsbName_DoubleClick(object sender, EventArgs e)
        {
            if (lsbName.SelectedItem != null)
            {
                txtName.Text = lsbName.SelectedItem.ToString();
                txtId.Text = Control_College.GetId(txtName.Text); 
            }

        }
    }
}

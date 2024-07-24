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
    public partial class btnPay : Form
    {
        public btnPay(string name)
        {
            InitializeComponent();
            lblName.Text = name;
            string sum = Control_College.GetSum(name);
            if (sum == "")
            {
                lblSum.Text = "0";
            }
            else
            {
                lblSum.Text = sum;
            }


        }
        public btnPay()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] values = { lblName.Text, txtSum.Text };
            Control_College.AddPay(values);            
            MessageBox.Show("שולם לחשבונך סך של  " + txtSum.Text + "שקלים");
            txtSum.Text = string.Empty;

        }
    }
}

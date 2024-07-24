using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEnterPassword.Focus();
                e.Handled = true;
            }
        }


        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string safePassword = txtEnterPassword.Text.StartsWith("\r\n") ? txtEnterPassword.Text.Substring(2) : txtEnterPassword.Text;
                string result = EmployeeManager.Login(txtEnterName.Text, safePassword);
                MessageBox.Show(result);
                txtEnterPassword.Text = "";
            }
        }



        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            lblChangePassword tmp = new lblChangePassword();
            tmp.Show();
        }
    }
}

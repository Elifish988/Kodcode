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
    public partial class lblChangePassword : Form
    {
        public lblChangePassword()
        {
            InitializeComponent();
            
        }

        

        private void txtPasswordAuthentication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string result = EmployeeManager.ChangePassword(txtId.Text, txtOldPassword.Text, txtNewPassword.Text, txtPasswordAuthentication.Text);
                MessageBox.Show(result);
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtOldPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNewPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPasswordAuthentication.Focus();
                e.Handled = true;
            }
        }
    }
}

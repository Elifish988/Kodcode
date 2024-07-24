using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empluys
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtCode.Text = (index + 1).ToString();
        }

        public Employ[] employsArr = new Employ[1];
        public int index = 0;

        public void addEmployee()
        {
            if (index < employsArr.Length)
            {
                employsArr[index] = new Employ(int.Parse(txtId.Text), txtFirstName.Text, dtp.Value, txtLestName.Text, GetStatus(), GetGender(), txtCity.Text, txtStreet.Text, txtNumber.Text, txtMobile.Text, txtPhone.Text, index + 1);
                //txtCode.Text = (index + 1).ToString();
                Console.WriteLine(employsArr[index].FullName);



            }
            else
            {
                Employ[] tmp = new Employ[employsArr.Length + 1];
                for (int i = 0; i < employsArr.Length; i++)
                {
                    tmp[i] = employsArr[i];
                }
                tmp[employsArr.Length] = new Employ(int.Parse(txtId.Text), txtFirstName.Text, dtp.Value, txtLestName.Text, GetStatus(), GetGender(), txtCity.Text, txtStreet.Text, txtNumber.Text, txtMobile.Text, txtPhone.Text, index + 1);
                employsArr = tmp;
                //Console.WriteLine(employsArr[index].FullName);

            }
            index++;
            
        }


        public void Clear()
        {
            txtId.Text = null;
            txtLestName.Text = null;
            txtFirstName.Text = null;
            txtPhone.Text = null;
            txtMobile.Text = null;
            txtNumber.Text = null;
            txtStreet.Text = null;
            txtCity.Text = null;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            rdbMarried.Checked = false;
            rdbDivorced.Checked = false;
            rdbSingle.Checked = false;
            rdbWidowed.Checked = false;
            dtp.Value = DateTime.Today;
            txtCode.Text = (index +1).ToString();

        }

        public void NextOrPrev(int i)
        {
            if(i >= 0 && i<= index)
            {
                txtId.Text = employsArr[i].Id.ToString();
                txtLestName.Text = employsArr[i].LastName;
                txtFirstName.Text = employsArr[i].FirstName;
                txtPhone.Text = employsArr[i].Phone.ToString();
                txtMobile.Text = employsArr[i].Mobile.ToString();
                txtNumber.Text = employsArr[i].Number.ToString();
                txtStreet.Text = employsArr[i].Street;
                txtCity.Text = employsArr[i].City;
                dtp.Value = employsArr[i].DateOfBirth;
                txtCode.Text = (i + 1).ToString();
                GivStatus(i);
                GivGender(i);
            }
            else
            {
                MessageBox.Show("סוף רשימה");
            }
        }

        private string GetStatus()
        {
            if (rdbSingle.Checked == true)
            {
                return "Single";
            }
            else if (rdbMarried.Checked == true)
            {
                return "Married";
            }
            else if (rdbDivorced.Checked == true)
            {
                return "Divorced";
            }
            else if (rdbWidowed.Checked == true)
            {
                return "Widowed";
            }
            else { return null; }
            
        }

        private void GivStatus(int i)
        {
            if (employsArr[i].Status == "Single")
            {
                rdbSingle.Checked = true;
            }
            else if (employsArr[i].Status == "Married")
            {
                rdbMarried.Checked = true ;
            }
            else if (employsArr[i].Status == "Divorced")
            {
                rdbDivorced.Checked = true ;
            }
            else if (employsArr[i].Status == "Widowed")
            {
                rdbWidowed.Checked = true;
            }
            

        }

        private string GetGender()
        {
            if(rdbMale.Checked == true)
            {
                return "Male";
            }
            else if(rdbFemale.Checked == true)
            {
                return "female";
            }
            else
            {
                return null;
            }
        }

        private void GivGender(int i)
        {
            if (employsArr[i].IsMale == "Male")
            {
                rdbMale.Checked = true ;
            }
            else if (employsArr[i].IsMale == "female")
            {
                rdbFemale.Checked = true;
            }
            
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee();
            Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            txtAga.Text = (DateTime.Now.Year - dtp.Value.Year).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextOrPrev(int.Parse(txtCode.Text));
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            NextOrPrev(int.Parse(txtCode.Text)-2);
        }
    }
}

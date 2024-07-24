using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rabanut_IDF
{
    public partial class Form1 : Form
    {
        RabnutMeneger rabnutMeneger;
        public Form1()
        {
            InitializeComponent();
            //הכנסת חיבור למשתנה
            XmlDocument rabnutDocument = mainRabanut.Main();
            //הכנסת חיבור למופע של קלאס מנהל
            rabnutMeneger = new RabnutMeneger(rabnutDocument);
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRezult.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string r = rabnutMeneger.Add(cmbWekDay.Text, cmbMunsDay.Text, cmbMuns.Text, cmdYear.Text);
            txtRezult.Visible = true;
            btnResult.Visible = false;
            txtRezult.Text = r;
        }
    }
}

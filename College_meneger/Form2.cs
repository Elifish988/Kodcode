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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //טבלת תלמידים
            string[] values = { lblCutegory.Text, Name };
            //הוספה ללוח
            dtgStudents.DataSource = Cntrol_Colleg_meneger.ShoewStudents();

        }
    }
}

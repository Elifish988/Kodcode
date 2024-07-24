using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_clock
{
    public partial class fmLerning : Form
    {
        public fmLerning()
        {
            InitializeComponent();
            
        }

        private void fmLerning_Load(object sender, EventArgs e)
        {
            string Sql = "select * from Passwords";
           SqlDataReader reader = DBConection.runSQlAllResult(Sql);
            while (reader.Read())
            {
                int Code = reader.GetInt32(0);
                int Full_name = reader.GetInt32(1);
                MessageBox.Show(Code.ToString(), Full_name.ToString());

            }
            
        }
    }
}

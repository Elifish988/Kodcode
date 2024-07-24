using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2Host : Form
    {
        public List<Form2Host> Forms;
        public int Position;
        public Form2Host(List<Form2Host> forms , int position, string categoryName)
        {
            InitializeComponent();
            // הפורום בעצמו
            Forms = forms;
            // מציג מספור של פורם
            Position = position;
            // שם קטגוריה
            lblCutegireHost.Text = categoryName;

        }

        //הכנסת הטבלה  ללוח
        private void Form2Host_Load(object sender, EventArgs e)
        {
            string[] values = { lblCutegireHost.Text };
            //הוספה ללוח
            dtgCutegory.DataSource = Control_Host.ShoeMaels(values);
            
        }

        //מעבר לטופס הבא
        private void btnNext_Click(object sender, EventArgs e)
        {
            // בודק האם זה הפורום האחרון
            if(Position < Forms.Count -1)
            {
                //סגירת הטופס הקודם
                Forms[Position].Visible = false;
                //פתיחת טופס חדש
                Forms[Position + 1].Show();
            }
            else
            {
                
                Forms[Position].Visible = false;
                Forms[0].Show();
                
            }
            
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            if (Position > 0)
            {

                Forms[Position].Visible = false;
                Forms[Position - 1].Show();
            }
            else
            {

                Forms[Position].Visible = false;
                Forms[Forms.Count - 1].Show();

            }
        }
    }
}

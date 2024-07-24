using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //רשימה ראשונית
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categries= Control_Host.GetCategoris();
            foreach(string category in categries)
            lsbCutegory.Items.Add(category);
                       
        }

        // הוספת איבר מרשימה על ידי דאבל קליק
        private void lsbCutegory_DoubleClick(object sender, EventArgs e)
        {
            if (lsbCutegory.SelectedItem != null)
            {
                txtEnterCutegor.Text = lsbCutegory.SelectedItem.ToString();
            }

        }

        

        private void txtEnterCutegor_KeyUp(object sender, KeyEventArgs e)
        {

            lsbCutegory.Items.Clear();
            string[] parameters = { "@Letter" };
            string[] values = {txtEnterCutegor.Text};
            List<string> categries = Control_Host.SelectCategoris(parameters, values);

            foreach (string category in categries)
                lsbCutegory.Items.Add(category);
        }

        //הוספת קטגוריה
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] values = {txtEnterCutegor.Text};
            Control_Host.AddCategory(values);
            //ניקוי רשימה ישנה
            lsbCutegory.Items.Clear();
            // הצגת רשימה חדשה כולל התוספת החדשה
            //קבלת רשימת קטגוריות
            List<string> categries = Control_Host.GetCategoris();
            //הכנסה לליסט בוקס
            foreach (string category in categries)
            lsbCutegory.Items.Add(category);
            //ניקוי טקסט בוקס
            txtEnterCutegor.Text = null;

        }

        //העברה לחלון הצגה
        private void btnShouOrder_Click(object sender, EventArgs e)
        {
            //יצירת טבלה של פורומים
            // יצירה של רשימת פורמים
            List<Form2Host> forms = new List<Form2Host>();
            //יצירה של רשימת קטגוריות
            List<string> categories = Control_Host.GetCategoris();
            //הכנסת פורומים לפי קטגוריות
            for (int i = 0; i < categories.Count; i++)
            {
                forms.Add(new Form2Host(forms, i, categories[i]));
            }
            // בודק האם יש ערך בשורת קטגוריה ופותח על פיה
            int z = 0;
            if (txtEnterCutegor.Text != "")
            {
                foreach (var item in categories)
                {
                    if (item == txtEnterCutegor.Text)
                    {
                        break;
                    }
                    z++;
                }
            }                
            forms[z].Show();


        }

        private void btnDelit_Click(object sender, EventArgs e)
        {
            string[] values = { txtEnterCutegor.Text };
            Control_Host.DeleteCategoris(values);
            //ניקוי רשימה ישנה
            lsbCutegory.Items.Clear();
            // הצגת רשימה חדשה כולל התוספת החדשה
            //קבלת רשימת קטגוריות
            List<string> categries = Control_Host.GetCategoris();
            //הכנסה לליסט בוקס
            foreach (string category in categries)
                lsbCutegory.Items.Add(category);
            //ניקוי טקסט בוקס
            txtEnterCutegor.Text = null;


        }

        
    }
}

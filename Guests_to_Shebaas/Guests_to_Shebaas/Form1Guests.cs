using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guests_to_Shebaas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // רשימה ראשונית
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categries = Control_Guests.GetNams();
            foreach (string category in categries)
            lsbName.Items.Add(category);

        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            lsbName.Items.Clear();
            string[] parameters = { "@Letter" };
            string[] values = { txtName.Text };
            List<string> categries = Control_Guests.SelectNams(parameters, values);

            foreach (string category in categries)
            lsbName.Items.Add(category);
        }
        // הוספת שם
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string[] values = { txtName.Text };
            Control_Guests.AddName(values);
            //ניקוי רשימה ישנה
            lsbName.Items.Clear();
            // הצגת רשימה חדשה כולל התוספת החדשה
            //קבלת רשימת שמות
            List<string> categries = Control_Guests.GetNams();
            //הכנסה לליסט בוקס
            foreach (string category in categries)
             lsbName.Items.Add(category);
            //ניקוי טקסט בוקס
            //txtName.Text = null;
            // מעבר לדף הבא
            //יצירת טבלה של פורומים
            // יצירה של רשימת פורמים
            List<Form2> forms = new List<Form2>();
            //יצירה של רשימת קטגוריות
            List<string> categories = Control_Guests.GetCategoris();
            //הכנסת פורומים לפי קטגוריות
            for (int i = 0; i < categories.Count; i++)
            {
                forms.Add(new Form2(forms, i, categories[i], txtName.Text));
            } 
            // v
            
            forms[0].Show();
        }

        private void btnDelit_Click(object sender, EventArgs e)
        {
            string[] values = { txtName.Text };
            Control_Guests.DeleteName(values);
            //ניקוי רשימה ישנה
            lsbName.Items.Clear();
            // הצגת רשימה חדשה כולל התוספת החדשה
            //קבלת רשימת קטגוריות
            List<string> categries = Control_Guests.GetNams();
            //הכנסה לליסט בוקס
            foreach (string category in categries)
            lsbName.Items.Add(category);
            //ניקוי טקסט בוקס
            txtName.Text = null;
        }

        private void lsbName_DoubleClick(object sender, EventArgs e)
        {
            if (lsbName.SelectedItem != null)
            {
                txtName.Text = lsbName.SelectedItem.ToString();
            }
        }

        
    }
}

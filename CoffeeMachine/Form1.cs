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
using System.Xml.Linq;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        //יצירת משתנה מסוג הקלאס שיחזיק את החיבור
        private DrinkMeneger drinkMeneger;
        public Form1()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            //הכנסת חיבור למשתנה
            XmlDocument  drinkDocument = MainProject.Main();
            //הכנסת חיבור למופע של קלאס מנהל
            drinkMeneger = new DrinkMeneger(drinkDocument);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            double price = double.Parse(txtPrice.Text);
            price += 0.5;
            txtPrice.Text = price.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtPrice.Text) > 0)
            {
                double price = double.Parse(txtPrice.Text);
                price -= 0.5;
                txtPrice.Text = price.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // הכנסת ערכים לטבלה
            //   קריאה לפונקציה שיוצרת מערך דו ממדי
            List<List<string>> drinkList = drinkMeneger.GetDrinksData();
            // הכנסה לגרייטרביו
            foreach(List<string> drink in drinkList)
            {
                dgvMenu.Rows.Add(drink.ToArray());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>() { txtName.Text, 
                cmbCacoa.Text, 
                cmbMilk.Text, 
                cmbCoffee.Text, 
                cmbShoger.Text, 
                txtPrice.Text };
            drinkMeneger.AddDrink(drinks);
            // הצגה מחודשת
            dgvMenu.Rows.Clear();           
            List<List<string>> drinkList = drinkMeneger.GetDrinksData();
            foreach (List<string> drink in drinkList)
            {
                dgvMenu.Rows.Add(drink.ToArray());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            drinkMeneger.Save();
        }

      

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
                // קבלת הערך של התא שנבחר
                string cellValue = dgvMenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // הצגת הערך ב-TextBox
                string nameValue = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
                string cacoaValue = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                string milkValue = dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
                string coffeeValue = dgvMenu.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sugerValue = dgvMenu.Rows[e.RowIndex].Cells[4].Value.ToString();
                string priceValue = dgvMenu.Rows[e.RowIndex].Cells[5].Value.ToString();

                // הצגת הערכים ב-TextBox
                txtName.Text = nameValue;
                cmbCacoa.Text = cacoaValue;
                cmbMilk.Text = milkValue;
                cmbCoffee.Text = coffeeValue;
                cmbShoger.Text = sugerValue;
                txtPrice.Text = priceValue;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>() 
            { 
                txtName.Text, 
                cmbCacoa.Text, 
                cmbMilk.Text, 
                cmbCoffee.Text, 
                cmbShoger.Text, 
                txtPrice.Text };
            drinkMeneger.UpdateDrink(drinks);
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            // הצגה מחודשת
            dgvMenu.Rows.Clear();
            List<List<string>> drinkList = drinkMeneger.GetDrinksData();
            foreach (List<string> drink in drinkList)
            {
                dgvMenu.Rows.Add(drink.ToArray());
            }


        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            XmlNode drinks = drinkMeneger.GetDrinkByName(txtName.Text);
            if (drinks == null) return;
            DialogResult showDialog = MessageBox.Show("האם ברצונך לעדכן את המשקה? ", "עדכן משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            XmlNodeList drinkChild = drinks.ChildNodes;
            if (showDialog == DialogResult.Yes)
            {
                cmbCacoa.Text = drinkChild[1].InnerText;
                cmbMilk.Text = drinkChild[2].InnerText;
                cmbCoffee.Text = drinkChild[3].InnerText;
                cmbShoger.Text = drinkChild[4].InnerText;
                txtPrice.Text = drinkChild[5].InnerText;
            }
            btnUpdate.Visible = true;
            btnAdd.Visible = false;


        }

        private void btnDelede_Click(object sender, EventArgs e)
        {
            XmlNode drinks = drinkMeneger.GetDrinkByName(txtName.Text);
            if (drinks == null) return;
            DialogResult showDialog = MessageBox.Show("האם ברצונך למחוק את המשקה? ", "מחיקת משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (showDialog == DialogResult.Yes)
            {
                drinkMeneger.delDrink(txtName.Text);
            }
            dgvMenu.Rows.Clear();
            List<List<string>> drinkList = drinkMeneger.GetDrinksData();
            foreach (List<string> drink in drinkList)
            {
                dgvMenu.Rows.Add(drink.ToArray());
            }
        }
    }
}

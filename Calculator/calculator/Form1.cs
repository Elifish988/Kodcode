namespace calculator
{
    public partial class Form1 : Form
    {

        
        private TextBox selectedeTexstBox;
        

        public Form1()
        {
            InitializeComponent();
            selectedeTexstBox = txtNumber1;
        }



        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1. Converst 'string' to int
            float num1 = float.Parse(txtNumber1.Text);
            float num2 = float.Parse(txtNumber2.Text);

            // 2. Validate inputs


            //3. Perform calculation
            if (cmbOperators.Text == "+")
            {
                lblResult.Text = (num1 + num2).ToString();
            }

            else if (cmbOperators.Text == "-")
            {
                lblResult.Text = (num1 - num2).ToString();
            }

            else if (cmbOperators.Text == "x")
            {
                lblResult.Text = (num1 * num2).ToString();
            }

            else if (cmbOperators.Text == "/")
            {// - Check that txtNumber2 is not 0
                if (num2 == 0)
                {
                    lblResult.Text = "Error";
                    return;
                }
                lblResult.Text = (num1 / num2).ToString();
            }


        }






        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = ""; 
            cmbOperators.Text = ""; 
            lblResult.Text = "00";
            selectedeTexstBox = txtNumber1;
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            selectedeTexstBox = sender as TextBox;
        }

  

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            selectedeTexstBox = sender as TextBox;
        }

        private void btn_Click_Global(object sender, EventArgs e)
        {
            selectedeTexstBox.Text += ((Button)sender).Text;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            cmbOperators.Text = "+";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            cmbOperators.Text = "+";
            selectedeTexstBox = txtNumber2;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            cmbOperators.Text = "-";
            selectedeTexstBox = txtNumber2;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            cmbOperators.Text = "x";
            selectedeTexstBox = txtNumber2;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cmbOperators.Text = "/";
            selectedeTexstBox = txtNumber2;
        }



    }
}

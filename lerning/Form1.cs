using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lerning
{
    public partial class btnArrey : Form
    {
        


        //2. define an array with values
        private string[] names = new string[1];
        int index = 0;


        public btnArrey()
        {
            InitializeComponent();
        }

        public Dog[] dogArray = new Dog[10];

 

        private void button1_Click(object sender, EventArgs e)
        {
            //2 options to initialise an array
            //1. define the length of the array
            int[] ages = { 23, 45 };

            

            Console.WriteLine(ages[0]);
            Console.WriteLine(ages[1]);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //loop
            //1. "for"
            // - (1)initialization
            // - (2) Condition
            // - (3) Chage Values
            for (int i = 0; i < names.Length; i++)
            {
                //Console.WriteLine("השם שלי הוא " + names[i]);
                Console.WriteLine($"name {i}:  {names[i]}");
            }


            //2. "foreach
            Console.WriteLine("--foreach");
            label2.Text = "";
            foreach (string oneName in names)
            {
                
                label2.Text += oneName + " ";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == null)
                {
                    names[i] = textBox1.Text;
                    break;
                }
            }
        }

        private Student[] studendsArray = new Student[1];
        private int lenArray = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (lenArray < studendsArray.Length)
            {
                //studendsArray[lenArray+1] = 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // תרגיל
            //להגדיר שלוש משתנים
            //int, float , string
            int x = 5;
            float y = 5.5f;
            string z = "I'm handsome on space";

            Console.WriteLine((x + y + z).GetType());
            Console.WriteLine(z + x + y);
            Console.WriteLine((x).GetType());
            Console.WriteLine((y + x).GetType());
            Console.WriteLine();
            


        }

        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            /*rexi = new Dog(float.Parse(txtHeight.Text), float.Parse(txtWeight.Text), txtFood.Text, txtName1.Text);
            lblDog.Text = rexi.height +" " + rexi.Weight + " " + rexi.Name + " " + rexi.Food;
            rexi.Eat();
            rexi.Run ();*/
            if (index < dogArray.Length)
            {
                dogArray[index] = new Dog(float.Parse(txtHeight.Text), float.Parse(txtWeight.Text), txtFood.Text, txtName1.Text);
                lblDog.Text = dogArray[index].height + " " + dogArray[index].Weight + " " + dogArray[index].Name + " " + dogArray[index].Food;
            }
            else
            {
                Dog[] tmp = new Dog[dogArray.Length + 1];
                for (int i = 0; i == dogArray.Length;i++)
                {
                    tmp[i] = dogArray[i];
                }
                tmp[dogArray.Length] = new Dog(float.Parse(txtHeight.Text), float.Parse(txtWeight.Text), txtFood.Text, txtName1.Text);
                dogArray = tmp;
                lblDog.Text = dogArray[index].height + " " + dogArray[index].Weight + " " + dogArray[index].Name + " " + dogArray[index].Food;
            }
            index++;


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            foreach(Dog dog in dogArray)
            {
                if (dog != null)
                {
                    Console.WriteLine(dog.height + dog.Weight + dog.Food + dog.Name);
                }
                
            }
        }


        
        private void btnAge_Click(object sender, EventArgs e)
        {
            person person = new person();
            person.Age = int.Parse(txtAge.Text);

        }

        int[] arr = { 1, 6, 4, 1, 3 };
        public void array(Array arr)
        {
            Array.Sort(arr);
        }
        public void button4_Click_1(object sender, EventArgs e)
        {
            
            array(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine( Array.Find(arr, ari => ari % 2 == 0));
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }


        }

        
    }
}

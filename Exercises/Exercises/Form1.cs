using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnCar_Click(object sender, EventArgs e)
        {
            Car a = new Car(Color.Red);
            switch (txtCar.Text)
            {
                case "red":
                    a = new Car(Color.Red);
                    break;
                case "Green":
                    a = new Car(Color.Red);
                    break;
                case "Blue":
                    a = new Car(Color.Red);
                    break;

            }

            
            a.DisplayColor();
        }

        //Student[] students = new Student[20];
        List<Student> students = new List<Student>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            GradeLevel grade = new GradeLevel();
            int[] scores = new int[4];


            switch (txtGrade.Text)
            {
                case "Freshman":
                    grade = GradeLevel.Freshman;
                    break;

                case "Sophomore":
                    grade = GradeLevel.Sophomore;
                    break;

                case "Junior":
                    grade = GradeLevel.Junior;
                    break;

                case "Senior":
                    grade = GradeLevel.Senior;
                    break;

               
            }

            scores[0] = int.Parse(txtScores.Text);
            scores[0] = int.Parse(txtScores1.Text);
            scores[0] = int.Parse(txtScores2.Text);
            scores[0] = int.Parse(txtScores3.Text);



            students.Add(new Student(Name, grade, scores));
            foreach(Student i in students)
            {
                i.DisplayInfo();
            }
        }
    }
}

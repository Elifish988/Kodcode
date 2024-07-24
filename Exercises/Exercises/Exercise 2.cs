using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{


    public enum GradeLevel
    {
        Freshman, 
        Sophomore, 
        Junior, 
        Senior

    }
    internal class Student
    {
        private string _name;

        private GradeLevel _grade;

        private int[] _scores;

        public string name { get { return _grade; } set { _name = value; } }

        public GradeLevel grade { get { return _grade; } set { _grade = value; } }

        public int[] scores { get { return _scores; } set { _scores = value; } }




        public Student(string name,  GradeLevel grade, int[] scores)
        {
            _name = name;
            _grade = grade;
            _scores = scores;
        }

        public void DisplayInfo()
        {
            double averageScore = _scores.Average();
            Console.WriteLine("nime " + _scores);
            Console.WriteLine("grade " + _grade)
            Console.WriteLine("scores" + averageScore.ToString());
        }


    }

    Student[] students = new Student[10];
}

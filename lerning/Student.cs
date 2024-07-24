using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning
{
    internal class Student
    {
        public Student() { }
        public Student(int id, string firstName, string lastNaime)
        {
            Id = id;
            FirstName = firstName;
            LastNaime = lastNaime;

        }

        public int Id;
        public string FirstName;
        public string LastNaime;

    }
}

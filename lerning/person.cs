using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning
{
    internal class person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if(value >= 0 && value <= 120)
                {
                    _age = value;
                    Console.WriteLine(_age);
                }
                else
                {
                    Console.WriteLine("גיל לא תקין");
                }
            }
        }


        
    }
}

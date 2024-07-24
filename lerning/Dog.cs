using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lerning
{
    public class Dog
    {
        public Dog() { }

        public float height;
        public float Weight;
        public string Food;
        public string Name;

        public Dog(float height, float weight, string food, string name)
        {
            this.height = height;
            Weight = weight;
            Food = food;
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine(Name + " us runing");
        }
        
        public void Play()
        {
            Console.WriteLine(Name + " is playing");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating");
        }

        


    }
}

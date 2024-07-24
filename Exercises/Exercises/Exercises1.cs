using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public enum Color
    {
        Red,
        Green,
        Blue

    }
    
    public class Car
    {
        private Color _carColor;



        public Car(Color carColor)
        {
            _carColor = carColor;
        }
         public void DisplayColor()
        {
            Console.WriteLine(_carColor);
        }




    }

}

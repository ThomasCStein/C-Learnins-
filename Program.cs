using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int num3 = 7;

            Console.WriteLine((num1+num2)*num3);

            //Prompting the user to enter their number.
            Console.Write("Please enter the temperature you wish to be converted:" );
            //assigning user input to a variable
            double Celsius = Convert.ToInt32(Console.ReadLine());
            //Doing the math conversion
            double fahrenheit = Celsius* 1.8+32;
            //Output of the conversion
            Console.WriteLine( "{0} Celsius is {1} Fahrenheit.", Celsius, fahrenheit );

        }
    }
}

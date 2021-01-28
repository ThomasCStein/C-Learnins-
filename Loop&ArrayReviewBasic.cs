using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopReview
{
    class Program
    {
        static void Main(string[] args)
        {

            //little bit of loop practice, just picked two.
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(i);
            }
            int j = 15;
            Console.WriteLine("counting down from 15-1");
            do
            {

                Console.WriteLine(j);
                j--;

            } while (j != 1);

            //initiate an array
            string[] colors = new string[3];
            //get user input for position 0
            Console.WriteLine("Type a color to enter");
            colors[0] = Console.ReadLine();
            //get user input for position 1
            Console.WriteLine("Type a new color to enter");
            colors[1] = Console.ReadLine();
            //get user input for position 2
            Console.WriteLine("Type a new color to enter");
            colors[2] = Console.ReadLine();

            //attempt to make a loop of asking the user for inputs, incrementing array index each time.
            //string[] loopColors = new string[3];

            //output current array
            Console.Write("\tYour colors are: ");
            foreach (string C in colors)
            {
                Console.Write(C + " ");
            }
            //attempting to reverse the order easily.
            Array.Reverse(colors);
            Console.WriteLine("\n");

            Console.Write("\tYour colors, backwards, are: ");
            //output of reverse order colors
            foreach (string C in colors)
            {
                Console.Write(C + " ");
            }
            Console.ReadLine();



            //designate days of the week
            //seperate by weekdays, weekends

            string[] weekDays = new string[] { "Mon", "Tue", "Wed", "Thur", "Fri" };
            string[] weekEnd = new string[] { "Sat", "Sun" };

            //ask for a day of the week from user
            Console.WriteLine("Please Enter a day of the week in 3 letter format");
            string userInput = Console.ReadLine();
            //if statemnt for weekdays
            if (weekDays.Contains(userInput))
            {
                Console.WriteLine("Working for the weekend");
            }

            //else statement for weekends
            else
            {
                Console.WriteLine("Weekends are too short");
            }


        }
    }
}

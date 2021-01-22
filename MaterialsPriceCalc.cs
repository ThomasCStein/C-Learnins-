using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting console window title.
            Console.Title = "Material and Costs Calculator";

            /*Compute the following: 
             * Length of wood needed: Ask for Height and Width...then compute total length.
             * Area of glass needed is computed from first values user gives
             * Cost of the wood based off constant price
             * Cost of the glass based off constant price
             * Total cost of all materials
            */

            //First set constants for cost of needed materials
            double woodCostPerFt = 4.50;
            double glassCostPerSqFt = 3.45;

            Double windowHeight=0;
            Double windowWidth=0;

            char userInput = 'N';
            //inserting loop to make sure they have the numbers they wanted.
            while (userInput != 'Y')
            {
                //Next ask for user to fill in wood perimeter variables
                Console.Write("Please enter desired height of window frame in feet: ");
                windowHeight = double.Parse(Console.ReadLine());
                Console.Write("Please enter desired width of window frame in feet: ");
                windowWidth = double.Parse(Console.ReadLine());
                Console.WriteLine($"Window height is: {windowHeight}' and window width is: {windowWidth}'\n " +
                    $"\n Hit y then enter if correct" +
                    $"\n Hit any key then enter to restart.");

                //In future iterations will practice input validation. For now, As long as they hit the correct key, it doesnt matter if its upper or lower case.
                //No error handling yet, need to review that. 
                userInput = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            }
      
            //Compute cost values for each material and assign into seperate variables
            double totalWoodLength = (windowHeight * 2) + (windowWidth * 2);
            double totalWoodCost = totalWoodLength * woodCostPerFt;

            //Output showing wood costs and material.
            Console.WriteLine("The total amount of wood required is: {0} feet. " +
                "The cost of this wood is ${1:0.00}",totalWoodLength, totalWoodCost);

            //Output showing glass area and cost
            double totalGlassArea = windowWidth * windowHeight;
            double totalGlassCost = totalGlassArea * glassCostPerSqFt;
            Console.WriteLine($"Glass that is {windowHeight}' tall by {windowWidth}' wide is {totalGlassArea} Sqft and costs ${totalGlassCost:0.00}. ");

            //Add individual cost ariable together for total
            double totalCost = totalGlassCost + totalWoodCost;
            Console.WriteLine($"\nTOTAL PROJECT COST: ${totalCost:0.00}");
            Console.Read();
        }
    }
}

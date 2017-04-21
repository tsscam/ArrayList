using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListBatting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("\nWelcome To The Batting Average Calculator!");
            Console.WriteLine();


            // Declare Variables
            int size;
            double SlugPerc;
            double BatAve;


            // Continue to Add Another Batter
            while (true)
            {

                // User Input for Array Length
                Console.WriteLine("------------------------------------------------");
                Console.Write("Please Enter the Number of Times At-Bat:  --->   ");

                // Call GetValidInt Method
                size = GetValidInt();
                Console.WriteLine("\n");

                int[] AtBat = new int[size];



                // Key/Legend
                Console.WriteLine("******************  Legend / Key ***********************");
                Console.WriteLine("0 = Out  1 = Single  2 = Double  3 = Triple  4 = Homerun");
                Console.WriteLine("\n");



                // Getting User Input for AtBat
                for (int i = 0; i <= size - 1; i++)
                {

                    Console.Write($"Result of At-Bats {i}:  --->   ");

                    // Call Method GetRange
                    AtBat[i] = GetRange(0, 4);
                    Console.WriteLine();

                }



                // Get Average
                double sum = 0.0;
                int count = 0;
                for (int i = 0; i <= size - 1; i++)
                {
                    sum = sum + AtBat[i];
                    if (AtBat[i] != 0)
                    {
                        count++;
                    }
                }



                // Get Slugging Perentage
                SlugPerc = ((double)sum / size);
                Console.WriteLine();

                // Convert Slugging Percentage to a string to get formatted with 3 decimal places
                Console.WriteLine("The Slugging Percentage is: " + SlugPerc.ToString("#,#.000"));



                //Get Batting Average
                BatAve = ((double)count / size);

                // Convert Batting Average to a string to get formatted with 3 decimal places
                Console.WriteLine("The Batting Average is: " + BatAve.ToString("#,0.000"));



                // Call Continue Method
                if (!GetContinue())
                {
                    return;
                }
            }
        }





        // Method to Validate Input
        public static int GetValidInt()
        {

            int number;

            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                // Number Validation with Colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Number:  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;

            }
            return number;
        }




        // Method to Get Input and Validate That Number is Between 0 and 4.
        public static int GetRange(int min, int max)
        {

            // Get a Valid Int from Previous Method
            int number = GetValidInt();

            while (number < 0 || number > 4)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("You MUST Enter a Number That is in Between 0 and 4  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                number = GetValidInt();
            }
            return number;

        }



        // Method to Continue
        public static bool GetContinue()
        {
            string Continue;
            //Continue Loop
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Another Batter?  (y/n)");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                Console.WriteLine("Please Enter Y or N");
                Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
            }
        }
    }
}

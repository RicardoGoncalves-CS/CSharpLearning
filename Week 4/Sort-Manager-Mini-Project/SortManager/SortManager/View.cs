using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager
{
    public class View
    {



        public static int AskArraySize()
        {
            Console.WriteLine("Choose your array length (up to 1000): ");



            int number = 0;


            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out number))
            {

                if (number <= 1000 && number > 0)
                {
                    Console.WriteLine("The number you entered is: " + number);
                    ;
                }
                else
                {
                    Console.WriteLine("Number should be less than or equal to 1000 ");
                    AskArraySize();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Try again!");
                AskArraySize();
            }



            return number;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Here is your array:");
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
        }

        public static string AskSortAlgor()
        {
            Console.WriteLine("Which Sorting Algorithm would you like to use?");
            Console.WriteLine("Please enter one of the choices");
            Console.WriteLine("A: Bubble Sort B: Merge Sort C: Insertion Sort D: .NET Sort E:");


            string userInput = Console.ReadLine().ToLower();
            string choice = "";


            switch (userInput)
            {
                case "a":
                    Console.WriteLine("You chose Bubble Sort");
                    choice = "a";

                    break;
                case "b":
                    Console.WriteLine("You chose Merge Sort");
                    choice = "b";

                    break;
                case "c":
                    Console.WriteLine("You chose Insertion Sort");
                    choice = "c";

                    break;
                case "d":
                    Console.WriteLine("You chose .NET Sort");
                    choice = "d";

                    break;
                default:
                    Console.WriteLine("Wrong input please try again");
                    AskSortAlgor();
                    break;

            }
            return choice;




        }


        public static void PrintTick(long tick)
        {
            Console.WriteLine($"The runtime of this algor is {tick} ticks");
        }

        public static void PrintMS(long ms)
        {
            Console.WriteLine($"The runtime of this algor is {ms} MS");
        }

        public static bool Reverse()
        {
            Console.WriteLine("Do you want your array sorted from Largest to Smallest?");
            Console.WriteLine("Y/n");
            

            string userInput = Console.ReadLine().ToLower();


            switch (userInput)
            {
                case "y":
                    Console.WriteLine("Largest to Smallest");
                    return true;
                    

                case "n":
                    Console.WriteLine("Smallest to Largest");
                    return false;
                    

                default:
                    Console.WriteLine("Wrong input please try again");
                    Reverse();
                    break;

            }

            return true;


        }
    }
}

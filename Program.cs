using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //creating the strings and ints for controlling the while statements ans and exit (roll again and restart), the counter (how many times you rolled) and the result (of the dice roll)
            string ans = "Y";
            string exit = "Y";
            int counter = 0;
            int result;


            //Create List
            List<int> numbers = new List<int>();

            //Start of UI
            Console.WriteLine("Welcome to The Dice Roller!");
            Console.WriteLine();
            Console.WriteLine("Press Any Key to start!");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------");

            //While Loop for exiting
            while (exit == "Y")
            {

                //While loop for rolling dice
                while (ans == "Y")
                {

                    //Creates Dice roll with a random number between 1-6 and adds 1 to the counter and stores the number in the list
                    Random rnd = new Random();
                    result = rnd.Next(1, 7);
                    counter++;
                    numbers.Add(result);

                    //Displays result and asks user if they want to roll again
                    Console.WriteLine("Your Number is " + result);
                    Console.WriteLine("Do you want to roll again? Y/N");
                    ans = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    //End While Loop (ans)
                }

                //End UI displays total amount of rolls, lists the rolls, calculates and displays the total sum and average
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("You Rolled " + counter + " Times!");
                Console.WriteLine("And these are all of your rolls!");
                numbers.ForEach(Console.WriteLine);
                Console.WriteLine();

                double average1 = numbers.Average();
                double average2 = Math.Round(average1);
                double total = numbers.Sum();

                Console.WriteLine("The total of the dice rolls is " + total);
                Console.WriteLine("And the average of the dice rolls is " + average2);
                Console.WriteLine();


                //Asks User if they want to restart without closing and reopening
                Console.WriteLine("Do you want to restart your rolls? Y/N");
                exit = Console.ReadLine().ToUpper();
                Console.WriteLine();
                counter = 0;
                ans = "Y";
                numbers.Clear();
                Console.WriteLine("-------------------------------------------");


                //End While Loop (Exit)
            }

            //Exits
            Console.Write("Press any key to exit . . . ");
            Console.ReadKey(true);
        }

    }
}
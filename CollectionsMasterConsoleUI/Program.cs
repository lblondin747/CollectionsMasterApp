using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var intArray = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(intArray);




            //Print the first number of the array
            Console.WriteLine($"Index 0: {intArray[0]}");
            //Print the last number of the array            
            Console.WriteLine($"Index 49: {intArray[49]}");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            ReverseArray(intArray);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(intArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
                
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(intArray);

            Console.WriteLine("-------------------");
            NumberPrinter(intArray);
            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var intList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(intList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);

            //Print the new capacity
            Console.WriteLine(intList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(intList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(intList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable

            var ListToArray = intList.ToArray();
            //Clear the list

            intList.Clear();
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (var a = 0; a <= 49; a ++)
            {
                if (numbers[a] % 3 == 0)
                {
                    numbers[a] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {

            for (int i = 49; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    Console.WriteLine($"{numberList[i]}");
                    numberList.RemoveAt(i);
                }

            }

            

        }

        private static void NumberChecker(List<int> numberList)
        {
            bool success = false;
            bool inArray = false;
            int a = 0;
            success = Int32.TryParse(Console.ReadLine(), out a);
            while (!success)
            {
                
                Console.WriteLine("Enter an integer");
                success = Int32.TryParse(Console.ReadLine(), out a);
            }
            foreach (var num in numberList)
            {
                if (num == a)
                {
                    inArray = true;
                }

            }
            if (inArray)
            {
                Console.WriteLine($"{a} is in the list.");
            }
            else
            {
                Console.WriteLine($"{a} is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int a = 0; a <= 49; a++)
            {
                
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int a = 0; a <= 49; a++)
            {
                
                numbers[a] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            var intArrayR = new int[50];

            for (int a = 0; a <= 49; a++)
            {
                intArrayR[a] = array[49 - a];
            }
            for (int a = 0; a <= 49; a++)
            {
                array[a] = intArrayR[a];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

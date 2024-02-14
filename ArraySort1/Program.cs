using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ArraySort1
{
    /// <summary>
    /// John Coulter
    /// 23/01/2024
    /// This program generates an array of integers (length input by user)<br>
    ///</br>Displays: Unsorted Array, Sorted Ascending Array, Sorted Descending Array
    /// </summary>
    internal class Program
    {

        Stopwatch stopwatch = new Stopwatch();
        private static readonly Random rnd = new Random();// random numbers

        static void Main(string[] args)
        {
            int arrayLength;
            
            arrayLength = UserInput();
            int[] numberArray = new int[arrayLength];
            GenerateArray(ref numberArray, arrayLength);

            Console.WriteLine("\nUNSORTED ARRAY");
            DisplayArray(numberArray);

            SortAscending(numberArray);
            Console.WriteLine("\nSORTED ARRAY: ASCENDING");
            DisplayArray(numberArray);   
            
            SortDescending(numberArray);
            Console.WriteLine("\nSORTED ARRAY: DESCENDING");
            DisplayArray(numberArray);

        }

        /// <summary>
        /// This method gets input from user to determine array size
        /// </summary>
        /// <returns></returns>
        static int UserInput()
        {
            
            Console.Write("How Many Elements would you like in the Array?: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            
            return arrayLength;
        }

        /// <summary>
        /// This method populates the array with random numbers
        /// </summary>
        /// <param name="numberArray"></param>
        /// <param name="arrayLength"></param>
        static void GenerateArray(ref int[] numberArray, int arrayLength)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = rnd.Next(1,250);//generate random number between 1 + 250, assigns number to array
            }
            
            
        }

        /// <summary>
        /// This method sorts the array in Ascending order
        /// </summary>
        /// <param name="numberArray"></param>
        static void SortAscending(int[]numberArray)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numberArray.Length - 1; i++)               
            {
                for (int j = 0; j < numberArray.Length - i - 1; j++)                                                               
                {
                    if (numberArray[j] > numberArray[j + 1]) // greater than to sort descending order
                    {
                        int temp = numberArray[j]; //temp variable to hold number being replaced                        
                        numberArray[j] = numberArray[j + 1]; //swapping lower value                       
                        numberArray[j + 1] = temp; //replacing swapped value with temp value

                    }
                }
            }
            stopwatch.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSorted Array in {stopwatch.Elapsed.TotalSeconds:0.000000} seconds\n");
            Console.ResetColor();
            Console.ReadKey();
        }

        /// <summary>
        /// This method sorts the array in descending order
        /// </summary>
        /// <param name="numberArray"></param>
        static void SortDescending(int[] numberArray)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numberArray.Length - 1; i++)               
            {
                for (int j = 0; j < numberArray.Length - i - 1; j++)                                                               
                {
                    if (numberArray[j] < numberArray[j + 1]) // less than to sort descending order
                    {
                        int temp = numberArray[j]; //temp variable to hold number being replaced                        
                        numberArray[j] = numberArray[j + 1]; //swapping lower value                       
                        numberArray[j + 1] = temp; //replacing swapped value with temp value

                    }
                }
            }
            stopwatch.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSorted Array in {stopwatch.Elapsed.TotalSeconds:0.000000} seconds\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    
        /// <summary>
        /// This method displays the array
        /// </summary>
        /// <param name="numberArray"></param>
        static void DisplayArray(int[] numberArray)
        {
            int count = 0;
            foreach (int number in numberArray)
            {
                Console.WriteLine($"Index[{count}]: {number}");
                count++;
            }
        }
    }
}

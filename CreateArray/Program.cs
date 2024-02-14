using System.Linq.Expressions;

namespace CreateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Array Population");
            Console.WriteLine("----------------");

            int arrayLength = 0;
            Console.Write("\nHow Many Elements would you like in the Array?: ");
            arrayLength = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[arrayLength];
            Console.Clear();


            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter value for Array position {i}: ");
                array[i] = Console.ReadLine()!;
                Console.Clear();
            }

            Console.WriteLine("Here is your final Array:\n");

            int count = 0;
            foreach (string element in array)
            {
                Console.WriteLine($"position[{count}]: {element}");
                count++;
            }
            Console.WriteLine($"\nThere are {count} values stored in the Array");
        }
    }
}



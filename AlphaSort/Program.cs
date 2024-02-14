namespace AlphaSort
{
    /// <summary>
    /// John Coulter<br></br>
    /// 24/01/2024
    /// This is program is to demonstrate sorting a string array in alphabetical order
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            bool sorted = false;

            string[] array = new string[arraySize];

            CreateArray(ref array, arraySize);

            DisplayArray(array, arraySize, sorted);

            sorted = SortArray(ref array, arraySize);//value of sorted is returned

            DisplayArray(array, arraySize, sorted);
        }

        /// <summary>
        /// This Method gets user to enter 5 words and stores them in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        static void CreateArray(ref string[] array, int arraySize)
        {
            Console.WriteLine($"You need to enter {arraySize} animals to continue...\n");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter Animal {i + 1}: ");
                array[i] = Console.ReadLine()!;
            }
        }

        /// <summary>
        /// This Method sorts the array using a bubble sort and String.Compare function
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        static bool SortArray(ref string[] array, int arraySize)
        {
            
            
            for(int i = 0; i < arraySize - 1; i++)
            {
                for(int j = 0;j < arraySize -i -1; j++)
                {
                    if (String.Compare(array[j], array[j + 1]) > 0)// like an int bubble sort, the value of array[j] and array[j+1] are compared
                                                                    //> 0 here, means that if array[j] is later in the alphabet than array[j+1] 1 is returned. if not 0 is returned
                                                                    //To switch to descending order change to < 1
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return true;
            
        }

        /// <summary>
        /// This method displays the array. The value of var sorted, decides what text to use (Sorted/Unsorted)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        /// <param name="sorted"></param>
        static void DisplayArray(string[] array, int arraySize, bool sorted)
        {
            
            if (sorted == false)
            {
                Console.WriteLine("\nUNSORTED ARRAY");
                foreach (string s in array)
                {
                    
                    Console.WriteLine($"{s}");
                }
            }

            if (sorted == true)
            {
                Console.WriteLine("\nSORTED ARRAY");
                foreach (string s in array)
                {
                    
                    Console.WriteLine($"{s}");
                }
            }
        }
            
    }
}

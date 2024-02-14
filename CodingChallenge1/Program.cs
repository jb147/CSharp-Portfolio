namespace CodingChallenge1
{
    //John Coulter
    //25/01/2024
    //v1

    /// <summary>
    /// This Class is a Coding Challenge that must meet the following criteria<br></br>
    /// Inserting, Removing, and choosing random numbers<br></br>
    /// a)Inserting a value (no duplicates)<br></br>
    /// b)Removing a value<br></br>
    /// c)Get at random a value that is already inserted<br></br>
    /// FUTURE IMPROVEMENT: Make it a menu driven program
    /// </summary>
    internal class Program
    {
        static readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            int arraySize = 0;
            bool cont = true;
            
            int[] array = new int[arraySize];


            do
            {
                InputValue(ref array, ref arraySize);
                cont = DisplayValues(array, arraySize);
            }
            while (cont == true);   
        }
        /// <summary>
        /// This methodis called by Main:<br></br> gets an input from user, calls Validation method to check if value is in the array<br></br>
        /// Calls AddValue method if number is not already in the array<br></br>
        /// Calls RemoveValue method if user chooses to remove the value from the array<br></br>
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        static void InputValue(ref int[] array, ref int arraySize)
        {
            int value;
            string input;
            string askRemove = "";
            bool isInt = true;

            do
            {
                Console.Write("Enter a number: ");
                input = (Console.ReadLine()!);
            
            
                if (int.TryParse(input, out value))
                {
                    isInt = true;// Use 'value' here - it's the parsed integer
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.\n");
                    Console.ResetColor();
                    isInt = false;
                }
            }
            while (isInt == false);

            bool dupe = Validation(array, value);

            if (dupe == false)
            {
                AddValue(ref array, ref arraySize, value);
            }

            else
            {
                Console.Write($"\nWould you like to remove {value} from the array [Y/N]?: ");
                askRemove = Console.ReadLine()!;
                askRemove = askRemove.ToLower();
                Console.WriteLine("\n");
                if (askRemove == "y")
                {
                    RemoveValue(ref array, ref arraySize, value);
                }
                
            }     
        }

        /// <summary>
        /// This method is called by InputValue:<br></br> checks if the array already contains (value) entered by the user
        /// returns true if value is in the array
        /// returns false if value is not in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool Validation(int[] array, int value)
        {
            if (array.Contains(value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nSorry, {value} is already in the array and can't be added again.\n");
                Console.ResetColor();
                return true;
            }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"\n{value} was successfully added to the array.\n");
            Console.ResetColor();
            return false;
        }

        /// <summary>
        /// This method is called by InputValue:<br></br> if the user chooses to remove a value from the array
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        /// <param name="value"></param>
        static void RemoveValue(ref int[] array, ref int arraySize, int value)
        {
            int temp;

            int index = Array.IndexOf(array, value);//Get the index value of the value entered by the user

            if (index == arraySize)//If the index value is equal to the array size, then the array is resized and the last index is removed from the array
            {
                Array.Resize(ref array, arraySize - 1);
                arraySize -= 1;
                
            }
            else//if the index value is somewhere else in the array 
            {
                temp = array[arraySize - 1]; //temp = last number in array 
                array[index] = array[arraySize -1]; //dupe number moved to last number in array
                array[index] = temp; //temp number moved to the dupe number position
                Array.Resize(ref array, arraySize - 1);
                arraySize -= 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{value} was successfully removed from the array.\n");
                Console.ResetColor();

            }
            

        }

        /// <summary>
        /// This method is called by InputValue:<br></br> adds the value entered by the user to the array and increments the new array size
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        /// <param name="value"></param>
        static void AddValue(ref int[] array, ref int arraySize, int value)
        {
            Array.Resize(ref array, arraySize + 1);
            arraySize += 1;
            array[arraySize - 1] = value;
        }

        /// <summary>
        /// This method is called by the Main:<br></br> displays the array, it returns true or false depending if the user chooses to continue
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        static bool DisplayValues(int[] array, int arraySize)
        {
            int rnd;
            string cont;
            Console.WriteLine($"There are currently {arraySize} values in the array.\n");

            if (arraySize > 0)
            {
                rnd = GetRandomValue(arraySize);
                Console.WriteLine($"A random number from the array is: {array[rnd]}\n");
            }
            
            
            Console.WriteLine("FULL ARRAY");
            Console.WriteLine("----------");
            int count = 0;

            foreach(int value in array)
            {
                Console.WriteLine($"array[{count}]: {value}\n");
                count++;
            }
            Console.Write("Would you like to continue [Y/N]: ");
            cont = Console.ReadLine()!;
            cont = cont.ToLower();
            if (cont == "n")
            {
                Console.WriteLine("You have chosen to exit.");
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }

        }

        /// <summary>
        /// This method is called by DisplayValues:<br></br> generates a random number from the size of the array
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        static int GetRandomValue(int arraySize)
        {
            
            return rnd.Next(arraySize);

        }

    }
}
/*
 * --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
-Your code implements a console application for managing an array of integers, with functionalities like adding, removing, and choosing a random number. Here are some suggestions for improvement:

-Separation of Concerns: Your Program class is currently handling multiple responsibilities (UI, array management, validation, etc.). Consider separating these concerns into different classes or methods for
better maintainability and readability.

-[XXX]Use of List<int> Instead of Array: Since your requirements involve dynamic sizing (adding/removing elements), using a List<int> would be more appropriate than resizing an array every time an operation is performed.
Lists are more efficient for these operations and provide built-in methods for adding and removing elements.

-[FIXED]Case-Insensitive User Input: The user input for "Y/N" responses is case-sensitive. Make it case-insensitive for better user experience.

-[FIXED?]Improve Validation Method: The Validation method prints a success message for adding a value, which is misleading if the value is already present in the array.
This method should only validate and return a boolean, while the calling method should handle the user feedback.

-Efficient Removal from Array: Your current method for removing an element from the array is inefficient. If you switch to using a List<int>, you can simply call Remove method.

-[FIXED]Error Handling: Add error handling for user inputs. For example, use int.TryParse instead of Convert.ToInt32 to safely handle non-integer inputs.

-[FIXED]Random Number Generation: The GetRandomValue method creates a new Random instance every time it's called. It's more efficient to have a single Random instance used throughout the application.

-[FIXED]Breaking the Infinite Loop: Your main loop is an infinite loop. Provide a clear way to exit the program.

-Comments and Documentation: While your method summaries are good, adding inline comments within methods for complex logic can further improve the readability.

-Code Optimization: There are places in your code where you can optimize, like not incrementing arraySize twice (in AddValue and then again in the calling method).

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Here's an example of how you might refactor the InputValue method using some of these suggestions:

csharp
Copy code
static void InputValue(List<int> numbers)
{
    Console.Write("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (!numbers.Contains(value))
        {
            numbers.Add(value);
            Console.WriteLine($"\n{value} was successfully added to the array.\n");
        }
        else
        {
            Console.WriteLine($"\n{value} is already in the array.\n");
            Console.Write("Would you like to remove it [Y/N]?: ");
            if (Console.ReadLine().Trim().ToUpper() == "Y")
            {
                numbers.Remove(value);
                Console.WriteLine($"\n{value} was successfully removed from the array.\n");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}
This code uses a List<int> and handles user input more robustly. Remember to apply similar improvements to other parts of your code!
*/

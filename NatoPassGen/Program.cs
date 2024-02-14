using System.ComponentModel.DataAnnotations;

namespace NatoPassGen
{
    /// <summary>
    /// John Coulter<br></br>
    /// 2024-01-17<br></br>
    /// NATO Password Generator<br></br>
    /// This program generates random 3 word passwords using the NATO Alphabet and character replacement
    /// </summary>
    internal class Program
    {
        private static readonly Random rnd = new Random(); //random instance created outside main program to ensure randomness
        static void Main(string[] args)
        {
            string fullPass = "";
            
            //Array for Nato Alphabet
            string[] nato = new string[26] {"Alpha", "Beta", "Charlie", "Delta","Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "Xray", "Yankee", "Zulu"};
            //Array for Character Replace
            string[] replaceLetters = new string[9] { "a","b" ,"c","e","g","i", "l", "o", "s" };
            string[] replaceChars = new string[9] { "@", "8","(", "3", "9","!", "1", "0", "$" };

            //do while loop repeats forever
            do
            {
                PassGen(ref nato, ref fullPass);
                //---test array---
                //ArrayTest(nato);
                //Console.ReadKey();
                //---test array---
                Console.WriteLine("Unmodified Password:");
                PassDisplay(fullPass);
                Console.WriteLine("\nPress any key to modify the password...");
                Console.ReadKey();
                PassReplace(replaceLetters, replaceChars, ref fullPass);
                Console.WriteLine("\nModified Password:");
                PassDisplay(fullPass);
                Console.WriteLine("\n");
                PassStats(fullPass, replaceChars);
                Console.WriteLine("\nPress any key to generate another password...");
                Console.ReadKey();
                Console.Clear();
            }while (true);
        }
        /// <summary>
        /// This Method uses a random number generator to generate a 3 word string from the nato alphabet in the format "word1-word2-word3"
        /// </summary>
        /// <param name="nato"></param>
        /// <param name="fullPass"></param>
        static void PassGen(ref string[] nato, ref string fullPass)
        {
            const int words = 3;//Number of words to generate
            int rndGen = 0;
            string[] pass = new string[words];//local variable[array] to store generated words
            
            
            

            //For loop populates 'pass' array with words
            for (int i = 0; i < words; i++)
            {
                rndGen = rnd.Next(0, 26);
                pass[i] = nato[rndGen];
            }

            fullPass = string.Join("-", pass); //the pass array is joined into one variable with '-' separating each word

        }

        
        /// <summary>
        /// This Method replaces specific letters found in replaceLetters[Array], with characters found in replaceCharacters[Array]
        /// </summary>
        /// <param name="replaceLetters"></param>
        /// <param name="replaceChars"></param>
        /// <param name="fullPass"></param>
        static void PassReplace(string[] replaceLetters, string[] replaceChars, ref string fullPass)
        {
            //for loop iterates for the lkength of replaceLetters array, and fullPass gets modified if characters are found
            for (int i = 0; i < replaceLetters.Length; i++) 
            {
                fullPass = fullPass.Replace(replaceLetters[i], replaceChars[i]);
            }
            
        }

        /// <summary>
        /// This Method displays the current value of the fullPass variable
        /// </summary>
        /// <param name="fullPass"></param>
        static void PassDisplay(string fullPass)
        {

            
            DisplayDashes(fullPass);
            Console.WriteLine($"\n{fullPass}");
            DisplayDashes(fullPass);



        }

        /// <summary>
        /// This method will calculate stats for the generated password<br></br>
        /// Password Length (characters), How many characters were replaced, Percent of password changed
        /// </summary>
        /// <param name="fullPass"></param>
        /// <param name="replaceChars"></param>
        static void PassStats(string fullPass, string[] replaceChars)
        {
            int replaced = 0;
            int length = fullPass.Length;
            
            foreach (char c in fullPass)
            {
                foreach (string replaceString in replaceChars)
                {
                    if (!string.IsNullOrEmpty(replaceString)) // Check if the replaceString is not null or empty
                    {
                        foreach (char replaceChar in replaceString) // Iterate over each character in the replaceString
                        {
                            if (c == replaceChar)
                            {
                                replaced++;
                                break; // Break the innermost loop once a match is found
                            }
                        }
                    }
                }
            }



            decimal pct = ((decimal)replaced / length);
            
            
            Console.WriteLine($"Characters in Password: {fullPass.Length}");
            Console.WriteLine($"Characters Replaced: {replaced}");
            Console.WriteLine($"{pct.ToString("%0.00")} of the characters where replaced");
        }

        /// <summary>
        /// This method creates a line of dashes that is equal to the length of the generated password<br></br>
        /// To make the password display more readable
        /// </summary>
        /// <param name="fullPass"></param>
        static void DisplayDashes(string fullPass)
        {
            for (int i = 0; i < fullPass.Length; i++)
            {
                Console.Write("-");
            }
        }

        static void ArrayTest(string[] nato)
        {
            int count = 0;
            foreach(string s in nato)
            {
                Console.WriteLine($"index[{count}]: {s}");
                count++;
            }
        }

        
    }
}
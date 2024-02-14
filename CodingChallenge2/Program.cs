using System.Diagnostics.CodeAnalysis;

namespace CodingChallenge2
{
    //John Coulter
    //26/01/2024
    //CodingChallenge2


    /// <summary>
    /// This Program is a coding challenge to build a 'Caesar Cipher'
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string message, eMessage, dMessage, action, option = "";
            int shift;
            char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            do
            {
                ChooseOption(ref option);
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        action = "Encrypt";
                        message = GetMessage(alphabet, action);
                        shift = GetShift();
                        eMessage = EncryptMessage(ref message, alphabet, shift);
                        action = "Encrypted";
                        DisplayMessage(eMessage, action);

                        break;

                    case "2":
                        Console.Clear();
                        action = "Decrypt";
                        message = GetMessage(alphabet, action);
                        shift = GetShift();
                        dMessage = DecryptMessage(ref message, alphabet, shift);
                        action = "Decrypted";
                        DisplayMessage(dMessage, action);


                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("You have chosen to exit, thanks for using our app");
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose an option from the menu");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            } while (option != "3");

        }


        /// <summary>
        /// Called by Main (returns string tMessage)<br></br>
        /// This method gets a message from the user converts it to lower case and removes all spaces
        /// </summary>
        /// <returns></returns>
        static string GetMessage(char[] alphabet, string action)
        {
            string message = "";
            Console.WriteLine($"Please Enter a message to {action}:");
            message = Console.ReadLine()!;
            message = message.ToLower()!;

            string tMessage = "";
            foreach (char ch in message)//For each loop iterates over each character in message
            {
                if (alphabet.Contains(ch))//If the character is in the alphabet array
                {
                    tMessage += ch;//The character is added to a new string called tMessage
                }
            }

            return tMessage; //Final edited string is returned
        }

        /// <summary>
        /// This method gets an integer between 1-25 to be the 'shift' value and returns the value
        /// </summary>
        /// <returns></returns>
        static int GetShift()
        {
            int shift = 0;
            bool valid = false;
            

            do
            {
                do
                {
                    Console.WriteLine("Please Enter value to shift by (1-25):");
                    valid = int.TryParse(Console.ReadLine(), out shift)!;
                    Console.Clear();
                }while (valid == false);



                Console.Clear();
            } while (shift <= 0 || shift > 25);//only allow 1-25



            
            return shift;
        }

        /// <summary>
        /// This Method encrypts the message entered by the user
        /// </summary>
        /// <param name="message"></param>
        /// <param name="alphabet"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        static string EncryptMessage(ref string message, char[] alphabet, int shift)
        {

            string eMessage = String.Empty;


            foreach (char ch in message)//For each character in the message, iterates over every character in message
            {
                for (int i = 0; i < alphabet.Length; i++)//For loop to determine the characters position in the alphabet array
                {
                    if (alphabet[i] == ch)//If a character in the alphabet matches a character in the message
                    {

                        if ((i + shift) > 26)//If the array position + shift value > 26 (To avoid out of bounds error) 
                        {
                            int k = (i + shift) - 26;//int k needs to equal (i + shift) - 26: To wrap around the alphabet


                            eMessage += alphabet[k]; //eMessage then adds the character at alphabet[k] to the encrypted message
                        }
                        else//else eMessage can just add the character at alphabet[i + shift value]
                        {
                            eMessage += alphabet[i + shift];
                        }
                        break;


                    }
                }
            }


            return eMessage;

        }

        /// <summary>
        /// This method decrypts a message entered by the user
        /// </summary>
        /// <param name="eMessage"></param>
        /// <param name="alphabet"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        static string DecryptMessage(ref string eMessage, char[] alphabet, int shift)
        {
            string dMessage = String.Empty;
            //The logic is the same as in the EncryptMessage Method Except*
            foreach (char ch in eMessage)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == ch)
                    {

                        if ((i - shift) < 0)//*change to if i - shift value is less than zero (to avoid out of bounds error)
                        {
                            int k = (i - shift) + 26;//*int k now becomes i - shift value +26


                            dMessage += alphabet[k];
                        }
                        else
                        {
                            dMessage += alphabet[i - shift];
                        }
                        break;


                    }
                }
            }
            return dMessage;
        }


        /// <summary>
        /// This method displays the encrypted or decrypted message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="action"></param>
        static void DisplayMessage(string message, string action)
        {
            Console.WriteLine($"{action} Message: {message}");//action will be set in main to encrypted or decrypted
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// This option displays a simple menu
        /// </summary>
        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("#############");
            Console.WriteLine("CAESAR CIPHER");
            Console.WriteLine("#############\n");
            Console.WriteLine("OPTION 1: Encrypt a Message");
            Console.WriteLine("OPTION 2: Decrypt a Message");
            Console.WriteLine("OPTION 3: EXIT\n");

        }

        /// <summary>
        /// This option gets a choice from the user
        /// </summary>
        /// <param name="option"></param>
        static void ChooseOption(ref string option)
        {

                DisplayMenu();

                Console.Write("Choose an option: ");
                option = Console.ReadLine()!;

        }

        
    }
}

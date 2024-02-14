using System.Numerics;

namespace Factorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum = UserInput();
            BigInteger result = CalcFactorial(userNum);
            DisplayResult(result, userNum);
        }

        static int UserInput()
        {
            Console.Write("Enter a number to show it's factorial: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        static BigInteger CalcFactorial(int userNum)
        {
            BigInteger result = 1;
            
            for(int i = 2; i <= userNum ; i++)
            {
                result *= i;    
            }
            return result;
        }

        static void DisplayResult(BigInteger result, int userNum)
        {
            Console.WriteLine($"{userNum}! is equal to {result}");
        }

    }
}

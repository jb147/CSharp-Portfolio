namespace justtesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _bias = -3;
            int _upper = 50;
            int _lower = -50;
            int bias = 3;
            int upper = 50;
            int lower = -50;

            Console.WriteLine($"UPPER RANGE: {upper}  LOWER RANGE: {lower} ");

            while (true)
            {
                /*
                if (bias > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    upper += bias;
                    lower += bias;
                    Console.WriteLine($"UPPER RANGE: {upper}  LOWER RANGE: {lower} ");
                    Console.ReadKey();
                }
                */
                

                if (_bias < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    _lower -= bias;
                    _upper -= bias;
                    Console.WriteLine($"_UPPER RANGE: {_upper}  _LOWER RANGE: {_lower} ");
                    Console.ReadKey();
                }
            }
            
            
        }
    }
}

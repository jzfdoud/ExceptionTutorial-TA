using System;

namespace ExceptionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Level1(3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" The program encountered an exception!");
                Console.WriteLine($" Exception: {ex.Message}");
            }
            Console.WriteLine(" Done...");
        }

        static void Level1(int i)
        {
            Level2(i - 1);
        }
        static void Level2(int i)
        {
            Level3(i - 2);
        }
        static void Level3(int i)
        {
            var result = 100 / i;
            Console.WriteLine($"Result is {result}");

        }



    }
}

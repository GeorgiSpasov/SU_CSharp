using System;

namespace _01._08.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('*', n));
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }
            Console.WriteLine(new String('*', n));
        }
    }
}

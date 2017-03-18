using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();

            Console.WriteLine(first == second ? "yes" : "no");
        }
    }
}

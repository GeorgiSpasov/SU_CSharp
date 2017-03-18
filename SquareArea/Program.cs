using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = Math.Pow(a, 2);
            Console.WriteLine("Square = {0}", area);
        }
    }
}

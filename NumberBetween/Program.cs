using System;

namespace NumberBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num >= 100)
            {
                Console.WriteLine(num <= 200 ? "Between 100 and 200" : "Greater than 200");
            }
            else
            {
                Console.WriteLine("Less than 100");
            }
        }
    }
}

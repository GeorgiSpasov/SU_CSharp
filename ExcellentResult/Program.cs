using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = double.Parse(Console.ReadLine());
            if (result >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}

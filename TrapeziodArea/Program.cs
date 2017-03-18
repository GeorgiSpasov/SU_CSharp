using System;

namespace TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid area = " + (a + b) * h / 2);

        }
    }
}

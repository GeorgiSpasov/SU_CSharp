using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            Console.WriteLine(a * b); // Area
            Console.WriteLine(2 * (a + b)); // Perimeter

        }
    }
}

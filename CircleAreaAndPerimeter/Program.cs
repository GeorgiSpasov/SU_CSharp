using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}

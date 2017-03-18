using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters = {0}", inches * 2.54);
        }
    }
}

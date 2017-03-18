using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sec = a + b + c;
            var min = 0;

            while (sec >= 60)
            {
                min++;
                sec -= 60;
            }

            Console.WriteLine(string.Format("{0}:{1}", min, sec.ToString().PadLeft(2, '0')));
        }
    }
}

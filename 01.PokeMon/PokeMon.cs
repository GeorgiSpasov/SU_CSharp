using System;

namespace _01.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int originalPower = power;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targets = 0;

            while (power >= distance)
            {
                if (exhaustionFactor != 0 && (double)power == (double)originalPower / 2.0)
                {
                    power /= exhaustionFactor;
                }
                if (power < distance)
                {
                    break;
                }
                power = power - distance;
                targets++;
            }
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}

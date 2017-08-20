using System;
using System.Collections.Generic;
using System.Linq;

namespace _002.Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            int currentWagon;
            int averageWagon;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out currentWagon))
                {
                    wagons.Add(currentWagon);
                    if (wagons.Sum() > power)
                    {
                        averageWagon = (int)wagons.Average();
                        wagons.Remove(wagons.Aggregate((x, y) => Math.Abs(x - averageWagon) < Math.Abs(y - averageWagon) ? x : y));
                    }
                }
                else
                {
                    break;
                }
            }
            wagons.Reverse();
            Console.WriteLine(string.Join(" ", wagons) + " " + power);
        }
    }
}

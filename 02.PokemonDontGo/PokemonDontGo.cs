using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int removedElement = 0;
            int sumOfRemoved = 0;
            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    removedElement = distances.First();
                    sumOfRemoved += removedElement;
                    distances[0] = distances.Last();
                    DistanceModifier(distances, removedElement);
                }
                else if (index > distances.Count - 1)
                {
                    removedElement = distances.Last();
                    sumOfRemoved += removedElement;
                    distances[distances.Count - 1] = distances[0];
                    DistanceModifier(distances, removedElement);
                }
                else
                {
                    removedElement = distances[index];
                    sumOfRemoved += removedElement;
                    distances.RemoveAt(index);
                    DistanceModifier(distances, removedElement);
                }
            }
            Console.WriteLine(sumOfRemoved);
        }
        public static void DistanceModifier(List<int> distances, int removedElement)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedElement)
                {
                    distances[i] += removedElement;
                }
                else if (distances[i] > removedElement)
                {
                    distances[i] -= removedElement;
                }
            }
        }
    }
}

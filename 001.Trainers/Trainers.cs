using System;
using System.Collections.Generic;
using System.Linq;

namespace _001.Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> teams = new Dictionary<string, double>();
            teams.Add("Technical", 0);
            teams.Add("Theoretical", 0);
            teams.Add("Practical", 0);

            int distanceInMeters = 0;
            double cargoInKillograms = 0;
            double participantEarnedMoney = 0;
            string currentTeam = "";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                distanceInMeters = int.Parse(Console.ReadLine()) * 1600;
                cargoInKillograms = double.Parse(Console.ReadLine()) * 1000;
                participantEarnedMoney = cargoInKillograms * 1.5 - 0.7 * distanceInMeters * 2.5;

                currentTeam = Console.ReadLine();
                teams[currentTeam] += participantEarnedMoney;
            }

            Console.WriteLine(string.Format("The {0} Trainers win with ${1:0.000}.",
                teams.Where(c => c.Value == teams.Values.Max()).First().Key,
                teams.Values.Max()));
        }
    }
}

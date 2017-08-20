using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _003.Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            Regex loco = new Regex(@"^<\[[^a-zA-Z0-9]+\]\.");
            Regex wagon = new Regex(@"\G\.\[([a-zA-Z0-9])*\]\.");
            List<string> validTrains = new List<string>();

            String input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Traincode!")
                {
                    break;
                }

                if (loco.IsMatch(input))
                {
                    int index = 0;
                    Match match = loco.Match(input, index);
                    if (match.Success)
                    {
                        string locoBody = match.Value;
                        index = match.Index + locoBody.Length;

                        if (index == input.Length)
                        {
                            validTrains.Add(input);
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }

                    // Check wagons
                    string wagonBody = "";
                    while (match.Success && index <= input.Length)
                    {
                        match = wagon.Match(input, index);
                        wagonBody = match.Value;
                        index = match.Index + wagonBody.Length;
                        if (index == input.Length)
                        {
                            validTrains.Add(input);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join("\n", validTrains));
        }
    }
}

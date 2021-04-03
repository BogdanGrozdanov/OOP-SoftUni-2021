using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var teamByName = new Dictionary<string, Team>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                var data = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (data[0] == "Add")
                    {
                        var teamName = data[1];

                        if (!teamByName.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }
                        var playerName = data[2];
                        var endurance = int.Parse(data[3]);
                        var sprint = int.Parse(data[4]);
                        var dribble = int.Parse(data[5]);
                        var passing = int.Parse(data[6]);
                        var shooting = int.Parse(data[7]);
                        var team = teamByName[teamName];

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        team.AddPlayer(player);

                    }
                    else if (data[0] == "Remove")
                    {
                        var teamName = data[1];
                        var playerName = data[2];
                        var team = teamByName[teamName];
                        team.RemovePlayer(playerName);
                    }
                    else if (data[0] == "Rating")
                    {
                        var teamName = data[1];
                        if (!teamByName.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }
                        var team = teamByName[teamName];
                        Console.WriteLine($"{teamName} - {team.AverageRatink()}");
                    }
                    else if (data[0] == "Team")
                    {
                        var teamName = data[1];
                        var team = new Team(teamName);
                        teamByName.Add(teamName, team);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

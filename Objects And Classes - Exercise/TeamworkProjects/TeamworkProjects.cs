using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {

                string[] regTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                bool teamCreated = teams.Select(t => t.TeamName).Contains(regTeam[1]);
                bool playerCreated = teams.Any(t => t.Members.Contains(regTeam[0]));


                if (!teamCreated && !playerCreated)
                {
                    Team newTeam = new Team(regTeam[1], regTeam[0]);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {regTeam[1]} has been created by {regTeam[0]}!");
                }
                else if (teamCreated)
                {
                    Console.WriteLine($"Team {regTeam[1]} was already created!");
                }
                else if (playerCreated)
                {
                    Console.WriteLine($"{regTeam[0]} cannot create another team!");
                }
            }


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] teamJoinData = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                bool exist = teams.Any(t => t.TeamName == teamJoinData[1]);
                bool memberJoin = teams.Any(t => t.Members.Contains(teamJoinData[0]));
                if (!memberJoin && exist)
                {
                    int teamIndex = teams.FindIndex(t => t.TeamName == teamJoinData[1]);
                    teams[teamIndex].Members.Add(teamJoinData[0]);
                }
                else if (!exist)
                {
                    Console.WriteLine($"Team {teamJoinData[1]} does not exist!");
                }

                else if (memberJoin)
                {
                    Console.WriteLine($"Member {teamJoinData[0]} cannot join team {teamJoinData[1]}!");
                }
            }

            List<Team> disbanded = new List<Team>();
            disbanded = teams.Where(t => t.Members.Count == 1).OrderBy(t => t.TeamName).ToList();
            teams.RemoveAll(t => t.Members.Count == 1);
            teams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            foreach (var team in teams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Members[0]}");
                team.Members.RemoveAt(0);
                team.Members.Sort();
                for (int i = 0; i < team.Members.Count; i++)
                {
                    Console.WriteLine($"-- {team.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbanded)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public Team(string name, string members)
        {
            Members = new List<string>();
            TeamName = name;
            Members.Add(members);
        }

        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
}

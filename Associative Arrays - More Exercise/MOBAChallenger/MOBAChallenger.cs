using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] playerData = input.Split(" -> ");
                    string player = playerData[0];
                    string role = playerData[1];
                    int skill = int.Parse(playerData[2]);
                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player].Add(role, skill);
                    }
                    else
                    {
                        if (players[player].ContainsKey(role))
                        {
                            if (players[player][role] < skill)
                            {
                                players[player][role] = skill;
                            }
                        }
                        else
                        {
                            players[player].Add(role, skill);
                        }
                    }
                }
                else if (input.Contains("vs"))
                {
                    string[] duel = input.Split(" vs ");
                    string player1 = duel[0];
                    string player2 = duel[1];
                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        if (players[player1].Keys.Intersect(players[player2].Keys).Any())
                        {
                            if (players[player1].Values.Sum() > players[player2].Values.Sum())
                            {
                                players.Remove(player2);
                            }
                            else if (players[player1].Values.Sum() < players[player2].Values.Sum())
                            {
                                players.Remove(player1);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var role in player.Value.OrderByDescending(p => p.Value).ThenBy(r => r.Key))
                {
                    Console.WriteLine($"- {role.Key} <::> {role.Value}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_IV03.Footbal_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var inputLine = Console.ReadLine();
            var leagueStandings = new Dictionary<string, int>();
            var goalsPerTeam = new Dictionary<string, int>();

            while (inputLine!="final")
            {
                var inputParams = inputLine.Split();
                var firstTeamName = GetTheName(inputParams[0], key);
                var secondTeamName = GetTheName(inputParams[1], key);
               
                var score = inputParams[inputParams.Length - 1].Split(':');
                var firstTeamScore = int.Parse(score[0]);
                var secondTeamScore= int.Parse(score[1]);
                AddGoalsPerTeam(goalsPerTeam, firstTeamName, firstTeamScore);
                AddGoalsPerTeam(goalsPerTeam, secondTeamName, secondTeamScore);
                var pointsFirst = 0;
                var pointsSecond = 0;
                if (firstTeamScore==secondTeamScore)
                {
                    pointsFirst = 1;
                    pointsSecond = 1;
                }
               else if (firstTeamScore>secondTeamScore)
                {
                    pointsFirst = 3;
                    pointsSecond = 0;
                }
                else if (secondTeamScore>firstTeamScore)
                {
                    pointsSecond = 3;
                    pointsFirst = 0;
                }

                AddToLeagueStandings(leagueStandings, firstTeamName,pointsFirst);
                AddToLeagueStandings(leagueStandings, secondTeamName,pointsSecond);
                inputLine = Console.ReadLine();
            }
            var sortedStandings = leagueStandings.OrderByDescending(x => x.Value).ThenBy(z => z.Key);
            var count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in sortedStandings)
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            var sortedGoals = goalsPerTeam.OrderByDescending(x => x.Value).ThenBy(z => z.Key).Take(3);
            foreach (var team in sortedGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }

        }

        private static void AddGoalsPerTeam(Dictionary<string, int> goalsPerTeam, string teamname, int goals)
        {
            if (!goalsPerTeam.ContainsKey(teamname))
            {
                goalsPerTeam[teamname] = 0;
            }
            goalsPerTeam[teamname] += goals;
        }

        private static void AddToLeagueStandings(Dictionary<string,int> leagueStandings,string teamname,int points)
        {
            if (!leagueStandings.ContainsKey(teamname))
            {
                leagueStandings[teamname] = 0;
            }
            leagueStandings[teamname] += points;
        }

        private static string GetTheName(string teamName, string key)
        {
            var firstIndex = teamName.IndexOf(key) + key.Length;
            var secondIndex = teamName.LastIndexOf(key);
            var length = secondIndex - firstIndex;
            var name = teamName.Substring(firstIndex, length);
            return string.Join("", name.ToUpper().Reverse());

       }
    }
}

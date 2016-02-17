using System;
using System.Collections.Generic;
using System.Linq;

public static class League
{
    private static List<Team> teams = new List<Team>(); 
    private static List<Match> matches = new List<Match>();

    public static IEnumerable<Team> Teams
    {
        get { return teams; }
    }

    public static IEnumerable<Match> Matches
    {
        get { return matches; }
    }

    public static void AddTeam(Team team)
    {
        if (CheckIfTeamExists(team))
        {
            throw new InvalidOperationException("Team already exists for that team");
        }

        teams.Add(team);
    }

    private static bool CheckIfTeamExists(Team team)
    {
        return Teams.Any(t => t.Name == team.Name);
    }

    public static void AddMatch(Match match)
    {
        if (CheckIfIdExists(match))
        {
            throw new InvalidOperationException("ID already exists for that match");
        }
        matches.Add(match);
    }

    private static bool CheckIfIdExists(Match match)
    {
        return Matches.Any(m => m.Id == match.Id);
    }
}



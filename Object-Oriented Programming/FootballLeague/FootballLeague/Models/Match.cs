using System;
using System.Runtime.CompilerServices;

public class Match
{
    private Team homeTeam;
    private Team awayTeam;
    private Score score;
    private int id;

    public Match(Team homeTeam, Team awayTeam, Score score, int id)
    {
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
        Score = this.score;
        Id = id;

    }

    public Team HomeTeam
    {
        get { return homeTeam; }
        set { homeTeam = value; }
    }

    public Team AwayTeam
    {
        get { return awayTeam; }
        set
        {
            if (homeTeam.Name.Equals(value.Name))
            {
                throw new ArgumentException("The names of the teams in a match cannot be the same !");
            }
            awayTeam = value;
        }
    }

    public Score Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private bool IsDraw()
    {
        return Score.AwayTeamGoals == Score.HomeTeamGoals;
    }

    public Team GetWinner()
    {
        if (this.IsDraw())
        {
            return null;
        }

        return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
            ? this.HomeTeam
            : this.AwayTeam;
    }
}
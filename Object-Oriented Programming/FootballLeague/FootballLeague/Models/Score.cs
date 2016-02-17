using System;

public class Score
{
    private int homeTeamGoals;
    private int awayTeamGoals;

    public Score(int homeTeamGoals, int awayTeamGoals)
    {
        HomeTeamGoals = homeTeamGoals;
        AwayTeamGoals = awayTeamGoals;
    }

    public int AwayTeamGoals
    {
        get { return awayTeamGoals; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Goals cannot be negative");
            }
            homeTeamGoals = value;
        }
    }

    public int HomeTeamGoals
    {
        get { return homeTeamGoals; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Goals cannot be negative");
            }
            homeTeamGoals = value;
        }
    }
}
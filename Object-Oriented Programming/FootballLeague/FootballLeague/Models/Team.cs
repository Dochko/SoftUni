using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private string nickname;
    private DateTime dateFounded;
    private List<Player> players;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
            {
                throw new ArgumentException("Team name should be at least 5 chars long");
            }
        }
    }

    public string Nickname
    {
        get { return nickname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
            {
                throw new ArgumentException("Nickname should be at least 5 chars long");
            }
        }
    }

    public DateTime DateFounded
    {
        get { return dateFounded; }
        set { dateFounded = value; }
    }

    public Team(string name, string nickname, DateTime dateFounded)
    {
        Name = name;
        Nickname = nickname;
        DateFounded = dateFounded;
        players = new List<Player>();
    }

    public IEnumerable<Player> Players
    {
        get { return players; }
    }

    public void AddPlayer(Player player)
    {
        if (CheckIfPlayerExists(player))
        {
            throw new InvalidOperationException("Player already exists for that team");
        }

        players.Add(player);
    }

    private bool CheckIfPlayerExists(Player player)
    {
        return Players.Any(p => p.FirstName == player.FirstName &&
                                p.LastName == player.LastName);
    }

    public override string ToString()
    {
        return Name + " - " + string.Join(", ", players.Select(z => z.ToString()));
    }
}
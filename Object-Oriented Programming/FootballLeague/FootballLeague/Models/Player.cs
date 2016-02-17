using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    private const int MinimumAllowedYear = 1980;
    private string firstName;
    private string lastName;
    private decimal salary;
    private DateTime dateOfBirth;
    private Team team;

    public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        DateOfBirth = dateOfBirth;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Firstname should be at least 3 chars long");
            }

            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Firstname should be at least 3 chars long");
            }

            lastName = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            salary = value;
        }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set
        {
            if (value.Year < MinimumAllowedYear)
            {
                throw new ArgumentException("Date of birth cannot be earlier than " + MinimumAllowedYear);
            }
        }
    }

    public Team Team
    {
        get { return team; }
        set { team = value; }
    }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}
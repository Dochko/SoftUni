using System;

namespace Minesweeper
{
    public class Player
    {
        private string name;
        private int points;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or empty !");
                }

                name = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("points", "Points cannot be negative !");
                }

                points = value;
            }
        }
    }
}
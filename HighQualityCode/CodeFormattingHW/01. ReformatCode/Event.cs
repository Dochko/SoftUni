namespace ReformatCode
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.Title = title;
            this.Location = location;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.title), "Title cannot be null or empty !");
                }

                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location; 
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.location), "Location cannot be null or empty !");
                }

                this.location = value;
            }
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = string.Compare(this.title, other.title, StringComparison.Ordinal);
            int byLocation = string.Compare(this.location, other.location, StringComparison.Ordinal);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }

                else
                {
                    return byTitle;
                }
            }

            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}
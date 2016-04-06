namespace TheSlum.Interfaces
{
    public interface ITimeoutable
    {
        int Countdown { get; set; }

        bool HasTimedOut { get; set; }

        int Timeout { get; set; }
    }
}
namespace LoggerLibrary.Contracts
{
    using System;
    using Models;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(DateTime date, ReportLevel reportLevel, string message);
    }
}
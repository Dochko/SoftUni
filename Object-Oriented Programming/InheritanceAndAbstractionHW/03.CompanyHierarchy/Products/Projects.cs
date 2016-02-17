using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Products
{
    public class Projects : IProjects
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Projects(string projectName, DateTime startDate, string details)
        {
            ProjectName = projectName;
            StartDate = startDate;
            Details = details;
            State = ProjectState.Open;
        }

        public string ProjectName
        {
            get { return projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Project name cannot be null !");
                }
                projectName = value;
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string Details
        {
            get { return details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Details cannot be null !");
                }
                details = value;
            }
        }

        public ProjectState State
        {
            get { return state; }
            set { state = value; }
        }

        public void CloseProject()
        {
            State = ProjectState.Closed;
        }

        public override string ToString()
        {
            string str = 
                string.Format("Name: {0}{6}Start date: {1}.{2}.{3}{6}Details: {4}{6}State: {5}{6}", 
                    projectName, startDate.Day,startDate.Month, startDate.Year, details, state, Environment.NewLine);

            return str;
        }
    }
}
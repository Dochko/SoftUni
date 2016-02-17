using System;

namespace CompanyHierarchy.Interfaces
{
    

    public interface IProjects
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        ProjectState State { get; set; }

        void CloseProject();
    }

    public enum ProjectState
    {
        Open, Closed
    }
}
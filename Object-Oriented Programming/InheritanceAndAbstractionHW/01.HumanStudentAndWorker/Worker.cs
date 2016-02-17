using System;

namespace HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative !");
                }
                weekSalary = value;
            } 
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day cannot be negative !");
                }
                workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = WeekSalary / (WorkHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            string str = string.Format("{0}{4}Week Salary: {1} lv.{4}Working hours per day: {2} hours{4}Money per hour: {3:F2} lv.{4}", 
                base.ToString(), weekSalary, workHoursPerDay, MoneyPerHour(),Environment.NewLine);

            return str;
        }
    }
}
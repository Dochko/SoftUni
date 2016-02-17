using System;

namespace SULS
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public void DeleteCourse(string course)
        {
            courses.Remove(course);
            Console.WriteLine("The course " + course + " has been deleted. ");
        }
    }
}

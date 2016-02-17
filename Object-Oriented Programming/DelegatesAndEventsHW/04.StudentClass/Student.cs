using System;

namespace StudentClass
{
    public delegate void PropertyChangedEventHandler(
            object sender, PropertyChangedEventArgs eventArgs);

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or empty !");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", this.Name, value);
                this.OnPropertyChange(this, args);

                this.name = value;
            } 
            
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be 0 or negative !");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Age", this.Age, value);
                this.OnPropertyChange(this, args);

                this.age = value;
            } 
            
        }

        private void OnPropertyChange(object sender, PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(sender, args);
            }
        }
    }
}
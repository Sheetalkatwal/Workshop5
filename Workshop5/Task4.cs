using System;

namespace School
{
    // Base class
    public class Teacher
    {
        protected string name; // Protected access for derived class usage

        public Teacher(string name)
        {
            this.name = name;
        }

        // Virtual method to be overridden
        public virtual void Teaching()
        {
            Console.WriteLine($"{name} teaches English.");
        }

        // Method that cannot be overridden
        public string SalaryInfo()
        {
            return $"{name}'s salary is fixed and cannot be overridden.";
        }
    }

    // Derived class for Nepali Teacher
    public class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name) { }

        // Overriding the Teaching method
        public override void Teaching()
        {
            Console.WriteLine($"{name} teaches Nepali.");
        }
    }

    // Derived class for Math Teacher
    public class MathTeacher : Teacher
    {
        public MathTeacher(string name) : base(name) { }

        // Overriding the Teaching method
        public override void Teaching()
        {
            Console.WriteLine($"{name} teaches Math.");
        }
    }
}
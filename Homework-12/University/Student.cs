using System.Collections.Generic;

namespace University
{
    public class Student : Person
    {
        public List<double> Marks { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Marks = new List<double>();
        }

        public void AddMark(double mark)
        {
            Marks.Add(mark);
        }

        public bool IsEligibleForGraduation()
        {
            return Marks.All(mark => mark >= 50);
        }

        public void Graduate()
        {
            Console.WriteLine($"{Name} has received a diploma.");
        }
    }
}
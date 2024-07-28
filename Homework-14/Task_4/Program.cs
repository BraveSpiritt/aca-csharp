namespace Task_4
{
    internal class Program
    {
        public interface IStudent
        {
            string Name { get; set; }
            int Age { get; set; }
            double Grade { get; set; }
        }
        public class Student : IStudent
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }
            public Student(string name, int age, double grade)
            {
                Name = name;
                Age = age;
                Grade = grade;
            }
        }
        static void Main(string[] args)
        {
            IStudent student = new Student("David", 24, 7.8);
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");
            student.Name = "Artur";
            student.Age = 24;
            student.Grade = 9.9;
            Console.WriteLine("Updated Student Information:");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");
        }
    }
}

using static University.University;
using System.Xml.Linq;

namespace University
{
    public class Instructor : Staff
    {
        public Instructor(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
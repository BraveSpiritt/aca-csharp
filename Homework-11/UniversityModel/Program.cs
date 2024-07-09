using System.Net;

namespace UniversityModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To see whole list of University press: 1, For adding new student press: 2");
            string command = Console.ReadLine();
            Person[] universityPeople = new Person[]
            {
            new Person { Name = "John Doe", Age = 40, Role = "Professor" },
            new Person { Name = "Jane Smith", Age = 30, Role = "Student" },
            new Person { Name = "Mark Johnson", Age = 50, Role = "Student" },
            new Person { Name = "Emily Brown", Age = 35, Role = "Professor" },
            new Person { Name = "Michael Lee", Age = 45, Role = "Administrator" },
            new Person { Name = "Sarah Wilson", Age = 25, Role = "Student" },
            new Person { Name = "James Taylor", Age = 55, Role = "Student" },
            new Person { Name = "Anna Martinez", Age = 38, Role = "Professor" },
            new Person { Name = "David Davis", Age = 42, Role = "Student" },
            };
            switch (command)
            {
                case "1":
                    foreach (Person person in universityPeople)
                    {
                        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Role: {person.Role}");
                    };
                    break;
                case "2":
                    University myUniversity = new University();
                    Console.Write("Type name:");
                    string newStudnetName = Console.ReadLine();
                    Console.WriteLine("Type age:");
                    int newStudentAge = Convert.ToInt32(Console.ReadLine());
                    myUniversity.AddNewPerson(ref universityPeople, newStudnetName, newStudentAge);
                    Console.WriteLine("Your student successfully added.");
                    break;
            }
        }
        struct Person
        {
            public string Name;
            public int Age;
            public string Role;
            public string Departament;
            public override string ToString()
            {
                return $"{Name} {Age}, Role: {Role}, Departament: {Departament}";
            }
        }
        struct Departament
        {
            public string Name;
            public int CountOfStudents;
        }

        struct University
        {
            public Departament Departament;
            public void AddNewPerson(ref Person[] people, string name, int age)
            {
                Array.Resize(ref people, people.Length + 1);
                people[people.Length - 1] = new Person { Name = name, Age = age, Role = "Student" };
            }
        }

    }
}

using System;
using System.Collections.Generic;
using University;

namespace University
{
    public class University
    {
        public string Name { get; set; }
        public int MaxStudents { get; set; }
        public double Budget { get; set; }
        private List<Student> Students { get; set; }
        private List<Staff> StaffMembers { get; set; }

        public University(string name, int maxStudents, double budget)
        {
            Name = name;
            MaxStudents = maxStudents;
            Budget = budget;
            Students = new List<Student>();
            StaffMembers = new List<Staff>();
        }

        public void AddStudent(Student student)
        {
            if (Students.Count < MaxStudents)
            {
                Students.Add(student);
            }
            else
            {
                throw new InvalidOperationException("Max student capacity reached.");
            }
        }

        public void AddStaffMember(Staff staff)
        {
            StaffMembers.Add(staff);
        }

        public void DistributeSalaries()
        {
            double totalSalaries = 0;

            foreach (var staff in StaffMembers)
            {
                totalSalaries += staff.Salary;
            }

            if (totalSalaries <= Budget)
            {
                foreach (var staff in StaffMembers)
                {
                    Budget -= staff.Salary;
                    Console.WriteLine($"Paid {staff.Name} {staff.Salary}");
                }
            }
            else
            {
                throw new InvalidOperationException("Budget is not sufficient to pay all staff.");
            }
        }

        public void GraduateStudent(Student student)
        {
            if (student.IsEligibleForGraduation())
            {
                student.Graduate();
                Console.WriteLine($"{student.Name} has graduated!");
            }
            else
            {
                Console.WriteLine($"{student.Name} is not eligible for graduation.");
            }
        }

        public void PrintStudentsWithMarks()
        {
            Console.WriteLine("List of Students and their Marks:");
            foreach (var student in Students)
            {
                Console.WriteLine($"Student: {student.Name}, Age: {student.Age}");
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks));
            }
        }

        public void PrintStaffWithSalaries()
        {
            Console.WriteLine("List of Staff and their Salaries:");
            foreach (var staff in StaffMembers)
            {
                Console.WriteLine($"Staff: {staff.Name}, Age: {staff.Age}, Salary: {staff.Salary}");
            }
        }
    }
}
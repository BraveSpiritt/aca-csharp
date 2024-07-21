namespace University
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var university = new University("Sample University", 10, 50000);

            var student1 = new Student("Alice", 20);
            student1.AddMark(85);
            student1.AddMark(90);

            var student2 = new Student("Bob", 22);
            student2.AddMark(75);
            student2.AddMark(80);

            university.AddStudent(student1);
            university.AddStudent(student2);

            var director = new Director("Dr. Smith", 50, 10000);
            var instructor1 = new Instructor("Prof. Johnson", 45, 7000);
            var staff1 = new CommonStaff("Ms. Brown", 30, 3000);

            university.AddStaffMember(director);
            university.AddStaffMember(instructor1);
            university.AddStaffMember(staff1);

            university.PrintStudentsWithMarks();
            university.PrintStaffWithSalaries();
        }
    }
}
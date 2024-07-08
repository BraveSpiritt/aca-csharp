namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person();
            David.FirstName = "David";
            David.LastName = "Soghomonyan";
            David.Age = 24;
            Person Tigran = new Person();
            Tigran.FirstName = "Tigran";
            Tigran.LastName = "Soghomonyan";
            Tigran.Age = 25;
            Person Hayk = new Person();
            Hayk.FirstName = "Hayk";
            Hayk.LastName = "Soghomonyan";
            Hayk.Age = 16;
            Console.WriteLine("First person information \nName: {0}\nSurname: {1}\nAge: {2}", David.FirstName, David.LastName, David.Age);
            Console.WriteLine("Second person information \nName: {0}\nSurname: {1}\nAge: {2}", Tigran.FirstName, Tigran.LastName, Tigran.Age);
            Console.WriteLine("Last person information \nName: {0}\nSurname: {1}\nAge: {2}", Hayk.FirstName, Hayk.LastName, Hayk.Age);
        }
        struct Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
        }

    }
}

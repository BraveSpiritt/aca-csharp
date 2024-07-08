namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David", "Soghomonyan", 24);
            Person Tigran = new Person("Tigran", "Soghomonyan", 25);
            Person Hayk = new Person("Hayk", "Soghomonyan", 16);
            double avarageAge = (David.Age + Tigran.Age + Hayk.Age) / 3;
            Console.WriteLine("Avarage age of all persons: {0}", avarageAge);

        }
        struct Person(string name, string surname, double age)
        {
            public string FirstName = name;
            public string LastName = surname;
            public double Age = age;
        }

    }
}

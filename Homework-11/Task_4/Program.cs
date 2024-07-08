namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David", "Soghomonyan", 24);
            Console.WriteLine("First person information \nName: {0}\nSurname: {1}\nAge: {2}", David.FirstName, David.LastName, David.Age);
        }
        struct Person(string name, string surname, int age)
        {
            public string FirstName = name;
            public string LastName = surname;
            public int Age = age;
        }

    }
}

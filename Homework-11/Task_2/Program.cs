namespace Task_2
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
        }
        struct Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
        }
        
    }
}

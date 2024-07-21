namespace Manually_Deep_Copy
{
    internal class Program
    {
        public static void Main()
        {
            var originalPerson = new Person
            {
                Name = "John",
                Address = new Address { City = "New York" }
            };
            /* var copiedPerson = new Person
            {
                Name = originalPerson.Name,
                Address = new Address { City = originalPerson.Address.City }
            }; */
            var copiedPerson = originalPerson.ManualCopy();
            
            copiedPerson.Address.City = "Los Angeles";

            Console.WriteLine($"Original City: {originalPerson.Address.City}"); 
            Console.WriteLine($"Copied City: {copiedPerson.Address.City}");    
        }
    }
    public class Address
    {
        public string City { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person ManualCopy()
        {
            return new Person
            {
                Name = this.Name,
                Address = new Address { City = this.Address.City } 
            };
        }
    }


}
}

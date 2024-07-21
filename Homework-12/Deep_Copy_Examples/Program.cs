using System;

namespace Deep_Copy_Example
{
    public class Program
    {
        public static void Main()
        {
            var originalPerson = new Person
            {
                Name = "John",
                Address = new Address { City = "New York" }
            };

            var clonedPerson = (Person)originalPerson.Clone();
            clonedPerson.Address.City = "Los Angeles";

            Console.WriteLine($"Original City: {originalPerson.Address.City}");
            Console.WriteLine($"Cloned City: {clonedPerson.Address.City}");
        }
    }
    public class Address : ICloneable
    {
        public string City { get; set; }

        public object Clone()
        {
            return new Address { City = this.City };
        }
    }

    public class Person : ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            return new Person
            {
                Name = this.Name,
                Address = (Address)this.Address.Clone()
            };
        }
    }


}

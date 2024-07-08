using System.Net;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Aragats", "Yerevan", "050");
            Person person = new Person("David", "Soghomonyan", address);
            Console.WriteLine(person);

        }
        struct Address
        {
            public string Street { get; }
            public string City { get; }
            public string PostalCode { get; }

            public Address(string street, string city, string postalCode)
            {
                Street = street;
                City = city;
                PostalCode = postalCode;
            }
            public override string ToString()
            {
                return $"{Street}, {City}, {PostalCode}";
            }
        }


        struct Person
        {
            public string FirstName { get; }
            public string LastName { get; }
            public Address Address { get; }

            public Person(string firstName, string lastName, Address address)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}, Address: {Address}";
            }
        }
    }
}




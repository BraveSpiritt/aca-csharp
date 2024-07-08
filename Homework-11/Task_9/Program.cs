namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structs-----------------\nStructs do not support inheritance (i.e., you cannot inherit from one struct to create another). However, they can implement interfaces.\nStructs are value types and are usually allocated on the stack. This makes them efficient for small data structures.\n When you assign one struct to another, a copy of the entire data is made. Changes to one instance do not affect the other.\nStructs cannot have a parameterless constructor. The default constructor is automatically provided and initializes all members to their default values.\nClasses-------\nlasses are reference types and are allocated on the heap. Variables of class types store references to the actual data, not the data itself.\nWhen you assign one class variable to another, only the reference is copied. Both variables refer to the same object, so changes to one instance affect the other.\nClasses support inheritance, allowing you to create a new class based on an existing class. This allows for polymorphism and code reuse.\n Classes can have multiple constructors, including a parameterless constructor. You can define custom constructors to initialize class members.");
        }
    }
}

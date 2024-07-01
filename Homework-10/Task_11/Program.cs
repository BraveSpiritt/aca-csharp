namespace Task_11
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var personInfo = GetPersonInfo("Henrik Mkhitaryan", 33);
            Console.WriteLine($"Name: {personInfo.Name}, Age: {personInfo.Age}, IsAdult: {personInfo.IsAdult}");
        }

        public static (string Name, int Age, bool IsAdult) GetPersonInfo(string name, int age)
        {
            bool isAdult = age >= 18;
            return (name, age, isAdult);
        }
    }

}


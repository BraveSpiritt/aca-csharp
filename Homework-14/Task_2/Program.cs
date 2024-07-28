namespace Task_2
{
    internal class Program
    {
        interface IAnimal
        {
             void Eat();
            void Sleep();
        }

        public class Dog : IAnimal
        {
            void IAnimal.Eat()
            {
                Console.WriteLine("Dog is eating");
            }
            void IAnimal.Sleep()
            {
                Console.WriteLine("Dog is sleeping");
            }
        }


        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            IAnimal animal = myDog;
            animal.Eat();
            animal.Sleep();
        }
    }
}

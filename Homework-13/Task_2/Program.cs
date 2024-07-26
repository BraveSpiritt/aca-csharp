namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Animal dog = new Dog();
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();
            Animal bird = new Bird();
            bird.MakeSound();
        }
        public abstract class Animal
        {
            public abstract void MakeSound();
        }
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof! Woof!");
            }
        }
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow! Meow!");
            }
        }
        public class Bird : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Chirp! Chirp!");
            }
        }
    }
}



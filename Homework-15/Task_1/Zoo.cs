using System.Collections;

namespace Task_1
{
        public class Zoo : IEnumerable<Animal>
        {
            private readonly List<Animal> animals = new List<Animal>();

            public void AddAnimal(string name, string nickname)
            {
                animals.Add(new Animal { Name = name, Nickname = nickname });
            }

            public IEnumerator<Animal> GetEnumerator()
            {
                return new Zookeeper(animals);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
}

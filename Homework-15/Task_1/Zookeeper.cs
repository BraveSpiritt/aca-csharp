﻿using System.Collections;

namespace Task_1
{
    class Zookeeper : IEnumerator<Animal>
    {
        private readonly List<Animal> animals;
        private int currentIndex = -1;
        public Zookeeper(List<Animal> animals)
        {
            this.animals = animals;
        }
        public Animal Current => animals[currentIndex];
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < animals.Count;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public void Dispose() { }
    }
}

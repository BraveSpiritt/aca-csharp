namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new CustomLinkedList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            Console.WriteLine("Contains 20: " + myList.Contains(20));
            Console.WriteLine("Contains 40: " + myList.Contains(40));

            myList.Remove(20);
            Console.WriteLine("Contains 20 after removal: " + myList.Contains(20));

            foreach (var value in myList)
            {
                Console.Write(value + " "); // 10 30
            }
        }
    }
    public class CustomLinkedList<T>
    {
        private Node head;

        private class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }
        }

        public bool Remove(T value)
        {
            if (head == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(head.Value, value))
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Value, value))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return false;
            }

            current.Next = current.Next.Next;
            return true;
        }

        public bool Contains(T value)
        {
            Node current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
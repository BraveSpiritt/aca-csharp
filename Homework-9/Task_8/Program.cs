class Program
{
    static void Main()
    {
        int[] array = new int[3];
        Console.WriteLine("Input 3 elements in the array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] frequency = new int[array.Length];
        bool[] visited = new bool[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (visited[i] == true)
                continue;

            int count = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            frequency[i] = count;
        }
        Console.WriteLine("Frequency of all elements of the array:");
        for (int i = 0; i < array.Length; i++)
        {
            if (!visited[i])
            {
                Console.WriteLine("{0} occurs {1} time(s).", array[i], frequency[i]);
            }
        }
    }
}
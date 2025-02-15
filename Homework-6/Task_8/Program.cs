﻿namespace Task_8
{
    internal class Program
    {
        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers from range ({0}, {1})", 0, n);
            for (var i = 0u; i < n; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadLine();
        }
    }
}
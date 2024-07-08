namespace Task_19
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Money usdAmount = new Money(100.50m);
            Money eurAmount = new Money(85.75m);
            Money totalAmount = usdAmount.Add(eurAmount);
            Money differenceAmount = usdAmount.Subtract(eurAmount);

            Console.WriteLine($"USD Amount: {usdAmount}");
            Console.WriteLine($"EUR Amount: {eurAmount}");
            Console.WriteLine($"Total Amount (USD + EUR): {totalAmount}");
            Console.WriteLine($"Difference Amount (USD - EUR): {differenceAmount}");
        }
        struct Money
        {
            public decimal Amount { get; }

            public Money(decimal amount)
            {
                Amount = amount;
            }

            public Money Add(Money other)
            {
                return new Money(Amount + other.Amount);
            }

            public Money Subtract(Money other)
            {
                return new Money(Amount - other.Amount);
            }
            public override string ToString()
            {
                return $"{Amount:C}";
            }
        }
    }
}

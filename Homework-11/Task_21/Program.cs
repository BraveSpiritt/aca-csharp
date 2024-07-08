namespace Task_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyExchangeRate usdToEurRate = new CurrencyExchangeRate("USD", "EUR", 0.85m);
            CurrencyExchangeRate usdToJpyRate = new CurrencyExchangeRate("USD", "JPY", 110.50m);
            decimal amountInUSD = 100.00m;
            decimal amountInEUR = usdToEurRate.Convert(amountInUSD);
            decimal amountInJPY = usdToJpyRate.Convert(amountInUSD);
            Console.WriteLine($"Amount in USD: {amountInUSD}");
            Console.WriteLine($"Amount in EUR: {amountInEUR}");
            Console.WriteLine($"Amount in JPY: {amountInJPY}");
        }
        struct CurrencyExchangeRate
        {
            public string FromCurrency { get; }
            public string ToCurrency { get; }
            public decimal Rate { get; }
            public CurrencyExchangeRate(string fromCurrency, string toCurrency, decimal rate)
            {
                FromCurrency = fromCurrency;
                ToCurrency = toCurrency;
                Rate = rate;
            }
            public decimal Convert(decimal amount)
            {
                return amount * Rate;
            }
        }
    }
}

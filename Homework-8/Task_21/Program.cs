namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            MakePayment(100.50, PaymentGateway.PayPal);
            MakePayment(75.25, PaymentGateway.Stripe);
            MakePayment(200.75, PaymentGateway.CreditCard);
        }
        public enum PaymentGateway
        {
            PayPal,
            Stripe,
            CreditCard
        }
        public static void MakePayment(double amount, PaymentGateway gateway)
        {
            switch (gateway)
            {
                case PaymentGateway.PayPal:
                    Console.WriteLine($"Processing PayPal payment of ${amount}");
                    break;
                case PaymentGateway.Stripe:
                    Console.WriteLine($"Processing Stripe payment of ${amount}");
                    break;
                case PaymentGateway.CreditCard:
                    Console.WriteLine($"Processing Credit Card payment of ${amount}");
                    break;
                default:
                    throw new ArgumentException("Unsupported payment gateway", nameof(gateway));
            }
        }
    }

}

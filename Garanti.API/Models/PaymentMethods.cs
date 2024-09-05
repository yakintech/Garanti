namespace Garanti.API.Models
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
           Console.WriteLine("Credit card payment process");
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("PayPal payment process");
        }
    }
}

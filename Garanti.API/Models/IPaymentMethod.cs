namespace Garanti.API.Models
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }
}

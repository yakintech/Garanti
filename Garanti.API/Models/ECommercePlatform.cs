namespace Garanti.API.Models
{
    public abstract class ECommercePlatform
    {
        protected IPaymentMethod _paymentMethod;

        public ECommercePlatform(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }


        public abstract void MakePayment(decimal amount);
    }



    public class WebPlatform : ECommercePlatform
    {
        public WebPlatform(IPaymentMethod paymentMethod) : base(paymentMethod)
        {
        }

        public override void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

    public class MobilePlatform : ECommercePlatform
    {
        public MobilePlatform(IPaymentMethod paymentMethod) : base(paymentMethod)
        {
        }

        public override void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}

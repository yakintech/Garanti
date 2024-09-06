using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void setPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }


        public void Checkout(double amount)
        {
            _paymentStrategy.Pay(amount);
        }



    }
}

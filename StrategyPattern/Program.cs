

using StrategyPattern.Models;

ShoppingCart shoppingCart = new ShoppingCart();

//credit card payment
shoppingCart.setPaymentStrategy(new CreditCardPayment());
shoppingCart.Checkout(100);


//paypal payment
shoppingCart.setPaymentStrategy(new PaypalPayment());
shoppingCart.Checkout(200);


//bitcoin payment
shoppingCart.setPaymentStrategy(new BitcoinPayment());
shoppingCart.Checkout(300);


Console.ReadLine();
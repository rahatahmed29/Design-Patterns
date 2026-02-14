// public interface IPaymentStrategy
// {
//     void Pay(int amount);
// }
// public class CreditCardPayment : IPaymentStrategy
// {
//     public void Pay(int amount)
//     {
//         Console.WriteLine($"Payment {amount} using Credit Card has been sucessful");
//     }
// }

// public class PayPalPayment : IPaymentStrategy
// {
//     public void Pay(int amount)
//     {
//         Console.WriteLine($"Payment {amount} using PayPal has been sucessful ");
//     }
// }
// public class PaymentProcessor
// {
//     IPaymentStrategy _strategy;
//     public PaymentProcessor(IPaymentStrategy strategy)
//     {
//       _strategy=strategy;  
//     }
//     public void SetStrategy(IPaymentStrategy strategy)
//     {
//         _strategy=strategy;
//     }
//     public void ProcessPayment(int amount)
//     {
//         _strategy.Pay( amount);
//     }


// }
// class Program
// {
//     public static void Main()
//     {
//       IPaymentStrategy strategy1=new CreditCardPayment();
//       PaymentProcessor processor=new(strategy1);
//       processor.ProcessPayment(500);
//       IPaymentStrategy strategy2=new PayPalPayment();
//       processor.SetStrategy(strategy2);
//       processor.ProcessPayment(900);


//     }
// }
// using System;

// /*
// ====================================================
// ADAPTER DESIGN PATTERN - PAYMENT SYSTEM EXAMPLE
// ====================================================

// PROBLEM (Real Industry Situation):
// ---------------------------------
// Our business system already expects all payment methods
// to have a method called:

//     Pay(double amount)

// This rule is used everywhere in the codebase, so we
// CANNOT change it.

// Now we want to integrate PayPal, but PayPal's API
// uses a DIFFERENT method name:

//     SendMoney(double amount)

// Because the method names don't match, we use
// the ADAPTER DESIGN PATTERN.
// */


// // --------------------------------------------------
// // 1️⃣ PAYMENT CONTRACT (ABSTRACTION)
// // --------------------------------------------------
// /*
// This interface defines WHAT a payment gateway can do.
// It does NOT define HOW payment is done.

// Any payment method that wants to be used by the system
// MUST implement this interface.
// */
// public interface IPaymentGateway
// {
//     void Pay(double amount);
// }


// // --------------------------------------------------
// // 2️⃣ BUSINESS LOGIC (USES ONLY THE INTERFACE)
// // --------------------------------------------------
// /*
// This class represents business logic (Checkout, Order,
// Payment processing etc.)

// IMPORTANT:
// - It does NOT know about CreditCard
// - It does NOT know about PayPal
// - It ONLY knows IPaymentGateway

// This makes the system flexible and extensible.
// */
// public class PaymentProcessor
// {
//     public void Process(IPaymentGateway payment, double amount)
//     {
//         // Business logic only calls Pay()
//         payment.Pay(amount);
//     }
// }


// // --------------------------------------------------
// // 3️⃣ CREDIT CARD PAYMENT (DIRECT IMPLEMENTATION)
// // --------------------------------------------------
// /*
// CreditCard already follows the rule:
// It has a Pay() method.

// So NO adapter is needed here.
// */
// public class CreditCard : IPaymentGateway
// {
//     public void Pay(double amount)
//     {
//         Console.WriteLine($"Paid {amount} using Credit Card");
//     }
// }


// // --------------------------------------------------
// // 4️⃣ THIRD-PARTY PAYPAL CLASS (CANNOT BE CHANGED)
// // --------------------------------------------------
// /*
// This simulates a real PayPal SDK.

// Problems:
// - Method name is SendMoney()
// - Does NOT match Pay()

// We are NOT allowed to modify this class.
// */
// public class PayPal
// {
//     public void SendMoney(double amount)
//     {
//         Console.WriteLine($"Paid {amount} using PayPal");
//     }
// }


// // --------------------------------------------------
// // 5️⃣ PAYPAL ADAPTER (CORE OF ADAPTER PATTERN)
// // --------------------------------------------------
// /*
// This class is the ADAPTER.

// ROLE:
// - Looks like IPaymentGateway to our system
// - Internally uses PayPal
// - Translates Pay() -> SendMoney()
// */
// public class PayPalAdapter : IPaymentGateway
// {
//     // Holds the real PayPal object
//     private PayPal _paypal;

//     // Adapter receives PayPal object from outside
//     public PayPalAdapter(PayPal paypal)
//     {
//         _paypal = paypal;
//     }

//     // This method is called by the business system
//     public void Pay(double amount)
//     {
//         // Adapter translates the call
//         _paypal.SendMoney(amount);
//     }
// }


// // --------------------------------------------------
// // 6️⃣ PROGRAM ENTRY POINT
// // --------------------------------------------------
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create third-party PayPal object
//         PayPal paypal = new PayPal();

//         // Wrap PayPal inside Adapter
//         IPaymentGateway paypalAdapter = new PayPalAdapter(paypal);

//         // Create CreditCard payment (no adapter needed)
//         IPaymentGateway creditCard = new CreditCard();

//         // Business service
//         PaymentProcessor processor = new PaymentProcessor();

//         // Pay using PayPal (via adapter)
//         processor.Process(paypalAdapter, 500.00);

//         // Pay using Credit Card
//         processor.Process(creditCard, 200.00);
//     }
// }

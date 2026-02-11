// /*
//  * Notification System - Factory Method Pattern
//  * --------------------------------------------
//  * PURPOSE:
//  * This system provides a flexible way to handle notifications (Email, SMS, Push).
//  * Each notification supports three operations:
//  *   1. Send the notification
//  *   2. Log the notification
//  *   3. Save the notification to a database
//  *
//  * DESIGN PATTERN USED:
//  * Factory Method Pattern
//  * - ISend, ILog, ISave define contracts (interfaces).
//  * - EmailNotify, SMSNotify, PushNotify implement these contracts.
//  * - NotifyContext acts as an orchestrator that executes Send → Log → Save.
//  * - Factories (EmailNotifyContextCreator, SMSNotifyContextCreator, PushNotifyContextCreator)
//  *   are responsible for creating and configuring NotifyContext objects.
//  *
//  * BENEFIT:
//  * New notification types (e.g., WhatsApp) can be added easily by:
//  *   - Implementing ISend, ILog, ISave
//  *   - Creating a new factory
//  * without modifying existing code (Open/Closed Principle).
//  */

// /// <summary>
// /// Defines a contract for sending notifications.
// /// </summary>
// public interface ISend
// {
//     /// <summary>
//     /// Sends the notification.
//     /// </summary>
//     void Send();
// }

// /// <summary>
// /// Defines a contract for logging notifications.
// /// </summary>
// public interface ILog
// {
//     /// <summary>
//     /// Logs the notification details.
// /// </summary>
//     void Log();
// }

// /// <summary>
// /// Defines a contract for saving notifications to a persistent store (e.g., database).
// /// </summary>
// public interface ISave
// {
//     /// <summary>
//     /// Saves the notification data.
//     /// </summary>
//     void Save();
// }

// /// <summary>
// /// Represents an Email notification.
// /// Implements sending, logging, and saving.
// /// </summary>
// public class EmailNotify : ISend, ILog, ISave
// {
//     /// <summary>
//     /// The recipient email address.
//     /// </summary>
//     public required string Email { get; set; }

//     /// <inheritdoc />
//     public void Send() => Console.WriteLine("Sending email to " + Email);

//     /// <inheritdoc />
//     public void Log() => Console.WriteLine("Logging email to " + Email);

//     /// <inheritdoc />
//     public void Save() => Console.WriteLine("Saving db to " + Email);
// }

// /// <summary>
// /// Represents an SMS notification.
// /// Implements sending, logging, and saving.
// /// </summary>
// public class SMSNotify : ISend, ILog, ISave
// {
//     /// <summary>
//     /// The recipient phone number (stored in Email property for simplicity).
//     /// </summary>
//     public required string Email { get; set; }

//     /// <inheritdoc />
//     public void Send() => Console.WriteLine("Sending SMS to " + Email);

//     /// <inheritdoc />
//     public void Log() => Console.WriteLine("Logging SMS to " + Email);

//     /// <inheritdoc />
//     public void Save() => Console.WriteLine("Saving SMS record for " + Email);
// }

// /// <summary>
// /// Represents a Push notification.
// /// Implements sending, logging, and saving.
// /// </summary>
// public class PushNotify : ISend, ILog, ISave
// {
//     /// <summary>
//     /// The target device identifier (stored in Email property for simplicity).
//     /// </summary>
//     public required string Email { get; set; }

//     /// <inheritdoc />
//     public void Send() => Console.WriteLine("Pushing notification to " + Email);

//     /// <inheritdoc />
//     public void Log() => Console.WriteLine("Logging push notification to " + Email);

//     /// <inheritdoc />
//     public void Save() => Console.WriteLine("Saving push record for " + Email);
// }

// /// <summary>
// /// Context class that orchestrates notification operations:
// /// Send → Log → Save.
// /// </summary>
// public class NotifyContext
// {
//     /// <summary>
//     /// The sending behavior.
//     /// </summary>
//     public ISend? SendBehavior { get; set; }

//     /// <summary>
//     /// The logging behavior.
//     /// </summary>
//     public ILog? LogBehavior { get; set; }

//     /// <summary>
//     /// The saving behavior.
//     /// </summary>
//     public ISave? SaveBehavior { get; set; }

//     /// <summary>
//     /// Initializes a new instance of the <see cref="NotifyContext"/> class.
//     /// </summary>
//     /// <param name="send">The send implementation.</param>
//     /// <param name="log">The log implementation.</param>
//     /// <param name="save">The save implementation.</param>
//     public NotifyContext(ISend send, ILog log, ISave save)
//     {
//         SendBehavior = send;
//         LogBehavior = log;
//         SaveBehavior = save;
//     }

//     /// <summary>
//     /// Executes the notification process: Send → Log → Save.
//     /// </summary>
//     public void Process()
//     {
//         SendBehavior?.Send();
//         LogBehavior?.Log();
//         SaveBehavior?.Save();
//     }
// }

// /// <summary>
// /// Defines a contract for factories that create notification contexts.
// /// </summary>
// public interface INotifyContextCreator
// {
//     /// <summary>
//     /// Creates and configures a notification context.
//     /// </summary>
//     /// <returns>A fully configured <see cref="NotifyContext"/> instance.</returns>
//     NotifyContext Create();
// }

// /// <summary>
// /// Factory that creates a context for Email notifications.
// /// </summary>
// public class EmailNotifyContextCreator : INotifyContextCreator
// {
//     public NotifyContext Create()
//     {
//         return new NotifyContext(
//             new EmailNotify { Email = "test@gmail.com" },
//             new EmailNotify { Email = "test@gmail.com" },
//             new EmailNotify { Email = "test@gmail.com" }
//         );
//     }
// }

// /// <summary>
// /// Factory that creates a context for SMS notifications.
// /// </summary>
// public class SMSNotifyContextCreator : INotifyContextCreator
// {
//     public NotifyContext Create()
//     {
//         return new NotifyContext(
//             new SMSNotify { Email = "test@gmail.com" },
//             new SMSNotify { Email = "test@gmail.com" },
//             new SMSNotify { Email = "test@gmail.com" }
//         );
//     }
// }

// /// <summary>
// /// Factory that creates a context for Push notifications.
// /// </summary>
// public class PushNotifyContextCreator : INotifyContextCreator
// {
//     public NotifyContext Create()
//     {
//         return new NotifyContext(
//             new PushNotify { Email = "test@gmail.com" },
//             new PushNotify { Email = "test@gmail.com" },
//             new PushNotify { Email = "test@gmail.com" }
//         );
//     }
// }

// /// <summary>
// /// Entry point of the program.
// /// Demonstrates usage of Factory Method Pattern for different notification types.
// /// </summary>
// class Program
// {
//     public static void Main()
//     {
//         // 1. Create Email notification context and process it
//         INotifyContextCreator emailContextCreator = new EmailNotifyContextCreator();
//         NotifyContext emailContext = emailContextCreator.Create();
//         emailContext.Process();

//         // 2. Create SMS notification context and process it
//         INotifyContextCreator smsContextCreator = new SMSNotifyContextCreator();
//         NotifyContext smsContext = smsContextCreator.Create();
//         smsContext.Process();

//         // 3. Create Push notification context and process it
//         INotifyContextCreator pushContextCreator = new PushNotifyContextCreator();
//         NotifyContext pushContext = pushContextCreator.Create();
//         pushContext.Process();
//     }
// }

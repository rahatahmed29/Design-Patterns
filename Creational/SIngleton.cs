// using System;
// using System.Threading;

// /// <summary>
// /// Singleton Example: Logger class
// /// This class ensures that only one Logger instance can exist in the entire program.
// /// It is thread-safe and globally accessible.
// /// </summary>
// public class Logger
// {
//     // STEP 1: Private constructor prevents others from creating objects using 'new'.
//     // So, only this class controls when and how the object is created.
//     private Logger()
//     {
//         Console.WriteLine("Logger created");
//     }

//     // STEP 2: Static variable to hold the single instance of Logger.
//     // 'null' means no instance has been created yet.
//     public static Logger? _instance = null;

//     // STEP 3: A lock object used to make the GetInstance() method thread-safe.
//     // 'readonly' ensures the lock object reference can’t change.
//     public static readonly object _lock = new object();

//     // STEP 4: Public method to provide a global access point to the Logger instance.
//     public static Logger GetInstance()
//     {
//         // First check – avoids locking unnecessarily once the instance is created.
//         if (_instance == null)
//         {
//             // 'lock' ensures that only one thread at a time can create the instance.
//             lock (_lock)
//             {
//                 // Double-check – ensures thread safety even when multiple threads reach here at the same time.
//                 if (_instance == null)
//                     _instance = new Logger();  // Create the singleton instance
//             }
//         }
//         // Return the same instance every time
//         return _instance;
//     }

//     // STEP 5: A simple method to simulate logging messages.
//     public void Log(string msg)
//     {
//         Console.WriteLine(msg);
//     }
// }


// /// <summary>
// /// Testing the Singleton behavior
// /// </summary>
// class Program
// {
//     public static void Main()
//     {
//         // Creating multiple references
//         Logger log1 = Logger.GetInstance();
//         Logger log2 = Logger.GetInstance();
//         Logger log3 = Logger.GetInstance();

//         // All will point to the SAME object
//         log1.Log("From 1");
//         log2.Log("From 2");
//         log3.Log("From 3");

//         // Creating multiple threads to test thread safety
//         Thread thread1 = new Thread(() => { Logger.GetInstance(); });
//         Thread thread2 = new Thread(() => { Logger.GetInstance(); });
//         Thread thread3 = new Thread(() => { Logger.GetInstance(); });

//         // Start the threads
//         thread1.Start();
//         thread2.Start();
//         thread3.Start();

//         // Wait for all threads to complete
//         thread1.Join();
//         thread2.Join();
//         thread3.Join();
//     }
// }

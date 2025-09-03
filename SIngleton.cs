// public class Logger
// {
//     private Logger()
//     {
//         Console.WriteLine("Logger created");
//     }
//     public static Logger? _instance = null;
//     public static readonly object _lock = new object();
//     public static Logger GetInstance()
//     {
//         if (_instance == null)
//         {
//             lock (_lock)
//             {
//                 if (_instance == null)
//                     _instance = new Logger();
//             }
//         }
//         return _instance;
//     }
//     public void Log(string msg)
//     {
//         Console.WriteLine(msg);
//     }

// }

// class Program
// {
//     public static void Main()
//     {


//         Logger log1 = Logger.GetInstance();
//         Logger log2 = Logger.GetInstance();
//         Logger log3 = Logger.GetInstance();
//         log1.Log("From 1");
//         log2.Log("From 2");
//         log3.Log("From 3");

//         Thread thread1 = new Thread(() =>
//         {
//             Logger.GetInstance();
//         });
//         Thread thread2 = new Thread(() =>
//         {
//             Logger.GetInstance();
//         });
//         Thread thread3 = new Thread(() =>
//         {
//             Logger.GetInstance();
//         });
//         thread1.Start();
//         thread2.Start();
//         thread3.Start();

//         thread1.Join();
//         thread2.Join();
//         thread3.Join();




//     }
// }

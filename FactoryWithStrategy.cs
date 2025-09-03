public interface ISend
{
   public void Send();
}

public interface ILog
{
    public void Log();
}

public interface ISave
{
    public void Save();
}


public class EmailNotify : ISend, ILog, ISave
{
    public required string Email { get; set;}
      public void Send() {
        Console.WriteLine("Sending email to " + Email);
    }

    public void Log() {
        Console.WriteLine("Logging email to " + Email);
    }

    public void Save() {
        Console.WriteLine("Saving db to " + Email);
    }
}

public class SMSNotify : ISend, ILog, ISave
{
        public required string Email { get; set;}

     public void Send()
    {
        Console.WriteLine("Sending email to " + Email);
    }

    public void Log() {
        Console.WriteLine("Logging email to " + Email);
    }

    public void Save() {
        Console.WriteLine("Saving db to " + Email);
    }
}

public class PushNotify : ISend, ILog, ISave
{
    public required string Email { get; set; }

    public void Send()
    {
        Console.WriteLine("Pushing email to " + Email);
    }

    public void Log()
    {
        Console.WriteLine("Pushing email to " + Email);
    }

    public void Save()
    {
        Console.WriteLine("Pushing db to " + Email);
    }
}
public class NotificatinContext : EmailNotify, SMSNotify, PushNotify
{
    
}
class Program
{
    public static void Main()
    {
        
    }
}
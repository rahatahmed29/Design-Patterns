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
    public required string Email { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending email to " + Email);
    }

    public void Log()
    {
        Console.WriteLine("Logging email to " + Email);
    }

    public void Save()
    {
        Console.WriteLine("Saving db to " + Email);
    }
}

public class SMSNotify : ISend, ILog, ISave
{
    public required string Email { get; set; }

    public void Send()
    {
        Console.WriteLine("Sending email to " + Email);
    }

    public void Log()
    {
        Console.WriteLine("Logging email to " + Email);
    }

    public void Save()
    {
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
public class NotifyContext
{
    public ISend? send { get; set; }
    public ILog? log { get; set; }
    public ISave? save { get; set; }
    public NotifyContext(ISend send, ILog log, ISave save)
    {
        this.send = send;
        this.log = log;
        this.save = save;
    }
    public void Process()
    {
        send.Send();
        log.Log();
        save?.Save();
    }

}

public interface INotifyContextCreator
{
    public NotifyContext Create();
}

public class EmailNotifyContextCreator : INotifyContextCreator
{
    public NotifyContext Create()
    {
        return new NotifyContext(
        new EmailNotify { Email = "test@gmail.com" },
        new EmailNotify { Email = "test@gmail.com" },
        new EmailNotify { Email = "test@gmail.com" }
        );


    }
}


class Program
{
    public static void Main()
    {
        INotifyContextCreator emailContextCreator = new EmailNotifyContextCreator();
        NotifyContext emailContext = emailContextCreator.Create();
        emailContext.Process();

    }
}
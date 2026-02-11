// public interface IDevice
// {
//     void TurnOn();
//     void TurnOff();
//     void SetChannel(int channel);
// }
// public class TV: IDevice
// {
//     public void TurnOn()
//     {
//         Console.WriteLine("TV turned ON");
//     }
//     public void TurnOff()
//     {
//         Console.WriteLine("TV turned OFF");
//     } 
//     public void SetChannel(int channel)
//     {
//         Console.WriteLine("TV channel set to " + channel);
//     }
// }
// public class Radio: IDevice
// {
//     public void TurnOn()
//     {
//         Console.WriteLine("Radio turned ON");
//     }
//     public void TurnOff()
//     {
//         Console.WriteLine("Radio turned OFF");
//     } 
//     public void SetChannel(int channel)
//     {
//         Console.WriteLine("Radio channel set to " + channel);
//     }
// }
//  public abstract class RemoteControl
// {
//     protected IDevice _device;
// public  RemoteControl(IDevice device)
//     {
//         _device = device;
//     }
//     public abstract void PowerOn();
//     public abstract void PowerOff();
//     public abstract void SetChannel(int channel);
// }
// public class BasicRemote : RemoteControl
// {
//     public BasicRemote(IDevice device):base(device){}
//     public override void PowerOn()
//     {
//         _device.TurnOn();
//     }
//     public override void PowerOff()
//     {
//         _device.TurnOff();
//     }
//     public override void SetChannel(int channel)
//     {
//         _device.SetChannel(channel);
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // IDevice tv = new TV();
//         // RemoteControl remote1 = new BasicRemote(tv);
//         // remote1.PowerOn();
//         // remote1.SetChannel(5);
//         // remote1.PowerOff();

//         // IDevice radio = new Radio();
//         // RemoteControl remote2 = new BasicRemote(radio);
//         // remote2.PowerOn();
//         // remote2.SetChannel(10);
//         // remote2.PowerOff();
//         IDevice radio=new Radio();
//         RemoteControl remote=new BasicRemote(radio);
//         remote.PowerOn();
//         remote.SetChannel(7);
        
//     }
// }
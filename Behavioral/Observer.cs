
// public interface IObserver
// {
//     void Update(string message);
// }
// public interface ISubject
// {
//     void Attach(IObserver observer);
//     void Detach(IObserver observer);
//     void Notify();
// }
// public class SocialMediaAccount : ISubject
// {
//     string _user;
    
//     public SocialMediaAccount(string user)
//     {
//         _user=user;
//     }
//     List<IObserver>followers=new List<IObserver>(); 
//     public void Attach(IObserver observer)
//     {
//         followers.Add(observer);
//     }
//      public void Detach(IObserver observer)
//     {
//         followers.Add(observer);
//     }
//     public void CreatePost(string post)
//     {
//         Console.WriteLine($"Post created by {_user} : {post} ");
//        Notify();
//     }
//     public void Notify()
//     {
//          foreach(var follower in followers)
//         {
//             follower.Update($"{_user} posted a new post" );
//         }
//     }


// }

// public class Follower : IObserver
// {
//     string _name;
//     public Follower(string name)
//     {
//         _name=name;
//     }
//     public void Update(string message)
//     {
//         Console.WriteLine($"{_name} recieved a notification: {message}");
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         SocialMediaAccount socialMediaAccount=new SocialMediaAccount("Rahat");
//         IObserver follower1=new Follower("Abir");
//         IObserver follower2=new Follower("Labib");
//         IObserver follower3=new Follower("Salman");
//         socialMediaAccount.Attach(follower1);
//         socialMediaAccount.Attach(follower2);
//         socialMediaAccount.Attach(follower3);
//         socialMediaAccount.CreatePost();

//     }
// }
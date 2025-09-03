// public interface IBurger
// {
//     void Prepare();
// }
// public class BasicBurger : IBurger
// {
//     public void Prepare()
//     {
//         Console.WriteLine("Preparing Basic Burger with bun, patty, and ketchup!");
//     }
// }

// public class StandardBurger : IBurger
// {
//     public void Prepare()
//     {
//                 Console.WriteLine("Preparing Standard Burger with bun, patty, cheese, and lettuce!");


//     }
// }

// public class PremiumBurger : IBurger
// {
//     public void Prepare()
//     {
//         Console.WriteLine("Preparing Premium Burger with gourmet bun, premium patty, cheese, lettuce, and secret sauce!");
//     }
// }

// public class BurgerFactory
// {
//     public IBurger? CreateBurger(string type)
//     {
//         if (type == "Basic") return new BasicBurger();
//         if (type == "Standard") return new StandardBurger();
//         if (type == "Premium") return new PremiumBurger();
//         Console.WriteLine("Invalid burger type");
//         return null;
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         BurgerFactory factory = new BurgerFactory();
//         IBurger burger = factory.CreateBurger("Standard");
//         burger?.Prepare();
//         IBurger burger2 = factory.CreateBurger("Basic");
//                 burger2?.Prepare();

//     }
// }
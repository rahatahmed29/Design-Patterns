// using System.Security.Cryptography.X509Certificates;

// public interface IClonable
// {
//     IClonable Clone();
// }
// public class NPC : IClonable
// {
//     string name;
//     int power;
//     int health;
//     int Attack;
//     int Defense;
//     public NPC(
//     string name, int power, int health, int Attack, int Defense)
//     {
//         //Expensive operations (DB connection, complex calculations etc)
//         this.name = name;
//         this.power = power;
//         this.health = health;
//         this.Attack = Attack;
//         this.Defense = Defense;
//         Console.WriteLine("Setting up template NPC" + "'" + name + "'");
//     }
//     public NPC(NPC other)
//     {
//         name = other.name;
//         power = other.power;
//         health = other.health;
//         Attack = other.Attack;
//         Defense = other.Defense;
//         Console.WriteLine("Cloning NPC '" + name + "'");
//     }

//     public IClonable Clone()
//     {
//         return new NPC(this);
//     }
//     public void Describe()
//     {
//         Console.WriteLine("NPC "+name+ "[HP="+health+"ATK="+Attack+"DEF="+Defense+"]");
//     }
//     public void SetName(string name)
//     {
//         this.name = name;
// }


// }

// class Program
// {
//     public static void Main()
//     {
//         NPC alien = new NPC("Alien", 30, 5, 2, 6);
//         NPC alien2 = (NPC)alien.Clone();
//         alien2.SetName("Alien2");
//         alien.Describe();
//         alien2.Describe();
//     }
// }

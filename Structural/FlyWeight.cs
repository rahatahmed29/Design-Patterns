// public interface ICharacter
// {
//     void Display(int x, int y);
// }
// public class CharacterFlyWeight : ICharacter
// {
//     char _symbol;
//     string _font;
//     public CharacterFlyWeight(char symbol, string font)
//     {
//         _symbol = symbol;
//         _font = font;

//     }
//     public void Display(int x, int y)
//     {
//         Console.WriteLine($"Draw {_symbol} at {x} , {y} which has font: {_font}");
//     }
// }
// public class CharacterFactory
// {
//     private Dictionary<char, ICharacter> cache = new();
//     public ICharacter getCharacter(char c)
//     {
//         if (!cache.ContainsKey(c))
//         {
//             cache[c] = new CharacterFlyWeight(c, "Arial");
//         }
//         return cache[c];

//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         CharacterFactory factory = new CharacterFactory();
//         ICharacter c = factory.getCharacter('A');
//         c.Display(10, 20);

//         c.Display(15, 20);
//         c = factory.getCharacter('B');
//         c.Display(11, 22);

//     }
// }
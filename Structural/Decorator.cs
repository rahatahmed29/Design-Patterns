// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler

// using System;

// public interface ICoffe
// {
//     string GetDescription();
//     double GetCost();

// }

// public class SimpleCoffe: ICoffe
// {
//     public string GetDescription()
//     {
//         return "Simple Coffe";
//     }
//     public double GetCost()
//     {
//         return 5.0;
//     }
// }
// public abstract class CoffeDecorator : ICoffe
// {
//     public ICoffe _decoratedCoffe;
//     public CoffeDecorator(ICoffe coffe){
//         _decoratedCoffe=coffe;
//     }
    
//     public virtual string GetDescription()
//     {
//         return _decoratedCoffe.GetDescription() ;
//     }
//     public virtual double GetCost()
//     {
//         return _decoratedCoffe.GetCost();
//     }
    
// }
// public class MilkDecorator:CoffeDecorator{
    
//     public MilkDecorator(ICoffe coffe):base(coffe){
        
//     }
//     public override string GetDescription()
//     {
//         return _decoratedCoffe.GetDescription()+"Milk" ;
//     }
//      public override double GetCost()
//     {
//         return _decoratedCoffe.GetCost()+100;
//     }
// }

// public class SugarDectorator : CoffeDecorator
// {
//     public SugarDectorator(ICoffe coffe) : base(coffe)
//     {
//     }

//     public override string GetDescription()
//     {
//         return _decoratedCoffe.GetDescription() + " Sugar";
//     }

//     public override double GetCost()
//     {
//         return _decoratedCoffe.GetCost() + 50;
//     }
// }

// public class HorilicsDectorator : CoffeDecorator
// {
//     public HorilicsDectorator(ICoffe coffe) : base(coffe)
//     {
//     }

//     public override string GetDescription()
//     {
//         return _decoratedCoffe.GetDescription() + " Horlics";
//     }

//     public override double GetCost()
//     {
//         return _decoratedCoffe.GetCost() + 150;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//      ICoffe coffe=new SimpleCoffe();
//      Console.WriteLine($"{coffe.GetDescription()} - {coffe.GetCost()}");
//      ICoffe MilkCoffe=new MilkDecorator(coffe);
//      Console.WriteLine($"{MilkCoffe.GetDescription()} - {MilkCoffe.GetCost()}");

//     }
// }
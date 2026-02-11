// using System;
// public class OrderRequest
// {
//     public string Name { get; } = "Rahat";
//     public string CardNumber { get; } = "1234";
//     public float Amount { get; } = 20.99f;
//     public string Address { get; } = "123 Springfield Way, Texas";
//     // item ids user wants to order
//     public string[] ItemIds { get; } = { "123", "423", "555", "989" };
// }

// public class Authenticate
// {
//     public string _Name;
//     public Authenticate(string Name)
//     {
//         _Name = Name;
//         Console.WriteLine("Authenticating user" + _Name);

//     }


// }

// public class Inventory
// {

//     public bool CheckInventory(string ItemId)
//     {
//         return true;
//     }
//     public void ReturnInventory(string ItemId, int amount)
//     {

//         Console.WriteLine("Reducing inventory of " + ItemId + " by " + amount);

//     }
// }

// public class Payment
// {

//     private readonly string _name;
//     private readonly string _cardNumber;
//     private readonly float _amount;
//     public Payment(string name, string cardNumber, float amount)
//     {
//         _name = name;
//         _cardNumber = cardNumber;
//         _amount = amount;

//     }
//     public void Pay()
//     {

//         Console.WriteLine("Charging card with name" + _name);
//     }

// }


// public class OrderFulfillment
// {


//     private Inventory _inventory;
//     public OrderFulfillment(Inventory inventory)
//     {

//         _inventory = inventory;

//     }

//     public void Fulfill(string name, string address, string[] items)
//     {


//         Console.WriteLine("Inserting order into database");
//         foreach (var item in items)
//         {

//             _inventory.ReturnInventory(item, 1);
//         }

//     }

// }

// public class OrderService
// {

//     public void Order(OrderRequest orderReq)
//     {

//         Authenticate auth = new Authenticate(orderReq.Name);
//         Inventory inventory = new Inventory();
//         foreach (var id in orderReq.ItemIds)
//         {
//             inventory.CheckInventory(id);


//         }
//         Payment payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);

//         payment.Pay();
//         OrderFulfillment orderFulfillment = new OrderFulfillment(inventory);
//         orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);


//     }


// }






// public class Program
// {
//     public static void Main(string[] args)
//     {
 

//         OrderRequest orderReq = new OrderRequest();

//         OrderService orderService = new OrderService();

//         orderService.Order(orderReq);
//     }



// }

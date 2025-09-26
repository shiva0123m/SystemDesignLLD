using System;
namespace InterfaceSegmentedPrinciple
{
    class Restaurent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restaurant is open!");
            IWaiter waiter = new Waiter();
            waiter.TakeOrder();
            waiter.ServeFood();
            waiter.CleanTable();

            IChef chef = new Chef();
            chef.PrepareFood();
            chef.CookFood();
            chef.CleanKitchen();

            Console.WriteLine("Interface Segregation Principle completed.!");
        }
    }
}
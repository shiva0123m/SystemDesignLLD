using System;
namespace InterfaceSegmentedPrinciple
{
    public class Waiter : IWaiter
    {
        public void ServeFood()
        {
            Console.WriteLine("Waiter is serving food.");
        }

        public void TakeOrder()
        {
            Console.WriteLine("Waiter is taking order.");
        }

        public void CleanTable()
        {
            Console.WriteLine("Waiter is cleaning the table.");
        }
    }
}
using System;
namespace InterfaceSegmentedPrinciple
{
    public class Chef : IChef
    {
        public void PrepareFood()
        {
            Console.WriteLine("Chef is preparing food.");
        }

        public void CookFood()
        {
            Console.WriteLine("Chef is cooking food.");
        }

        public void CleanKitchen()
        {
            Console.WriteLine("Chef is cleaning the kitchen.");
        }
    }
}
using System;
using DecoratorDesign.BehaviouralDesign.Base;
using DecoratorDesign.BehaviouralDesign.Toppings;

namespace DecoratorDesign.BehaviouralDesign
{
    public class Billing
    {
        public static void Main(string[] args)
        {
            BasePizza pizza = new Extracheese(new VegPizza());  // Veg pizza with extra cheese
            Console.WriteLine("Total Cost: " + pizza.Cost());  // Print the total cost
        }
    }
}

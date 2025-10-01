using System;

public class Dominoz
{
    public static void Main(string[] args)
    {
        BasePizza pizza = new ChickenSauce(new Extracheese(new Margerita()));
        Console.WriteLine("Cost of Pizza: " + pizza.GetCost());        
    }
}
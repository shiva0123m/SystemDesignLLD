using System;

public class ChickenSauce : Toppings
{
    private BasePizza _basePizza;

    public ChickenSauce(BasePizza basePizza)
    {
        _basePizza = basePizza;
    }

    public override int GetCost()
    {
        return 50 + _basePizza.GetCost();
    }
}
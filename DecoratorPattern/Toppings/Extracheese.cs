using System;

public class Extracheese : Toppings
{
    private BasePizza _basePizza;

    public Extracheese(BasePizza basePizza)
    {
        _basePizza = basePizza;
    }

    public override int GetCost()
    {
        return 20 + _basePizza.GetCost();
    }
}
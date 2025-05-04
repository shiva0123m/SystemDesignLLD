using DecoratorDesign.BehaviouralDesign.Base;

namespace DecoratorDesign.BehaviouralDesign.Toppings
{
    public class Extracheese : Topps
    {
        public Extracheese(BasePizza pizza) : base(pizza) { }

        public override int Cost()
        {
            return base.pizza.Cost() + 10;
        }
    }
}

using DecoratorDesign.BehaviouralDesign.Base;

namespace DecoratorDesign.BehaviouralDesign.Toppings
{
    public abstract class Topps : BasePizza
    {
        protected BasePizza pizza;

        public Topps(BasePizza pizza)
        {
            this.pizza = pizza;
        }

        public override int Cost()
        {
            return this.pizza.Cost();
        }
    }
}

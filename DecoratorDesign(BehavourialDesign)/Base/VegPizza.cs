using System;

namespace DecoratorDesign.BehaviouralDesign.Base
{
    public class VegPizza : BasePizza
    {
        public override int Cost()
        {
            return 200;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Design
{
    public class ShapeFactory
    {
        public Shape GetShape(String input)
        {
           switch(input)
            {
                case "Rectangle":
                    return new Rectangle();

                case "Circle":
                    return new Circle();

                default:
                    return null;
            }
        }
    }
}

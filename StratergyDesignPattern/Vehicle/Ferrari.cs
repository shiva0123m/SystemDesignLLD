using System;
using StratergyDesignPattern.Stratergy;
namespace StratergyDesignPattern.Vehicle
{
    public class Ferrari : Vehicle
    {
        public Ferrari() : base(new Sports())
        {
        }
    }
}
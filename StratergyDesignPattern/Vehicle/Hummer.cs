using System;
using StratergyDesignPattern.Stratergy;
namespace StratergyDesignPattern.Vehicle
{
    public class Hummer : Vehicle
    {
        public Hummer() : base(new OffRoad())
        {
        }
    }
}
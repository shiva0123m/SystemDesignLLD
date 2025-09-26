using System;
using StratergyDesignPattern.Stratergy;
namespace StratergyDesignPattern.Vehicle
{
    public class Maruti : Vehicle
    {
        public Maruti() : base(new Normal())
        {
        }
    }
}
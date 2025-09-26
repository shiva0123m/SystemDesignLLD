using System;
using StratergyDesignPattern.Stratergy;
namespace StratergyDesignPattern.Vehicle
{
    public class Vehicle
    {
        IStratergy strategy;
        public Vehicle(IStratergy strategy)
        {
            this.strategy = strategy;
        }
        public void Drive()
        {
            strategy.Drive();
        }

    }
}
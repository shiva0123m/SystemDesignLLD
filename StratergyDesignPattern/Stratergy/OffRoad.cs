using System;
namespace StratergyDesignPattern.Stratergy
{
    public class OffRoad : IStratergy
    {
        public void Drive()
        {
            Console.WriteLine("OffRoad Drive");
        }
    }
}
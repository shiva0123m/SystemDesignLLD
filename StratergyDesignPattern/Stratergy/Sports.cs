using System;
namespace StratergyDesignPattern.Stratergy
{
    public class Sports : IStratergy
    {
        public void Drive()
        {
            Console.WriteLine("Sports Drive");
        }
    }
}
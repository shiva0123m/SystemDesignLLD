using System;
namespace StratergyDesignPattern.Stratergy
{
    public class Normal : IStratergy
    {
        public void Drive()
        {
            Console.WriteLine("Normal Drive");
        }
    }
}
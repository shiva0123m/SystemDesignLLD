using ConsoleApp1;
using System;
namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Vehicle ctx = new Alto();
            ctx.drive();

            Vehicle ctx2 = new lexus();
            ctx2.drive();
       
        }
    }
}
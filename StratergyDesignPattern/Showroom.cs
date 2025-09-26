using System;
using StratergyDesignPattern.Stratergy;
using StratergyDesignPattern.Vehicle;
class Showroom
{
    static void Main(string[] args)
    {
        Console.WriteLine("This pattern is implemented when multiple child class need same functionality ");
        Vehicle v = new Hummer();
        v.Drive();
        Vehicle v1 = new Ferrari();
        v1.Drive();

        Vehicle v2 = new Maruti();
        v2.Drive();

        Console.WriteLine("Redudant code is avoided");
    }
}
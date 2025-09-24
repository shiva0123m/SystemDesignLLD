using System;
class Cipla : Mankind
{

    public Cipla(string name) : base(name)
    {
    }
    public void Cold()
    {
        Console.WriteLine("Cipla can treat cold issues. with medicine " + name);
    }
}
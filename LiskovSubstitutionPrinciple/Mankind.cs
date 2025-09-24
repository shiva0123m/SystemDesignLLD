using System;
class Mankind
{
    public string name;
    public Mankind(string name)
    {
        this.name = name;
    }
    public void Sinus()
    {
        Console.WriteLine($"{name} can treat sinus issues.");
    }
}
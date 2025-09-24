using System;

class Patient
{
    Cipla cipla;
    string name;
    public Patient(string name, Cipla cipla)
    {
        this.name = name;
        this.cipla = cipla;
    }

    public void Fever()
    {
        Console.WriteLine($"{name} has fever and it can be treated.");
        cipla.Cold();
        cipla.Sinus();
    }
}
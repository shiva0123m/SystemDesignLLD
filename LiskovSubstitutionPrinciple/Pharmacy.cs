using System;

class Pharmacy
{
    static void Main(string[] args)
    {
        Console.WriteLine("Liskov Substitution Principle");
        Cipla cipla = new Cipla("Paracetamol");

        Patient patient = new Patient("John", cipla);
        patient.Fever();
    }
}
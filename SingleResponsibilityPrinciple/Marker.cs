using System;
class Marker
{
    string Brand;
    string Color;

    public Marker(string brand, string color)
    {
        Brand = brand;
        Color = color;
    }
    public void PrintDetails()
    {
        Console.WriteLine($"Brand: {Brand}, Color: {Color}");
    }

}
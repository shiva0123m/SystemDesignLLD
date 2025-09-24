using System;
class ZMR
{
    public string color;
    int price;

    public ZMR(string color, int price)
    {
        this.color = color;
        this.price = price;
    }
    public void Start()
    {
        Console.WriteLine("ZMR started");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Single Responsibility Principple Demonstration");
        Marker marker = new Marker("Reynolds", "Blue");
        Invoice invoice = new Invoice(marker, 10, 15.5);

        double total = invoice.CalculateTotal();
        Console.WriteLine($"Total Invoice Amount: {total}");

        SaveToDB saveToDB = new SaveToDB();
        saveToDB.SaveInvoice(invoice);
        marker.PrintDetails();
    }
}
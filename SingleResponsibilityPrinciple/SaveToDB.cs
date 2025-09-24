using System;

class SaveToDB
{
    
    public void SaveInvoice(Invoice invoice)
    {
        // Code to save invoice to database
        Console.WriteLine($"Invoice saved to database : {invoice.CalculateTotal()}" );
    }
}
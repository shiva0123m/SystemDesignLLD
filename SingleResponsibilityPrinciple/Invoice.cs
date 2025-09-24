using System;

class Invoice
{
    Marker marker;
    int Quantity;
    double PricePerUnit;

    public Invoice(Marker marker, int quantity, double pricePerUnit)
    {
        this.marker = marker;
        Quantity = quantity;
        PricePerUnit = pricePerUnit;
    }
    public double CalculateTotal()
    {
        return Quantity * PricePerUnit;
    }
}
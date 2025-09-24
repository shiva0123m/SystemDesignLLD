
class DigitalMeter
{
    string meterType;
    int reading;
    ZMR zmr; // Composition with ZMR class
    public DigitalMeter(string meterType, int reading, ZMR zmr)
    {
        this.meterType = meterType;
        this.reading = reading;
        this.zmr = zmr;
    }
    
    public void ShowReading()
    {
        Console.WriteLine("Meter Type: " + meterType + ", Reading: " + reading + " color"+ zmr.color);
    }
}
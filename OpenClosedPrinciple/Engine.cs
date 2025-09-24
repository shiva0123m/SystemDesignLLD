

class Engine
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adding New feature to our zmr !");
        ZMR zmr = new ZMR("Red", 5000);
        DigitalMeter digitalMeter = new DigitalMeter("Digital", 100, zmr);
        zmr.Start();
        digitalMeter.ShowReading();
        Console.WriteLine("Open Closed Principle implemented successfully!");
    }
}
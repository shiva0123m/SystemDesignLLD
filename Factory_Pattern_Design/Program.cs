using Factory_Pattern_Design;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();
        Shape sp = factory.GetShape("Rectangle");
        sp.draw();
    }
}
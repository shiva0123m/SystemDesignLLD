class Program
{
    static void Main()
    {
        Console.Write("Enter Player 1 Name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter Player 2 Name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"Game board size will be {n}x{m}");

        Game game = new Game(name1, name2, n, m);
        game.Start();
    }
}

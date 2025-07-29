public class Game
{
    private Player player1;
    private Player player2;
    private Player currentPlayer;
    private Board board;

    public Game(string name1, string name2, int rows, int cols)
    {
        player1 = new Player(name1, 'X');
        player2 = new Player(name2, 'O');
        currentPlayer = player1;
        board = new Board(rows, cols);
    }

    public void Start()
    {
        board.Print();

        while (true)
        {
            Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol}):");
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int col = int.Parse(Console.ReadLine());

            if (!board.MakeMove(row, col, currentPlayer.Symbol))
            {
                Console.WriteLine("Invalid move, try again.");
                continue;
            }

            board.Print();

            if (board.CheckWin(row, col, currentPlayer.Symbol))
            {
                Console.WriteLine($"{currentPlayer.Name} wins!");
                break;
            }

            if (board.IsFull())
            {
                Console.WriteLine("It's a draw!");
                break;
            }

            SwitchTurn();
        }
    }

    private void SwitchTurn()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }
}

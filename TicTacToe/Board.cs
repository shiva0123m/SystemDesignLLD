public class Board
{
    private char[][] grid;
    private int rows;
    private int cols;

    public Board(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        grid = new char[rows][];
        for (int i = 0; i < rows; i++)
        {
            grid[i] = new char[cols];
            for (int j = 0; j < cols; j++)
                grid[i][j] = ' ';
        }
    }

    public bool MakeMove(int row, int col, char symbol)
    {
        if (row >= 0 && row < rows && col >= 0 && col < cols && grid[row][col] == ' ')
        {
            grid[row][col] = symbol;
            return true;
        }
        return false;
    }

    public void Print()
    {
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            Console.Write(" ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(grid[i][j]);
                if (j < cols - 1) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < rows - 1) Console.WriteLine(new string('-', cols * 4 - 3));
        }
    }

    public bool CheckWin(int row, int col, char symbol)
    {
        bool win;

        // Row check
        win = true;
        for (int i = 0; i < cols; i++)
            if (grid[row][i] != symbol) win = false;
        if (win) return true;

        // Column check
        win = true;
        for (int i = 0; i < rows; i++)
            if (grid[i][col] != symbol) win = false;
        if (win) return true;

        // Main diagonal
        if (row == col)
        {
            win = true;
            for (int i = 0; i < rows; i++)
                if (grid[i][i] != symbol) win = false;
            if (win) return true;
        }

        // Anti-diagonal
        if (row + col == rows - 1)
        {
            win = true;
            for (int i = 0; i < rows; i++)
                if (grid[i][rows - 1 - i] != symbol) win = false;
            if (win) return true;
        }

        return false;
    }

    public bool IsFull()
    {
        foreach (var row in grid)
            foreach (var cell in row)
                if (cell == ' ') return false;
        return true;
    }
}

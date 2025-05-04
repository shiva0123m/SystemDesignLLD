using System;
using System.Collections.Generic;

public class Board
{
    private Dictionary<int, int> snakes = new Dictionary<int, int>();
    private Dictionary<int, int> ladders = new Dictionary<int, int>();
    private int size;

    public Board(int size)
    {
        this.size = size;

        // Sample snakes
        snakes[14] = 7;
        snakes[31] = 26;
        snakes[38] = 20;

        // Sample ladders
        ladders[3] = 22;
        ladders[5] = 8;
        ladders[11] = 26;
    }

    public int GetNewPosition(int position)
    {
        if (snakes.ContainsKey(position))
        {
            Console.WriteLine($"Oops! Bitten by a snake at {position}");
            return snakes[position];
        }
        else if (ladders.ContainsKey(position))
        {
            Console.WriteLine($"Yay! Climbed a ladder at {position}");
            return ladders[position];
        }
        return position;
    }

    public int GetSize()
    {
        return size;
    }
}

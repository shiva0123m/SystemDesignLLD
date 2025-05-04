using System;
using System.Collections.Generic;

public class Game
{
    private Queue<Player> players = new Queue<Player>();
    private Board board;
    private Random random = new Random();

    public Game(Board board, List<Player> playerList)
    {
        this.board = board;
        foreach (var player in playerList)
        {
            players.Enqueue(player);
        }
    }

    private int RollDice()
    {
        return random.Next(1, 7);
    }

    public void Play()
    {
        while (true)
        {
            Player current = players.Dequeue();

            Console.WriteLine($"\n{current.Name}'s turn. Press Enter to roll the dice...");
            Console.ReadLine();

            int dice = RollDice();
            Console.WriteLine($"{current.Name} rolled a {dice}");

            int newPosition = current.Position + dice;

            if (newPosition > board.GetSize())
            {
                Console.WriteLine("Can't move! Need exact number to win.");
            }
            else
            {
                newPosition = board.GetNewPosition(newPosition);
                current.Position = newPosition;
                Console.WriteLine($"{current.Name} moved to position {current.Position}");

                if (current.Position == board.GetSize())
                {
                    Console.WriteLine($"\n🎉 {current.Name} wins the game! 🎉");
                    break;
                }
            }

            players.Enqueue(current);
        }
    }
}

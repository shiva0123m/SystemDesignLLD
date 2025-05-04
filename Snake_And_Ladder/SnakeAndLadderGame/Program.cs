using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Board board = new Board(50);

        List<Player> players = new List<Player>
        {
            new Player("Alice"),
            new Player("Bob")
        };

        Game game = new Game(board, players);
        game.Play();
    }
}

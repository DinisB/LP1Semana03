using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("You have to choose two arguments!");
                return;
            }


            GameItem player1 = Enum.Parse<GameItem>(args[0], true);
            GameItem player2 = Enum.Parse<GameItem>(args[1], true);

            GameStatus result = RockPaperScissors(player1, player2);

            Console.WriteLine(result switch
            {
                GameStatus.Draw => "It's a draw!",
                GameStatus.Player1Wins => "Player 1 wins!",
                GameStatus.Player2Wins => "Player 2 wins!",
                _ => "Unexpected result"
            });
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return GameStatus.Draw;
            }
            return (player1, player2) switch
            {
                (GameItem.Rock, GameItem.Scissors) => GameStatus.Player1Wins,
                (GameItem.Scissors, GameItem.Paper) => GameStatus.Player1Wins,
                (GameItem.Paper, GameItem.Rock) => GameStatus.Player1Wins,
                _ => GameStatus.Player2Wins
            };
        }
    }
}

﻿namespace tictactoe
{
    class Program
    {
        public class Game
        {
            private GameBoard gameBoard;
            private Player player1;
            private Player player2;
            private Player currentPlayer;

            public Game(Player player1, Player player2)
            {
                gameBoard = new GameBoard();
                this.player1 = player1;
                this.player2 = player2;
                currentPlayer = player1;
            }

            public void Play()
            {
                while (true)
                {
                    Console.Clear();
                    gameBoard.DisplayBoard();
                    Console.WriteLine($"{currentPlayer.Name}'s ({currentPlayer.Marker}) turn. Choose your position: ");
                    int position;
                    while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 9 || !gameBoard.UpdateBoard(position, currentPlayer.Marker))
                    {
                        Console.WriteLine("Invalid input, please choose an empty position between 1 and 9: ");
                    }

                    if (gameBoard.CheckForWinner())
                    {
                        Console.Clear();
                        gameBoard.DisplayBoard();
                        Console.WriteLine($"{currentPlayer.Name} wins!");
                        break;
                    }

                    if (gameBoard.IsFull())
                    {
                        Console.Clear();
                        gameBoard.DisplayBoard();
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string response = Console.ReadLine();
                if (response?.ToLower() == "y")
                {
                    gameBoard.Reset();
                    currentPlayer = player1;
                    Play();
                }
            }
        }

        public class GameBoard
        {
            private string[] board;

            public GameBoard()
            {
                board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            }

            public void DisplayBoard()
            {
                Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {3} | {4} | {5} ", board[3], board[4], board[5]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {6} | {7} | {8} ", board[6], board[7], board[8]);
            }

            public bool UpdateBoard(int position, string marker)
            {
                if (position >= 1 && position <= 9 && board[position - 1] != "X" && board[position - 1] != "O")
                {
                    board[position - 1] = marker;
                    return true;
                }
                return false;
            }

            public bool CheckForWinner()
            {
                string[][] winningCombinations = new string[][]
                {
                    new string[] { board[0], board[1], board[2] },
                    new string[] { board[3], board[4], board[5] },
                    new string[] { board[6], board[7], board[8] },
                    new string[] { board[0], board[3], board[6] },
                    new string[] { board[1], board[4], board[7] },
                    new string[] { board[2], board[5], board[8] },
                    new string[] { board[0], board[4], board[8] },
                    new string[] { board[2], board[4], board[6] }
                };

                foreach (var combo in winningCombinations)
                {
                    if (combo[0] == combo[1] && combo[1] == combo[2])
                    {
                        return true;
                    }
                }
                return false;
            }

            public bool IsFull()
            {
                foreach (var spot in board)
                {
                    if (spot != "X" && spot != "O")
                    {
                        return false;
                    }
                }
                return true;
            }

            public void Reset()
            {
                board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            }
        }

        public class Player
        {
            public string Name { get; set; }
            public string Marker { get; set; }

            public Player(string name, string marker)
            {
                Name = name;
                Marker = marker;
            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            Console.Write("Enter name for Player 1: ");
            string player1Name = Console.ReadLine();
            Player player1 = new Player(player1Name, "X");

            Console.Write("Enter name for Player 2: ");
            string player2Name = Console.ReadLine();
            Player player2 = new Player(player2Name, "O");

            Game game = new Game(player1, player2);
            game.Play();

            Console.WriteLine("Thanks for playing!");
        }
    }
}

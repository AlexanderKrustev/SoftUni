using System;
using System.Collections.Generic;
using Application2.Models;

namespace Application2
{
    public class Minesweeper
    {


        private static void Main()
        {
            string command = string.Empty;
            char[,] board = Engine.CreateGameBoard();
            char[,] mines = Engine.PlaceMines();
            int counter = 0;
            bool isThereMine = false;
            List<Player> players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isStartOfTheGame = true;
            const int maks = 35;
            bool isGameFinished = false;

            do
            {
                if (isStartOfTheGame)
                {
                    Console.WriteLine(
                        "Let pleay <<Minesweeper>>\nTry to find position without mines." +
                        "\n'top'- show statistics\n'restart'- start new game\n'exit'- exit the game");
                    Engine.dumpp(board);
                    isStartOfTheGame = false;
                }

                Console.Write("Please enter row and column number with : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= board.GetLength(0) && column <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Engine.Staticsitcs(players);
                        break;
                    case "restart":
                        board = Engine.CreateGameBoard();
                        mines = Engine.PlaceMines();
                        Engine.dumpp(board);
                        isThereMine = false;
                        isStartOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Buy! See you soon");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                Engine.NextMove(board, mines, row, column);
                                counter++;
                            }

                            if (maks == counter)
                            {
                                isGameFinished = true;
                            }
                            else
                            {
                                Engine.dumpp(board);
                            }
                        }
                        else
                        {
                            isThereMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Error! This command is invalid");
                        break;
                }

                if (isThereMine)
                {
                    Engine.dumpp(mines);
                    Console.WriteLine("Game Over! Your Score is {0} points. Please enter nickname: ", counter);
                    string playerNickname = Console.ReadLine();
                    Player player = new Player(playerNickname, counter);
                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].PlayerPoints < player.PlayerPoints)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    // shampion4eta.Sort((Player r1, Player r2) => r2.PlayerName.CompareTo(r1.igra4));
                    players.Sort((Player r1, Player r2) => r2.PlayerPoints.CompareTo(r1.PlayerPoints));
                    Engine.Staticsitcs(players);

                    board = Engine.CreateGameBoard();
                    mines = Engine.PlaceMines();
                    counter = 0;
                    isThereMine = false;
                    isStartOfTheGame = true;
                }

                if (isGameFinished)
                {
                    Console.WriteLine("Congratulations! You have opened 35 positions! ");
                    Engine.dumpp(mines);
                    Console.WriteLine("Please enter you name: ");
                    string imeee = Console.ReadLine();
                    Player to4kii = new Player(imeee, counter);
                    players.Add(to4kii);
                    Engine.Staticsitcs(players);
                    board = Engine.CreateGameBoard();
                    mines = Engine.PlaceMines();
                    counter = 0;
                    isGameFinished = false;
                    isStartOfTheGame = true;
                }
            } while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("See you soon");
            Console.Read();
        }

    }
}
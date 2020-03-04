using System;
using RPS.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, Scissors\n-------------------\nPlayer 1, what is your choice? (No peaking p2)");
    string player1Choice = Console.ReadLine();
    Console.WriteLine("Player 2, what is your choice? (No peaking p1)");
    string player2Choice = Console.ReadLine();
    try
    {
      Console.WriteLine($"Winner is: {Game.DetermineWinner(player1Choice, player2Choice)}");
    }
    catch
    {
      Console.WriteLine("Error in user input");
    }
  }
}
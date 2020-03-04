using System;
using RPS.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, Scissors\n-------------------\nWould you like to play one or two player mode? (1/2)");
    string players = Console.ReadLine();
    if (players == "1")
    {
      Console.WriteLine("Player 1, what is your choice?");
      string playerChoice = Console.ReadLine();
      string compChoice = Game.ComputerMove();
      Console.WriteLine("The Computer has chosen " + compChoice);
      Console.WriteLine($"Winner is: {Game.DetermineWinner(playerChoice, compChoice, players)}");
    }
    else if (players == "2")
    {
    Console.WriteLine("Player 1, what is your choice? (No peaking p2)");
    string player1Choice = Console.ReadLine();
    Console.WriteLine("Player 2, what is your choice? (No peaking p1)");
    string player2Choice = Console.ReadLine();
    try
    {
      Console.WriteLine($"Winner is: {Game.DetermineWinner(player1Choice, player2Choice, players)}");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    }
  }
}
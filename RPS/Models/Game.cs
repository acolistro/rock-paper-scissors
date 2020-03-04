using System;

namespace RPS.Models
{
  public class Game
  {
    public static string DetermineWinner(string p1Move, string p2Move)
    {
      if((p1Move == "Rock" && p2Move == "Scissors") || (p1Move == "Scissors" && p2Move == "Paper") || (p1Move == "Paper" && p2Move == "Rock"))
      {
        return "Player 1";
      } else if((p2Move == "Rock" && p1Move == "Scissors") || (p2Move == "Scissors" && p1Move == "Paper") || (p2Move == "Paper" && p1Move == "Rock"))
      {
        return "Player 2";
      }
      else if(p1Move == p2Move)
      {
        return "Draw";
      }
      else
      {
        return "Error";
      }
    }

    public static string ComputerMove()
    {
      Random rnd = new Random();
      int randomMove = rnd.Next(0,3);
      if(randomMove == 0)
      {
        return "Rock";
      }
      else if(randomMove == 1)
      {
        return "Paper";
      }
      else if(randomMove == 2)
      {
        return "Scissors";
      }
      else return "error";
    }
  }
}
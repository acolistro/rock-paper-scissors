using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void DetermineWinner_RockBeatsScissors_Player1()
    {
      string winner = Game.DetermineWinner("Rock", "Scissors");
      Assert.AreEqual("Player 1", winner);
    }
    [TestMethod]
    public void DetermineWinner_ScissorsBeatsPaper_Player1()
    {
      string winner = Game.DetermineWinner("Scissors", "Paper");
      Assert.AreEqual("Player 1", winner);
    }
    [TestMethod]
    public void DetermineWinner_PaperBeatsRock_Player1()
    {
      string winner = Game.DetermineWinner("Paper", "Rock");
      Assert.AreEqual("Player 1", winner);
    }
    [TestMethod]
    public void DetermineWinner_RockBeatsScissors_Player2()
    {
      string winner = Game.DetermineWinner("Scissors", "Rock");
      Assert.AreEqual("Player 2", winner);
    }
    [TestMethod]
    public void DetermineWinner_ScissorsBeatsPaper_Player2()
    {
      string winner = Game.DetermineWinner("Paper", "Scissors");
      Assert.AreEqual("Player 2", winner);
    }
    [TestMethod]
    public void DetermineWinner_PaperBeatsRock_Player2()
    {
      string winner = Game.DetermineWinner("Rock", "Paper");
      Assert.AreEqual("Player 2", winner);
    }
    [TestMethod]
    public void DetermineWinner_PaperAndPaperDraws_Draw()
    {
      string winner = Game.DetermineWinner("Paper", "Paper");
      Assert.AreEqual("Draw", winner);
    }
    [TestMethod]
    public void DetermineWinner_RockAndRockDraws_Draw()
    {
      string winner = Game.DetermineWinner("Rock", "Rock");
      Assert.AreEqual("Draw", winner);
    }
    [TestMethod]
    public void DetermineWinner_ScissorsAndScissors_Draw()
    {
      string winner = Game.DetermineWinner("Scissors", "Scissors");
      Assert.AreEqual("Draw", winner);
    }
  }
}
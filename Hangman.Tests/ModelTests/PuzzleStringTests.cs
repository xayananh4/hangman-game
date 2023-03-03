using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Hangman.Models;
using System;

namespace Hangman.Tests
{
  [TestClass]
  public class PuzzleStringTests
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void PuzzleStringConstructor_CreatesInstanceOfPuzzleString_PuzzleString()
    {
      PuzzleString newPuzzleString = new PuzzleString();
      Assert.AreEqual(typeof(PuzzleString), newPuzzleString.GetType());
    }
    [TestMethod]

    public void PuzzleStringConstructor_ReturnsWithRandomSolution_PuzzleString()
    {
      PuzzleString newPuzzleString = new PuzzleString();

      string result = newPuzzleString.Solution;
      bool hasSolution = false;
      if (Array.IndexOf(PuzzleString.puzzles, result) > -1)
      {
        hasSolution = true;

      }
      Assert.AreEqual(true, hasSolution);
    }

    [TestMethod]

    public void PuzzleString_CheckTypeOfReturn_Array()
    {
      PuzzleString newPuzzleString = new PuzzleString();
      List<int> results = newPuzzleString.CheckLetter('x');
      Assert.AreEqual(typeof(List<int>), results.GetType());
    }

    [TestMethod]

    public void PuzzleStringCheckLetter_CheckCheckIncorrectGuess_Array()
    {
      PuzzleString newPuzzleString = new PuzzleString();
      newPuzzleString.Solution = "hello world";

      List<int> results = newPuzzleString.CheckLetter('x');
      Assert.AreEqual(0, results.Count);
    }

    [TestMethod]

    public void PuzzleStringCheckLetter_CheckCheckCorrectGuess_Array()
    {
      PuzzleString newPuzzleString2 = new PuzzleString();
      newPuzzleString2.Solution = "hello world";

      List<int> results2 = newPuzzleString2.CheckLetter('h');
      Assert.AreEqual(1, results2.Count);
    }

    [TestMethod]

    public void PuzzleStringCheckLetter_CheckForMultipleLetters_Array()
    {
      PuzzleString newPuzzleString = new PuzzleString();
      newPuzzleString.Solution = "Last Tuesday I bought a horse";

      List<int> results = newPuzzleString.CheckLetter('e');
      Assert.AreEqual(2, results.Count);
    }

    [TestMethod]

    public void PuzzleStringCheckLetter_CheckForCorrectIndexes_Array()
    {
      bool matches = false;
      PuzzleString newPuzzleString = new PuzzleString();
      newPuzzleString.Solution = "hello world";

      List<int> results = newPuzzleString.CheckLetter('l');
      if(results.Contains(2) && results.Contains(3) && results.Contains(9))
      {
        matches = true;
      }   
      Assert.AreEqual(true, matches);
    }
  }
}
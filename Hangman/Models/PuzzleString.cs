using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class PuzzleString
  {
    public string Solution { get; set; }
    public static string[] puzzles = {
      "Last Tuesday I bought a horse",
      "We have no guacamole in the pantry",
      "I have a brass waterbed",
    };



    public PuzzleString()
    {
      Random rand = new Random();
      int puzzleIndex  = rand.Next(0, puzzles.Length - 1);
      Solution = puzzles[puzzleIndex];
    }



    public List<int> CheckLetter(char letter)
    {
      char[] splitSolution = Solution.ToCharArray();
      List<int> result = new List<int>() { };
      for (int i = 0; i < splitSolution.Length; i++)
      {
        if(splitSolution[i] ==  letter)
        {
          result.Add(i);
        }

      }
      return result;
      
    }
  }
}

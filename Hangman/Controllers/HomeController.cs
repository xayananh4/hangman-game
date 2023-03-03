using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{ 

    public class HomeController : Controller
    {
      PuzzleString newPuzzleString = new PuzzleString();       


      [HttpGet("/")]
      public ActionResult Index()
      {     
        return View();
      
      }

      [HttpGet("/puzzleword")]
      public ActionResult Create()
      {
        newPuzzleString = new PuzzleString();          
        return View("Index", newPuzzleString.Solution);
      }
      
      [HttpPost("/guess")]
      public ActionResult Create(char guess)
      {
        List<int> matchIndexes = newPuzzleString.CheckLetter(guess);        
        
        return View("Index", newPuzzleString.Solution);
      }



    }
}
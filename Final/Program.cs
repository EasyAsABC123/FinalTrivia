using System;
using System.Collections.Generic;

namespace FinalTrivia
{
  public class Game
  {
    public string Player { get; set; }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter Player Name:");

      // Not currently being used, need to utilize this for random numbers?
      List<int> gamequestionNumbers = new List<int> { 1, 2, 3, 4 };

      Console.WriteLine("Welcome to Triviabate");

      Console.WriteLine("How old are you?");

      // add check to make sure console.ReadLine is working right
      var age = int.Parse(Console.ReadLine());

      if (age <= 17)
      {
        Console.WriteLine("You are not authorized to play this game.You must be 18 or older.");
        // return to exit program
        return;
      }
      else if (age >= 18)
      {
        Console.WriteLine("You're 18 or older let's get the party started!");
      }
      else
      {
        Console.WriteLine("No response was recieved please start over.");
        // return to exit program
        return;
      }

      Console.WriteLine("Choose a username! What would you like your username to be?");
      var str = Console.ReadLine();
      // might need to check if str was read right
      var aGame = new Game() { Player = str };

      //use gamequestionNumbers
      // Run(aGame, gamequestionNumbers);
    }
  }
}
using System;
//using System.Drawing;
using Bakery.Models;

namespace Bakery
{

  class Program
  {
    static void Main()
    {

      Console.Clear();
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");
      Console.WriteLine("\x1b[44m" + new string(' ', 17) + "\x1b[0m\x1b[47m" + new string(' ', 16) + "\x1b[0m\x1b[41m" + new string(' ', 17) + "\x1b[0m");


      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("**~*~~*~~*~~*~~*~~*~<()>~*~~*~~*~~*~~*~~*~~*~~*~**");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("La Mauvaise Boulangerie");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Welcome to the fanciest bakery in all of digital France!");
      Console.WriteLine("Today's specials are:");
      Console.ForegroundColor = ConsoleColor.Yellow;

      Console.WriteLine("All Bread Loaves -- > Buy 2, get one free!");
      Console.WriteLine("All croissants, macarons, éclairs and other pastries-- > Buy 3, get one free!");

      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.WriteLine();
      Console.WriteLine("(Make sure to double-check that you are receiving the best deal,");
      Console.WriteLine("sometimes employees take advantage of ignorant touristes)");
      Console.WriteLine();

      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Bonjour mon ami!");
      Console.WriteLine();

      //bread input
      int breadCount = 0;
      bool validInput = false;
      while (!validInput)
      {
        Console.WriteLine("How many loaves of bread would you like?");
        string bread = Console.ReadLine();
        if (int.TryParse(bread, out breadCount))
        {
          validInput = true;
        }
        else
        {
          Console.WriteLine("Please enter a number.");
        }
      }

      //pastry input
      int pastryCount = 0;
      validInput = false;
      while (!validInput)
      {
        Console.WriteLine("How many pastries would you like (make your own selection)");
        string pastries = Console.ReadLine();
        if (int.TryParse(pastries, out pastryCount))
        {
          validInput = true;
        }
        else
        {
          Console.WriteLine("Please enter a number");
        }
      }
      newBoulangerie.CheckoutTotal = (float)newBoulangerie.CalcTotal(breadCount, pastryCount);
      newBoulangerie.CheckoutMessage = "Have a wonderful rest of your day mon ami!";
      Console.WriteLine();
      Console.WriteLine($"Your excellent selection will cost you ${newBoulangerie.CheckoutTotal}.00");
      Console.WriteLine();


      Console.WriteLine(newBoulangerie.SneakyFrench(breadCount, pastryCount));
      Console.WriteLine();
      Console.WriteLine(newBoulangerie.CheckoutMessage);
      Console.ResetColor();

    }
  }
}

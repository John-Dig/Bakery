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
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Welcome to the fanciest bakery in all of digital France!");
      Console.WriteLine("Today's specials are:");
      Console.ForegroundColor = ConsoleColor.Yellow;

      Console.WriteLine("All Bread Loaves -- > Buy 2, get one free!");
      Console.WriteLine("All pastries croissants, macarons, and éclairs-- > Buy 3, get one free!");

      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.WriteLine();
      Console.WriteLine("(Make sure to double check your order that you are receiving the best deal, the economy is rough and sometime employees take advantage of -ignorant touristes-)");
      //Console.Font = new System.Drawing.Font("Helvetica", 12, System.Drawing.FontStyle.Italic);
      Console.WriteLine();
      Console.ResetColor(); 


      // Game newGame = new Game();
      // string human = Console.ReadLine();
      // string computer = newGame.Evaluate();
      // Console.WriteLine("Computer Choice:" + computer);
      // Console.WriteLine("Human Choice: " + human);
      // string result = newGame.GameEvaluator(computer, human);
      // Console.WriteLine(result);
    }
  }
}
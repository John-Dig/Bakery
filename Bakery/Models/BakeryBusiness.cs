using System;

namespace Bakery.Models
{
  public class Boulangerie //the class for the whole bakery
  {
    public string CheckoutMessage { get; set; }
    public float CheckoutTotal { get; set; }
    public Boulangerie(string checkoutMessage, float checkoutTotal) //constructor for when I instantiate a new Boulangerie
    {
      CheckoutMessage = checkoutMessage;
      CheckoutTotal = checkoutTotal;
    }
    public double CalcTotal(int breadTotal, int pastryTotal) //UPDATE FOR EFFICIENCY! make sure to output rounded to 2 decimals
    {
      double breadOrder = breadTotal;
      int pastryOrder = pastryTotal;
      int breadPrice = 5;
      int pastryPrice = 2;
      // int freeBreadDeal = 3;
      // int freePastryDeal = 4;
      double freeBreadCount = Math.Floor(breadOrder / 3.0); //add converted var later
      double freePastryCount = Math.Floor(pastryOrder / 4.0); //add converted var later
      double breadTotalPrice = Math.Round(((breadOrder - freeBreadCount) * breadPrice), 2);
      double pastryTotalPrice = Math.Round(((pastryOrder - freePastryCount) * pastryPrice), 2);
      return breadTotalPrice + pastryTotalPrice;
    }
    public bool MissingFreeStuff(int breadTotal, int pastryTotal)
    {
      if ((breadTotal + 1) % 3 == 0 || (pastryTotal + 1) % 4 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string SneakyFrench(int breadTotal, int pastryTotal)
    {
      if (MissingFreeStuff(breadTotal, pastryTotal))
      {
        return "Toi, iel touriste, je vais partager ça avec ma copine pendant que nous buvons du vin au bord de la Seine lors de notre soirée romantique ce soir.";

      }
      else
      {
        return "Thank you for your order.";
      }
    }

    public class Bread //class for bread
    {
      public int Count { get; set; }

      public Bread(int count)
      {
        Count = count;
      }
    }
    public class Pastry //class for pastry
    {
      public int Count { get; set; }

      public Pastry(int count)
      {
        Count = count;
      }
    }
  }
}

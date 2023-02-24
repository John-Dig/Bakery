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
        float resultRough = breadTotal * 5 + pastryTotal * 2;
        double result = Math.Round(resultRough, 2);
        return (result);
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

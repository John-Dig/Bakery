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
    public class Bread //class for bread
    {
      public int Count { get; set; }
      public float CalcTotal()
      {
        return (8.99f);
      }
      public Bread(int count)
      {
        Count = count;
      }
    }  
    public class Pastry //class for pastry
    {
      public int Count { get; set; }
      public float CalcTotal()
      {
        return (8.99f);
      }
      public Pastry(int count)
      {
        Count = count;
      }
    }
  }
}  

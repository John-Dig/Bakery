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
      public float CalcBreadTotal()
      {
        return (8.99f);
      }
      public Bread(int count)
      {
        Count = count;
      }
    }
  }
}

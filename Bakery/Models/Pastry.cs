namespace Bakery.Models
{
  public partial class Boulangerie
  {

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
namespace Bakery.Models
{
  public partial class Boulangerie
  {
    public class Bread //class for bread
    {
      public int Count { get; set; }
      public Bread(int count)
      {
        Count = count;
      }
    }
  }
}

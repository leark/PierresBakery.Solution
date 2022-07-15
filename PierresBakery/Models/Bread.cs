namespace Bakery.Models
{
  public class Bread
  {
    public int baseCost = 5;
    public int Count { get; set; }
    public Bread(int count)
    {
      Count = count;
    }

    public int CalculateCost()
    {
      return baseCost * Count;
    }

    public int CalculateWithDiscount()
    {
      return 0;
    }
  }
}
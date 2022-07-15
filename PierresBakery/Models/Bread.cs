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
      // Discount is that every 3rd loaf is free
      return baseCost * Count - (Count / 3 * baseCost);
    }
  }
}
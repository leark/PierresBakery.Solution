namespace Bakery.Models
{
  public class Bread
  {
    private static int _baseCost = 5;
    public int Count { get; set; }
    private static string _discount = "Every 3rd Bread is free";

    public Bread(int count)
    {
      Count = count;
    }

    public int CalculateCost()
    {
      return _baseCost * Count;
    }

    public int CalculateCostWithDiscount()
    {
      // Discount is that every 3rd loaf is free
      return _baseCost * Count - (Count / 3 * _baseCost);
    }

    public static string GetDiscountMessage()
    {
      return _discount;
    }
  }
}
namespace Bakery.Models
{
  public class Pastry
  {
    public int Count { get; set; }
    private static int _baseCost = 2;
    public Pastry(int count)
    {
      Count = count;
    }

    public int CalculateCost()
    {
      return Count * _baseCost;
    }

    public int CalculateCostWithDiscount()
    {
      // every 3rd pastry is $1 off
      return Count * _baseCost - (Count / 3);
    }
  }
}
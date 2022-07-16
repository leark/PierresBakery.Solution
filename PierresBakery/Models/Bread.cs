namespace Bakery.Models
{
  public class Bread : BakeryItem
  {
    protected override int BaseCost
    {
      get { return 5; }
    }
    protected override string DiscountMsg
    {
      get { return "Every 3rd Bread is free"; }
    }

    public Bread(int count) : base(count)
    {
    }

    public override int CalculateCostWithDiscount()
    {
      // Discount is that every 3rd loaf is free
      return BaseCost * Count - (Count / 3 * BaseCost);
    }
  }
}
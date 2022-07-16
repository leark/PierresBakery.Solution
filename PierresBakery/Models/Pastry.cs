namespace Bakery.Models
{
  public class Pastry : BakeryItem
  {
    protected override int BaseCost
    {
      get { return 2; }
    }
    protected override string DiscountMsg
    {
      get { return "Every 3rd Pastry is $1 off"; }
    }

    public Pastry(int count) : base(count)
    {
      Count = count;
    }

    public override int CalculateCostWithDiscount()
    {
      // every 3rd pastry is $1 off
      return Count * BaseCost - (Count / 3);
    }
  }
}

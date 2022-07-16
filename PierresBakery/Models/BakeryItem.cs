public abstract class BakeryItem
{
  public int Count { get; set; }
  protected abstract int BaseCost { get; }
  protected abstract string DiscountMsg { get; }

  public BakeryItem(int count)
  {
    Count = count;
  }

  public int CalculateCost()
  {
    return BaseCost * Count;
  }

  public abstract int CalculateCostWithDiscount();
  public string GetDiscountMessage()
  {
    return DiscountMsg;
  }
}
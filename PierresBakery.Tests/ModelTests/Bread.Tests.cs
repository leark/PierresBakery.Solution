using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Count_ReturnsCount_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.Count);
    }

    [TestMethod]
    public void CalculateCost_ReturnsCalculatedCost_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.CalculateCost());
    }

    [TestMethod]
    public void CalculateWithDiscount_ReturnsCalculatedCostWithDiscount_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.CalculateCostWithDiscount());
      newBread.Count = 4;
      Assert.AreEqual(15, newBread.CalculateCostWithDiscount());
      newBread.Count = 5;
      Assert.AreEqual(20, newBread.CalculateCostWithDiscount());
      newBread.Count = 6;
      Assert.AreEqual(20, newBread.CalculateCostWithDiscount());
    }
  }
}
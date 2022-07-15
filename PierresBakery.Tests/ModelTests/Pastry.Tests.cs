using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Count_ReturnsCount_Int()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(0, newPastry.Count);
    }

    [TestMethod]
    public void CalculateCost_ReturnsCalculatedCost_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.CalculateCost());
      newPastry.Count = 2;
      Assert.AreEqual(4, newPastry.CalculateCost());
    }
  }
}
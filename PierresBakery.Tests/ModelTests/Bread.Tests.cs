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
    public void GetCount_ReturnsCount_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.GetCount());
    }
  }
}
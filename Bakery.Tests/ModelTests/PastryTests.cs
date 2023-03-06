using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod] //3 (moved)
    public void Pastry_CreatesInstanceOfPastry_Class()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(1);
      //act
      //assert
      Assert.AreEqual(typeof(Boulangerie.Pastry), newPastry.GetType());
    }
  }
}
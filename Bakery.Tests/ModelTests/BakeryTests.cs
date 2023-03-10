using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BoulangerieTests
  {
    [TestMethod] //1
    public void Boulangerie_CreatesInstanceOfBoulangerie_Class()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      //act
      //assert
      Console.WriteLine(newBoulangerie.CheckoutTotal);
      Assert.AreEqual(typeof(Boulangerie), newBoulangerie.GetType());
    }
    [TestMethod] //4
    public void CalcTotal_CalculatesTotalForBreadAndPastry_floatOrOtherNumberType()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(2);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(1);
      //act
      double result = newBoulangerie.CalcTotal(newBread.Count, newPastry.Count);
      //assert
      Assert.AreEqual(12.00, result);
    }
    [TestMethod] //5
    public void CalcTotal_CalculatesTotalAndAccountsForSpecialsForBreadAndPastry_floatOrOtherNumberType()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(7);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(8);
      //act
      double result = newBoulangerie.CalcTotal(newBread.Count, newPastry.Count);
      //assert
      Assert.AreEqual(37.00, result);
    }
    [TestMethod] //6
    public void MissingFreeStuff_ReturnsTrueIfNumberSelectedIsNotIncludingAFreeEarnedItem_bool()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(5);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(7);
      //act
      bool result = newBoulangerie.MissingFreeStuff(newBread.Count, newPastry.Count);
      //assert
      Assert.IsTrue(result);
    }
    [TestMethod] //7
    public void SneakyFrench_ReturnsDifferentMessageIfCustomerMissesDiscount_String()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(5);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(7);
      //act
      bool result = newBoulangerie.MissingFreeStuff(newBread.Count, newPastry.Count);
      //assert
      Assert.AreEqual(true, result);
    }
  }
}
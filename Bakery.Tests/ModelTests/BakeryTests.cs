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
    [TestMethod] //2
    public void Bread_CreatesInstanceOfBread_Class()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(1);
      //act
      //assert
      Assert.AreEqual(typeof(Boulangerie.Bread), newBread.GetType());
    }
    [TestMethod] //3
    public void Pastry_CreatesInstanceOfPastry_Class()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(1);
      //act
      //assert
      Assert.AreEqual(typeof(Boulangerie.Pastry), newPastry.GetType());
    }
    [TestMethod] //4
    public void CalcTotal_CalculatesTotalForBreadAndPastry_float()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(1);
      Boulangerie.Pastry newPastry = new Boulangerie.Pastry(1);
      //act
      float result = newBoulangerie.CalcTotal();
      //assert
      Assert.AreEqual(8.99, result);
    }
  }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {


    [TestMethod] //2 (moved)
    public void Bread_CreatesInstanceOfBread_Class()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      Boulangerie.Bread newBread = new Boulangerie.Bread(1);
      //act
      //assert
      Assert.AreEqual(typeof(Boulangerie.Bread), newBread.GetType());
    }
    [TestMethod] //9 
    public void BreadCount_ReturnsBreadCount_Int()
    {
      //arrange
      Boulangerie newBoulangerie = new Boulangerie("default message", 5.55f);
      //act
      Boulangerie.Bread newBread = new Boulangerie.Bread(5);
      //assert
      Assert.AreEqual(5, newBread.Count);
    }
  }
}
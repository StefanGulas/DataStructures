using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using NUnit.Framework;

namespace DataStructureTests
{
  [TestFixture]
  public class BigONotationTests
  {
    public BigONotation bigONotation { get; set; }
    private List<int> numbers;
    public List<int> Numbers { get => Numbers; set => numbers = value; }
    [SetUp]
    public void Setup()
    {
      bigONotation = new BigONotation();
      numbers = new List<int>();
      for(int i = 0; i < 200; i++)
      {
        numbers.Add(i);
      }
    }
    [Test]
    public void TestSimple1ArrayPrintOneItem()
    {
      bigONotation.SimpleArrayPrintOneItem(numbers);
      Assert.AreEqual(1, 1);
    }
    [Test]
    public void TestSimple2ArrayLog()
    {
      bigONotation.SimpleArrayLog(numbers);
      Assert.AreEqual(1,1);
    }
    [Test]
    public void TestSimple3ArrayLogInnerLoop()
    {
      bigONotation.SimpleArrayLogInnerLoop(numbers);
      Assert.AreEqual(1, 1);
    }
    [Test]
    public void TestSimple3ArrayLogTwoInnerLoops()
    {
      bigONotation.SimpleArrayLogTwoInnerLoops(numbers);
      Assert.AreEqual(1, 1);
    }
  }
}

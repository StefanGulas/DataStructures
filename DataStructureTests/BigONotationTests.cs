using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using NUnit.Framework;

namespace DataStructureTests
{
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
      for(int i = 0; i < 1000; i++)
      {
        numbers.Add(i);
      }
    }
    [Test]
    public void TestSimpleArrayLog()
    {
      bigONotation.SimpleArrayLog(numbers);
      Assert.AreEqual(1,1);
    }
  }
}

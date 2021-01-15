using System.Collections.Generic;
using System.Linq;
using DataStructures;
using NUnit.Framework;

namespace DataStructureTests
{
  [TestFixture]
  public class StackTests
  {
    private StackNew stackNew;

    public StackNew StackNew { get => stackNew; set => stackNew = value; }

    [SetUp]
    public void Setup()
    {
      stackNew = new StackNew();
      stackNew.FillStack("firstItem");
      stackNew.FillStack("secondItem");

    }

    [Test]
    public void TestTwoItemsIsEqual()
    {
      var expectedStack = new List<string>();
      expectedStack.Add("firstItem");
      expectedStack.Add("secondItem");
      var actualStack = stackNew.GetStack();
      Assert.IsTrue(actualStack.SequenceEqual(expectedStack));
    }
    [Test]
    public void TestRemoveOneItemIsTrue()
    {
      var expectedStack = new List<string>();
      expectedStack.Add("firstItem");

      var actualStack = stackNew.EmptyStack();
      Assert.IsTrue(actualStack.SequenceEqual(expectedStack));
    }
  }
}
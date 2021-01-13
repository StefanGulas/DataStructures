using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class BigONotation
  {
    //Big(
    public void SimpleArrayLog(List<int> numbers)
    {
      for (int i = 0; i < numbers.Count; i++)
      {
        Console.WriteLine(numbers[i]);
      }
    }
  }
}

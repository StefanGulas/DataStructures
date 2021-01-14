using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class BigONotation
  {
    public void SimpleArrayPrintOneItem(List<int> numbers)
    {
      // O(1)
      int i = 5;
      Console.WriteLine(numbers[i]);
      Console.WriteLine(numbers[i + 1]);

    }
    public void SimpleArrayLog(List<int> numbers)
    {
      // O(n)
      for (int i = 0; i < numbers.Count; i++)
      {
        Console.WriteLine(numbers[i]);
      }
    }
    public void SimpleArrayLogInnerLoop(List<int> numbers)
    {
      // O(n^2)
      for (int i = 0; i < numbers.Count; i++)
      {
        for (int j = 0; j < numbers.Count; j++)
        {
          Console.WriteLine(numbers[i]);
        }
      }
    }
    public void SimpleArrayLogTwoInnerLoops(List<int> numbers)
    {
      // O(n^3)
      for (int i = 0; i < numbers.Count; i++)
      {
        for (int j = 0; j < numbers.Count; j++)
        {
          for (int k = 0; k < numbers.Count; k++)
          {
            Console.WriteLine(numbers[i]);

          }
          
        }
      }
    }
  }
}

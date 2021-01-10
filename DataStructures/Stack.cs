using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Stack
  {
    
    private List<string> stackList { get; set; }
    public List<string> StackList { get; set; }
    public List<string> FillStack(string newItem)
    {
      stackList.Add(newItem)
    }
    public List<string> EmptyStack()
    {
      var firstItem = stackList[0];
      stackList.Remove(firstItem);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class StackNew
  {
    public StackNew()
    {
      stackList = new List<string>();
    }
    private List<string> stackList { get; set; }
    public List<string> StackList { get; set; }
    public List<string> FillStack(string newItem)
    {
      stackList.Add(newItem);
      return stackList;
    }
    public List<string> EmptyStack()
    {
      var firstItem = stackList[0];
      stackList.Remove(firstItem);
      return stackList;
    }
    public List<string> GetStack()
    {
      return stackList;
    }
  }
}

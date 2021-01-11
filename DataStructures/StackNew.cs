using System;
using System.Collections.Generic;
using System.Linq;
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
      
      var lastItem = stackList[stackList.Count() - 1];
      stackList.Remove(lastItem);
      return stackList;
    }
    public List<string> GetStack()
    {
      return stackList;
    }
  }
}

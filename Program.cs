using System;
using Algorithms.Searching;

namespace Algorithms {
  class Program {
    static void Main( string[] args ) {
      //LinearSearch ls = new LinearSearch();
      //ls.GetLinearSearch();

      //BinarySearch bs = new BinarySearch();
      //bs.GetBinarySearch();

      JumpSearch js = new JumpSearch();
      js.GetJumpSearch();
      
      Console.ReadKey();
    }
  }
}

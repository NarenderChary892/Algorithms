using System;
using Algorithms.Searching;
using Algorithms.Sorting;

namespace Algorithms {
  class Program {
    static void Main( string[] args ) {
      //LinearSearch ls = new LinearSearch();
      //ls.GetLinearSearch();

      //BinarySearch bs = new BinarySearch();
      //bs.GetBinarySearch();

      //JumpSearch js = new JumpSearch();
      //js.GetJumpSearch();

      //InterpolationSearch ish = new InterpolationSearch();
      //ish.GetInterpolationSearch();

      //SelectionSort ss = new SelectionSort();
      //ss.GetSelectionSort();

      BubbleSort bSort = new BubbleSort();
      bSort.GetBubbleSort();
      
      Console.ReadKey();
    }
  }
}

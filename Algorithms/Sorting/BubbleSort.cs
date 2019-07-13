using System;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting {
  internal class BubbleSort {
    internal void GetBubbleSort() {
      /*
       Worst and Average Case Time Complexity: O(n*n). Worst case occurs when array is reverse sorted.

       Best Case Time Complexity: O(n). Best case occurs when array is already sorted.

       Auxiliary Space: O(1)

       Boundary Cases: Bubble sort takes minimum time (Order of n) when elements are already sorted.
       */

      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );

      int n = arr.Length;
      for ( int i = 0; i < n - 1; i++ ) {
        for ( int j = 0; j < n - i - 1; j++ ) {
          if ( arr[j + 1] < arr[j] ) {
            int temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
          }
        }
      }

      foreach ( var element in arr ) {
        Console.Write( element + " " );
      }
    }
  }
}

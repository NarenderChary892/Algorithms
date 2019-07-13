using System;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting {
  internal class SelectionSort {
    public void GetSelectionSort() {
      /*
       Time Complexity: O(n2) as there are two nested loops.
        Auxiliary Space: O(1)
        The good thing about selection sort is it never makes more than O(n) swaps and can be useful when memory write is a costly operation.
       */
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int i, j, min;
      for ( i = 0; i < arr.Length; i++ ) {
        min = i;
        for ( j = min + 1; j < arr.Length; j++ ) {
          if ( arr[j] < arr[min] ) {
            int temp = arr[j];
            arr[j] = arr[min];
            arr[min] = temp;
          }
        }
      }
      foreach ( var t in arr ) {
        Console.Write( t + " " );
      }
    }
  }
}

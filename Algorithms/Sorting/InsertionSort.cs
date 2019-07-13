using System;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting {
  internal class InsertionSort {
    public void GetInsertionSort() {
      /*
        Time Complexity: O(n*2)

        Auxiliary Space: O(1)
       */
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int n = arr.Length;
      for ( int i = 1; i < n; i++ ) {
        int temp = arr[i];
        int j = i - 1;
        while ( j >= 0 && arr[j] > temp ) {
          arr[j + 1] = arr[j];
          j = j - 1;
        }
        arr[j + 1] = temp;

      }

      foreach ( var element in arr ) {
        Console.Write( element + " " );
      }
    }
  }
}

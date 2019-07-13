using System;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting {
  internal class QuickSort {
    public void GetQuickSort() {
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      quickSort( arr, 0, arr.Length - 1 );
      printArray( arr );

    }

    private void printArray( int[] arr ) {
      foreach ( var element in arr ) {
        Console.Write( element + " " );
      }
    }

    private void quickSort( int[] arr, int low, int high ) {
      if ( low < high ) {
        int pivot = Partition( arr, low, high );
        quickSort( arr, low, pivot - 1 );
        quickSort( arr, pivot + 1, high );
      }
    }

    private int Partition( int[] arr, int low, int high ) {
      int pivot = arr[high];
      int i = low - 1;
      for ( int j = low; j < high; j++ ) {
        if ( arr[j] < pivot ) {
          i++;

          int temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
        }
      }
      int temp1 = arr[i + 1];
      arr[i + 1] = arr[high];
      arr[high] = temp1;

      return i + 1;
    }
  }
}

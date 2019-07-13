using System;

namespace AlgorithmsAndDataStructures.Algorithms.Sorting {
  internal class MergeSort {
    public void GetMergeSort() {
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      Console.WriteLine( "Given Array" );
      printArray( arr );

      MergeSort ob = new MergeSort();
      ob.mergeSort( arr, 0, arr.Length - 1 );
      Console.WriteLine( "\nSorted array" );
      printArray( arr );
    }

    private void mergeSort( int[] arr, int left, int right ) {
      if ( left < right ) {

        int mid = ( left + right ) / 2;
        mergeSort( arr, left, mid );
        mergeSort( arr, mid + 1, right );
        merge( arr, left, mid, right );
      }
    }

    private void merge( int[] arr, int left, int mid, int right ) {
      int leftArrRange = mid - left + 1;
      int rightArrRange = right - mid;
      int i, j, k;

      int[] leftArr = new int[leftArrRange];
      int[] rightArr = new int[rightArrRange];

      for ( i = 0; i < leftArrRange; ++i ) {
        leftArr[i] = arr[left + i];
      }

      for ( j = 0; j < rightArrRange; ++j ) {
        rightArr[j] = arr[mid + 1 + j];
      }

      i = 0;
      j = 0;
      k = left;
      while ( i < leftArrRange && j < rightArrRange ) {
        if ( leftArr[i] <= rightArr[j] ) {
          arr[k] = leftArr[i];
          i++;
        }
        else {
          arr[k] = rightArr[j];
          j++;
        }

        k++;
      }

      while ( i < leftArrRange ) {
        arr[k] = leftArr[i];
        i++;
        k++;
      }

      while ( j < rightArrRange ) {
        arr[k] = rightArr[j];
        j++;
        k++;
      }
    }

    private void printArray( int[] arr ) {
      int n = arr.Length;
      for ( int i = 0; i < n; ++i )
        Console.Write( arr[i] + " " );
    }
  }
}

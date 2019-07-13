using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class SortedRotatedPairSum {
    public void GetSortedRotatedPairSum() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      int sum = Convert.ToInt32( Console.ReadLine() );
      int n = arr.Length;
      if ( pairInSortedRotated( arr, n, sum ) )
        Console.WriteLine( "Array has two elements with sum {0}", sum );
      else
        Console.WriteLine( "Array doesn't have two elements with sum {0}", sum );

    }

    private bool pairInSortedRotated( int[] arr, int n, int sum ) {
      int i;
      for ( i = 0; i < n - 1; i++ ) {
        if ( arr[i] > arr[i + 1] )
          break;
      }

      int l = ( i + 1 ) % n;
      int r = i;
      while ( l != r ) {
        if ( arr[l] + arr[r] == sum ) {
          return true;
        }

        if ( arr[l] + arr[r] < sum ) {
          l = ( l + 1 ) % n;
        }
        else {
          r = ( n + r - 1 ) % n;
        }
      }
      return false;
    }
  }
}

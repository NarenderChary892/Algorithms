using System;

namespace Algorithms.Searching {
  class LinearSearch {
    internal void GetLinearSearch() {

      //The time complexity of this algorithm is O(n).
      //Linear search is rarely used practically because other search algorithms such as the binary search algorithm and hash tables allow significantly faster searching comparison to Linear search.

      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int searchElement = Convert.ToInt32( Console.ReadLine() );
      int result = LinearSearchImplementation( arr, searchElement );
      if ( result == -1 ) {
        Console.WriteLine( "Element not found..!" );
      }
      else {
        Console.WriteLine( "{0} found at index {1}", searchElement, result );
      }
    }

    private int LinearSearchImplementation( int[] arr, int searchElement ) {
      for ( int i = 0; i < arr.Length; i++ ) {
        if ( arr[i] == searchElement ) {
          return i;
        }
      }

      return -1;
    }
  }
}

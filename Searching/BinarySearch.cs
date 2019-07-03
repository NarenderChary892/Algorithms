using System;

namespace Algorithms.Searching {
  class BinarySearch {
    internal void GetBinarySearch() {

      /* The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n)
         
        We basically ignore half of the elements just after one comparison.

        Compare x with the middle element.
        If x matches with middle element, we return the mid index.
        Else If x is greater than the mid element, then x can only lie in right half subarray after the mid element.So we recur for right half.
        Else( x is smaller ) recur for the left half.*/
 
       int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int serachElement = Convert.ToInt32( Console.ReadLine() );

      int result = binarySearchImplementation( arr, serachElement );

      if ( result == -1 ) {
        Console.WriteLine( "Element not found..!" );
      }
      else {
        Console.WriteLine( "{0} found at index {1}", serachElement, result );
      }
    }

    private int binarySearchImplementation( int[] arr, int serachElement ) {
      int l = 0;
      int r = arr.Length - 1;
      while ( l <= r ) {
        int mid = ( l + r ) / 2;
        if ( arr[mid] == serachElement ) {
          return mid;
        }
        if ( mid < serachElement ) {
          l = mid + 1;
        }
        else {
          r = mid - 1;
        }
      }
      return -1;
    }
  }
}

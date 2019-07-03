using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching {
  internal class JumpSearch {
    public void GetJumpSearch() {

      /*
       What is the optimal block size to be skipped?
            In the worst case, we have to do n/m jumps and if the last checked value is greater than the element to be searched for, we perform m-1 comparisons more for linear search. 
            Therefore the total number of comparisons in the worst case will be ((n/m) + m-1). The value of the function ((n/m) + m-1) will be minimum when m = √n. Therefore, the best step size is m = √n.
       
       Time Complexity : O(√n)
       Auxiliary Space : O(1)

        Important points:

       -> Works only sorted arrays.
       -> The optimal size of a block to be jumped is (√ n). This makes the time complexity of Jump Search O(√ n).
       -> The time complexity of Jump Search is between Linear Search ( ( O(n) ) and Binary Search ( O (Log n) ).
       -> Binary Search is better than Jump Search, but Jump search has an advantage that we traverse back only once (Binary Search may require up to O(Log n) jumps, consider a situation where the element to be search is the smallest element or smaller than the smallest). So in a systems where jumping back is costly, we use Jump Search.
       */
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ',' ), temp => Convert.ToInt32( temp ) );
      int searchElement = Convert.ToInt32( Console.ReadLine() );
      int result = jumpSearchImplementation( arr, searchElement );
      if ( result == -1 ) {
        Console.WriteLine( "Element not found..!" );
      }
      else {
        Console.WriteLine( "{0} found at index {1}", searchElement, result );
      }
    }

    private int jumpSearchImplementation( int[] arr, int searchElement ) {
      int jump = (int) Math.Floor( Math.Sqrt( arr.Length ) );
      int tempJump = jump;
      for ( int i = 0; i < arr.Length; ) {
        if ( searchElement >= arr[i] && searchElement <= arr[tempJump - 1] ) {
          for ( int j = i; j < tempJump; j++ ) {
            if ( arr[j] == searchElement ) {
              return j;
            }
          }
        }
        i = i + jump;
        tempJump = tempJump + jump > arr.Length ? arr.Length : tempJump + jump;

      }
      return -1;
    }
  }
}

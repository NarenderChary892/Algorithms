using System;

namespace AlgorithmsAndDataStructures.Algorithms.Searching {
  internal class InterpolationSearch {
    public void GetInterpolationSearch() {

      /*
       The Interpolation Search is an improvement over Binary Search for instances, 
       where the values in a sorted array are uniformly distributed.
       Binary Search always goes to the middle element to check. On the other hand, 
       interpolation search may go to different locations according to the value of the key being searched.
       For example, if the value of the key is closer to the last element, interpolation search is likely 
       to start search toward the end side.

       The idea of formula is to return higher value of pos
        when element to be searched is closer to arr[hi]. And
        smaller value when closer to arr[lo]
        ** pos = lo + [ (x-arr[lo])*(hi-lo) / (arr[hi]-arr[Lo]) ]
         
         arr[] ==> Array where elements need to be searched
         x     ==> Element to be searched
         lo    ==> Starting index in arr[]
         hi    ==> Ending index in arr[]

        Time Complexity: If elements are uniformly distributed, then O (log log n)). In worst case it can take upto O(n).
        Auxiliary Space: O(1)

       */

      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ',' ), temp => Convert.ToInt32( temp ) );
      int searchElement = Convert.ToInt32( Console.ReadLine() );
      int lower = 0;
      int higher = arr.Length - 1;
      int result = InterpolationSearchImplementation( arr, searchElement, lower, higher );
      if ( result == -1 ) {
        Console.WriteLine( "Element not found..!" );
      }
      else {
        Console.WriteLine( "{0} found at index {1}", searchElement, result );
      }
    } 
    private int InterpolationSearchImplementation( int[] arr, int searchElement, int lower, int higher ) {

      while ( lower <= higher && arr[lower] <= searchElement && arr[higher] >= searchElement ) {
        if ( lower == higher ) return 0;
        var position = lower + ( ( searchElement - arr[lower] ) * ( higher - lower ) / ( arr[higher] - arr[lower] ) );
        // if mid element is search element
        if ( searchElement == arr[position] ) {
          return position;
        }

        //  searchElement is greater than mid element
        if ( arr[position] < searchElement ) {
          return InterpolationSearchImplementation( arr, searchElement, position + 1, higher );
        }
        // searchElement is less than mid element
        return InterpolationSearchImplementation( arr, searchElement, lower, position - 1 );
      }
      return -1;
    }
  }
}

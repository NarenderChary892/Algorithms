using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class KthSmallestLargestElement {
    public void GetKthSmallest() {

      int Kth = Convert.ToInt32( Console.ReadLine() );
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      // 4 3 2 6 1
      // 1 2 3 4 6
      for ( int i = 0; i < arr.Length; i++ ) {
        int min = i;
        for ( int j = min + 1; j < arr.Length; j++ ) {
          if ( arr[j] < arr[min] ) {
            int temp = arr[j];
            arr[j] = arr[min];
            arr[min] = temp;
          }
        }
      }
      Console.WriteLine( "Kth({0}) Smallest element is {1}", Kth, arr[Kth - 1] );
      Console.WriteLine( "Kth({0}) Largest element is {1}", Kth, arr[arr.Length - Kth] );
    }
  }
}

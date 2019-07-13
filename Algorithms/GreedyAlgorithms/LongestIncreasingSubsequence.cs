using System;

namespace AlgorithmsAndDataStructures.Algorithms.GreedyAlgorithms {
  internal class LongestIncreasingSubsequence {
    public void GetLis() {
      int[] arr = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int n = arr.Length / 2;
      int number = 1;

      for ( int i = 0; i < n + 1; i++ ) {
        int count = 1;
        for ( int j = 0; j < arr.Length - 1; j++ ) {
          if ( arr[j] < arr[j + 1] ) {
            count++;
          }
        }
        number = count > number ? count : number;
      }
      Console.WriteLine( number );
    }
  }
}

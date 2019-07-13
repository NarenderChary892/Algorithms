using System;

namespace AlgorithmsAndDataStructures.Algorithms.GreedyAlgorithms {
  internal class ActivitySelection {
    public void GetActivitySelection() {
      int[] start = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );
      int[] finish = Array.ConvertAll( Console.ReadLine().Split( ' ' ), temp => Convert.ToInt32( temp ) );

      int i = 0;
      Console.Write( i + " " );
      for ( int j = 1; j < start.Length; j++ ) {
        if ( start[j] < finish[i] ) continue;
        Console.Write( j + " " );
        i = j;
      }
    }
  }
}

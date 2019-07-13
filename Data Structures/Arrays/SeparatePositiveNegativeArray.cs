using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class SeparatePositiveNegativeArray {
    public void GetSeparatePositiveNegativeArray() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      var temp = new int[arr.Length];
      var j = 0;
      foreach ( var t in arr ) {
        if ( t >= 0 ) {
          temp[j] = t;
          j++;
        }
      }
      
      if ( j < arr.Length ) {
        foreach ( var t in arr ) {
          if ( t < 0 ) {
            temp[j] = t;
            j++;
          }
        }
      }

      for ( int m = 0; m < arr.Length; m++ ) {
        arr[m] = temp[m];
      }
      foreach ( var t in arr ) {
        Console.Write( t + " " );
      }
    }
  }
}

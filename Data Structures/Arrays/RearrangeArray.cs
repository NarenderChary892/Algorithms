using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class RearrangeArray {
    internal void GetRearrangeArray() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      Array.Sort( arr );
      for ( int i = 0; i < arr.Length; i++ ) {
        if ( !arr.Contains( i ) ) {
          arr[i] = -1;
        }
        else {
          arr[i] = i;
        }
      }

      foreach ( var element in arr ) {
        Console.Write( element + " " );
      }
    }
  }
}

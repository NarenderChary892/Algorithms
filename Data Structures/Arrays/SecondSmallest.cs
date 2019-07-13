using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class SecondSmallest {
    public void GetSecondSmallest() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      var firstMin = Int32.MaxValue;
      var secondMin = Int32.MaxValue;
      foreach ( var element in arr ) {
        if ( element < firstMin ) {
          secondMin = firstMin;
          firstMin = element;
        }
        else if ( element < secondMin ) {
          secondMin = element;
        }
      }
      Console.WriteLine( "Smallest element: {0}", firstMin );
      Console.WriteLine( "Second smallest element: {0}", secondMin );
    }
  }
}

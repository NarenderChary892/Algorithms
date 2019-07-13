using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class ThirdSmallest {
    public void GetThirdSmallest() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      var firstMin = Int32.MaxValue;
      var secondMin = Int32.MaxValue;
      var thirdMin = Int32.MaxValue;
      foreach ( var element in arr ) {
        if ( element < firstMin ) {
          thirdMin = secondMin;
          secondMin = firstMin;
          firstMin = element;
        }
        else if ( element < secondMin ) {
          thirdMin = secondMin;
          secondMin = element;
        }
        else if ( element < thirdMin ) {
          thirdMin = element;
        }
      }
      Console.WriteLine( "Smallest element: {0}", firstMin );
      Console.WriteLine( "Second smallest element: {0}", secondMin );
      Console.WriteLine( "Third smallest element: {0}", thirdMin );
    }
  }
}

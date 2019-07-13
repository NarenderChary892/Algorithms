using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class ThirdLarge {
    public void GetThirdLarge() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      var firstMax = Int32.MinValue;
      var secondMax = Int32.MinValue;
      var thirdMax = Int32.MinValue;
      foreach ( var element in arr ) {
        if ( element > firstMax ) {
          thirdMax = secondMax;
          secondMax = firstMax;
          firstMax = element;
        }
        else if ( element > secondMax ) {
          thirdMax = secondMax;
          secondMax = element;
        }
        else if ( element > thirdMax ) {
          thirdMax = element;
        }
      }
      Console.WriteLine( "Largest Element : {0}", firstMax );
      Console.WriteLine( "Second largest element: {0}", secondMax );
      Console.WriteLine( "third largest element: {0}", thirdMax );
    }
  }
}

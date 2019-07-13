using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class SecondLarge {
    public void GetSecondLarge() {
      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      var FirstMax = Int32.MinValue;
      var secondMax = Int32.MinValue;
      //1 4 5 2 6
      for ( int i = 0; i < arr.Length; i++ ) {
        if ( arr[i] > FirstMax ) {
          secondMax = FirstMax;
          FirstMax = arr[i];
        }

        else if ( arr[i] > secondMax ) {
          secondMax = arr[i];
        }
      }
      Console.WriteLine( "Largest Element : {0}", FirstMax );
      Console.WriteLine( "Second largest element: {0}", secondMax );
    }
  }
}

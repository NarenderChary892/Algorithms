using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class ArrayLeftRightRotations {
    public void GetArrayLeftRotation() {
      var leftArray = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), temp => Convert.ToInt32( temp ) );
      var d = Convert.ToInt32( Console.ReadLine() );
      var rightArray = new int[leftArray.Length];
      leftArray.CopyTo( rightArray, 0 );
      LeftRotate( leftArray, d );
      Console.WriteLine( "Left rotation of given array by {0} position(s).", d );
      PrintLeftArray( leftArray );
      RightRotate( rightArray, d );
      Console.WriteLine( "Right rotation of given array by {0} position(s).", d );
      PrintRightArray( rightArray );
    }


    // Left rotation
    private static void LeftRotate( int[] arr, int d ) {
      for ( var i = 0; i < d; i++ ) {
        int temp = arr[0], j;
        for ( j = 0; j < arr.Length - 1; j++ ) {
          arr[j] = arr[j + 1];
        }
        arr[j] = temp;
      }
    }
    private static void PrintLeftArray( int[] arr ) {
      foreach ( var element in arr ) {
        Console.Write( element + " " );
      }
      Console.WriteLine();
    }


    // Right Rotation
    private static void RightRotate( int[] rightArray, int d ) {
      for ( var i = 0; i < d; i++ ) {
        int rTemp = rightArray[rightArray.Length - 1], k;
        for ( k = rightArray.Length - 1; k > 0; k-- ) {
          rightArray[k] = rightArray[k - 1];
        }
        rightArray[k] = rTemp;
      }
    }

    private static void PrintRightArray( int[] rightArray ) {
      foreach ( var element in rightArray ) {
        Console.Write( element + " " );
      }
    }
  }
}

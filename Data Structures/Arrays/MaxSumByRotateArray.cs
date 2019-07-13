using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  internal class MaxSumByRotateArray {
    public void GetMaxSumByRotateArray() {

      var arr = Array.ConvertAll( Console.ReadLine()?.Split( ' ' ), Convert.ToInt32 );
      int n = arr.Length;
      int sum = Int32.MinValue;
      int rotations = 0;
      int i;
      for ( i = 0; i < n; i++ ) {
        int temp = arr[0], j;
        for ( j = 0; j < n - 1; j++ ) {
          arr[j] = arr[j + 1];
        }
        arr[j] = temp;
        int tempSum = 0;
        for ( int k = 0; k < n; k++ ) {
          tempSum = tempSum + k * arr[k];
        }

        if ( tempSum > sum ) {
          sum = tempSum;
          rotations = i + 1;
        }
      }
      Console.WriteLine( "Max sum is {0} by {1} rotations", sum, rotations );
    }
  }
}

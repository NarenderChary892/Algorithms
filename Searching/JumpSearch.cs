using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    internal class JumpSearch
    {
      public void GetJumpSearch()
      {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), temp => Convert.ToInt32(temp));
        int searchElement = Convert.ToInt32(Console.ReadLine());
        int result = jumpSearchImplementation(arr, searchElement);
        if (result == -1)
        {
          Console.WriteLine("Element not found..!");
        }
        else
        {
          Console.WriteLine("{0} found at index {1}",searchElement,result);
        }

        
      }
    //(0, 1, 1, 2, 3, 5, 8, 13, 21)
    private int jumpSearchImplementation( int[] arr, int searchElement )
    {
      int jump = (int)Math.Floor(Math.Sqrt(arr.Length));
      int tempJump = jump;
      for (int i = 0; i < arr.Length;)
      {
        if (searchElement >= arr[i] && searchElement <= arr[tempJump-1] )
        {
          for (int j = i; j < tempJump; j++)
          {
            if (arr[j] == searchElement)
            {
              return j;
            }
          }
        }

        i = i + jump;
        tempJump = tempJump + jump;
      }
      return -1;
    }
  }
}

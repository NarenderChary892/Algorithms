using System;

namespace AlgorithmsAndDataStructures.Data_Structures.Arrays {
  public class SampleArray {
    public void GetSampleArray() {
      Student[] arr = new Student[5];
      arr[0] = new Student( 1, "MS" );
      arr[1] = new Student( 2, "VK" );
      arr[2] = new Student( 3, "RS" );
      arr[3] = new Student( 4, "SD" );
      arr[4] = new Student( 5, "JB" );

      for ( int i = 0; i < arr.Length; i++ ) {
        //Console.WriteLine("Student at index " + i +": "+arr[i].RollNo+' '+ arr[i].Name);
        Console.WriteLine( "Student at index {0}: {1} {2}", i, arr[i].RollNo, arr[i].Name );
      }
    }
  }

  class Student {
    public int RollNo;
    public string Name;

    public Student( int rollNo, string name ) {
      this.RollNo = rollNo;
      this.Name = name;
    }
  }
}

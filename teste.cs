using System;
using System.Collections;
using System.Collections.Generic;

class Program{
  public static void Main(){
    SortedList d = new SortedList();
    int valor = 9;
    string[] a = "$1".Split("$");
    int b = Convert.ToInt32(a[1]);
    //Console.WriteLine(b);
    d["$2"] = 0; 
    d["$3"] = 0;
    d["$4"] = 0;
    d[d.GetKey(b)]=4;
    Console.WriteLine(d.GetByIndex(1));

    d[d.GetKey(b)] = Convert.ToInt32(d.GetByIndex(b)) + 2;
    
    Console.WriteLine(d.GetByIndex(1));
    foreach (KeyValuePair<object, object> x in d)
      Console.WriteLine($"{x.Key} = {x.Value}");
  }

}

/*
using System;
using System.Collections;
public class SamplesSortedList  {

   public static void Main()  {

      // Creates and initializes a new SortedList.
      SortedList mySL = new SortedList();
     mySL.Add( 1.4, "jumps" ); 
     mySL.Add( 1.3, "fox" );
      
      

      // Gets the key and the value based on the index.
      int myIndex=0;
      mySL[mySL.GetKey( myIndex )] = "Lucas";
     
      Console.WriteLine( "The key   at index {0} is {1}.", myIndex, mySL.GetKey( myIndex ) );
      Console.WriteLine( "The value at index {0} is {1}.", myIndex, mySL.GetByIndex( myIndex ) );

      // Gets the list of keys and the list of values.
      IList myKeyList = mySL.GetKeyList();
      IList myValueList = mySL.GetValueList();
      // Prints the keys in the first column and the values in the second column.
      
   }
}
*/
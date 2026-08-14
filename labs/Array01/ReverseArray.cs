namespace RArray;

using System.Runtime.Intrinsics.Arm;
using IAMARRAY;

public class Reverce
{
    public int PrintReverce()
    {
        
        ARRAY ob5=new ARRAY();

        for(int i=ob5.arr.Length-1;i>=0;i--)
        {
            Console.WriteLine(ob5.arr[i]);
        }

         
     return ob5.arr[0];
    }
}

        
   
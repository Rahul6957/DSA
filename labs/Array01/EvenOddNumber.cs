//Count Even and Odd numbers	
namespace EO;
using IAMARRAY;


public class EvenOdd
{
    ARRAY obj6=new ARRAY();

    public void FindEvenOdd()
{
    for (int i = 0; i < obj6.arr.Length; i++)
    {
        if (obj6.arr[i] % 2 == 0)
        {
            Console.WriteLine("Even = " + obj6.arr[i]);
        }
        else
        {
            Console.WriteLine("Odd = " + obj6.arr[i]);
        }
    }
}
        
    
}

namespace min;
using IAMARRAY;
public class Min
{
public int CalculateMixofarray()
    {
        ARRAY ob3=new ARRAY();
        
        int min =ob3.arr[0];
        for(int i = 1; i < ob3.arr.Length; i++)
        {
            if (ob3.arr[i] < min)

            {
                min=ob3.arr[i];
            }
     
        }
        return min;
    }


} 
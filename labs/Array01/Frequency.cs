namespace Fre;

using IAMARRAY;

public class Frequency
{
    public void CalFrequency()
    {
        ARRAY obj34= new ARRAY();
        for (int i=0;i<obj34.arr.Length;i++){
        int count =0;
        for (int j=1;j<obj34.arr.Length;j++){

        if (obj34.arr[i] == obj34.arr[j])
        {
        Console.WriteLine(obj34.arr[i] +"count"+count);
        }
        }
        }
    }
}
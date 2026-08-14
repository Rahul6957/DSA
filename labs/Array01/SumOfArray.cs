using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using IAMARRAY;
namespace ItIsTheSum;
public class TheSum
{

    public int Sum()
    {
    ARRAY obj2=new ARRAY();
    int sum=0;
    for(int i= 0;i<obj2.arr.Length;i++){
       sum=obj2.arr[i]+sum;

    }
       return sum;
       }
}
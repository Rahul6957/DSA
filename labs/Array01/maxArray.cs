using IAMARRAY;
namespace Maxss;
 


public class Max()
{
    public int CalculateMaxOfarray()
    {
         ARRAY obj1=new ARRAY();//object 
        int max =obj1.arr[0];//max local variable he teyat o index chi value store keli
        for (int i =1;i< obj1.arr.Length; i++)//i variable tela baydefoult alue 1 natar array chi length cumpare i aani mg i chi value yek na vadavtoy
        {
            if (obj1.arr[i]>max)//index no pass keliye ti tr greter than max aasel tr tela 
            {
                max=obj1.arr[i];
            }
        }
        return max;
    }

}
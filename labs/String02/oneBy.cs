//print string one by one 

using System.Net.Http.Headers;

namespace one;

public class Onebyone
{
    public void Print1by1()
    {
        string Name= "Rahul";

        for (int i = 0; i < Name.Length; i++)
        {
            Console.WriteLine(Name[i]);


        }

    }

}
namespace f;
//check  a perticulare word how much time is repeat
public class Charfrequency
{
    string Name = "Raahual";

    public void Frequency()
    {
        int Count = 1;
        for (int i = 0; i < Name.Length; i++)
        {
            for (int j = i + 1; j < Name.Length; j++)
            {

                if (Name[i] == Name[j])
                {
                    Count++;
                    Console.WriteLine(Name[i] + "is " + Count);

                }
            }

        }
    }
}
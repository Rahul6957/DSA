using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace Three;

public class Palindrome // class
{
    public void checkPalindrome()//Method
    {
        string Name="MADAM";
        string Copy="";
        for(  int i = Name.Length -1; i >= 0; i--){
          Copy=  Copy +Name[i];
        }
         if (Name == Copy)
            {
                Console.WriteLine("it is Palindrome");

            }

            else
            {
                Console.WriteLine("it is NOT Palindrome");
            }
        }
    }


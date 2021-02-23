//By: Anuj

using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            String str = Console.ReadLine();
            Check_palindrome(str);
        }
        static void Check_palindrome(String s)
        {
            int i = 0, j = s.Length-1;
            int flag = 0;
            while(i<j)
            {
                if(s[i]==s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");

        }
    }
}

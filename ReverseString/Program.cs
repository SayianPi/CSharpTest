/*Program to reverse a string*/
using System;
namespace Test6
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            //using while loop 
            string str = "", reverseStr = "";
            int length = 0;

            Console.WriteLine("enter the string");
            str = Console.ReadLine();

            length = str.Length - 1;

            while (length >= 0)
            {
                reverseStr = reverseStr + str[length];
                length--;
            }
            Console.WriteLine($"reverse of {str} is {reverseStr}");


            //using for loop
            string word = "", reverseword = "";
            int length1 = 0;
            Console.WriteLine("enter another string");
            word = Console.ReadLine();

            length1 = word.Length - 1;

           for(int i = length1; i >= 0; i--)
            { 
                reverseword = reverseword + word[i];
            }

            Console.WriteLine($"reverse of {word} is {reverseword}");

        }
    }
}

/*Program to reverse the string using Array.Reverse() method.*/
using System;
namespace Test5
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string to reverse: ");
            //string varaible named 'word'
            string word = Console.ReadLine(); 

            //ToCharArray() method to convert the string to a character array and store it in the variable 'charArray'
            char[] charArray = word.ToCharArray();

            //Array.reverse() method to reverse charArray
            Array.Reverse(charArray);

            Console.WriteLine(charArray); //reversed already happened but

            //create a new string variable 'reversedWord' from 'charArray'
            string reversedWord = new string(charArray);
            Console.WriteLine($"reverse of {word} is {reversedWord}");

        }
    }
}

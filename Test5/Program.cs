/*Program to reverse the string using Array.Reverse() method.*/
using System;
namespace Test5
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            /*
             steps:
             a) change the input string into char[] array using 'ToCharArray()' method.
             b) reverse the changed char[] array using "Array.Reverse()' method.
             C) convert the reversed char[] array into a string and assign to a new string.
                OR join the members/values of char[] array and assign it to a new string.
            */


            Console.WriteLine("enter a string to reverse: "); //SUP
            
            string word = Console.ReadLine();  //word = SUP

            char[] charArray = word.ToCharArray(); //charArray = ["S", "U", "P"]

            Array.Reverse(charArray); //["P", "U", "S"]

            //create a new string variable 'reversedWord' from 'charArray'
            string reversedWord = new string(charArray); //reversedWord = PUS
            //OR string reversedWord = string.Join("", charArray);
            Console.WriteLine($"reverse of {word} is {reversedWord}");

        }
    }
}

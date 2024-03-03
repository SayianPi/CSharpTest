/*program to reverse the position of the word in a sentence*/
using System;
using System.Text;
namespace Test8
{
    class ReverseWordOfString
    {
        static void Main(string[] args)
        {

            /*
             * Method 1:
             a) split the string from space(' ') into string array.
             b) Reverse the splitted string array using Array.Reverse() method.
             c) join the reversed string array with space (' ').
            */
            Console.WriteLine("Enter the sentence"); //eg: HI THERE!
            string sentence = Console.ReadLine();  //sentence = HI THERE!

            string[] stringarray = sentence.Split(' '); // stringarray = ["HI", "THERE!"]
            //foreach (string str in stringarray)
            //{
            //    Console.WriteLine(str);
            //}

            Array.Reverse(stringarray); //["THERE!", "HI"]

            //Console.WriteLine(stringarray.Length);
            //foreach (string str1 in stringarray)
            //{
            //    Console.WriteLine(str1);
            //}

            /* string reversedstring = new string(stringarray); //cannot convert from string[] to char
            Console.WriteLine(reversedstring); */

            string reversedsentence = string.Join(" ", stringarray); //reversedsentence = THERE! HI
            Console.WriteLine(reversedsentence); //THERE! HI










            //for (int i = 0; i <= stringarray.Length - 1; i++)
            //{
            //    Console.Write(stringarray[i] + ' ');
            //}




        }
    }
}




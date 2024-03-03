using System;
namespace Test8
{
    class ReverseWordOfString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            string sentence = Console.ReadLine();

            string[] stringarray = sentence.Split(' ');
            //foreach (string str in stringarray)
            //{
            //    Console.WriteLine(str);
            //}

            Array.Reverse(stringarray);

            //Console.WriteLine(stringarray.Length);
            //foreach (string str1 in stringarray)
            //{
            //    Console.WriteLine(str1);
            //}

            /* string reversedstring = new string(stringarray); //cannot convert from string[] to char
            Console.WriteLine(reversedstring); */

            Console.WriteLine("Reverse sentence is: ");
            for (int i = 0; i <= stringarray.Length - 1; i++)
            {
                Console.Write(stringarray[i] + ' ');
            }



        }
    }
}

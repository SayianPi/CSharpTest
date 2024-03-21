using System;
using System.Diagnostics.Tracing;

namespace ArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[2];
            for(int i = 0; i < words.Length; i++) //getting array values from user
            {
                Console.WriteLine("enter the string value in array");
                words[i] = Console.ReadLine();
            }
            foreach(string word in words) //assume sentence = ["hi", "there"]
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //ARRAY(words) TO STRING(sentence)
            string sentence1 = String.Join(" ", words);
            Console.WriteLine("conversion of array(words) to string(sentence) is " + sentence1); //hi there

            string sentence2 = string.Concat(words.Select(x => x.ToString()));
            Console.WriteLine("conversion of array(words) to string(sentence) is " + sentence2); //hithere
        }
    }
}








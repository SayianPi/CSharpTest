using System;
namespace StringToArray
{
    class Program
    {
        static void Main(string[] args)

        {   //WORD to LETTER
            string word;
            Console.WriteLine("enter the string");
            word = Console.ReadLine(); //HELLO
            char[] letterArray = word.ToCharArray(); //["H", "E", "L", "L", "O"]
            foreach(char letter in letterArray)
            {
                Console.WriteLine(letter);
            }
            Console.ReadKey();

            //SENTENCE to WORD
            string sentence;
            Console.WriteLine("enter the sentence");
            sentence = Console.ReadLine(); //HI BYE
            string[] wordArray = sentence.Split(' '); //["HI", "BYE"]
            foreach(string words in wordArray)
            {
                Console.WriteLine(words);
            }
            Console.ReadKey();
        }
    }
}

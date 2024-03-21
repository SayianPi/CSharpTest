using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, output;
            string strnum;

            //string a = null;
            
            Console.WriteLine("Enter the number you want to reverse");
            number = int.Parse(Console.ReadLine());

            int[] digitArray = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            Array.Reverse(digitArray);
            strnum = string.Concat(digitArray.Select(x => x.ToString()));
            Console.WriteLine(strnum);
            //foreach (int digit in digitArray)
            //{
            //    a += digit.ToString();
            //}
            //output = int.Parse(a);
            //Console.WriteLine("Reverse of the {0} is {1}", number, output);

        }
    }
}

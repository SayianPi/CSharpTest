using System;
namespace Int_Into_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("enter the multi digit number : ");
            number = int.Parse(Console.ReadLine());

            //1. int to string
            string digitString = number.ToString();
            Console.WriteLine("string of {0} is {1}",number, digitString);

            //2. string to char array
            char[] digitCharArray = digitString.ToCharArray();
            Console.WriteLine("char array of number is");
            foreach(char c in digitCharArray)
            {
                Console.WriteLine(c);
            }

            //3. char array to int array
            int[] digitIntArray = digitCharArray.Select(x => (int)Char.GetNumericValue(x)).ToArray();
            Console.WriteLine("int array of  number is");
            foreach (int i in digitIntArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Environment.NewLine);

            // in a single line of code
            int[] intArrayOfNumber = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            foreach(int i in intArrayOfNumber)
            {
                Console.WriteLine(i);
            }
           
       


            Console.ReadKey();
        }
    }
}
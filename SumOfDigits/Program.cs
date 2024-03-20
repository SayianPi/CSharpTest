using System;
namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, length, sum = 0;
            Console.Write("Enter the multi digit number: ");
            number = int.Parse(Console.ReadLine());
            //converting number into array of digits eg, 123 = [1, 2,3]
            int[] digitArray = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            length = digitArray.Length-1;

            //my method
            for (int i = 0; i <= length; i++)
            {
                sum = sum + digitArray[i];
            }
            Console.WriteLine("The sum of the digits in {0} is {1}", number, sum);

            //using while loop
            int modulo, summ = 0;
            while (number > 0)
            {
                modulo = number % 10;
                summ = summ + modulo;
                number = number / 10;
            }
            Console.WriteLine("The sum of the digits in number is {0}", summ);
            Console.ReadKey();
        }


    }
}
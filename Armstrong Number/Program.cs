using System;

//371 = 3^3+7^3+1^3 = 27+343+1 = 371
//1634 = 1^4+6^4+3^4+4^4 = 1634
namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, power, length, sum = 0;
            Console.Write("enter the number you want to test : ");
            number = int.Parse(Console.ReadLine());
            
            //Converting number into an integer array eg, 123 into [1, 2, 3]
            int[] digits = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            power = digits.Length;
            length = power - 1;

            for(int i = 0; i <= length; i++)
            {
                sum = sum + (int)Math.Pow(digits[i], power);
            }

            if(sum == number)
            {
                Console.WriteLine("Number is armstrong/narcissistic number.");
            }
            else
            {
                Console.WriteLine("Num" +
                    "ber is not armstrong/narcissistic number.");
            }
            Console.ReadKey();
       
        }
    }
}

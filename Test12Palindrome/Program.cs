using System;
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, temp, r, sum = 0 ;

            Console.WriteLine("Enter the number to check palindrome:");
            number = int.Parse(Console.ReadLine());

            temp = number; //temporarily holding the entered number

            //logic to reverse the number
            while(number > 0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if (temp == sum) //comparing original number(currently being holded by temp field) with a reversed number

                Console.WriteLine("The entered number is palindrome.");
            else
                Console.WriteLine("The entered number is not a palindrome");

        }
        
    }
}
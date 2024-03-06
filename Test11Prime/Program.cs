using System;
namespace IdentifyPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the number to check for a prime");
            int number = int.Parse(Console.ReadLine());

            int m = number / 2;

            /*Console.WriteLine("m = "+m);
            int z = number % 2;
            Console.WriteLine("z = " + z);*/

            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is not a prime");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is prime");
            }
        }
    }
}

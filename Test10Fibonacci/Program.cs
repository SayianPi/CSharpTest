using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci ");
            Console.WriteLine("Series");

            int n1 = 0, n2 = 1;

            Console.WriteLine("Enter the number of elements");
            int number = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); //printing first 2 elements 0 and 1

            for(int i = 2; i<number; i++) //loop starts from 2 because 0 and 1 are already printed 
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
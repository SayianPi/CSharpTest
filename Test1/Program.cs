using System;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            /*Console.WriteLine(i);*/ //Compile time error: use of unassigned local variable 'i'.

            int j = 5, k;
            Console.WriteLine(k =  j * 2); //Output: 10
        }
    }
}
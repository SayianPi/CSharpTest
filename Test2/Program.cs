using System;
using System.ComponentModel.DataAnnotations;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            /* display(k); */ //compile time error; use of unassigned local variable 'k'.
        }

        static void display(int val = 0)
        {
            Console.WriteLine(val);
        }
    }
}

